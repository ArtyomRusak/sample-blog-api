using SampleBlog.RepositoryContracts.Models;

namespace SampleBlog.RepositoryContracts.Contracts
{
  public interface IBaseRepository<TModel, TKeyType> : IRepository
    where TModel : Entity
    where TKeyType : struct
  {
    TModel CreateEntity(TModel model);

    void UpdateEntity(TModel model);

    void DeleteEntity(TKeyType id);

    TModel GetEntityById(TKeyType id);
  }
}