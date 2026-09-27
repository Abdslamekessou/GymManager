namespace GymManager.Business.Tests
{
    [TestClass]
    public sealed class clsPersonneTests
    {



        [TestMethod]
        public void FindPersonne_WhenPersonExists_ReturnsPersonneObject()
        {
            // Arrange
            int personID = 1;

            // Act
            clsPersonne person = clsPersonne.FindPersonne(personID);

            // Assert
            Assert.IsNotNull(person);

            Assert.AreEqual(personID, person.PersonneID);

            Assert.IsFalse(string.IsNullOrEmpty(person.Prenom));
            Assert.IsFalse(string.IsNullOrEmpty(person.Nom));
            Assert.IsFalse(string.IsNullOrEmpty(person.NumeroTelephone));

            Assert.AreNotEqual(DateTime.MinValue, person.DateDeNaissance);
        }


        [TestMethod]
        public void FindPersonne_WhenPersonDoesNotExist_ReturnsNull()
        {
            // Arrange
            int personID = -1;

            // Act
            clsPersonne person = clsPersonne.FindPersonne(personID);

            // Assert
            Assert.IsNull(person);
        }


    }
}
