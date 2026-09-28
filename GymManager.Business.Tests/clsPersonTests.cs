namespace GymManager.Business.Tests
{
    [TestClass]
    public sealed class clsPersonTests
    {



        [TestMethod]
        public void FindPerson_WhenPersonExists_ReturnsPersonObject()
        {
            // Arrange
            int personID = 1;

            // Act
            clsPerson person = clsPerson.FindPerson(personID);

            // Assert
            Assert.IsNotNull(person);

            Assert.AreEqual(personID, person.PersonID);

            Assert.IsFalse(string.IsNullOrEmpty(person.FirstName));
            Assert.IsFalse(string.IsNullOrEmpty(person.LastName));
            Assert.IsFalse(string.IsNullOrEmpty(person.PhoneNumber));

            Assert.AreNotEqual(DateTime.MinValue, person.DateOfBirth);
        }


        [TestMethod]
        public void FindPerson_WhenPersonDoesNotExist_ReturnsNull()
        {
            // Arrange
            int personID = -1;

            // Act
            clsPerson person = clsPerson.FindPerson(personID);

            // Assert
            Assert.IsNull(person);
        }


    }
}
