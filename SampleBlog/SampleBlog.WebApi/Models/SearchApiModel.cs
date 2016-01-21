using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleBlog.WebApi.Models
{
  public class SearchApiModel
  {
    public string Q { get; set; }

    public string Page { get; set; }
  }
}