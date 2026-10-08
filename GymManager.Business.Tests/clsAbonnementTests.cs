using GymManager.Business.GymManager.Business;

namespace GymManager.Business.Tests;

[TestClass]
public class clsAbonnementTests
{
    [TestMethod]
    public void FindAbonnementByMemberID_ValidMemberID_ReturnsAbonnement()
    {
        // Arrange
        int memberID = 4; // Use an existing MemberID that has an abonnement

        // Act
        clsAbonnement abonnement = clsAbonnement.FindAbonnementByMemberID(memberID);

        // Assert
        Assert.IsNotNull(abonnement);

        Assert.AreEqual(memberID, abonnement.AdherentID);
        Assert.IsTrue(abonnement.AbonnementID > 0);
        Assert.IsTrue(abonnement.TypeAbonnementID > 0);
        Assert.IsTrue(abonnement.CreePar > 0);
        Assert.IsTrue(abonnement.PrixPaye >= 0);
    }



    [TestMethod]
    public void FindAbonnementByMemberID_MemberWithoutAbonnement_ReturnsNull()
    {
        // Arrange
        int memberID = 999999; // Use a MemberID that has no abonnement

        // Act
        clsAbonnement abonnement = clsAbonnement.FindAbonnementByMemberID(memberID);

        // Assert
        Assert.IsNull(abonnement);
    }


}
