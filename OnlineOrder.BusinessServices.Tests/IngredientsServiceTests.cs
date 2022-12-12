using NUnit.Framework;

namespace OnlineOrder.BusinessServices.Tests
{
    public class IngredientsServiceTests
    {
        [Test]
        public void GetAllIngredientItems_P()
        {
            //Arrange

            var service = new IngredientService();

            //Act
            var result = service.GetAllIngredients();

            //Asserts
            Assert.AreEqual(1, result.Count);

        }
    }
}
