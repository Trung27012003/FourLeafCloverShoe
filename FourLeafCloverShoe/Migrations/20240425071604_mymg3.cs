using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourLeafCloverShoe.Migrations
{
    public partial class mymg3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rates_OrderItems_OrderItemId1",
                table: "Rates");

            migrationBuilder.DropIndex(
                name: "IX_Rates_OrderItemId",
                table: "Rates");

            migrationBuilder.DropIndex(
                name: "IX_Rates_OrderItemId1",
                table: "Rates");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("2d972901-431c-4095-b2a5-f0105cc76b54"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("2f11a1a7-f152-4c90-9966-3fa5d0ac3ec3"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("2fa50043-61a4-4d9d-bc0f-30a71996b7c9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("38effd99-d6e1-4037-88f3-63e50c0762e8"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("3e4c255a-66f4-415b-a6b0-de48fe603011"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("49e4b5d3-f6e4-4edc-9a2c-745a90fe5545"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("4cf9452d-279f-4753-a7c1-7a167da6b5e4"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("53631b2d-fe95-4504-98b4-93ce13c1c293"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("6ed5d7db-47bc-48f8-9707-a936bdb40418"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("7964b470-7244-46da-a80f-6c1cdf2edf16"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("82e899cd-ddcc-4141-a194-4f4bd8d650b6"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("8e050401-8144-4b40-9eea-359eb9b08a61"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("ab614159-252f-4059-a603-85fc89fd8a6e"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("c4bd8a8a-ade5-4a21-845e-2c52131c1978"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("e8c240c9-3dd7-46e7-b668-cb0abb751abb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c44c1c4-2db8-47be-9f17-d445bed227fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d3ad491-31e8-4bae-8ab6-ef466ec990c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41b8a318-48ca-4154-a6e6-5a01f0aa0789"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("908737cf-8d0b-4615-93d9-02355e39b4b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9fa065a1-e457-4bb4-979a-a4b319a69eea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a35c0bf2-9cfa-4c30-83bf-34ab78852d3d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b52dabec-8881-492a-a863-4c13fc1725ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6d38a38-5b7d-4d1b-bf67-af498799b372"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d756361a-2fbc-4691-a32c-99bac8a4be35"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6a07adf-18f3-469d-b2e5-2d7a25b01211"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("2930257e-ef50-4d8c-a70b-3e19a5bd0195"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("afd8de79-94c0-4908-b779-f98f96be5677"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("234a9df1-0b21-4229-a3ff-14187e4d848e"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("28e1fc53-3e32-4500-a89e-26e6d766142d"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("39c9db39-ec71-4681-8cb2-4ad13ce97e72"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("3b264b14-bfa4-43d4-ae45-c60f4882ea95"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("3b83c5d9-d1ee-4047-8e20-97efd6efd898"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("9d15820b-5a2b-4519-98ae-7e2c62e3f707"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("ceb2a2b3-59fc-4b6e-aaeb-d55b974f25e3"));

            migrationBuilder.DropColumn(
                name: "OrderItemId1",
                table: "Rates");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("028c8cf0-2ab6-4107-9d85-811f38d41b24"), "Asics" },
                    { new Guid("0611258f-9521-431a-960c-6b0433363ccd"), "Vans" },
                    { new Guid("0f212bbb-9d12-4bc7-95d1-8fa7646a1ef6"), "Converse" },
                    { new Guid("0fa4a56b-e098-4874-bc63-fbe88b2308ca"), "Skechers" },
                    { new Guid("10df5c83-fcdf-4b60-9868-638f98e3dfed"), "New Balance " },
                    { new Guid("14bc5843-d5e6-4f80-9e29-9aa39f27afdd"), "Puma" },
                    { new Guid("1ce9c758-d66f-4842-aa3d-ff601c6103c9"), "Brooks" },
                    { new Guid("489eb9e9-e808-4b08-8d78-0796ff837a2b"), "Adidas" },
                    { new Guid("5b6eef14-02bb-42f1-baec-854279ff1d26"), "Reebok" },
                    { new Guid("61884cd1-d52a-4098-bc72-15415ac835d1"), "Dr. Martens" },
                    { new Guid("73bd566f-8508-4ac3-829e-2f570a4dce0b"), "Nike" },
                    { new Guid("89a55abc-a4f0-4c89-bf17-a33c55fcc301"), "Timberland" },
                    { new Guid("9a128f32-a27c-4c1a-bf8a-15cc1f914bf4"), "Under Armour" },
                    { new Guid("b430bdde-d822-4f40-a076-b6a4aed36fc9"), "Fila" },
                    { new Guid("db2b417a-1603-4c67-a3fc-373ef9ec0d56"), "Clarks" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0bfdc92d-8d57-4f0c-b7cf-e64aff246f1e"), "Dress shoes " },
                    { new Guid("0c268ef5-c628-4297-b8c0-0a81f3a41da7"), "Espadrilles" },
                    { new Guid("147c8c0b-69d3-41c3-ad37-abea5a8c5906"), "Sandals  " },
                    { new Guid("2fbe0cd8-905f-4464-a03e-0f3296218bc5"), "Flats" },
                    { new Guid("3230f843-fa7d-45e8-8103-0e692436a859"), "Athletic shoes " },
                    { new Guid("7af92d3e-11a4-4ada-b0a6-fd028f1dce0b"), "Slippers  " },
                    { new Guid("8106eb54-ae9a-4a59-9eb5-ee20cd50cbd8"), "Boots  " },
                    { new Guid("d10ccf56-d724-45fd-a5d2-b5e2ad61c5d2"), "Sneakers " },
                    { new Guid("facd6e1d-9ccd-44c1-b620-82eb40510b81"), "High heels" },
                    { new Guid("fc18d754-e252-45ce-ac88-1808b3a859b6"), "Loafers  " }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Description", "Name", "PoinsMax", "PointsMin" },
                values: new object[,]
                {
                    { new Guid("1282acbe-74fb-4c7d-aac5-5677bfafbc49"), null, "Vàng", 3000000, 1000001 },
                    { new Guid("cd3dcfde-6955-443c-a29e-0875643f7544"), null, "Kim Cương", 10000000, 3000001 }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE1D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "2bc2bdac-3583-46e2-8508-c876a8495d36");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE2D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "d14a6fc6-094b-452c-b1cd-e2383b3113f3");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE3D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "70cd26be-1fea-4cbe-a75f-a768b8df28f7");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "4f297a4c-0a59-4d97-b8e8-86a41f9f0546");

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("646d685a-e846-4530-9877-877b434bc554"), "40" },
                    { new Guid("6ae487af-5a7c-47f1-b9f5-dc08a7ede6f2"), "39" },
                    { new Guid("7ad618b1-7bd6-499b-a451-a5962d60507e"), "41" },
                    { new Guid("c377bac3-ce64-4551-847a-342607278c80"), "44" },
                    { new Guid("c538dd26-f65f-472d-acc9-28fc19f9c5e1"), "38" },
                    { new Guid("d50d0c0b-4db0-45ae-8c84-17cd6a6c2cab"), "42" },
                    { new Guid("eb4900e6-cd0b-4f01-81da-cdb84539099e"), "43" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d52a40a1-b2f4-43db-b2c4-bfc42ef63941", "ca6419ac-978e-4be4-b400-75f8467784e3" });

            migrationBuilder.CreateIndex(
                name: "IX_Rates_OrderItemId",
                table: "Rates",
                column: "OrderItemId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rates_OrderItemId",
                table: "Rates");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("028c8cf0-2ab6-4107-9d85-811f38d41b24"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("0611258f-9521-431a-960c-6b0433363ccd"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("0f212bbb-9d12-4bc7-95d1-8fa7646a1ef6"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("0fa4a56b-e098-4874-bc63-fbe88b2308ca"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("10df5c83-fcdf-4b60-9868-638f98e3dfed"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("14bc5843-d5e6-4f80-9e29-9aa39f27afdd"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("1ce9c758-d66f-4842-aa3d-ff601c6103c9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("489eb9e9-e808-4b08-8d78-0796ff837a2b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("5b6eef14-02bb-42f1-baec-854279ff1d26"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("61884cd1-d52a-4098-bc72-15415ac835d1"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("73bd566f-8508-4ac3-829e-2f570a4dce0b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("89a55abc-a4f0-4c89-bf17-a33c55fcc301"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("9a128f32-a27c-4c1a-bf8a-15cc1f914bf4"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("b430bdde-d822-4f40-a076-b6a4aed36fc9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("db2b417a-1603-4c67-a3fc-373ef9ec0d56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0bfdc92d-8d57-4f0c-b7cf-e64aff246f1e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0c268ef5-c628-4297-b8c0-0a81f3a41da7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("147c8c0b-69d3-41c3-ad37-abea5a8c5906"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2fbe0cd8-905f-4464-a03e-0f3296218bc5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3230f843-fa7d-45e8-8103-0e692436a859"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7af92d3e-11a4-4ada-b0a6-fd028f1dce0b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8106eb54-ae9a-4a59-9eb5-ee20cd50cbd8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d10ccf56-d724-45fd-a5d2-b5e2ad61c5d2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("facd6e1d-9ccd-44c1-b620-82eb40510b81"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc18d754-e252-45ce-ac88-1808b3a859b6"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("1282acbe-74fb-4c7d-aac5-5677bfafbc49"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("cd3dcfde-6955-443c-a29e-0875643f7544"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("646d685a-e846-4530-9877-877b434bc554"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("6ae487af-5a7c-47f1-b9f5-dc08a7ede6f2"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("7ad618b1-7bd6-499b-a451-a5962d60507e"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("c377bac3-ce64-4551-847a-342607278c80"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("c538dd26-f65f-472d-acc9-28fc19f9c5e1"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("d50d0c0b-4db0-45ae-8c84-17cd6a6c2cab"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("eb4900e6-cd0b-4f01-81da-cdb84539099e"));

            migrationBuilder.AddColumn<Guid>(
                name: "OrderItemId1",
                table: "Rates",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2d972901-431c-4095-b2a5-f0105cc76b54"), "Reebok" },
                    { new Guid("2f11a1a7-f152-4c90-9966-3fa5d0ac3ec3"), "Puma" },
                    { new Guid("2fa50043-61a4-4d9d-bc0f-30a71996b7c9"), "Clarks" },
                    { new Guid("38effd99-d6e1-4037-88f3-63e50c0762e8"), "New Balance " },
                    { new Guid("3e4c255a-66f4-415b-a6b0-de48fe603011"), "Brooks" },
                    { new Guid("49e4b5d3-f6e4-4edc-9a2c-745a90fe5545"), "Timberland" },
                    { new Guid("4cf9452d-279f-4753-a7c1-7a167da6b5e4"), "Dr. Martens" },
                    { new Guid("53631b2d-fe95-4504-98b4-93ce13c1c293"), "Asics" },
                    { new Guid("6ed5d7db-47bc-48f8-9707-a936bdb40418"), "Vans" },
                    { new Guid("7964b470-7244-46da-a80f-6c1cdf2edf16"), "Adidas" },
                    { new Guid("82e899cd-ddcc-4141-a194-4f4bd8d650b6"), "Nike" },
                    { new Guid("8e050401-8144-4b40-9eea-359eb9b08a61"), "Converse" },
                    { new Guid("ab614159-252f-4059-a603-85fc89fd8a6e"), "Skechers" },
                    { new Guid("c4bd8a8a-ade5-4a21-845e-2c52131c1978"), "Fila" },
                    { new Guid("e8c240c9-3dd7-46e7-b668-cb0abb751abb"), "Under Armour" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2c44c1c4-2db8-47be-9f17-d445bed227fb"), "Sandals  " },
                    { new Guid("2d3ad491-31e8-4bae-8ab6-ef466ec990c3"), "Dress shoes " },
                    { new Guid("41b8a318-48ca-4154-a6e6-5a01f0aa0789"), "Flats" },
                    { new Guid("908737cf-8d0b-4615-93d9-02355e39b4b4"), "Espadrilles" },
                    { new Guid("9fa065a1-e457-4bb4-979a-a4b319a69eea"), "Athletic shoes " },
                    { new Guid("a35c0bf2-9cfa-4c30-83bf-34ab78852d3d"), "High heels" },
                    { new Guid("b52dabec-8881-492a-a863-4c13fc1725ac"), "Boots  " },
                    { new Guid("c6d38a38-5b7d-4d1b-bf67-af498799b372"), "Sneakers " },
                    { new Guid("d756361a-2fbc-4691-a32c-99bac8a4be35"), "Loafers  " },
                    { new Guid("e6a07adf-18f3-469d-b2e5-2d7a25b01211"), "Slippers  " }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Description", "Name", "PoinsMax", "PointsMin" },
                values: new object[,]
                {
                    { new Guid("2930257e-ef50-4d8c-a70b-3e19a5bd0195"), null, "Vàng", 3000000, 1000001 },
                    { new Guid("afd8de79-94c0-4908-b779-f98f96be5677"), null, "Kim Cương", 10000000, 3000001 }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE1D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "f8084163-3ea7-42bd-8e36-010f27b32614");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE2D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "5078cc31-0f90-4aae-8817-0a8588fa7680");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE3D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "f26a069b-3a0c-456d-a10e-3f0ae36e6562");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "1b05d4bd-87ab-4527-aba8-a6c719d97430");

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("234a9df1-0b21-4229-a3ff-14187e4d848e"), "38" },
                    { new Guid("28e1fc53-3e32-4500-a89e-26e6d766142d"), "39" },
                    { new Guid("39c9db39-ec71-4681-8cb2-4ad13ce97e72"), "43" },
                    { new Guid("3b264b14-bfa4-43d4-ae45-c60f4882ea95"), "41" },
                    { new Guid("3b83c5d9-d1ee-4047-8e20-97efd6efd898"), "40" },
                    { new Guid("9d15820b-5a2b-4519-98ae-7e2c62e3f707"), "42" },
                    { new Guid("ceb2a2b3-59fc-4b6e-aaeb-d55b974f25e3"), "44" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "27213c79-1efb-4676-a2d9-c92009073aa4", "8583644d-c837-47cd-b174-9e09be396ab9" });

            migrationBuilder.CreateIndex(
                name: "IX_Rates_OrderItemId",
                table: "Rates",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_OrderItemId1",
                table: "Rates",
                column: "OrderItemId1",
                unique: true,
                filter: "[OrderItemId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_OrderItems_OrderItemId1",
                table: "Rates",
                column: "OrderItemId1",
                principalTable: "OrderItems",
                principalColumn: "Id");
        }
    }
}
