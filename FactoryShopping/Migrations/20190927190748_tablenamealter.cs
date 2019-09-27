using Microsoft.EntityFrameworkCore.Migrations;

namespace FactoryShopping.Migrations
{
    public partial class tablenamealter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addresses_addressType_AddressTypeID",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_addresses_Users_UserId",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_cart_Products_PId",
                table: "cart");

            migrationBuilder.DropForeignKey(
                name: "FK_cart_Users_UserId",
                table: "cart");

            migrationBuilder.DropForeignKey(
                name: "FK_feedback_Products_PId",
                table: "feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_feedback_Users_UserId",
                table: "feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_wishlist_Products_PId",
                table: "wishlist");

            migrationBuilder.DropForeignKey(
                name: "FK_wishlist_Users_UserId",
                table: "wishlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_feedback",
                table: "feedback");

            migrationBuilder.DropPrimaryKey(
                name: "PK_addresses",
                table: "addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_wishlist",
                table: "wishlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cart",
                table: "cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_addressType",
                table: "addressType");

            migrationBuilder.RenameTable(
                name: "feedback",
                newName: "Feedback");

            migrationBuilder.RenameTable(
                name: "addresses",
                newName: "Addresses");

            migrationBuilder.RenameTable(
                name: "wishlist",
                newName: "Wishlists");

            migrationBuilder.RenameTable(
                name: "cart",
                newName: "Carts");

            migrationBuilder.RenameTable(
                name: "addressType",
                newName: "AddressTypes");

            migrationBuilder.RenameIndex(
                name: "IX_feedback_UserId",
                table: "Feedback",
                newName: "IX_Feedback_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_feedback_PId",
                table: "Feedback",
                newName: "IX_Feedback_PId");

            migrationBuilder.RenameIndex(
                name: "IX_addresses_UserId",
                table: "Addresses",
                newName: "IX_Addresses_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_addresses_AddressTypeID",
                table: "Addresses",
                newName: "IX_Addresses_AddressTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_wishlist_UserId",
                table: "Wishlists",
                newName: "IX_Wishlists_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_wishlist_PId",
                table: "Wishlists",
                newName: "IX_Wishlists_PId");

            migrationBuilder.RenameIndex(
                name: "IX_cart_UserId",
                table: "Carts",
                newName: "IX_Carts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_cart_PId",
                table: "Carts",
                newName: "IX_Carts_PId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feedback",
                table: "Feedback",
                column: "FeedbackId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wishlists",
                table: "Wishlists",
                column: "WishId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "CartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressTypes",
                table: "AddressTypes",
                column: "AddressTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AddressTypes_AddressTypeID",
                table: "Addresses",
                column: "AddressTypeID",
                principalTable: "AddressTypes",
                principalColumn: "AddressTypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Products_PId",
                table: "Carts",
                column: "PId",
                principalTable: "Products",
                principalColumn: "PId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Products_PId",
                table: "Feedback",
                column: "PId",
                principalTable: "Products",
                principalColumn: "PId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Users_UserId",
                table: "Feedback",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlists_Products_PId",
                table: "Wishlists",
                column: "PId",
                principalTable: "Products",
                principalColumn: "PId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlists_Users_UserId",
                table: "Wishlists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AddressTypes_AddressTypeID",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Products_PId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Products_PId",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Users_UserId",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlists_Products_PId",
                table: "Wishlists");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlists_Users_UserId",
                table: "Wishlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feedback",
                table: "Feedback");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wishlists",
                table: "Wishlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressTypes",
                table: "AddressTypes");

            migrationBuilder.RenameTable(
                name: "Feedback",
                newName: "feedback");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "addresses");

            migrationBuilder.RenameTable(
                name: "Wishlists",
                newName: "wishlist");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "cart");

            migrationBuilder.RenameTable(
                name: "AddressTypes",
                newName: "addressType");

            migrationBuilder.RenameIndex(
                name: "IX_Feedback_UserId",
                table: "feedback",
                newName: "IX_feedback_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedback_PId",
                table: "feedback",
                newName: "IX_feedback_PId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_UserId",
                table: "addresses",
                newName: "IX_addresses_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_AddressTypeID",
                table: "addresses",
                newName: "IX_addresses_AddressTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Wishlists_UserId",
                table: "wishlist",
                newName: "IX_wishlist_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Wishlists_PId",
                table: "wishlist",
                newName: "IX_wishlist_PId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_UserId",
                table: "cart",
                newName: "IX_cart_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_PId",
                table: "cart",
                newName: "IX_cart_PId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_feedback",
                table: "feedback",
                column: "FeedbackId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_addresses",
                table: "addresses",
                column: "AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_wishlist",
                table: "wishlist",
                column: "WishId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cart",
                table: "cart",
                column: "CartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_addressType",
                table: "addressType",
                column: "AddressTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_addressType_AddressTypeID",
                table: "addresses",
                column: "AddressTypeID",
                principalTable: "addressType",
                principalColumn: "AddressTypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_Users_UserId",
                table: "addresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cart_Products_PId",
                table: "cart",
                column: "PId",
                principalTable: "Products",
                principalColumn: "PId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cart_Users_UserId",
                table: "cart",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_feedback_Products_PId",
                table: "feedback",
                column: "PId",
                principalTable: "Products",
                principalColumn: "PId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_feedback_Users_UserId",
                table: "feedback",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wishlist_Products_PId",
                table: "wishlist",
                column: "PId",
                principalTable: "Products",
                principalColumn: "PId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wishlist_Users_UserId",
                table: "wishlist",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
