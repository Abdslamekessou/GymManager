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


        [TestMethod]
        public void IsPersonExist_ExistingPerson_ReturnsTrue()
        {
            // Arrange
            int personID = 1; // Make sure this PersonID exists in the database

            // Act
            bool result = clsPerson.isPersonExist(personID);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPersonExist_NonExistingPerson_ReturnsFalse()
        {
            // Arrange
            int personID = 999999; // Make sure this ID does not exist

            // Act
            bool result = clsPerson.isPersonExist(personID);

            // Assert
            Assert.IsFalse(result);
        }


    }
}
