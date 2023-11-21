
namespace challengeApp.Tests 
{

    public class TypeTests
    {

        [Test]
        public void AreTheUserDiffrent()
        {
            //arrange
            var user1 = ("Tomek", "Mazur", 35);
            var user2 = ("Tomek", "Mazur", 38);

            //act

            //assert
            Assert.AreNotEqual(user1, user2);

        }
        [Test]
        public void AreTheNamesDiffrent()
        {
            //arrange
            string name1 = ("Tomek");
            string name2 = ("Adam");
            //act
            //assert
            Assert.AreNotEqual(name1, name2);

        }
        public void AreTheEmployeesDiffrent()
        {
            //arrange
            var employee1 = ("Tomek", "Mazur", 35);
            var employee2 = ("Tomek", "Mazur", 38);
            //act
            //assert
            Assert.AreNotEqual(employee1, employee2);

        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
        private User GetUser(string name,string surname, int age)
        {
            return new User(name, surname,age);
        }

        [Test]
        public void AreTheNumbersDiffrent()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }
    }
}
