// **************************************************
using Microsoft.EntityFrameworkCore;

namespace Data;
//namespace Client.Data;

//public class DatabaseContext :
//	Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
//{
//}

//public class DatabaseContext :
//	Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
//	<Microsoft.AspNetCore.Identity.IdentityUser<int>,
//	Microsoft.AspNetCore.Identity.IdentityRole<int>,
//	int>
//{
//}

public class DatabaseContext :
	Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
	<Microsoft.AspNetCore.Identity.IdentityUser<int>,
	Microsoft.AspNetCore.Identity.IdentityRole<int>,
	int>
{
	public DatabaseContext
		(Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext> options)
		: base(options)
	{
	}

	protected override void OnModelCreating
		(Microsoft.EntityFrameworkCore.ModelBuilder builder)
	{
		// باید دقت داشته باشیم که
		// دستور ذیل نباید حذف شود
		base.OnModelCreating(builder: builder);

		// using Microsoft.EntityFrameworkCore;
		builder.HasDefaultSchema(schema: "Identity");

		builder.Entity<Microsoft.AspNetCore.Identity.IdentityUser<int>>
			(buildAction: entity =>
			{
				// using Microsoft.EntityFrameworkCore;
				entity.ToTable(name: "Users");
			});

		builder.Entity<Microsoft.AspNetCore.Identity.IdentityRole<int>>
			(buildAction: entity =>
			{
				entity.ToTable(name: "Roles");
			});

		builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserRole<int>>
			(buildAction: entity =>
			{
				entity.ToTable(name: "UserRoles");
			});

		builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserClaim<int>>
			(buildAction: entity =>
			{
				entity.ToTable(name: "UserClaims");
			});

		builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserLogin<int>>
			(buildAction: entity =>
			{
				entity.ToTable(name: "UserLogins");
			});

		builder.Entity<Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>>
			(buildAction: entity =>
			{
				entity.ToTable(name: "RoleClaims");
			});

		builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserToken<int>>
			(buildAction: entity =>
			{
				entity.ToTable(name: "UserTokens");
			});
	}
}
// **************************************************

// **************************************************
//using Microsoft.EntityFrameworkCore;

//namespace Data;

////public class DatabaseContext :
////	Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
////	<Microsoft.AspNetCore.Identity.IdentityUser<int>,
////	Microsoft.AspNetCore.Identity.IdentityRole<int>,
////	int>
////{
////}

////public class DatabaseContext :
////	Microsoft.AspNetCore.Identity.EntityFrameworkCore
////	.IdentityDbContext<Domain.User, Domain.Role, int>
////{
////}

//public class DatabaseContext :
//	Microsoft.AspNetCore.Identity.EntityFrameworkCore
//	.IdentityDbContext<Domain.User, Domain.Role, int>
//{
//	public DatabaseContext
//		(Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext> options)
//		: base(options)
//	{
//	}

//	protected override void OnModelCreating
//		(Microsoft.EntityFrameworkCore.ModelBuilder builder)
//	{
//		base.OnModelCreating(builder: builder);

//		builder.HasDefaultSchema(schema: "Identity");

//		builder.Entity<Domain.Role>
//			(buildAction: entity =>
//			{
//				entity.ToTable(name: "Roles");
//			});

//		//builder.Entity<Microsoft.AspNetCore.Identity.IdentityRole<int>>
//		//	(buildAction: entity =>
//		//	{
//		//		entity.ToTable(name: "Roles");
//		//	});

//		builder.Entity<Domain.User>
//			(buildAction: entity =>
//			{
//				entity.ToTable(name: "Users");
//			});

//		//builder.Entity<Microsoft.AspNetCore.Identity.IdentityUser<int>>
//		//	(buildAction: entity =>
//		//	{
//		//		entity.ToTable(name: "Users");
//		//	});

//		builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserRole<int>>
//			(buildAction: entity =>
//			{
//				entity.ToTable(name: "UserRoles");
//			});

//		builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserClaim<int>>
//			(buildAction: entity =>
//			{
//				entity.ToTable(name: "UserClaims");
//			});

//		builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserLogin<int>>
//			(buildAction: entity =>
//			{
//				entity.ToTable(name: "UserLogins");
//			});

//		builder.Entity<Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>>
//			(buildAction: entity =>
//			{
//				entity.ToTable(name: "RoleClaims");
//			});

//		builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserToken<int>>
//			(buildAction: entity =>
//			{
//				entity.ToTable(name: "UserTokens");
//			});
//	}
//}
// **************************************************
