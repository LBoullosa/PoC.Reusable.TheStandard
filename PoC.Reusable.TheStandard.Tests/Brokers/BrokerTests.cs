using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Moq;
using PoC.Reusable.TheStandard.Brokers;
using PoC.Reusable.TheStandard.Models;

namespace PoC.Reusable.TheStandard.Tests.Unit.Brokers
{
	public class BrokerTests
	{
		//private readonly Mock<IStorageBroker<Car>> storageBrokerMock;

		public BrokerTests()
		{
			//this.storageBrokerMock = new Mock<IStorageBroker<Car>>();
		}

		/*[Fact]
		public async Task ShouldRetrieveAllCars()
		{
			StorageBroker broker = new StorageBroker(null);

			//given
			//when
			List<Car> cars = await storageBrokerMock.Object
				.SelectAll()
				.ToListAsync();
			//then
			cars.Should().NotBeNull();
		}*/
	}
}