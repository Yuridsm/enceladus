using Business.Tests.TestDoubles;
using BusinessEntities.WorkStatisticEntity;
using BusinessServices.Customer.CustomerServices;
using NUnit.Framework;

namespace Business.Tests
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void CalculateWage_HourlyPayed_ReturnsCorrectWage()
        {
            DbGatewayStub gateway = new DbGatewayStub();
            gateway.SetWorkingStatistics(new WorkingStatistics() { PayHourly = true, HourSalary = 100, WorkingHours = 10, MonthSalary = 9 });
            
            var sut = new CustomerServices(gateway, new LoggerDummy());

            const int anyId = 1;
            decimal actual = sut.CalculateWage(anyId);

            const decimal expectedWage = 100 * 10;
            Assert.That(actual, Is.EqualTo(expectedWage).Within(0.1));
        }

        [Test]
        public void CalculateWage_PassesCorrectId()
        {
            const int id = 1;

            var gateway = new DbGatewaySpy();
            gateway.SetWorkingStatistics(new WorkingStatistics());

            var sut = new CustomerServices(gateway, new LoggerDummy());

            sut.CalculateWage(id);

            Assert.That(id, Is.EqualTo(gateway.Id));
        }

        [Test]
        public void CalculateWage_ConnectedIsFalse()
        {
            const int id = -100;
            
            var gateway = new DbGatewaySpy();

            gateway.SetWorkingStatistics(new WorkingStatistics());

            var sut = new CustomerServices(gateway, new LoggerDummy());

            sut.CalculateWage(id);

            const bool expect = false;

            Assert.That(expect, Is.EqualTo(gateway.Connected));
        }

        [Test]
        public void CalculateWage_ConnectedIsTrue()
        {
            const int id = 0;

            var gateway = new DbGatewaySpy();

            gateway.SetWorkingStatistics(new WorkingStatistics());

            var sut = new CustomerServices(gateway, new LoggerDummy());

            sut.CalculateWage(id);

            const bool expectConnect = true;

            Assert.That(expectConnect, Is.EqualTo(gateway.Connected));
        }

        [Test]
        public void CalculateWage_PassesCorrectId2()
        {
            const int id = 1;

            var gateway = new DbGatewayMock();

            gateway.SetWorkingStatistics(new WorkingStatistics());

            var sut = new CustomerServices(gateway, new LoggerDummy());

            sut.CalculateWage(id);

            Assert.IsTrue(gateway.VerifyCalledWithProperId(id));
        }
    }
}