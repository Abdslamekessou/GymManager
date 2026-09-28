namespace GymManager.DataAccess.Tests
{
    [TestClass]
    public sealed class clsPersonDataTests
    {


        [TestMethod]
        public void FindPersonne_WhenPersonExists_ReturnsTrueAndLoadsCorrectData()
        {
            // Arrange
            int personID = 1;

            string prenom = "";
            string nom = "";
            string numeroTelephone = "";
            string email = "";
            DateTime dateDeNaissance = DateTime.MinValue;
            byte genre = 0;
            string image = "";

            // Act
            bool isFound = clsPersonData.FindPerson(
                personID,
                ref prenom,
                ref nom,
                ref numeroTelephone,
                ref email,
                ref dateDeNaissance,
                ref genre,
                ref image
            );

            // Assert
            Assert.IsTrue(isFound);

            Assert.AreEqual("Karim", prenom);
            Assert.AreEqual("Benali", nom);
            Assert.AreEqual("0555123456", numeroTelephone);
            Assert.AreEqual("karim.benali@email.com", email);

            Assert.AreEqual(
                new DateTime(1990, 5, 14),
                dateDeNaissance
            );

            Assert.AreEqual((byte)0, genre);

            Assert.AreEqual(null, image);

        }


        [TestMethod]
        public void IsPersonExist_ExistingPersonID_ReturnsTrue()
        {
            // Arrange
            int personID = 1; // Make sure PersonID = 1 exists in your database

            // Act
            bool result = clsPersonData.isPersonExist(personID);

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void IsPersonExist_NonExistingPersonID_ReturnsFalse()
        {
            // Arrange
            int personID = -1; // An ID that should not exist

            // Act
            bool result = clsPersonData.isPersonExist(personID);

            // Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void AddNewPerson_ValidData_ReturnsNewPersonID()
        {
            // Arrange
            string firstName = "Test";
            string lastName = "Person";
            string phoneNumber = "0555555555";
            string email = "test@test.com";
            DateTime dateOfBirth = new DateTime(2000, 1, 1);
            byte gender = 1;
            string image = "";

            // Act
            int personID = clsPersonData.AddNewPerson(
                firstName,
                lastName,
                phoneNumber,
                email,
                dateOfBirth,
                gender,
                image
            );

            // Assert
            Assert.IsTrue(personID > 0);
        }


    }


}
