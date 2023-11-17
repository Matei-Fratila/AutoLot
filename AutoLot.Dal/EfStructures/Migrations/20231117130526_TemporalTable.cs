using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoLot.Dal.EfStructures.Migrations
{
    /// <inheritdoc />
    public partial class TemporalTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Inventory",
                schema: "dbo")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<byte[]>(
                name: "TimeStamp",
                schema: "dbo",
                table: "Inventory",
                type: "rowversion",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "rowversion",
                oldRowVersion: true,
                oldNullable: true)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                schema: "dbo",
                table: "Inventory",
                type: "decimal(18,2)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<string>(
                name: "PetName",
                schema: "dbo",
                table: "Inventory",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                schema: "dbo",
                table: "Inventory",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDrivable",
                schema: "dbo",
                table: "Inventory",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBuilt",
                schema: "dbo",
                table: "Inventory",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getdate()")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                schema: "dbo",
                table: "Inventory",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "dbo",
                table: "Inventory",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidFrom",
                schema: "dbo",
                table: "Inventory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidTo",
                schema: "dbo",
                table: "Inventory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<string>(
                name: "Display",
                schema: "dbo",
                table: "Inventory",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                computedColumnSql: "[PetName] + ' (' + [Color] + ')'",
                stored: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComputedColumnSql: "[PetName] + ' (' + [Color] + ')'",
                oldStored: true)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValidFrom",
                schema: "dbo",
                table: "Inventory")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.DropColumn(
                name: "ValidTo",
                schema: "dbo",
                table: "Inventory")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterTable(
                name: "Inventory",
                schema: "dbo")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<byte[]>(
                name: "TimeStamp",
                schema: "dbo",
                table: "Inventory",
                type: "rowversion",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "rowversion",
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                schema: "dbo",
                table: "Inventory",
                type: "decimal(18,2)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 50,
                oldNullable: true)
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<string>(
                name: "PetName",
                schema: "dbo",
                table: "Inventory",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                schema: "dbo",
                table: "Inventory",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDrivable",
                schema: "dbo",
                table: "Inventory",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true)
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBuilt",
                schema: "dbo",
                table: "Inventory",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getdate()")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                schema: "dbo",
                table: "Inventory",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "dbo",
                table: "Inventory",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<string>(
                name: "Display",
                schema: "dbo",
                table: "Inventory",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                computedColumnSql: "[PetName] + ' (' + [Color] + ')'",
                stored: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComputedColumnSql: "[PetName] + ' (' + [Color] + ')'",
                oldStored: true)
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "InventoryAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");
        }
    }
}
