namespace OutlinerServer.Models.Tab;
using System.ComponentModel.DataAnnotations;

public record TabNodeDto() {
    [Key]
    public int PrimaryId { get; set; }
    public string Id { get; set; }
    public string openerTabId { get; set; } 
    public string Title { get; set; }
    public string Url { get; set; }
    public string FaviconUrl { get; set; }
    public string WindowId { get; set; }
}


