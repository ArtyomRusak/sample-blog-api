using SampleBlog.BusinessContracts.Contracts;
using SampleBlog.BusinessContracts.Models;
using SampleBlog.RepositoryContracts;

namespace SampleBlog.Services.Services
{
  public class MembershipService : BaseService, IMembershipService
  {
    public MembershipService(IRepositoryFactory repositoryFactory)
      : base(repositoryFactory)
    {
    }

    public bool VerifyUser(int userId)
    {
      throw new System.NotImplementedException();
    }

    public User RegisterUser(User user)
    {
      throw new System.NotImplementedException();
    }

    public User RegisterUser(string email, string password)
    {
      throw new System.NotImplementedException();
    }

    public bool LoginUser(string email, string password)
    {
      throw new System.NotImplementedException();
    }

    public User GetUser(int userId)
    {
      throw new System.NotImplementedException();
    }
  }
}