using FourLeafCloverShoe.IServices;
using FourLeafCloverShoe.Libraries;
using FourLeafCloverShoe.Services;
using FourLeafCloverShoe.Share.Models;
using MailKit.Search;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace FourLeafCloverShoe.Controllers
{
    public class OrderController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IOrderItemService _orderItemService;
        private readonly IOrderService _orderService;
        private readonly ICartItemItemService _cartItemItemService;

        public OrderController(UserManager<User> userManager, IOrderService orderService, IOrderItemService orderItemService, ICartItemItemService cartItemItemService)
        {
            _userManager = userManager;
            _orderItemService = orderItemService;
            _orderService = orderService;
            _cartItemItemService = cartItemItemService;
        }
        public static string GenerateInvoiceCode(string paymentType)
        {
            // Lấy ngày và giờ hiện tại
            DateTime currentDate = DateTime.Now;
            string year = currentDate.ToString("yy"); // Lấy 2 chữ số cuối của năm
            string month = currentDate.ToString("MM"); // Lấy tháng (thêm số 0 nếu cần)
            string day = currentDate.ToString("dd"); // Lấy ngày (thêm số 0 nếu cần)
            string hour = currentDate.ToString("HH"); // Lấy giờ (thêm số 0 nếu cần)
            string minute = currentDate.ToString("mm"); // Lấy phút (thêm số 0 nếu cần)
            string second = currentDate.ToString("ss"); // Lấy giây (thêm số 0 nếu cần)
            string code = "";
            // Ghép các phần tử lại với nhau để tạo mã hóa đơn
            if (paymentType == "cod") code = "CD";
            if (paymentType == "vnpay") code = "VNP";
            if (paymentType == "momo") code = "MM";
            if (paymentType == "off") code = "OF";
            string invoiceCode = code.ToUpper() + year + month + day + hour + minute + second;

            return invoiceCode;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<string> CheckOutAsync(Order order)
        {

            var user = await _userManager.GetUserAsync(HttpContext.User);
            var lstCartItem = await _cartItemItemService.GetsByUserId(user.Id);
            order.UserId = user.Id;
            order.VoucherId = order.VoucherId;
            order.OrderCode = GenerateInvoiceCode(order.PaymentType);
            order.PaymentType = order.PaymentType;
            if (order.PaymentType == "vnpay" || order.PaymentType == "momo" || order.PaymentType == "off")
            {
                order.OrderStatus = 0; // chờ thanh toán
            }
            else
            {
                order.OrderStatus = 2; // chờ xác nhận
            }
            order.RecipientName = order.RecipientName;
            order.RecipientAddress = order.RecipientAddress;
            order.RecipientPhone = order.RecipientPhone;
            order.CoinsUsed = order.CoinsUsed;
            order.TotalAmout = order.TotalAmout;
            order.VoucherValue = order.VoucherValue;
            order.ShippingFee = order.ShippingFee;
            order.CreateDate = DateTime.Now;

            var result = await _orderService.Add(order); // tạo hoá đơn
            if (result)
            {
                var lstOrderItems = new List<OrderItem>();
                foreach (var item in lstCartItem)
                {
                    var orderItems = new OrderItem()
                    {
                        OrderId = order.Id,
                        ProductDetailId = item.ProductDetailId,
                        Quantity = item.Quantity,
                        Price = item.ProductDetails.PriceSale,
                    };
                    lstOrderItems.Add(orderItems);
                }
                var resultCreateOrderItems = await _orderItemService.AddMany(lstOrderItems);
                if (resultCreateOrderItems)
                {
                    // tạo đơn hàng thành công
                    if (order.PaymentType == "cod")
                    {
                        return $"/Order/CheckOutSuccess?orderid={order.Id}";
                    }
                    else if (order.PaymentType == "momo" || order.PaymentType == "vnpay")
                    {
                        if (order.PaymentType == "momo")
                        {
                            return await UrlCheckOutMoMo(order);
                        }
                        else
                        {
                            return await UrlCheckOutVnPay(order);
                        }
                    }
                    else
                    {
                        return "thanh toán tại quầy";
                    }
                }
            }
            return $"/Order/CheckOutFailed";
        }
        public async Task<string> UrlCheckOutVnPay(Order order)
        {
            string vnp_Returnurl = $"https://localhost:7116/Order/PaymentCallBack?orderId={order.Id}"; //URL nhan ket qua tra ve 
            string vnp_Url = "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html"; //URL thanh toan cua VNPAY 
            string vnp_TmnCode = "IHE4U2JP"; //Ma định danh merchant kết nối (Terminal Id)
            string vnp_HashSecret = "KGUFENFAPPMWXGAYUBTNECEYOYEWEPWR"; //Secret Key
            string ipAddr = HttpContext.Connection.RemoteIpAddress?.ToString();
            //Get payment input
            //Save order to db

            //Build URL for VNPAY
            VnPayLibrary vnpay = new VnPayLibrary();
            vnpay.AddRequestData("vnp_Version", VnPayLibrary.VERSION);
            vnpay.AddRequestData("vnp_Command", "pay");
            vnpay.AddRequestData("vnp_TmnCode", vnp_TmnCode);
            vnpay.AddRequestData("vnp_Amount", (order.TotalAmout * 100).ToString());
            vnpay.AddRequestData("vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", "VND");
            vnpay.AddRequestData("vnp_IpAddr", ipAddr);
            vnpay.AddRequestData("vnp_Locale", "vn");
            vnpay.AddRequestData("vnp_OrderInfo", "Thanh toán đơn hàng :" + order.OrderCode);
            vnpay.AddRequestData("vnp_OrderType", "other"); //default value: other
            vnpay.AddRequestData("vnp_ReturnUrl", vnp_Returnurl);
            vnpay.AddRequestData("vnp_TxnRef", DateTime.Now.Ticks.ToString());
            string paymentUrl = vnpay.CreateRequestUrl(vnp_Url, vnp_HashSecret);
            //log.InfoFormat("VNPAY URL: {0}", paymentUrl);
            return paymentUrl;
        }
        public async Task<string> UrlCheckOutMoMo(Order order)
        {
            //request params need to request to MoMo system
            string endpoint = "https://test-payment.momo.vn/v2/gateway/api/create";
            string partnerCode = "MOMO5RGX20191128";
            string accessKey = "M8brj9K6E22vXoDB";
            string serectkey = "nqQiVSgDMy809JoPF6OzP5OdBUB550Y4";
            string orderInfo = "Thanh toán đơn hàng :" + order.OrderCode;
            string redirectUrl = $"https://localhost:7116/Order/PaymentCallBack?orderId={order.Id}";
            string ipnUrl = $"https://localhost:7116/Order/PaymentCallBack?orderId={order.Id}";
            string requestType = "captureWallet";

            string amount = order.TotalAmout.ToString();
            string orderId = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();
            string extraData = "";

            //Before sign HMAC SHA256 signature
            string rawHash = "accessKey=" + accessKey +
                "&amount=" + amount +
                "&extraData=" + extraData +
                "&ipnUrl=" + ipnUrl +
                "&orderId=" + orderId +
                "&orderInfo=" + orderInfo +
                "&partnerCode=" + partnerCode +
                "&redirectUrl=" + redirectUrl +
                "&requestId=" + requestId +
                "&requestType=" + requestType
                ;


            MoMoLibrary crypto = new MoMoLibrary();
            //sign signature SHA256
            string signature = crypto.signSHA256(rawHash, serectkey);

            //build body json request
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "partnerName", "Test" },
                { "storeId", "MomoTestStore" },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderId },
                { "orderInfo", orderInfo },
                { "redirectUrl", redirectUrl },
                { "ipnUrl", ipnUrl },
                { "lang", "en" },
                { "extraData", extraData },
                { "requestType", requestType },
                { "signature", signature }

            };
            string responseFromMomo = MoMoRequest.sendPaymentRequest(endpoint, message.ToString());
            JObject jmessage = JObject.Parse(responseFromMomo);
            return (jmessage.GetValue("payUrl").ToString());
        }
        public async Task<IActionResult> CheckOutSuccess(Guid orderId)
        {
            return Redirect("CheckOutSuccess");
        }
        public async Task<IActionResult> CheckOutFailed()
        {
            return Redirect($"/Order/CheckOutFailed");
        }

        [HttpGet]
        public async Task<IActionResult> PaymentCallBack(Guid orderId)
        {
            if (Request.Query.Count > 0)
            {
                var order = await _orderService.GetById(orderId);
                if (order.PaymentType == "momo")
                {
                    var resultCode = Request.Query["resultCode"];
                    if (resultCode == 0|| resultCode=="0")
                    {
                        order.OrderStatus = 1;
                        order.PaymentDate = DateTime.Now;
                        order.UpdateDate = DateTime.Now;
                        var result = await _orderService.Update(order);
                        if (result)
                        {
                            return Redirect($"/Order/CheckOutSuccess?orderid={orderId}");
                        }
                    }
                }
                if (order.PaymentType == "vnpay")
                {
                    string vnp_HashSecret = "KGUFENFAPPMWXGAYUBTNECEYOYEWEPWR"; //Secret Key
                    var vnpayData = Request.Query;
                    VnPayLibrary vnpay = new VnPayLibrary();
                    foreach (var s in vnpayData)
                    {
                        //get all querystring data
                        if (!string.IsNullOrEmpty(s.Key) && s.Key.StartsWith("vnp_"))
                        {
                            vnpay.AddResponseData(s.Key, vnpayData[s.Key]);
                        }
                    }
                    string vnp_ResponseCode = vnpay.GetResponseData("vnp_ResponseCode");
                    string vnp_TransactionStatus = vnpay.GetResponseData("vnp_TransactionStatus");
                    String vnp_SecureHash = Request.Query["vnp_SecureHash"];
                    bool checkSignature = vnpay.ValidateSignature(vnp_SecureHash, vnp_HashSecret);
                    if (checkSignature)
                    {
                        if (vnp_ResponseCode == "00" && vnp_TransactionStatus == "00")
                        {

                            order.OrderStatus = 1;
                            order.PaymentDate = DateTime.Now;
                            order.UpdateDate = DateTime.Now;
                            var result = await _orderService.Update(order);
                            if (result)
                            {
                                return Redirect($"/Order/CheckOutSuccess?orderid={orderId}");
                            }
                        }
                    }
                }
            }
            return Redirect($"/Order/CheckOutFailed");
        }
    }
}
