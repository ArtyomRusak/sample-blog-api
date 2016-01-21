using SampleBlog.Repository.Repositories;
using SampleBlog.RepositoryContracts;
using SampleBlog.RepositoryContracts.Contracts;

namespace SampleBlog.Repository
{
  public class RepositoryFactory : IRepositoryFactory
  {
    public IMembershipRepository GetMembershipRepository()
    {
      return new MembershipRepository();
    }
  }
}