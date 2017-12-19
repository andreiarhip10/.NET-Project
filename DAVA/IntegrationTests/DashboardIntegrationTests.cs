using System;
using System.Collections.Generic;
using System.Text;
using Business.Repositories;
using Data.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests
{
    [TestClass]
    public class DashboardIntegrationTests : BaseIntegrationTest
    {
        [TestMethod]
        public void Given_DashboardRepository_When_AddingNewDashboard_Then_TheDashboardShouldBeProperlyAdded()
        {
            RunOnDatabase(sut =>
            {
                //Arrange
                var repository = new DashboardRepository(sut);
                var dashboard = Dashboard.Create(new DateTime(2017, 12, 16), "leisure");

                //Act
                repository.Add(dashboard);
                
                //Assert
                var dashboards = repository.GetAll();
                Assert.AreEqual(1, dashboards.Count);
            });
        }

        [TestMethod]
        public void Given_DashboardRepository_When_GettingDashboardById_Then_ShouldReturnCorrectDashboard()
        {
            RunOnDatabase(sut =>
            {
                //Arrange
                var repository = new DashboardRepository(sut);
                var dashboard = Dashboard.Create(new DateTime(2017, 12, 16), "leisure");

                //Act
                repository.Add(dashboard);

                //Assert
                var returnedDashboard = repository.GetById(dashboard.Id);
                Assert.AreEqual(dashboard.Id, returnedDashboard.Id);
            });
        }
    }
}
