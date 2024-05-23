using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourLeafCloverShoe.Migrations
{
    public partial class mg22050204v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Colors_ColorsId",
                table: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_ColorsId",
                table: "ProductDetails");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("246e4bf2-e598-4316-b650-d15bd47151ce"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("34e83500-c7d4-4d0d-ae48-8b61a7db9054"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("54911e26-cafb-456b-9034-34652c637817"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("585b37b5-01f1-4c66-a59f-7c4ce3dfe8d3"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("90d535eb-f7f2-42e8-aa23-ebb37123e17a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("9cf70eea-fb1c-4b20-a7ca-4dbb01f8f962"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("b02612aa-b3bc-42ac-89cc-35600141822b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("c77fd1b7-6d8c-4afb-99e4-45015224c88f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("ce2f1608-ec99-4712-b1df-4dd354fbb61b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("e2a50ac0-fcdb-4d0d-b8b1-68dff3f368e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0deca26a-5e87-4bd2-9bc4-1e784328f84e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47450740-5f08-4c96-90e0-02c804ebbbc6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e3e71f7-4487-4ded-acb9-49cc77625e32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77d5df3e-7887-4834-9e34-5f35fabfc5b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7c360c1e-4cfb-4871-9cb4-2c5173db2a25"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("af0d44ad-2ac8-4079-98b2-72d1ec249e9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c03790b1-b2bc-4212-93eb-5c6e93b26c6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f0918d36-ef0b-4448-8f4d-4c72c3566e26"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("3c4698ca-6f85-4d8c-88ee-0f25010c40a2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("49b5bc60-d363-4e01-933d-62659d7a53da"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("59659a08-d6a9-4db7-be9d-0d21f5d4952e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("6db65397-418f-47cc-a47b-1765beefbe51"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("6de72734-1038-49b1-b045-b94f762ae031"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("8427f0bf-cd34-4faf-83d0-eaf2038e5af0"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a7bbf036-497e-451a-864a-6f4ff4e2d24b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a7ec19cb-12bb-45e4-aaff-9af1cc3f52cb"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a8d62696-4e3e-45c7-813b-4ac47f4a7cea"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("b84d285c-802c-4752-9bf3-38b185173fb4"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("b9ade7fc-be6a-47d4-8651-0ccec3df1166"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("ddd9455c-93bf-4e44-aed0-b9e3017a5638"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("eb617332-6152-49a7-95ff-5c2423d5d194"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("f77ca10a-ebca-4241-ab1a-75916674ee3c"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("f9d0aeed-052c-475e-9567-50600e623017"));

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: new Guid("66334d2e-2946-4db0-bbb0-a1d766ea06fb"));

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: new Guid("68ae4c32-e1a5-494d-af82-d2417fd7a436"));

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: new Guid("b69fa31e-d7e9-4e9b-81ad-9a555baf4523"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("6eb7b930-b05f-49db-ba27-32bac86c617f"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("b771e79b-b451-4038-8f5a-1414b7e0ef1c"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("315eb890-350f-4648-88f1-62ba79cf10f3"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("94cfb484-77dc-45d5-b480-251a26e7e043"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("b714fe70-6c60-4166-9b0a-dd2a08488bf8"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("c0b81f57-7f85-49aa-884f-d55f50627351"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("ca84ecc1-ca7d-42ad-aac6-1c491d66826e"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("f2d53016-7b30-4ee3-9197-4197e9662fd5"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("f525ffee-914c-4d26-952d-142f690d6ef1"));

            migrationBuilder.DropColumn(
                name: "ColorsId",
                table: "ProductDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "ColorId",
                table: "ProductDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("15c65339-a7eb-4235-8e58-71409563b430"), "Nike" },
                    { new Guid("19102d99-bcd8-438d-8661-06c51449e2ca"), "Biti's" },
                    { new Guid("2339048a-89f5-4711-adb3-868169956321"), "Thượng Đình" },
                    { new Guid("23a7c76c-c602-4559-a748-b4cd51a385aa"), "Ananas" },
                    { new Guid("2449b199-83ea-4a9e-9661-77bc8b36ae7a"), "Laforce" },
                    { new Guid("390fdffc-5d31-4fbc-ba20-54be1df005cf"), "MWC" },
                    { new Guid("449a81e4-faa9-4e86-b678-0e5ccb5909ee"), "Juno" },
                    { new Guid("5fdb62a9-efba-43ea-89b3-2bf279363d0a"), "Đông Hải" },
                    { new Guid("d7afb528-386d-4400-8edb-66fb986e67d4"), "Adidas" },
                    { new Guid("f6c567cc-5d85-4e81-8c8f-eef899e4ce72"), "Vascara" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("13526548-6939-40c5-ab6f-5dd4bfe63993"), "Giày lười" },
                    { new Guid("1db4153b-5fad-4dc3-a1e0-3e9fd60dc085"), "Dép" },
                    { new Guid("247fd884-65a2-4d31-918d-f3b54097bc45"), "Giày sandal" },
                    { new Guid("42c57fc0-f0a6-4fee-9855-36b0fb50f836"), "Sneakers" },
                    { new Guid("6dda28fa-0656-4987-8d2b-4cf54f1c2f2d"), "Giày da" },
                    { new Guid("ef6ba7bb-75fb-4b71-badf-41432951aa9c"), "Giày cao gót" },
                    { new Guid("f14c3b4e-0ed2-4706-ba49-b66e9b5d206c"), "Giày thể thao" },
                    { new Guid("fc3e8fb1-54a4-47a9-a19e-74b233a19693"), "Giày boot" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorCode", "ColorName" },
                values: new object[,]
                {
                    { new Guid("0371bfcf-cd27-4459-acd4-67b2b4218871"), "#A52A2A", "Nâu" },
                    { new Guid("1e692987-e4d9-4a41-8dd2-9037baeb66a2"), "#FFA500", "Cam" },
                    { new Guid("2ddf318d-3408-4de7-9826-195ce18a98d9"), "#800080", "Tím" },
                    { new Guid("3f7e02e1-bf55-4680-a86f-02295c95c8ba"), "#0000FF", "Lam" },
                    { new Guid("4c6f52db-ccdf-424d-83f3-fa0e48c81da2"), "#FFDAB9", "Hồng đào" },
                    { new Guid("6087aeba-82eb-4141-9237-96c33fc1ebdb"), "#FFFF00", "Vàng" },
                    { new Guid("727861ee-8242-42c1-9475-e8f6d00e839e"), "#E6E6FA", "Tím hoa cà" },
                    { new Guid("72a80f98-c879-46c4-b089-5fbcdbd9d181"), "#FF0000", "Đỏ" },
                    { new Guid("84a7a22d-4898-45b0-8559-98f97b4b5ce3"), "#40E0D0", "Ngọc lam" },
                    { new Guid("8af13afb-3cf8-4afd-a34f-a7f2ddb236b4"), "#808080", "Xám" },
                    { new Guid("9c6f27c9-6f1c-4cb6-8cd0-64a75bad4bb0"), "#008000", "Lục" },
                    { new Guid("9c7d4921-94fe-4f19-8f6b-512d524426a3"), "#4B0082", "Chàm" },
                    { new Guid("d351e81d-b71e-47b4-88c3-9997fc4adb6d"), "#FFFFFF", "Trắng" },
                    { new Guid("f5f08ca9-c567-4621-8295-ad1b238d2b6d"), "#FFC0CB", "Hồng" },
                    { new Guid("fdb32c71-ca18-4e75-894e-6c74b5c46b44"), "#000000", "Đen" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("03e1c84c-f078-45df-ad75-439dac7bc52c"), "momo", true },
                    { new Guid("1f3e8630-1aff-4b9f-b047-64a8444a2e24"), "vnpay", true },
                    { new Guid("d9b85c50-0dc0-4b26-ab45-438dad87a742"), "cod", true }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Description", "Name", "PoinsMax", "PointsMin" },
                values: new object[,]
                {
                    { new Guid("354b9590-5a88-4fe1-a343-b3a6421e1ac4"), null, "Kim Cương", 10000000, 3000001 },
                    { new Guid("8f503645-2df9-4486-a017-a02838631093"), null, "Vàng", 3000000, 1000001 }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE1D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "82982fd8-8a04-4032-a5a7-cbe0cb320480");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE2D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "dbf51b42-2cea-43a3-9517-05ed4f146031");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "f1a568e3-3732-4c2b-9183-b04ea4bc14df");

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("200deec0-835c-4989-adef-77723c9286de"), "40" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("496b1d6b-b595-4e4a-a99a-7ce5700c9723"), "39" },
                    { new Guid("4c6c1381-c284-45b6-b6cc-016238b66a57"), "43" },
                    { new Guid("687b13cc-9af5-409f-baad-77000b6320a2"), "42" },
                    { new Guid("6a0fe1c5-15bd-49bd-8df9-86dd4431906f"), "44" },
                    { new Guid("df24d64b-0070-4a5f-a432-9ff3c1bc3929"), "38" },
                    { new Guid("e3926698-21bd-4296-82ec-e51b11cd9f5f"), "41" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "1FA6148D-B530-421F-878E-CE4D54BFC6AB",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04c4dbc9-da7c-4034-94ee-29ad60157964", "19a6e848-313f-42a3-aa81-a5c619e07955" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2404865e-eb9f-4af5-937c-e1589fa64fcd", "28541405-10ce-49b2-b7ac-954db78709f7" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ColorId",
                table: "ProductDetails",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Colors_ColorId",
                table: "ProductDetails",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Colors_ColorId",
                table: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_ColorId",
                table: "ProductDetails");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("15c65339-a7eb-4235-8e58-71409563b430"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("19102d99-bcd8-438d-8661-06c51449e2ca"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("2339048a-89f5-4711-adb3-868169956321"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("23a7c76c-c602-4559-a748-b4cd51a385aa"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("2449b199-83ea-4a9e-9661-77bc8b36ae7a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("390fdffc-5d31-4fbc-ba20-54be1df005cf"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("449a81e4-faa9-4e86-b678-0e5ccb5909ee"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("5fdb62a9-efba-43ea-89b3-2bf279363d0a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("d7afb528-386d-4400-8edb-66fb986e67d4"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("f6c567cc-5d85-4e81-8c8f-eef899e4ce72"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("13526548-6939-40c5-ab6f-5dd4bfe63993"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1db4153b-5fad-4dc3-a1e0-3e9fd60dc085"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("247fd884-65a2-4d31-918d-f3b54097bc45"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("42c57fc0-f0a6-4fee-9855-36b0fb50f836"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6dda28fa-0656-4987-8d2b-4cf54f1c2f2d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef6ba7bb-75fb-4b71-badf-41432951aa9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f14c3b4e-0ed2-4706-ba49-b66e9b5d206c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc3e8fb1-54a4-47a9-a19e-74b233a19693"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("0371bfcf-cd27-4459-acd4-67b2b4218871"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("1e692987-e4d9-4a41-8dd2-9037baeb66a2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("2ddf318d-3408-4de7-9826-195ce18a98d9"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("3f7e02e1-bf55-4680-a86f-02295c95c8ba"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4c6f52db-ccdf-424d-83f3-fa0e48c81da2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("6087aeba-82eb-4141-9237-96c33fc1ebdb"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("727861ee-8242-42c1-9475-e8f6d00e839e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("72a80f98-c879-46c4-b089-5fbcdbd9d181"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("84a7a22d-4898-45b0-8559-98f97b4b5ce3"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("8af13afb-3cf8-4afd-a34f-a7f2ddb236b4"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("9c6f27c9-6f1c-4cb6-8cd0-64a75bad4bb0"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("9c7d4921-94fe-4f19-8f6b-512d524426a3"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("d351e81d-b71e-47b4-88c3-9997fc4adb6d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("f5f08ca9-c567-4621-8295-ad1b238d2b6d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("fdb32c71-ca18-4e75-894e-6c74b5c46b44"));

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: new Guid("03e1c84c-f078-45df-ad75-439dac7bc52c"));

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: new Guid("1f3e8630-1aff-4b9f-b047-64a8444a2e24"));

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: new Guid("d9b85c50-0dc0-4b26-ab45-438dad87a742"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("354b9590-5a88-4fe1-a343-b3a6421e1ac4"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("8f503645-2df9-4486-a017-a02838631093"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("200deec0-835c-4989-adef-77723c9286de"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("496b1d6b-b595-4e4a-a99a-7ce5700c9723"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("4c6c1381-c284-45b6-b6cc-016238b66a57"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("687b13cc-9af5-409f-baad-77000b6320a2"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("6a0fe1c5-15bd-49bd-8df9-86dd4431906f"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("df24d64b-0070-4a5f-a432-9ff3c1bc3929"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("e3926698-21bd-4296-82ec-e51b11cd9f5f"));

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "ProductDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "ColorsId",
                table: "ProductDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("246e4bf2-e598-4316-b650-d15bd47151ce"), "Laforce" },
                    { new Guid("34e83500-c7d4-4d0d-ae48-8b61a7db9054"), "MWC" },
                    { new Guid("54911e26-cafb-456b-9034-34652c637817"), "Juno" },
                    { new Guid("585b37b5-01f1-4c66-a59f-7c4ce3dfe8d3"), "Vascara" },
                    { new Guid("90d535eb-f7f2-42e8-aa23-ebb37123e17a"), "Đông Hải" },
                    { new Guid("9cf70eea-fb1c-4b20-a7ca-4dbb01f8f962"), "Biti's" },
                    { new Guid("b02612aa-b3bc-42ac-89cc-35600141822b"), "Thượng Đình" },
                    { new Guid("c77fd1b7-6d8c-4afb-99e4-45015224c88f"), "Nike" },
                    { new Guid("ce2f1608-ec99-4712-b1df-4dd354fbb61b"), "Ananas" },
                    { new Guid("e2a50ac0-fcdb-4d0d-b8b1-68dff3f368e6"), "Adidas" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0deca26a-5e87-4bd2-9bc4-1e784328f84e"), "Giày boot" },
                    { new Guid("47450740-5f08-4c96-90e0-02c804ebbbc6"), "Giày lười" },
                    { new Guid("6e3e71f7-4487-4ded-acb9-49cc77625e32"), "Giày sandal" },
                    { new Guid("77d5df3e-7887-4834-9e34-5f35fabfc5b3"), "Giày da" },
                    { new Guid("7c360c1e-4cfb-4871-9cb4-2c5173db2a25"), "Sneakers" },
                    { new Guid("af0d44ad-2ac8-4079-98b2-72d1ec249e9c"), "Dép" },
                    { new Guid("c03790b1-b2bc-4212-93eb-5c6e93b26c6d"), "Giày cao gót" },
                    { new Guid("f0918d36-ef0b-4448-8f4d-4c72c3566e26"), "Giày thể thao" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorCode", "ColorName" },
                values: new object[,]
                {
                    { new Guid("3c4698ca-6f85-4d8c-88ee-0f25010c40a2"), "#A52A2A", "Nâu" },
                    { new Guid("49b5bc60-d363-4e01-933d-62659d7a53da"), "#FFFFFF", "Trắng" },
                    { new Guid("59659a08-d6a9-4db7-be9d-0d21f5d4952e"), "#E6E6FA", "Tím hoa cà" },
                    { new Guid("6db65397-418f-47cc-a47b-1765beefbe51"), "#FFC0CB", "Hồng" },
                    { new Guid("6de72734-1038-49b1-b045-b94f762ae031"), "#000000", "Đen" },
                    { new Guid("8427f0bf-cd34-4faf-83d0-eaf2038e5af0"), "#FFDAB9", "Hồng đào" },
                    { new Guid("a7bbf036-497e-451a-864a-6f4ff4e2d24b"), "#808080", "Xám" },
                    { new Guid("a7ec19cb-12bb-45e4-aaff-9af1cc3f52cb"), "#0000FF", "Lam" },
                    { new Guid("a8d62696-4e3e-45c7-813b-4ac47f4a7cea"), "#FFFF00", "Vàng" },
                    { new Guid("b84d285c-802c-4752-9bf3-38b185173fb4"), "#40E0D0", "Ngọc lam" },
                    { new Guid("b9ade7fc-be6a-47d4-8651-0ccec3df1166"), "#FFA500", "Cam" },
                    { new Guid("ddd9455c-93bf-4e44-aed0-b9e3017a5638"), "#800080", "Tím" },
                    { new Guid("eb617332-6152-49a7-95ff-5c2423d5d194"), "#FF0000", "Đỏ" },
                    { new Guid("f77ca10a-ebca-4241-ab1a-75916674ee3c"), "#4B0082", "Chàm" },
                    { new Guid("f9d0aeed-052c-475e-9567-50600e623017"), "#008000", "Lục" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("66334d2e-2946-4db0-bbb0-a1d766ea06fb"), "momo", true },
                    { new Guid("68ae4c32-e1a5-494d-af82-d2417fd7a436"), "vnpay", true },
                    { new Guid("b69fa31e-d7e9-4e9b-81ad-9a555baf4523"), "cod", true }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Description", "Name", "PoinsMax", "PointsMin" },
                values: new object[,]
                {
                    { new Guid("6eb7b930-b05f-49db-ba27-32bac86c617f"), null, "Kim Cương", 10000000, 3000001 },
                    { new Guid("b771e79b-b451-4038-8f5a-1414b7e0ef1c"), null, "Vàng", 3000000, 1000001 }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE1D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "d557fa66-8867-4bae-a4f0-c33a05cf226b");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE2D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "d1382ce6-33aa-4d2b-aca9-f94e36c638f2");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "bbd0e17b-a56d-4000-8894-7ba08bd910de");

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("315eb890-350f-4648-88f1-62ba79cf10f3"), "42" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("94cfb484-77dc-45d5-b480-251a26e7e043"), "38" },
                    { new Guid("b714fe70-6c60-4166-9b0a-dd2a08488bf8"), "39" },
                    { new Guid("c0b81f57-7f85-49aa-884f-d55f50627351"), "43" },
                    { new Guid("ca84ecc1-ca7d-42ad-aac6-1c491d66826e"), "40" },
                    { new Guid("f2d53016-7b30-4ee3-9197-4197e9662fd5"), "44" },
                    { new Guid("f525ffee-914c-4d26-952d-142f690d6ef1"), "41" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "1FA6148D-B530-421F-878E-CE4D54BFC6AB",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f69d4196-97c5-4cbc-9478-aa51ef78f24e", "cc51674f-6cbc-4d80-b0ea-25232e047e4b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8cd944f-36dd-4871-8ec0-674d31d02a6c", "1d3454ac-f693-49c9-8f5c-be3befcb0bd1" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ColorsId",
                table: "ProductDetails",
                column: "ColorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Colors_ColorsId",
                table: "ProductDetails",
                column: "ColorsId",
                principalTable: "Colors",
                principalColumn: "Id");
        }
    }
}
