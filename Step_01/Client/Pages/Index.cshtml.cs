namespace Client.Pages;

public class IndexModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public IndexModel
		(Microsoft.Extensions.Logging.ILogger<IndexModel> logger) : base()
	{
		Logger = logger;

		//_logger = logger;
	}

	private Microsoft.Extensions.Logging.ILogger<IndexModel> Logger { get; }

	//private readonly Microsoft.Extensions.Logging.ILogger<IndexModel> _logger;

	public void OnGet()
	{
	}
}
