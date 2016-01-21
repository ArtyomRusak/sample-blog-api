using SampleBlog.BusinessContracts.Contracts;
using SampleBlog.RepositoryContracts;

namespace SampleBlog.Services.Services
{
  public abstract class BaseService : IService
  {
    protected readonly IRepositoryFactory RepositoryFactory;

    protected BaseService(IRepositoryFactory repositoryFactory)
    {
      this.RepositoryFactory = repositoryFactory;
    }
  }
}