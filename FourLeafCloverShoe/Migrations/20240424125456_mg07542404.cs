using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourLeafCloverShoe.Migrations
{
    public partial class mg07542404 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_ProductDetails_ProductDetailId",
                table: "OrderItems");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("22f2c05f-29a3-497a-9207-c956385a3c40"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("2d496c2f-46f4-4962-88a7-8e0810dc1f6d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("2e3414d3-8132-4628-97ba-f5be2ca24df7"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("3afad3e3-958f-44c5-a9f0-66ce2dc840ec"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("3e5ad88b-00a4-4cdb-97a3-7e88853cbc8c"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("4654b785-ecb9-45f7-a4a9-d83805ebf394"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("4a80dbf1-63aa-4f50-99c3-e9200448a7be"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("8354731e-15aa-4489-a61d-c214e500dad5"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("83feb9e7-c37a-468b-992f-6bf57ec93f2a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("98806145-408c-4d4a-bfac-0fa0b7934749"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("ad2cdfbc-ff47-4608-bab7-ce8352e4ccf5"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("bdf48f08-9495-421f-a9db-7543fbee7f21"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("f33f5172-a5f3-46dd-9112-c9ef0ae7750c"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("f34c760d-2d6b-4235-9f0d-cfe4f817e5f6"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("f56ab33c-e456-4d4d-b51e-f2435574ef16"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ca76aaa-2dc3-4c5d-8da3-60d59754721b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27db344c-0b44-4ad2-a4f2-21e9c34f45db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28b924cf-eb1c-42e3-a6ba-d91aedf6df57"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2eb2b89a-eba0-46e5-ae7d-662647240702"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("76972fba-316c-4fcc-bf68-e1f743d13072"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7c4443bd-0649-474b-809b-e950198ccbe7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81c0486c-7e6e-4688-8edc-d87071528e3d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a72c44e8-9e22-4486-b7d6-2b748e60e611"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed09ae78-b9b3-42ed-b7ab-48f4aa6ce7dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed7aff29-e482-4d2c-a8ef-a80661d115f9"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("16ac5fb6-da6b-45a2-a431-eff4515d0d76"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("824bc0cf-ad07-4107-b29d-22ada1d5ec40"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("19533a73-ebf3-4582-9afe-8e55ae701db8"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("3873f94f-4f9f-4a19-bd00-697361e80b8c"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("8678d030-89bb-4166-91ba-7ae7ec2d0b95"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("931256c8-5885-4485-9c09-aa7257aeebc9"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("cbe6e584-6e1c-45e9-9831-1273eb69c914"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("f29ef548-0236-4fb0-9f28-496e633b68c4"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("f7cd221f-554d-4ff7-b7c7-00ce563661ab"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Coins",
                schema: "security",
                table: "Users",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductDetailId",
                table: "OrderItems",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "OrderItems",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("09ece388-1006-4489-98a4-b79f56c94d59"), "Puma" },
                    { new Guid("10044a3f-7058-42e9-8b5a-f18dd9f998f2"), "Adidas" },
                    { new Guid("13d6e4f5-be49-4f01-b058-7da69c600a99"), "Converse" },
                    { new Guid("41fb9ebd-18b8-40e8-a53e-2d38675e1155"), "Asics" },
                    { new Guid("565481d4-a073-4e9a-a405-8ff57ece8da9"), "Reebok" },
                    { new Guid("570918ed-a966-44bd-8a77-8ae36edd0da8"), "Skechers" },
                    { new Guid("58a8b67b-b569-4af4-8f3e-62002bdfe385"), "Nike" },
                    { new Guid("6c6afadf-f1d3-4458-abe9-26b473061c77"), "Vans" },
                    { new Guid("80f55db3-97b1-4fa5-92c9-1d6c58e90e80"), "Under Armour" },
                    { new Guid("8cd5d124-2fac-4d83-b5d5-c76596a05005"), "Timberland" },
                    { new Guid("983e03fc-107c-44ba-adf0-c305a95af236"), "Clarks" },
                    { new Guid("a0173724-cc92-437d-943c-b31316e65608"), "Brooks" },
                    { new Guid("a3356624-13aa-462a-9d95-d787d6a5c47f"), "New Balance " },
                    { new Guid("bcab0aac-a3e0-4cea-b3b1-611696736d8b"), "Dr. Martens" },
                    { new Guid("ca131e2d-0803-4f65-9762-3bb53ba03211"), "Fila" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01554432-7410-4863-8575-4afc7b7bba43"), "Dress shoes " },
                    { new Guid("1c70e21d-9aef-488a-a9f1-fef37f830ad7"), "Flats" },
                    { new Guid("326b39ce-c6d7-41a8-aee1-a1787ab89fa7"), "Boots  " },
                    { new Guid("4de6bac5-f531-463c-a526-22aae3226507"), "High heels" },
                    { new Guid("55c62ad0-2553-4970-9abd-eddd598f8354"), "Sandals  " },
                    { new Guid("77d60430-3bfb-44d1-93ff-4434127e88fe"), "Sneakers " },
                    { new Guid("80144f07-3fff-4339-9833-8c491aecc4e0"), "Athletic shoes " },
                    { new Guid("bb3d3061-5890-4289-b353-0d9527c52f09"), "Espadrilles" },
                    { new Guid("c9178e47-4abf-4482-ad5b-368c56610a7e"), "Slippers  " },
                    { new Guid("f5651d5c-ea99-4743-a1ed-45b50efb3b33"), "Loafers  " }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Description", "Name", "PoinsMax", "PointsMin" },
                values: new object[,]
                {
                    { new Guid("3fa52de4-9223-4e65-97c8-c5d2051e2a8d"), null, "Kim Cương", 10000000, 3000001 },
                    { new Guid("70060411-da3a-4e6d-b4ab-227c434de88f"), null, "Vàng", 3000000, 1000001 }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE1D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "5d1174fa-7c04-41f9-aaf8-2b01e6dcbee7");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE2D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "54f44eac-cb90-4c45-8002-4dc37dcba0f9");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE3D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "40cca3cf-863e-48ca-87c7-c6fb308fb039");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "e9ad0ca6-6058-4a5b-aa26-d40320247b1b");

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6b330aa6-cdf6-4d3e-96e3-5df33911c330"), "40" },
                    { new Guid("6b3b7a3b-bef1-49b2-b254-63ba56a3ee10"), "38" },
                    { new Guid("751d4771-ea7d-49c1-97a8-b09f0a9245d6"), "39" },
                    { new Guid("771b9143-bd7b-4d53-93d2-df0ff0f6cc50"), "43" },
                    { new Guid("a81a3c72-93d9-4288-a9ed-466ae367e8a9"), "41" },
                    { new Guid("befd7d3b-622f-455c-8b0e-5d83e3b994ea"), "42" },
                    { new Guid("d692669d-59da-45b6-89bb-501d73a5548c"), "44" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55d59d45-69e2-44a1-887b-22d81987a167", "b8c681be-63d7-47f8-819a-adb7f436fbf6" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_ProductDetails_ProductDetailId",
                table: "OrderItems",
                column: "ProductDetailId",
                principalTable: "ProductDetails",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_ProductDetails_ProductDetailId",
                table: "OrderItems");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("09ece388-1006-4489-98a4-b79f56c94d59"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("10044a3f-7058-42e9-8b5a-f18dd9f998f2"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("13d6e4f5-be49-4f01-b058-7da69c600a99"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("41fb9ebd-18b8-40e8-a53e-2d38675e1155"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("565481d4-a073-4e9a-a405-8ff57ece8da9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("570918ed-a966-44bd-8a77-8ae36edd0da8"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("58a8b67b-b569-4af4-8f3e-62002bdfe385"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("6c6afadf-f1d3-4458-abe9-26b473061c77"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("80f55db3-97b1-4fa5-92c9-1d6c58e90e80"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("8cd5d124-2fac-4d83-b5d5-c76596a05005"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("983e03fc-107c-44ba-adf0-c305a95af236"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("a0173724-cc92-437d-943c-b31316e65608"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("a3356624-13aa-462a-9d95-d787d6a5c47f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("bcab0aac-a3e0-4cea-b3b1-611696736d8b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("ca131e2d-0803-4f65-9762-3bb53ba03211"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01554432-7410-4863-8575-4afc7b7bba43"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c70e21d-9aef-488a-a9f1-fef37f830ad7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("326b39ce-c6d7-41a8-aee1-a1787ab89fa7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4de6bac5-f531-463c-a526-22aae3226507"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55c62ad0-2553-4970-9abd-eddd598f8354"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77d60430-3bfb-44d1-93ff-4434127e88fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80144f07-3fff-4339-9833-8c491aecc4e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb3d3061-5890-4289-b353-0d9527c52f09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9178e47-4abf-4482-ad5b-368c56610a7e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f5651d5c-ea99-4743-a1ed-45b50efb3b33"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("3fa52de4-9223-4e65-97c8-c5d2051e2a8d"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("70060411-da3a-4e6d-b4ab-227c434de88f"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("6b330aa6-cdf6-4d3e-96e3-5df33911c330"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("6b3b7a3b-bef1-49b2-b254-63ba56a3ee10"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("751d4771-ea7d-49c1-97a8-b09f0a9245d6"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("771b9143-bd7b-4d53-93d2-df0ff0f6cc50"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("a81a3c72-93d9-4288-a9ed-466ae367e8a9"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("befd7d3b-622f-455c-8b0e-5d83e3b994ea"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("d692669d-59da-45b6-89bb-501d73a5548c"));

            migrationBuilder.AlterColumn<int>(
                name: "Coins",
                schema: "security",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductDetailId",
                table: "OrderItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "OrderItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("22f2c05f-29a3-497a-9207-c956385a3c40"), "Timberland" },
                    { new Guid("2d496c2f-46f4-4962-88a7-8e0810dc1f6d"), "Reebok" },
                    { new Guid("2e3414d3-8132-4628-97ba-f5be2ca24df7"), "Fila" },
                    { new Guid("3afad3e3-958f-44c5-a9f0-66ce2dc840ec"), "Vans" },
                    { new Guid("3e5ad88b-00a4-4cdb-97a3-7e88853cbc8c"), "Asics" },
                    { new Guid("4654b785-ecb9-45f7-a4a9-d83805ebf394"), "Under Armour" },
                    { new Guid("4a80dbf1-63aa-4f50-99c3-e9200448a7be"), "Clarks" },
                    { new Guid("8354731e-15aa-4489-a61d-c214e500dad5"), "Nike" },
                    { new Guid("83feb9e7-c37a-468b-992f-6bf57ec93f2a"), "New Balance " },
                    { new Guid("98806145-408c-4d4a-bfac-0fa0b7934749"), "Puma" },
                    { new Guid("ad2cdfbc-ff47-4608-bab7-ce8352e4ccf5"), "Skechers" },
                    { new Guid("bdf48f08-9495-421f-a9db-7543fbee7f21"), "Brooks" },
                    { new Guid("f33f5172-a5f3-46dd-9112-c9ef0ae7750c"), "Dr. Martens" },
                    { new Guid("f34c760d-2d6b-4235-9f0d-cfe4f817e5f6"), "Converse" },
                    { new Guid("f56ab33c-e456-4d4d-b51e-f2435574ef16"), "Adidas" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1ca76aaa-2dc3-4c5d-8da3-60d59754721b"), "Sandals  " },
                    { new Guid("27db344c-0b44-4ad2-a4f2-21e9c34f45db"), "Flats" },
                    { new Guid("28b924cf-eb1c-42e3-a6ba-d91aedf6df57"), "Slippers  " },
                    { new Guid("2eb2b89a-eba0-46e5-ae7d-662647240702"), "Loafers  " },
                    { new Guid("76972fba-316c-4fcc-bf68-e1f743d13072"), "Boots  " },
                    { new Guid("7c4443bd-0649-474b-809b-e950198ccbe7"), "Athletic shoes " },
                    { new Guid("81c0486c-7e6e-4688-8edc-d87071528e3d"), "Sneakers " },
                    { new Guid("a72c44e8-9e22-4486-b7d6-2b748e60e611"), "High heels" },
                    { new Guid("ed09ae78-b9b3-42ed-b7ab-48f4aa6ce7dd"), "Dress shoes " },
                    { new Guid("ed7aff29-e482-4d2c-a8ef-a80661d115f9"), "Espadrilles" }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Description", "Name", "PoinsMax", "PointsMin" },
                values: new object[,]
                {
                    { new Guid("16ac5fb6-da6b-45a2-a431-eff4515d0d76"), null, "Vàng", 3000000, 1000001 },
                    { new Guid("824bc0cf-ad07-4107-b29d-22ada1d5ec40"), null, "Kim Cương", 10000000, 3000001 }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE1D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "402fbcba-40df-49d0-9200-60ead96e2190");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE2D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "9bac7842-676b-4d3d-9bb6-ed18c0f67f5e");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE3D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "88482cbf-896e-40e7-8b1a-d334b4026a29");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "d1e66e39-19db-42d2-aae6-9ab706a4a10f");

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("19533a73-ebf3-4582-9afe-8e55ae701db8"), "43" },
                    { new Guid("3873f94f-4f9f-4a19-bd00-697361e80b8c"), "38" },
                    { new Guid("8678d030-89bb-4166-91ba-7ae7ec2d0b95"), "40" },
                    { new Guid("931256c8-5885-4485-9c09-aa7257aeebc9"), "39" },
                    { new Guid("cbe6e584-6e1c-45e9-9831-1273eb69c914"), "41" },
                    { new Guid("f29ef548-0236-4fb0-9f28-496e633b68c4"), "44" },
                    { new Guid("f7cd221f-554d-4ff7-b7c7-00ce563661ab"), "42" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2aa0bf09-4d97-4fe0-ad2c-1ef2544ac6bc", "d9852575-1721-4e3b-82d7-cc450950ad98" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_ProductDetails_ProductDetailId",
                table: "OrderItems",
                column: "ProductDetailId",
                principalTable: "ProductDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
