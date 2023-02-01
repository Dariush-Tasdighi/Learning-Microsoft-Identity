//namespace Client.Domain

namespace Domain;

public class User :
	Microsoft.AspNetCore.Identity.IdentityUser<int>
{
	public User() : base()
	{
	}

	[System.ComponentModel.DataAnnotations.MaxLength
		(length: 50)]
	public string? LastName { get; set; }

	[System.ComponentModel.DataAnnotations.MaxLength
		(length: 50)]
	public string? FirstName { get; set; }
}
