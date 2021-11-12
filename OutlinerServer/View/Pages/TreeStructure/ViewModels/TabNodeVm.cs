namespace OutlinerServer.View.Pages.TreeStructure.ViewModels;

public record TabNodeVm(string? Id, string? ParentId, string Title, string Url, string FaviconUrl, string WindoUrl) {
    public string Id { get; set; } = Id;
    public string? ParentId { get; set; }= ParentId;
    public string Title { get; set; } = Title;
    public string Url { get; set; } = Url;
    public string FaviconUrl { get; set; } = FaviconUrl;
    public string WindowId { get; set; } = WindoUrl;
}


