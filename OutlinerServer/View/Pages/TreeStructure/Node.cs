namespace OutlinerServer.View.Pages.TreeStructure;

public interface INode
{
    public string Id { get; set; }
    public string ParentId { get; set; }
    public void CollapseExpand();
    public void Serialize();
}

public record class Node(string Id, string ParentId, string Title) : INode
{
    public string Id { get; set; } = Id;
    public string ParentId { get; set; } = ParentId;
    public string Title { get; set; } = Title;
    public void CollapseExpand()
    {

    }
    public void Serialize()
    {

    }
}

