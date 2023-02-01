namespace Client.Pages;

public class PrivacyModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public PrivacyModel
		(Microsoft.Extensions.Logging.ILogger<PrivacyModel> logger) : base()
	{
		Logger = logger;

		//_logger = logger;
	}

	private Microsoft.Extensions.Logging.ILogger<PrivacyModel> Logger { get; }

	//private readonly Microsoft.Extensions.Logging.ILogger<PrivacyModel> _logger;

	public void OnGet()
	{
	}
}
