using SampleBlog.RepositoryContracts.Contracts;
using SampleBlog.RepositoryContracts.Models;

namespace SampleBlog.Repository.Repositories
{
  public class MembershipRepository : Repository<UserDto, int>, IMembershipRepository
  {
  }
}