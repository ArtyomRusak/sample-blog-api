using System;
using SampleBlog.RepositoryContracts.Contracts;
using SampleBlog.RepositoryContracts.Exceptions;
using SampleBlog.RepositoryContracts.Models;

namespace SampleBlog.Repository.Repositories
{
  public abstract class Repository<TModel, TKeyType> : IBaseRepository<TModel, TKeyType>
    where TModel : Entity, new()
    where TKeyType : struct
  {
    public TModel CreateEntity(TModel model)
    {
      try
      {
        //base adding
        return null;
      }
      catch (Exception e)
      {
        throw new UserException(string.Empty, e);
      }

      return null;
    }

    public void UpdateEntity(TModel model)
    {
      try
      {
        //base updating
      }
      catch (Exception e)
      {
        throw new UserException(string.Empty, e);
      }
    }

    public void DeleteEntity(TKeyType id)
    {
      try
      {
        //base deleting
      }
      catch (Exception e)
      {
        throw new UserException(string.Empty, e);
      }
    }

    public TModel GetEntityById(TKeyType id)
    {
      try
      {
        //base getting
        return null;
      }
      catch (Exception e)
      {
        throw new UserException(string.Empty, e);
      }

      return null;
    }
  }
}