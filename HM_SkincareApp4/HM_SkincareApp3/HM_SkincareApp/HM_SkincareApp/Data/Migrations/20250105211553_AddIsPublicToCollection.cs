﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HM_SkincareApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsPublicToCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Collections",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Collections");
        }
    }
}
