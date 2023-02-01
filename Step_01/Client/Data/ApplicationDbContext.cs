namespace Client.Data;

public class ApplicationDbContext :
	Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
{
	public ApplicationDbContext
		(Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext> options)
		: base(options)
	{
	}
}
