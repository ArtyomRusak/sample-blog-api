using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using SampleBlog.WebApi.Models;

namespace SampleBlog.WebApi.Controllers
{
  public class PostController : BaseController
  {
    [Route("search/posts")]
    [HttpGet]
    public IHttpActionResult SearchPosts(SearchApiModel model)
    {
      //do search
      return null;
    }

    [Route("post/{slug:int}")]
    [HttpGet]
    public IHttpActionResult GetPost([FromUri] string fields)
    {
      return null;
    }

    [Route("post/{slug:int}/comment")]
    [HttpPost]
    public IHttpActionResult AddPostComment([FromBody] string message)
    {
      return null;
    }
  }
}