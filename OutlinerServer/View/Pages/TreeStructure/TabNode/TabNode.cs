using Newtonsoft.Json;
using OutlinerServer.Models.Tab;

namespace OutlinerServer.View.Pages.TreeStructure.TabNode;
public record class TabNode(TabNodeDto Tab) : Node(Tab.Id, Tab.Url, Tab.Title)
{
    public string Url { get; } = Tab.Url;
    public string FaviconUrl { get; set; } = Tab.FaviconUrl;
    public string WindowUrl { get; set; } = Tab.WindowId;
    //public List<TabDto> children { get; set; }
    //public TabNode(TabDto tab) => (Id, ParentId, Title, Url, FaviconUrl, WindowId) = (tab.Id, tab.ParentId, tab.Title, tab.Url, tab.FaviconUrl, tab.WindowId);
    public void CollapseExpand()
    {

    }
    public string Serialize() => JsonConvert.SerializeObject(this);
}