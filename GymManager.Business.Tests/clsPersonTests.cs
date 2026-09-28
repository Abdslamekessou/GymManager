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


        //[TestMethod]
        //public void AddNewPerson_ValidData_PersonIsAdded()
        //{
        //    // Arrange
        //    clsPerson person = new clsPerson();

        //    person.FirstName = "Test02";
        //    person.LastName = "Person";
        //    person.PhoneNumber = "0555555555";
        //    person.Email = "test@test.com";
        //    person.DateOfBirth = new DateTime(2000, 1, 1);
        //    person.Gendor = 1;
        //    person.Image = null;

        //    // Act
        //    bool result = person._AddNewPerson();

        //    // Assert
        //    Assert.IsTrue(result);
        //    Assert.IsTrue(person.PersonID > 0);

        //    // Verify that the generated ID actually exists
        //    Assert.IsTrue(clsPerson.isPersonExist(person.PersonID));
        //}


    }
}
