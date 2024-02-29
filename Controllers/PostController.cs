using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{
    public PostController()
    {
    }

    [HttpGet]
    public ActionResult<List<Post>> GetAll() =>
        PostService.GetAll();
}