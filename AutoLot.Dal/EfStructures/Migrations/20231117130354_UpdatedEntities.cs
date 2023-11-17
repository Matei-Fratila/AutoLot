using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoLot.Dal.EfStructures.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Make_Inventory",
                table: "Inventory");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.EnsureSchema(
                name: "Logging");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Orders",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Makes",
                newName: "Makes",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Inventory",
                newName: "Inventory",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customers",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CreditRisks",
                newName: "CreditRisks",
                newSchema: "dbo");

            migrationBuilder.AlterTable(
                name: "Orders",
                schema: "dbo")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterTable(
                name: "Makes",
                schema: "dbo")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "MakesAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<byte[]>(
                name: "TimeStamp",
                schema: "dbo",
                table: "Orders",
                type: "rowversion",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "rowversion",
                oldRowVersion: true,
                oldNullable: true)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                schema: "dbo",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                schema: "dbo",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "dbo",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidFrom",
                schema: "dbo",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidTo",
                schema: "dbo",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<byte[]>(
                name: "TimeStamp",
                schema: "dbo",
                table: "Makes",
                type: "rowversion",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "rowversion",
                oldRowVersion: true,
                oldNullable: true)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "MakesAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Makes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "MakesAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "dbo",
                table: "Makes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "MakesAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidFrom",
                schema: "dbo",
                table: "Makes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "MakesAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidTo",
                schema: "dbo",
                table: "Makes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "MakesAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateBuilt",
                schema: "dbo",
                table: "Inventory",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<bool>(
                name: "IsDrivable",
                schema: "dbo",
                table: "Inventory",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                schema: "dbo",
                table: "Inventory",
                type: "decimal(18,2)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Display",
                schema: "dbo",
                table: "Inventory",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                computedColumnSql: "[PetName] + ' (' + [Color] + ')'",
                stored: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                schema: "dbo",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                computedColumnSql: "[LastName] + ', ' + [FirstName]");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                schema: "dbo",
                table: "CreditRisks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                computedColumnSql: "[LastName] + ', ' + [FirstName]");

            migrationBuilder.CreateTable(
                name: "Drivers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, computedColumnSql: "[LastName] + ', ' + [FirstName]"),
                    TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Radios",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "RadiosAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom"),
                    HasTweeters = table.Column<bool>(type: "bit", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "RadiosAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom"),
                    HasSubWoofers = table.Column<bool>(type: "bit", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "RadiosAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom"),
                    RadioId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "RadiosAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom"),
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "RadiosAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom"),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "RadiosAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom"),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "RadiosAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom"),
                    TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "RadiosAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Radios_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalSchema: "dbo",
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "RadiosAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.CreateTable(
                name: "SeriLogs",
                schema: "Logging",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MessageTemplate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Level = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Exception = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Properties = table.Column<string>(type: "Xml", maxLength: 50, nullable: true),
                    LogEvent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SourceContext = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequestPath = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ApplicationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MachineName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MemberName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LineNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryToDrivers",
                schema: "dbo",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "InventoryToDriversAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom"),
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "InventoryToDriversAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom"),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "InventoryToDriversAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom"),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "InventoryToDriversAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom"),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "InventoryToDriversAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom"),
                    TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "InventoryToDriversAudit")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryToDrivers", x => new { x.InventoryId, x.DriverId });
                    table.ForeignKey(
                        name: "FK_InventoryDriver_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalSchema: "dbo",
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryDriver_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalSchema: "dbo",
                        principalTable: "Inventory",
                        principalColumn: "Id");
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryToDriversAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryToDrivers_DriverId",
                schema: "dbo",
                table: "InventoryToDrivers",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Radios_CarId",
                schema: "dbo",
                table: "Radios",
                column: "InventoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Makes_MakeId",
                schema: "dbo",
                table: "Inventory",
                column: "MakeId",
                principalSchema: "dbo",
                principalTable: "Makes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Makes_MakeId",
                schema: "dbo",
                table: "Inventory");

            migrationBuilder.DropTable(
                name: "InventoryToDrivers",
                schema: "dbo")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "InventoryToDriversAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.DropTable(
                name: "Radios",
                schema: "dbo")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "RadiosAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.DropTable(
                name: "SeriLogs",
                schema: "Logging");

            migrationBuilder.DropTable(
                name: "Drivers",
                schema: "dbo");

            migrationBuilder.DropColumn(
                name: "Display",
                schema: "dbo",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "FullName",
                schema: "dbo",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FullName",
                schema: "dbo",
                table: "CreditRisks");

            migrationBuilder.DropColumn(
                name: "ValidFrom",
                schema: "dbo",
                table: "Orders")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.DropColumn(
                name: "ValidTo",
                schema: "dbo",
                table: "Orders")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.DropColumn(
                name: "ValidFrom",
                schema: "dbo",
                table: "Makes")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "MakesAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.DropColumn(
                name: "ValidTo",
                schema: "dbo",
                table: "Makes")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "MakesAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.DropColumn(
                name: "DateBuilt",
                schema: "dbo",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "IsDrivable",
                schema: "dbo",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "Price",
                schema: "dbo",
                table: "Inventory");

            migrationBuilder.RenameTable(
                name: "Orders",
                schema: "dbo",
                newName: "Orders")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo");

            migrationBuilder.RenameTable(
                name: "Makes",
                schema: "dbo",
                newName: "Makes")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "MakesAudit")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "dbo");

            migrationBuilder.RenameTable(
                name: "Inventory",
                schema: "dbo",
                newName: "Inventory");

            migrationBuilder.RenameTable(
                name: "Customers",
                schema: "dbo",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "CreditRisks",
                schema: "dbo",
                newName: "CreditRisks");

            migrationBuilder.AlterTable(
                name: "Orders")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterTable(
                name: "Makes")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "MakesAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<byte[]>(
                name: "TimeStamp",
                table: "Orders",
                type: "rowversion",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "rowversion",
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "OrdersAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<byte[]>(
                name: "TimeStamp",
                table: "Makes",
                type: "rowversion",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "rowversion",
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "MakesAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "MakesAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Makes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "MakesAudit")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "dbo")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "ValidTo")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "ValidFrom");

            migrationBuilder.AddForeignKey(
                name: "FK_Make_Inventory",
                table: "Inventory",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id");
        }
    }
}
