namespace challengeApp.Tests
{
    public class Tests
    {


        [Test]
        public void WhenEmployeeCollectPositiveScores_ShouldCorrectResult()
        {
            //arrange
            var user = new User("Tomek", "1234", 35);
            user.AddScore(3);
            user.AddScore(4);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(7);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(25, result);
        }
        [Test]
        public void WhenEmployeeCollectNegativeScores_ShouldCorrectResult()
        {
            //arrange
            var user = new User("Bartek", "4321", 25);
            user.AddScore(8);
            user.AddScore(9);
            user.AddScore(-5);
            user.AddScore(-1);
            user.AddScore(-3);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(8, result);
        }



    }
}