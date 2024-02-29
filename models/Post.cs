public class Post
{
    public int PostId {get; set;}
    public int BoardId {get; set;}
    public string? Writer {get; set;}
    public string? PostTitle {get; set;}
    public string? PostContext {get; set;}
    public System.DateTime? PostDate {get; set;}
    public int? PostModify {get; set;}
    public int? ReadCount {get; set;}
    public int? PostRecommand {get; set;}
}