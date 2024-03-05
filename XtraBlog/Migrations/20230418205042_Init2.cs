using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XtraBlog.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_TagPost_Posts_PostID",
                table: "TagPost");

            migrationBuilder.DropForeignKey(
                name: "FK_TagPost_Tags_TagsId",
                table: "TagPost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagPost",
                table: "TagPost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameTable(
                name: "TagPost",
                newName: "TagPosts");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_TagPost_TagsId",
                table: "TagPosts",
                newName: "IX_TagPosts_TagsId");

            migrationBuilder.RenameIndex(
                name: "IX_TagPost_PostID",
                table: "TagPosts",
                newName: "IX_TagPosts_PostID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostID",
                table: "Comment",
                newName: "IX_Comment_PostID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagPosts",
                table: "TagPosts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Posts_PostID",
                table: "Comment",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagPosts_Posts_PostID",
                table: "TagPosts",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagPosts_Tag_TagsId",
                table: "TagPosts",
                column: "TagsId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Posts_PostID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_TagPosts_Posts_PostID",
                table: "TagPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_TagPosts_Tag_TagsId",
                table: "TagPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagPosts",
                table: "TagPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "TagPosts",
                newName: "TagPost");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_TagPosts_TagsId",
                table: "TagPost",
                newName: "IX_TagPost_TagsId");

            migrationBuilder.RenameIndex(
                name: "IX_TagPosts_PostID",
                table: "TagPost",
                newName: "IX_TagPost_PostID");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PostID",
                table: "Comments",
                newName: "IX_Comments_PostID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagPost",
                table: "TagPost",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostID",
                table: "Comments",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagPost_Posts_PostID",
                table: "TagPost",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagPost_Tags_TagsId",
                table: "TagPost",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
