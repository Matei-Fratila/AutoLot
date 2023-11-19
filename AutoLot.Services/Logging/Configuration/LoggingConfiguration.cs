﻿namespace AutoLot.Services.Logging.Configuration;
public static class LoggingConfiguration
{
    internal static readonly string OutputTemplate = @"[{Timestamp:yy-MM-dd HH:mm:ss} {Level}]{ApplicationName}:{SourceContext}{NewLine}Message:{Message}{NewLine}in method {MemberName} at {FilePath}:{LineNumber}{NewLine}{Exception}{NewLine}";
    internal static readonly ColumnOptions ColumnOptions = new ColumnOptions
    {
        AdditionalColumns = new List<SqlColumn>
        {
            new SqlColumn {DataType = SqlDbType.VarChar, ColumnName = "ApplicationName"},
            new SqlColumn {DataType = SqlDbType.VarChar, ColumnName = "MachineName"},
            new SqlColumn {DataType = SqlDbType.VarChar, ColumnName = "MemberName"},
            new SqlColumn {DataType = SqlDbType.VarChar, ColumnName = "FilePath"},
            new SqlColumn {DataType = SqlDbType.Int, ColumnName = "LineNumber"},
            new SqlColumn {DataType = SqlDbType.VarChar, ColumnName = "SourceContext"},
            new SqlColumn {DataType = SqlDbType.VarChar, ColumnName = "RequestPath"},
            new SqlColumn {DataType = SqlDbType.VarChar, ColumnName = "ActionName"},
        }
    };

    public static IServiceCollection RegisterLoggingInterfaces(this IServiceCollection services)
    {
        services.AddScoped(typeof(IAppLogging<>), typeof(AppLogging<>));
        return services;
    }

    public static void ConfigureSerilog(this WebApplicationBuilder builder)
    {
        builder.Logging.ClearProviders();
        var config = builder.Configuration;
        var settings = config.GetSection(nameof(AppLoggingSettings)).Get<AppLoggingSettings>();
        var connectionStringName = settings.MSSqlServer.ConnectionStringName;
        var connectionString = config.GetConnectionString(connectionStringName);
        var tableName = settings.MSSqlServer.TableName;
        var schema = settings.MSSqlServer.Schema;
        string restrictedToMinimumLevel = settings.General.RestrictedToMinimumLevel;

        if (!Enum.TryParse<LogEventLevel>(restrictedToMinimumLevel, out var logLevel))
        {
            logLevel = LogEventLevel.Debug;
        }

        var sqlOptions = new MSSqlServerSinkOptions
        {
            AutoCreateSqlTable = true,
            SchemaName = schema,
            TableName = tableName,
        };

        if (builder.Environment.IsDevelopment())
        {
            sqlOptions.BatchPeriod = new TimeSpan(0, 0, 0, 1);
            sqlOptions.BatchPostingLimit = 1;
        }

        var log = new LoggerConfiguration()
            .MinimumLevel.Is(logLevel)
            .Enrich.FromLogContext()
            .Enrich.With(new PropertyEnricher("ApplicationName", config.GetValue<string>("ApplicationName")))
            .Enrich.WithMachineName()
            .WriteTo.File(
                path: builder.Environment.IsDevelopment() ? settings.File.FileName : settings.File.FullLogPathAndFileName,
                rollingInterval: RollingInterval.Day,
                restrictedToMinimumLevel: logLevel,
                outputTemplate: OutputTemplate)
            .WriteTo.Console(restrictedToMinimumLevel: logLevel)
            .WriteTo.MSSqlServer(
                connectionString: connectionString,
                sqlOptions,
                restrictedToMinimumLevel: logLevel,
                columnOptions: ColumnOptions);

        builder.Logging.AddSerilog(log.CreateLogger(), false);
    }

}
