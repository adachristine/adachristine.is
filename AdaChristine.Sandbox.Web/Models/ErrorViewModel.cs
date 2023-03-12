namespace AdaChristine.Sandbox.Web.Models;

public class ErrorViewModel
{
    public System.Net.HttpStatusCode? StatusCode { get; set; }
    public string? StatusReason { get; set; }
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
