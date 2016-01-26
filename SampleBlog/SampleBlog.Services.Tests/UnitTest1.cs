using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleBlog.ServiceContracts.Contracts;
using SampleBlog.ServiceContracts.Models;

namespace SampleBlog.Services.Tests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void GetUserTest()
    {
      var mockService = new Mock<IMembershipService>();

      mockService.Setup(s => s.GetUser(It.IsAny<int>())).Returns(
        new User
        {
          Email = "Hello@email.com",
          Password = "password"
        });

      var user = mockService.Object.GetUser(1);
      Assert.AreEqual(user.Email, "Hello@email.com");
    }
  }
}
