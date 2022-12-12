using NUnit.Framework;
using OrderServiceRepository.Interface;
using Moq;

namespace OnlineOrder.BusinessServices.Tests
{
    public class CustomerServiceTests
    {

        [Test]
        public void GetAllCustomer_P()
        {
            //Arrange
            var customerRepoMock = new Mock<ICustomerRepo>();
            var service = new CustomerService(customerRepoMock.Object);

            //Act
            var result = service.GetAll();

            //Asserts
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("abc@morgen.com", result[0].EmailId);

        }
    }
}
