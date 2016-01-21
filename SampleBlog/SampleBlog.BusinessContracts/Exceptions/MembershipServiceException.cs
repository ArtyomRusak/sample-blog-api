using System;

namespace SampleBlog.BusinessContracts.Exceptions
{
  public class MembershipServiceException : Exception
  {
    public MembershipServiceException()
    {
    }

    public MembershipServiceException(string message)
      : base(message)
    {
    }

    public MembershipServiceException(string message, Exception innerException)
      : base(message, innerException)
    {
    }
  }
}