using SampleBlog.BusinessContracts.Models;

namespace SampleBlog.BusinessContracts.Contracts
{
  public interface IMembershipService : IService
  {
    bool VerifyUser(int userId);

    User RegisterUser(User user);

    User RegisterUser(string email, string password);

    bool LoginUser(string email, string password);

    bool LogoutUser(string email);

    User GetUser(int userId);
  }
}