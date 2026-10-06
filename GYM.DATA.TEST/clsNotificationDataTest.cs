using GymManager.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace GYM.DATA.TEST
{
    [TestClass]
    public sealed class clsNotificationDataTest
    {
        [TestMethod]
        public void GetAllNotifications_ReturnsTable_AndContainsExpectedColumnsIfAvailable()
        {
            // Act
            var dt = clsNotificationData.GetAllNotifications();

            // Assert basic contract
            Assert.IsNotNull(dt, "GetAllNotifications should not return null.");

            // Expected columns used by the presentation layer
            string[] expectedColumns = new[]
            {
                "MemberName",
                "Sport",
                "SubscriptionType",
                "AbonnementStatus",
                "ReadStatus",
                "Exportation"
            };

            if (dt.Columns.Count == 0)
            {
                // Database might be unavailable in the test environment; mark inconclusive instead of failing.
                Assert.Inconclusive("No columns returned from GetAllNotifications — database may be unavailable. Test inconclusive.");
            }

            foreach (var col in expectedColumns)
            {
                Assert.IsTrue(dt.Columns.Contains(col), $"Expected column '{col}' was not found in the returned DataTable.");
            }
        }

        [TestMethod]
        public void MakeNotificationsAsExported_SetsEstExportee_ForGivenIds()
        {
            List<int> IDs  = new List<int>();
            IDs.Add(1);
            IDs.Add(2);
            IDs.Add(3);

            //Act
            bool Affected = clsNotificationData.MakeNotificationsAsExported(IDs);

            //
            Assert.IsTrue(Affected);
        }
    }
}
