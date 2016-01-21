namespace SampleBlog.Infrastructure.Security
{
    public class PasswordHasher : IPasswordHasher
    {
      public string Hash(string password, string passwordSalt)
      {
        //hash our password
        return string.Empty;
      }
    }
}