using SampleBlog.BusinessContracts.Models;
using SampleBlog.Infrastructure.Mapping;
using SampleBlog.WebApi.Models;

namespace SampleBlog.WebApi.Mappers
{
  internal class UserMapper : IMapper<UserApiModel, User>
  {
    public User Map(UserApiModel model)
    {
      return new User();
    }

    public UserApiModel Map(User model)
    {
      return new UserApiModel();
    }
  }
}