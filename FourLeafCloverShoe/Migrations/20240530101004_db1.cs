using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourLeafCloverShoe.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE3D54BFC6AB");

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
                name: "MaterialId",
                table: "ProductDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "materials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materials", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("11a9f3c1-5a28-417b-8377-01eac1940921"), "Adidas" },
                    { new Guid("334ee58a-f2e8-4906-b283-9e8fad33b947"), "Asics" },
                    { new Guid("3944f266-cb82-4a0e-a984-9ee64ca748b9"), "Dr. Martens" },
                    { new Guid("4477a122-ad65-49b3-a0d6-c3fe5cec9b9b"), "Puma" },
                    { new Guid("50047c2b-6411-4e17-8be1-580bb97e8c89"), "Converse" },
                    { new Guid("5291d3ba-aa96-46c1-8467-1ed915121629"), "Brooks" },
                    { new Guid("658075a3-1f08-4bf9-9fc2-c36733bdfa2d"), "Vans" },
                    { new Guid("66acb55b-51e6-4dc6-affe-2f28eda19d27"), "Timberland" },
                    { new Guid("81978850-930c-470a-9d8d-529eb6825137"), "Fila" },
                    { new Guid("c188cd0d-8118-4674-a1c2-3188b0b3d5bc"), "Skechers" },
                    { new Guid("c5525d88-b84d-4cdc-ac2c-159408754cf7"), "Under Armour" },
                    { new Guid("c9e1dbed-86b8-4ffd-8e27-3683cdbe7f20"), "Clarks" },
                    { new Guid("da16c597-7dea-44cc-a2c3-5b00b564b8da"), "Nike" },
                    { new Guid("de5c8247-dd7b-42e8-a6ad-09eee9a972ef"), "New Balance " },
                    { new Guid("f3bdd7ff-bb03-44f8-a9b0-afb3de6da096"), "Reebok" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("179e627e-123d-4386-af37-b94e403c32b0"), "Slippers  " },
                    { new Guid("3883695d-7ace-4ffe-8440-895448b8ec03"), "Sandals  " },
                    { new Guid("4692ad62-ee3c-4594-837b-4b464eee936d"), "Loafers  " },
                    { new Guid("627c3aa8-a39a-4643-b33d-3fc9d2d20538"), "Espadrilles" },
                    { new Guid("6ff75069-ec96-4dc9-9581-6f5c1b821bcf"), "Sneakers " },
                    { new Guid("7cb0d99a-a9c6-48c6-998a-0fc7082b3324"), "Flats" },
                    { new Guid("7d2841de-8dcc-4cc2-84b4-685e8930f251"), "Boots  " },
                    { new Guid("c6037491-796c-4adc-a60f-5a66a5cb3f73"), "Dress shoes " },
                    { new Guid("ca9dc0e1-bc7e-499c-a549-644d4c1ad965"), "Athletic shoes " },
                    { new Guid("f74f6027-9da6-427a-b67f-6c1599b97cc5"), "High heels" }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Description", "Name", "PoinsMax", "PointsMin" },
                values: new object[,]
                {
                    { new Guid("8677fd75-515e-4a3b-ae01-d020c759fb94"), null, "Kim Cương", 10000000, 3000001 },
                    { new Guid("db68c0e6-e26a-46be-bb6d-e4c5d913f525"), null, "Vàng", 3000000, 1000001 }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE1D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "20d7ec8d-7c61-44aa-8e66-43b4a279d5d0");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE2D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "6efdf826-0757-41fe-bd64-bd4256aae35d");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "02b3d84f-1d0a-4681-80bd-fc2b75351c69");

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("10065a0a-eee1-491a-a2c3-550bee3069b3"), "42" },
                    { new Guid("41f03f67-7faf-42a1-9c0d-0331c7d60511"), "40" },
                    { new Guid("644be8b1-d251-410b-b798-68ddbf583d7b"), "44" },
                    { new Guid("9ea11e75-686b-4a39-a716-1c300718748b"), "38" },
                    { new Guid("bdf12b80-efac-4cba-9809-fe47da2393cd"), "39" },
                    { new Guid("c0676c06-e56d-4612-a5de-818c05320f70"), "41" },
                    { new Guid("d9f18a6e-49fc-4c66-8b73-ed5ba6fd1c0f"), "43" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                columns: new[] { "Coins", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { 0m, "693e6105-2ec9-4abc-a43f-cd4bb825e9bf", "860bc952-5551-4015-b790-ae82c61e7929" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_MaterialId",
                table: "ProductDetails",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_materials_MaterialId",
                table: "ProductDetails",
                column: "MaterialId",
                principalTable: "materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_materials_MaterialId",
                table: "ProductDetails");

            migrationBuilder.DropTable(
                name: "materials");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_MaterialId",
                table: "ProductDetails");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("11a9f3c1-5a28-417b-8377-01eac1940921"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("334ee58a-f2e8-4906-b283-9e8fad33b947"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("3944f266-cb82-4a0e-a984-9ee64ca748b9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("4477a122-ad65-49b3-a0d6-c3fe5cec9b9b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("50047c2b-6411-4e17-8be1-580bb97e8c89"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("5291d3ba-aa96-46c1-8467-1ed915121629"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("658075a3-1f08-4bf9-9fc2-c36733bdfa2d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("66acb55b-51e6-4dc6-affe-2f28eda19d27"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("81978850-930c-470a-9d8d-529eb6825137"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("c188cd0d-8118-4674-a1c2-3188b0b3d5bc"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("c5525d88-b84d-4cdc-ac2c-159408754cf7"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("c9e1dbed-86b8-4ffd-8e27-3683cdbe7f20"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("da16c597-7dea-44cc-a2c3-5b00b564b8da"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("de5c8247-dd7b-42e8-a6ad-09eee9a972ef"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("f3bdd7ff-bb03-44f8-a9b0-afb3de6da096"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("179e627e-123d-4386-af37-b94e403c32b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3883695d-7ace-4ffe-8440-895448b8ec03"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4692ad62-ee3c-4594-837b-4b464eee936d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("627c3aa8-a39a-4643-b33d-3fc9d2d20538"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ff75069-ec96-4dc9-9581-6f5c1b821bcf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7cb0d99a-a9c6-48c6-998a-0fc7082b3324"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d2841de-8dcc-4cc2-84b4-685e8930f251"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6037491-796c-4adc-a60f-5a66a5cb3f73"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca9dc0e1-bc7e-499c-a549-644d4c1ad965"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f74f6027-9da6-427a-b67f-6c1599b97cc5"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("8677fd75-515e-4a3b-ae01-d020c759fb94"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("db68c0e6-e26a-46be-bb6d-e4c5d913f525"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("10065a0a-eee1-491a-a2c3-550bee3069b3"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("41f03f67-7faf-42a1-9c0d-0331c7d60511"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("644be8b1-d251-410b-b798-68ddbf583d7b"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("9ea11e75-686b-4a39-a716-1c300718748b"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("bdf12b80-efac-4cba-9809-fe47da2393cd"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("c0676c06-e56d-4612-a5de-818c05320f70"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("d9f18a6e-49fc-4c66-8b73-ed5ba6fd1c0f"));

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "ProductDetails");

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
                keyValue: "2FA6148D-B530-421F-878E-CE4D54BFC6AB",
                column: "ConcurrencyStamp",
                value: "4f297a4c-0a59-4d97-b8e8-86a41f9f0546");

            migrationBuilder.InsertData(
                schema: "security",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2FA6148D-B530-421F-878E-CE3D54BFC6AB", "70cd26be-1fea-4cbe-a75f-a768b8df28f7", "Guest", "GUEST" });

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
                columns: new[] { "Coins", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "d52a40a1-b2f4-43db-b2c4-bfc42ef63941", "ca6419ac-978e-4be4-b400-75f8467784e3" });
        }
    }
}
