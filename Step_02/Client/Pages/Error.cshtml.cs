namespace Client.Pages;

[Microsoft.AspNetCore.Mvc.IgnoreAntiforgeryToken]

[Microsoft.AspNetCore.Mvc.ResponseCache(Duration = 0,
	Location = Microsoft.AspNetCore.Mvc.ResponseCacheLocation.None, NoStore = true)]
public class ErrorModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public ErrorModel
		(Microsoft.Extensions.Logging.ILogger<ErrorModel> logger) : base()
	{
		Logger = logger;
	}

	public string? RequestId { get; set; }

	public bool ShowRequestId
	{
		get
		{
			var result =
				!string.IsNullOrEmpty(value: RequestId);

			return result;
		}
	}

	private Microsoft.Extensions.Logging.ILogger<ErrorModel> Logger { get; }

	public void OnGet()
	{
		RequestId =
			System.Diagnostics.Activity.Current?.Id
			??
			HttpContext.TraceIdentifier;
	}
}
