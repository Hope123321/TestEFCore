using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using TestEFCore.Controllers;
using TestEFCore.Service.Interfaces;
using TestEFCore.Service.Models;

namespace TestEFCore.Test.Tests
{
    /// <summary>
    /// 測試總部公告控制器
    /// </summary>
    public class TestSysNoticesController
    {
        private ISysNoticesService _SysNoticesService;
        private SysNoticesController _SysNoticesController;

        [SetUp]
        public void Setup()
        {
            _SysNoticesService = Substitute.For<ISysNoticesService>();
            _SysNoticesController = new SysNoticesController(_SysNoticesService);
        }

        [Test]
        public async Task TestGetSysNotices()
        {
            // Arrange
            IEnumerable<SysNotice> sysNotices = new List<SysNotice>
            {
                new SysNotice { NtcNo = 1, Title = "Test1" },
                new SysNotice { NtcNo = 2, Title = "Test2" }
            };
            _SysNoticesService.GetSysNotices().Returns(sysNotices);
            // Act
            var result = await _SysNoticesController.GetSysNotices();

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result, Is.Not.Null);
            Assert.IsTrue(result.Result is OkObjectResult);
            Assert.AreEqual(2, ((IEnumerable<SysNotice>?)((OkObjectResult)result.Result)?.Value)?.Count() ?? 0);
        }
        [Test]
        public async Task TestGetSysNotice()
        {
            // Arrange
            SysNotice sysNotice = new SysNotice { NtcNo = 1, Title = "Test1" };
            _SysNoticesService.GetSysNotice(1).Returns(sysNotice);
            // Act
            var result = await _SysNoticesController.GetSysNotice(1);
            // Assert
            Assert.IsNotNull(result);
            Assert.That(result, Is.Not.Null);
            Assert.IsTrue(result.Result is OkObjectResult);
            Assert.AreEqual("Test1", ((SysNotice)((OkObjectResult)result.Result).Value)?.Title ?? "");
        }
        [Test]
        public async Task TestPutSysNotice()
        {
            // Arrange
            SysNotice sysNotice = new SysNotice { NtcNo = 1, Title = "Test1" };
            _SysNoticesService.PutSysNotice(1, sysNotice).Returns(true);
            // Act
            var result = await _SysNoticesController.PutSysNotice(1, sysNotice);
            // Assert
            Assert.IsTrue(result is OkObjectResult);
        }
        [Test]
        public async Task TestPostSysNotice()
        {
            // Arrange
            SysNotice sysNotice = new SysNotice { NtcNo = 1, Title = "Test1" };
            _SysNoticesService.PostSysNotice(sysNotice).Returns(sysNotice);
            // Act
            var result = await _SysNoticesController.PostSysNotice(sysNotice);
            // Assert
            Assert.IsNotNull(result);
            Assert.That(result, Is.Not.Null);
            Assert.IsTrue(result.Result is OkObjectResult);
            Assert.AreEqual("Test1", ((SysNotice)((OkObjectResult)result.Result).Value)?.Title ?? "");
        }
        [Test]
        public async Task TestDeleteSysNotice()
        {
            // Arrange
            _SysNoticesService.DeleteSysNotice(1).Returns(true);
            // Act
            var result = await _SysNoticesController.DeleteSysNotice(1);
            // Assert
            Assert.IsTrue(result is OkObjectResult);
        }
        [Test]
        public async Task TestGetSysNoticesNull()
        {
            // Arrange
            _SysNoticesService.GetSysNotices().Returns((IEnumerable<SysNotice>)null);
            // Act
            var result = await _SysNoticesController.GetSysNotices();
            // Assert
            Assert.IsTrue(result.Result is OkObjectResult);
        }
        [Test]
        public async Task TestGetSysNoticeNull()
        {
            // Arrange
            _SysNoticesService.GetSysNotice(1).Returns((SysNotice)null);
            // Act
            var result = await _SysNoticesController.GetSysNotice(1);
            // Assert
            Assert.IsTrue(result.Result is OkObjectResult);
        }
    }
}