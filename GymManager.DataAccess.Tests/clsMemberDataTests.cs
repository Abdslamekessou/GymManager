using System.Data;

namespace GymManager.DataAccess.Tests;

[TestClass]
public class clsMemberDataTests
{
    [TestMethod]
    public void FindMember_WhenMemberExists_ReturnsTrueAndLoadsCorrectData()
    {
        // Arrange
        int memberID = 4;

        int personID = -1;
        DateTime createdAt = DateTime.MinValue;
        int createdBy = -1;
        bool isActif = false;

        
        // Act
        bool isFound = clsMemberData.FindMember(
            memberID,
            ref personID,
            ref createdAt,
            ref createdBy,
            ref isActif
        );

        // Assert
        Assert.IsTrue(isFound);


    }


    [TestMethod]
    public void IsMemberExist_ExistingMemberID_ReturnsTrue()
    {
        // Arrange
        int memberID = 5;

        // Act
        bool result = clsMemberData.IsMemberExist(memberID);

        // Assert
        Assert.IsTrue(result);
    }


    [TestMethod]
    public void IsMemberExist_NonExistingMemberID_ReturnsFalse()
    {
        // Arrange
        int memberID = -1;

        // Act
        bool result = clsMemberData.IsMemberExist(memberID);

        // Assert
        Assert.IsFalse(result);
    }


    [TestMethod]
    public void AddNewMember_ValidData_ReturnsNewMemberID()
    {
        // Arrange
        int personID = 14;

        DateTime createdAt =
            new DateTime(2026, 10, 1);

        int createdBy = 2;

        bool isActif = true;

        // Act
        int memberID = clsMemberData.AddNewMember(
            personID,
            createdAt,
            createdBy,
            isActif
        );

        // Assert
        Assert.IsTrue(memberID > 0);
    }


    [TestMethod]
    public void UpdateMember_ShouldReturnTrue_WhenMemberExists()
    {
        // Arrange
        int memberID = 4;

        int personID = 1;

        DateTime createdAt =
            new DateTime(2024, 12, 1);

        int createdBy = 2;

        bool isActif = false;

        
        // Act
        bool result = clsMemberData.UpdateMember(
            memberID,
            personID,
            createdAt,
            createdBy,
            isActif
        );

        // Assert
        Assert.IsTrue(result);
    }


    [TestMethod]
    public void GetAllMembers_WhenMembersExist_ReturnsDataTableWithRows()
    {
        // Act
        DataTable dt = clsMemberData.GetAllMembers();

        // Assert
        Assert.IsNotNull(dt);

        Assert.IsTrue(dt.Rows.Count > 0);
    }


}
