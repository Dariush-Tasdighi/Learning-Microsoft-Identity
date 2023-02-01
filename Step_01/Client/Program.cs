using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(args: args);

var connectionString =
	// using Microsoft.Extensions.Configuration;
	builder.Configuration
		.GetConnectionString(name: "DefaultConnection")
	??
	throw new System.InvalidOperationException
		(message: "Connection string 'DefaultConnection' not found.");

builder.Services
	// using Microsoft.Extensions.DependencyInjection;
	.AddDbContext<Client.Data.ApplicationDbContext>
	(optionsAction: options =>
	{
		// using Microsoft.EntityFrameworkCore;
		options.UseSqlServer
			(connectionString: connectionString);
	});

// using Microsoft.Extensions.DependencyInjection;
builder.Services
	.AddDatabaseDeveloperPageExceptionFilter();

// using Microsoft.Extensions.DependencyInjection;
builder.Services
	.AddDefaultIdentity<Microsoft.AspNetCore.Identity.IdentityUser>
	(configureOptions: options =>
	{
		options.SignIn.RequireConfirmedAccount = true;
	})

	.AddEntityFrameworkStores
		<Client.Data.ApplicationDbContext>();

// using Microsoft.Extensions.DependencyInjection;
builder.Services
	.AddRazorPages();

var app =
	builder.Build();

// using Microsoft.Extensions.Hosting;
if (app.Environment.IsDevelopment())
{
	// using Microsoft.AspNetCore.Builder;
	app.UseMigrationsEndPoint();
}
else
{
	// using Microsoft.AspNetCore.Builder;
	app.UseExceptionHandler
		(errorHandlingPath: "/Error");

	// using Microsoft.AspNetCore.Builder;
	app.UseHsts();
}

// using Microsoft.AspNetCore.Builder;
app.UseHttpsRedirection();

// using Microsoft.AspNetCore.Builder;
app.UseStaticFiles();

// using Microsoft.AspNetCore.Builder;
app.UseRouting();

// using Microsoft.AspNetCore.Builder;
app.UseAuthorization();

// using Microsoft.AspNetCore.Builder;
app.MapRazorPages();

app.Run();
