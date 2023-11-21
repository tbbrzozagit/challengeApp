namespace challengeApp.Tests
{
    public class UserTests
    {


        [Test]
        public void WhenEmployeeCollectPositiveScores_ShouldCorrectResult()
        {
            //arrange
            var user = new User("Tomek", "1234", 25);
            

            //act
            var result = user.Result;

            //assert
            Assert.AreNotEqual(25, result);
        }
        [Test]
        public void WhenEmployeeCollectNegativeScores_ShouldCorrectResult()
        {
            //arrange
            var user = new User("Bartek", "4321", 25);
            

            //act
            var result = user.Result;

            //assert
            Assert.AreNotEqual(25, result);
        }



    }
}