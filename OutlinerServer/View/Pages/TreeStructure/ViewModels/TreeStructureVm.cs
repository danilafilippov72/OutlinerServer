using System.Collections.Generic;

namespace OutlinerServer.View.Pages.TreeStructure.ViewModels;


public record class TreeStructureVm(TabNodeVm? TabDto) : TabNodeVm(TabDto?.Id ?? "IntialTabNode", TabDto?.ParentId ?? "", TabDto?.Title ?? "InitialTabNode", TabDto?.Url ?? "", TabDto?.FaviconUrl ?? "", TabDto?.WindowId ?? "")
{
    public List<TreeStructureVm> ChildrenTabVms { get; set; } = new List<TreeStructureVm>();
    
}


