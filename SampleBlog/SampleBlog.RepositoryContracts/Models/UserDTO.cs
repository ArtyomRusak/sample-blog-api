using System;

namespace SampleBlog.RepositoryContracts.Models
{
  public class UserDto : Entity<int>
  {
    public string Email { get; set; }

    public string Password { get; set; }

    public string PasswordSalt { get; set; }

    public string UserName { get; set; }

    public DateTime CreateDate { get; set; }
  }
}