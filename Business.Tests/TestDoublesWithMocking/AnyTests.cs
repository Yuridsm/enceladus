using BusinessContracts.DbGateway;
using BusinessContracts.FileOnMachine;
using BusinessContracts.Logger;
using BusinessContracts.Socket;
using BusinessServices.Any;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Tests.TestDoublesWithMocking
{
    [TestFixture]
    public class AnyTests
    {
        [Test]
        public void IsValid_InvalidPath_ShouldReturnsFalse()
        {
            var gateway = Substitute.For<IDbGateway>();
            var logger = Substitute.For<ILogger>();
            var socket = Substitute.For<ISocketOverNetwork>();
            var fileOnMachine = Substitute.For<IFileOnMachine>();
            
            string content = "Lorem Ipsum";
            string path = "fake path";
            fileOnMachine.IsValid(path).ReturnsForAnyArgs(true);
            var anyService = new AnyServices(gateway, logger, fileOnMachine, socket);

            const bool expected = true;
            var result = anyService.WriteOnFile("path", content);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
