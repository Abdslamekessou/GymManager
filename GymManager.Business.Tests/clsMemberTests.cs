using System.Data;

namespace GymManager.Business.Tests;

[TestClass]
public class clsMemberTests
{
    // =========================================================
    // Constructor - Add New
    // =========================================================

    [TestMethod]
    public void Constructor_ShouldInitializeMemberCorrectly()
    {
        // Arrange & Act
        clsMember member = new clsMember();

        // Assert
        Assert.AreEqual(-1, member.MemberID);

        Assert.AreEqual(-1, member.PersonID);

        Assert.AreEqual(-1, member.CreatedBy);

        Assert.IsTrue(member.IsActif);

        Assert.AreEqual(
            clsMember.enMode.AddNew,
            member.Mode
        );

        Assert.AreEqual(
            DateTime.Now.Date,
            member.CreatedAt.Date
        );
    }


    // =========================================================
    // Find Member
    // =========================================================

    [TestMethod]
    public void FindMember_WhenMemberExists_ReturnsMemberWithCorrectData()
    {
        // Arrange
        int memberID = 4;

        // Act
        clsMember member = clsMember.FindMember(memberID);

        // Assert
        Assert.IsNotNull(member);

        Assert.AreEqual(4, member.MemberID);

        Assert.AreEqual(1, member.PersonID);



        Assert.AreEqual(2, member.CreatedBy);

        Assert.IsFalse(member.IsActif);

        Assert.AreEqual(
            clsMember.enMode.Update,
            member.Mode
        );

    }


    [TestMethod]
    public void FindMember_WhenMemberDoesNotExist_ReturnsNull()
    {
        // Arrange
        int memberID = -1;

        // Act
        clsMember member = clsMember.FindMember(memberID);

        // Assert
        Assert.IsNull(member);
    }


    // =========================================================
    // Is Member Exist
    // =========================================================

    [TestMethod]
    public void IsMemberExist_WhenMemberExists_ReturnsTrue()
    {
        // Arrange
        int memberID = 5;

        // Act
        bool result = clsMember.IsMemberExist(memberID);

        // Assert
        Assert.IsTrue(result);
    }


    [TestMethod]
    public void IsMemberExist_WhenMemberDoesNotExist_ReturnsFalse()
    {
        // Arrange
        int memberID = -1;

        // Act
        bool result = clsMember.IsMemberExist(memberID);

        // Assert
        Assert.IsFalse(result);
    }


    // =========================================================
    // Save - Add New
    // =========================================================

    [TestMethod]
    public void Save_WhenAddingNewMember_ReturnsTrueAndChangesModeToUpdate()
    {
        // Arrange
        clsMember member = new clsMember();

        member.PersonID = 2;

        member.CreatedAt =
            new DateTime(2026, 10, 3);

        member.CreatedBy = 2;

        member.IsActif = true;

        // Act
        bool result = member.Save();

        // Assert
        Assert.IsTrue(result);

        Assert.IsTrue(member.MemberID > 0);

        Assert.AreEqual(
            clsMember.enMode.Update,
            member.Mode
        );
    }


    // =========================================================
    // Save - Update
    // =========================================================

    [TestMethod]
    public void Save_WhenUpdatingExistingMember_ReturnsTrue()
    {
        // Arrange
        clsMember member = clsMember.FindMember(4);

        Assert.IsNotNull(member);

        member.PersonID = 5;

        member.CreatedAt =
            new DateTime(2026, 10, 3);

        member.CreatedBy = 1;

        member.IsActif = true;

        // Act
        bool result = member.Save();

        // Assert
        Assert.IsTrue(result);

        // Verify that the data was actually updated
        clsMember updatedMember =
            clsMember.FindMember(member.MemberID);

        Assert.IsNotNull(updatedMember);

        Assert.AreEqual(5, updatedMember.PersonID);

        Assert.AreEqual(
            new DateTime(2026, 10, 3),
            updatedMember.CreatedAt
        );

        Assert.AreEqual(1, updatedMember.CreatedBy);

        Assert.IsTrue(updatedMember.IsActif);

        Assert.AreEqual(
            clsMember.enMode.Update,
            updatedMember.Mode
        );
    }


    // =========================================================
    // Get All Members
    // =========================================================

    [TestMethod]
    public void GetAllMembers_WhenMembersExist_ReturnsDataTableWithRows()
    {
        // Act
        DataTable dt = clsMember.GetAllMembers();

        // Assert
        Assert.IsNotNull(dt);

        Assert.IsTrue(dt.Rows.Count > 0);
    }


    // =========================================================
    // Get All Members - Verify Columns
    // =========================================================

    [TestMethod]
    public void GetAllMembers_ReturnsExpectedColumns()
    {
        
        // Act
        DataTable dt = clsMember.GetAllMembers();

        // Assert
        Assert.IsNotNull(dt);

        Assert.IsTrue(dt.Columns.Contains("AdherentID"));

        Assert.IsTrue(dt.Columns.Contains("PersonneID"));

        Assert.IsTrue(dt.Columns.Contains("DateAjout"));

        Assert.IsTrue(dt.Columns.Contains("CreePar"));

        Assert.IsTrue(dt.Columns.Contains("EstActif"));
    }
}
