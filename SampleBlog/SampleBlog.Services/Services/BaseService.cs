using SampleBlog.RepositoryContracts;
using SampleBlog.ServiceContracts.Contracts;

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