using SampleBlog.Infrastructure.Mapping;
using SampleBlog.RepositoryContracts.Models;
using SampleBlog.ServiceContracts.Models;

namespace SampleBlog.ServiceContracts.Mappers
{
  public class UserMapper : IMapper<User, UserDto>
  {
    public UserDto Map(User model)
    {
      return new UserDto();
    }

    public User Map(UserDto model)
    {
      return new User();
    }
  }
}