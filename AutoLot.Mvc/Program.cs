var builder = WebApplication.CreateBuilder(args);

//Configure logging
builder.ConfigureSerilog();
builder.Services.RegisterLoggingInterfaces();

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("AutoLot");
builder.Services.AddSqlServer<ApplicationDbContext>(connectionString, options =>
{
    options.EnableRetryOnFailure().CommandTimeout(60);
});

builder.Services.AddRepositories();
builder.Services.Configure<DealerInfo>(builder.Configuration.GetSection(nameof(DealerInfo)));
builder.Services.ConfigureApiServiceWrapper(builder.Configuration);
builder.Services.AddDataServices(builder.Configuration);

//needed to create custom tag helpers
builder.Services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddWebOptimizer(false, false);
    //builder.Services.AddWebOptimizer(options =>
    //{
    //    options.MinifyCssFiles("AutoLot.Mvc.styles.css");
    //    options.MinifyCssFiles("css/site.css");
    //    options.MinifyJsFiles("js/site.js");
    //});
}
else
{
    builder.Services.AddWebOptimizer(options =>
    {
        options.MinifyCssFiles("AutoLot.Mvc.styles.css");
        options.MinifyCssFiles("css/site.css");
        options.MinifyJsFiles("js/site.js");
        options.AddJavaScriptBundle("js/validationCode.js",
            "js/validations/validators.js", "js/validations/errorFormatting.js");
    });
}

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    // This lambda determines whether user consent for non-essential cookies is
    // needed for a given request.
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});

// The TempData provider cookie is not essential. Make it essential
// so TempData is functional when tracking is disabled.
builder.Services.Configure<CookieTempDataProviderOptions>(options => { options.Cookie.IsEssential = true; });
builder.Services.AddSession(options => { options.Cookie.IsEssential = true; });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //Initialize the database
    if (app.Configuration.GetValue<bool>("RebuildDatabase"))
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        SampleDataInitializer.ClearAndReseedDatabase(dbContext);
    }
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//for bundling and minification
app.UseWebOptimizer();

app.UseStaticFiles();

app.UseCookiePolicy();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.MapControllerRoute(
    name: "AdminArea",
    pattern: "{area=Admin}/{controller=Home}/{action=Index}/{id?}");

app.Run();
