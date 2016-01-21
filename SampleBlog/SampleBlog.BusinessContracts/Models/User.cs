using System;

namespace SampleBlog.BusinessContracts.Models
{
  public class User
  {
    public string Email { get; set; }

    public string Password { get; set; }

    public string UserName { get; set; }

    public DateTime CreateDate { get; set; }
  }
}