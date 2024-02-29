public static class PostService
{
    static List<Post> Posts {get;}
    static PostService()
    {
        PostManager postManager = new PostManager();
        Posts = postManager.selectQry("SELECT * From post");
    }

    public static List<Post> GetAll() => Posts;
    public static Post? Get(int postId) => Posts.FirstOrDefault(p => p.PostId == postId);
    
}