namespace Client.Pages;

public class IndexModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public IndexModel
		(Microsoft.Extensions.Logging.ILogger<IndexModel> logger) : base()
	{
		Logger = logger;
	}

	private Microsoft.Extensions.Logging.ILogger<IndexModel> Logger { get; }

	public void OnGet()
	{
	}
}
