using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(args: args);

var connectionString =
	builder.Configuration
		.GetConnectionString(name: "DefaultConnection")
	??
	throw new System.InvalidOperationException
		(message: "Connection string 'DefaultConnection' not found.");

builder.Services
	.AddDbContext<Data.DatabaseContext>
	(optionsAction: options =>
	{
		options.UseSqlServer
			(connectionString: connectionString);
	});

builder.Services
	.AddDatabaseDeveloperPageExceptionFilter();

// **************************************************
// دستور ذیل به دلیل تغییر جنس کلید اولیه کار نمی‌کند
// **************************************************
//builder.Services
//	.AddDefaultIdentity<Microsoft.AspNetCore.Identity.IdentityUser>
//	(configureOptions: options =>
//	{
//		options.SignIn.RequireConfirmedAccount = true;
//	})

//	.AddEntityFrameworkStores
//		<Data.DatabaseContext>();
// **************************************************

// **************************************************
builder.Services
	.AddDefaultIdentity<Microsoft.AspNetCore.Identity.IdentityUser<int>>
	(configureOptions: options =>
	{
		options.SignIn.RequireConfirmedAccount = true;
	})

	.AddEntityFrameworkStores
		<Data.DatabaseContext>();
// **************************************************

// **************************************************
//builder.Services
//	// New
//	.AddDefaultIdentity<Domain.User>
//	(configureOptions: options =>
//	{
//		options.SignIn.RequireConfirmedAccount = true;
//	})

//	// New
//	.AddRoles<Domain.Role>()

//	.AddEntityFrameworkStores
//		<Data.DatabaseContext>();
// **************************************************

builder.Services
	.AddRazorPages();

var app =
	builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
}
else
{
	app.UseExceptionHandler
		(errorHandlingPath: "/Error");

	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
