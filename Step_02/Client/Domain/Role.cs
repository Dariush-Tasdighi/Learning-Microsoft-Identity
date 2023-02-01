namespace Domain;

public class Role :
	Microsoft.AspNetCore.Identity.IdentityRole<int>
{
	public Role() : base()
	{
	}

	public bool IsActive { get; set; }
}
