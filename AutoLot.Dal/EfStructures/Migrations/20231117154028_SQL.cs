﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoLot.Dal.EfStructures.Migrations
{
    /// <inheritdoc />
    public partial class SQL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            MigrationHelpers.CreateCustomerOrderView(migrationBuilder);
            MigrationHelpers.CreateSproc(migrationBuilder);
            MigrationHelpers.CreateFunctions(migrationBuilder);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            MigrationHelpers.DropCustomerOrderView(migrationBuilder);
            MigrationHelpers.DropSproc(migrationBuilder);
            MigrationHelpers.DropFunctions(migrationBuilder);
        }
    }
}
