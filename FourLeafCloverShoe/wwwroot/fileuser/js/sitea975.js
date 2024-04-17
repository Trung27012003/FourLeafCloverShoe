;
var siteHelper = {};

(function (context) {
    context.openProcess = function () {
        $('#loading-ico').show();
    };
    context.closeProcess = function () {
        $('#loading-ico').hide();
    };
    context.showInfoMessage = function (heading, text, position) {
        $.toast({
            heading: heading,
            text: text,
            icon: 'info',
            position: position ?? 'top-right',
        })
    };
    context.showSuccessMessage = function (heading, text, position) {
        $.toast({
            heading: heading,
            text: text,
            icon: 'success',
            position: position ?? 'top-right',
        })
    };
    context.showWarningMessage = function (heading, text, position) {
        $.toast({
            heading: heading,
            text: text,
            icon: 'warning',
            position: position ?? 'top-right',
        })
    };
    context.showErrorMessage = function (heading, text, position) {
        $.toast({
            heading: heading,
            text: text,
            icon: 'error',
            position: position ?? 'top-right',
        })
    };
})(siteHelper);

$(document).ready(function () {
    var path = window.location.pathname.replaceAll('/', '');
    if (path) {
        if ($('a#' + path).length > 0) {
            $('a#' + path).addClass('profile-sidebar--submenu-item--active');
        }
    }    
})

function likeFunction(id, detailid) {
    //alert(id + '-' + detailid)
    //account/like-product
    var dataPost = {
        "id": id,
        "pid": detailid
    };

    $.ajax({
        type: "POST",
        url: "/account/like-product",
        data: dataPost,
        dataType: "json",
        success: function (data, textStatus, jqXHR) {
            // Set values
            ShowNotify('success', data);
        },
        error: function (xhr, status, error) {
            // Stop progress bar
        }
    });
    $('#wishlist-id-' + id).addClass('wishlist-active');
    $('#wishlist-id-' + id + ' .mwc-icon-heart').attr('onclick', 'dislikeFunction(' + id + ',' + detailid + ')');
}

function dislikeFunction(id, detailid) {
    var dataPost = {
        "id": id,
        "pid": detailid
    };

    $.ajax({
        type: "POST",
        url: "/account/dis-like-product",
        data: dataPost,
        dataType: "json",
        success: function (data, textStatus, jqXHR) {
            // Set values
            ShowNotify('success', data);
        },
        error: function (xhr, status, error) {
            // Stop progress bar
        }
    });
    $('#wishlist-id-' + id).removeClass('wishlist-active');
    $('#wishlist-id-' + id + ' .mwc-icon-heart').attr('onclick', 'likeFunction(' + id + ',' + detailid + ')');
}

function hoverPcolor(classIndex, imgUrl, url, imgclass,liclass, liclassindex) {
    var hrefElements = document.querySelectorAll('.'+classIndex);
    hrefElements.forEach(function (element) {
        element.href = url
    });

    var imgElements = document.querySelectorAll('.' + imgclass);
    imgElements.forEach(function (element) {
        element.src = imgUrl
    });

    //var liElements = document.querySelectorAll('.' + liclass);
    //liElements.forEach(function (element) {
    //    element.removeClass('active')
    //});
    $("li." + liclass).removeClass("active");
    $("li." + liclassindex).addClass("active");
    //$(this).addClass("active");
}

function closecart() {
    $("#sidebar-cart").removeClass('wd-opened');
    $("#mm-blocker").hide();
}
function opencart() {
    $("#sidebar-cart").addClass('wd-opened');
    $("#mm-blocker").show();
}
function removecart(pid) {
    console.log(pid);
    let url = '/Cart/RemoveCarts';
    url = url + "?productDetailId=" + pid;
    $.post(url, function (res) {

        document.getElementById('cart-list-item').innerHTML = res;
        refreshTotalCart();
    });
}

function refreshTotalCart() {
    let url2 = '/Cart/GetCartTotal'
    $.get(url2, function (res2) {
        $('.count-holder .count').text(res2.CartItems.length)
       
    })
}

function closepopup() {
    $("#home-popup").remove();
}
//jQuery(document).on('click', '.footer-title-toggle .mwc-icon-chevron-down', function (e) {
//    e.preventDefault();
//    if (jQuery(window).width() > 992) {
//        jQuery(this).next("ul").show();
//    } else {
//        jQuery(this).parent().next("ul").slideToggle();
//        jQuery(this).parent().toggleClass('is-active');
//    }
//});
$(".footer-title-toggle .mwc-icon-chevron-down").on('click', function (event) {
    if ($(window).width() > 992) {
        $(this).next("ul").show();
    } else {
        $(this).parent().next("ul").slideToggle();
        $(this).parent().toggleClass('is-active');
    }
});
