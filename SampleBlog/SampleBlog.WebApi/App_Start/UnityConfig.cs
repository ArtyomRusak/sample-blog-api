using Microsoft.Practices.Unity;
using System.Web.Http;
using SampleBlog.BusinessContracts.Contracts;
using SampleBlog.BusinessContracts.Models;
using SampleBlog.Infrastructure.Mapping;
using SampleBlog.Repository;
using SampleBlog.RepositoryContracts;
using SampleBlog.Services.Services;
using SampleBlog.WebApi.Mappers;
using SampleBlog.WebApi.Models;
using Unity.WebApi;

namespace SampleBlog.WebApi
{
  public static class UnityConfig
  {
    public static void RegisterComponents()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();

      container.RegisterType<IRepositoryFactory, RepositoryFactory>();
      container.RegisterType<IMembershipService, MembershipService>();
      container.RegisterType<IMapper<UserApiModel, User>, UserMapper>();

      GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
    }
  }
}