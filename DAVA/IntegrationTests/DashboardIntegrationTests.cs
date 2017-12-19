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
        public void Given_DashboardRepository_When_AddingMoreNewDashboards_Then_TheDashboardsShouldBeProperlyAdded()
        {
            RunOnDatabase(sut =>
            {
                //Arrange
                var repository = new DashboardRepository(sut);
                var dashboard = Dashboard.Create(new DateTime(2017, 12, 16), "leisure");
                var secondDashboard = Dashboard.Create(new DateTime(2017, 11, 11), "sport");
                var thirdDashboard = Dashboard.Create(new DateTime(2017, 5, 5), "faculty");
                //Act
                repository.Add(dashboard);
                repository.Add(secondDashboard);
                repository.Add(thirdDashboard);
                
                //Assert
                var dashboards = repository.GetAll();
                Assert.AreEqual(3, dashboards.Count);
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

        [TestMethod]
        public void Given_DashboardRepository_When_DeletingDashboard_Then_TheDashboardShouldBeProperlyRemoved()
        {
            RunOnDatabase(sut =>
            {
                //Arrange
                var repository = new DashboardRepository(sut);
                var dashboard = Dashboard.Create(new DateTime(2017, 12, 16), "leisure");

                //Act
                repository.Add(dashboard);
                repository.Delete(dashboard.Id);

                //Assert
                var dashboards = repository.GetAll();
                Assert.AreEqual(0, dashboards.Count); // adaug 3 si count sa fie 3. ( la GetAll )
            });
        }

        [TestMethod]
        public void Given_DashboardRepository_When_DeletingMoreDashboards_Then_TheDashboardsShouldBeProperlyRemoved()
        {
            RunOnDatabase(sut =>
            {
                //Arrange
                var repository = new DashboardRepository(sut);
                var dashboard = Dashboard.Create(new DateTime(2017, 12, 16), "leisure");
                var secondDashboard = Dashboard.Create(new DateTime(2017, 11, 11), "sport");
                var thirdDashboard = Dashboard.Create(new DateTime(2017, 5, 5), "faculty");

                //Act
                repository.Add(dashboard);
                repository.Add(secondDashboard);
                repository.Add(thirdDashboard);
                repository.Delete(dashboard.Id);
                repository.Delete(secondDashboard.Id);
                repository.Delete(thirdDashboard.Id);

                //Assert
                var dashboards = repository.GetAll();
                Assert.AreEqual(0, dashboards.Count); // adaug 3 si count sa fie 3. ( la GetAll )
            });
        }



    }
}
