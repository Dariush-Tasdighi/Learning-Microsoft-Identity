namespace Client.Pages;

public class PrivacyModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public PrivacyModel
		(Microsoft.Extensions.Logging.ILogger<PrivacyModel> logger) : base()
	{
		Logger = logger;
	}

	private Microsoft.Extensions.Logging.ILogger<PrivacyModel> Logger { get; }

	public void OnGet()
	{
	}
}
