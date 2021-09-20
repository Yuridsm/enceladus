using Business.Tests.AnyServiceTests.TestDoubles;
using BusinessServices.Any;
using NUnit.Framework;

namespace Business.Tests.AnyServiceTests
{
    [TestFixture]
    public class AnyTests
    {
        [Test]
        public void IsValid_InvalidPath_ShouldReturnsFalse()
        {
            // Arrange
            DbGatewayDummy gateway = new DbGatewayDummy();
            LoggerDummy logger = new LoggerDummy();
            FileOnMachineSpy fileOnMachine = new FileOnMachineSpy();
            SocketOverNetworkDummy socket = new SocketOverNetworkDummy();

            // Act
            fileOnMachine.SetContent("Yuri Melo");
            var anyService = new AnyServices(gateway, logger, fileOnMachine, socket);
            var result = anyService.WriteOnFile("Here you must pass the pathway of a file", fileOnMachine.Content);
            const bool expected = true;

            // Assert
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
