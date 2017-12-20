using System;
using System.Collections.Generic;
using System.Text;
using Business.Repositories;
using Data.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Repositories;
using Data.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace IntegrationTests
{
    [TestClass]
    public class ActivityIntegrationTests : BaseIntegrationTest
    {
        [TestMethod]
        public void Given_ActivityRepository_When_AddingNewActivity_Then_TheActivityShouldBeProperlyAdded()
        {
            RunOnDatabase(sut =>
            {
                //Arrange
                var repository = new ActivityRepository(sut);
                var activity = Activity.Create(".NET", "Study about .NET", "study", new Guid(), new DateTime(2017, 11, 11), new DateTime(2017, 12, 11));

                //Act
                repository.Add(activity);

                //Assert
                var activitys = repository.GetAll();
                Assert.AreEqual(1, activitys.Count);
            });
        }

        [TestMethod]
        public void Given_ActivityRepository_When_AddingMoreNewActivities_Then_TheActivitiesShouldBeProperlyAdded()
        {
            RunOnDatabase(sut =>
            {
                //Arrange

                var repository = new ActivityRepository(sut);
                var activity = Activity.Create("Swim", "Go to Vivertine", "study", new Guid(), new DateTime(2017, 11, 11), new DateTime(2017, 12, 11));
                var secondActivity = Activity.Create("Sing", "Study Eminem music", "study", new Guid(), new DateTime(2017, 10, 10), new DateTime(2017, 11, 11));
                var thirdActivity =  Activity.Create("Read Books", "Study .NET books", "study", new Guid(), new DateTime(2017, 2, 2), new DateTime(2017, 3, 3));

                //Act
                repository.Add(activity);
                repository.Add(secondActivity);
                repository.Add(thirdActivity);

                //Assert
                var activitys = repository.GetAll();
                Assert.AreEqual(3, activitys.Count);
            });
        }



        [TestMethod]
        public void Given_ActivityRepository_When_GettingActivityById_Then_ShouldReturnCorrectActivity()
        {
            RunOnDatabase(sut =>
            {
                //Arrange
                var repository = new ActivityRepository(sut);
                Activity.Create("Swim", "Go to Vivertine", "study", new Guid(), new DateTime(2017, 11, 11), new DateTime(2017, 12, 11));
                var activity = Activity.Create("Swim", "Go to Vivertine", "study", new Guid(), new DateTime(2017, 11, 11), new DateTime(2017, 12, 11));
                //Act
                repository.Add(activity);

                //Assert
                var returnedActivity = repository.GetById(activity.Id);
                Assert.AreEqual(activity.Id, returnedActivity.Id);
            });
        }

        [TestMethod]
        public void Given_ActivityRepository_When_DeletingActivity_Then_TheActivityShouldBeProperlyRemoved()
        {
            RunOnDatabase(sut =>
            {
                //Arrange
                var repository = new ActivityRepository(sut);
                var activity = Activity.Create("Swim", "Go to Vivertine", "study", new Guid(), new DateTime(2017, 11, 11), new DateTime(2017, 12, 11));
                //Act
                repository.Add(activity);
                repository.Delete(activity.Id);

                //Assert
                var activitys = repository.GetAll();
                Assert.AreEqual(0, activitys.Count); // adaug 3 si count sa fie 3. ( la GetAll )
            });
        }

        [TestMethod]
        public void Given_ActivityRepository_When_DeletingMoreActivities_Then_TheActivitiesShouldBeProperlyRemoved()
        {
            RunOnDatabase(sut =>
            {
                //Arrange
                var repository = new ActivityRepository(sut);
                var activity =  Activity.Create("Swim", "Go to Vivertine", "study", new Guid(), new DateTime(2017, 11, 11), new DateTime(2017, 12, 11));
                var secondActivity = Activity.Create("Poker", "Go to Las Vegas", "win", new Guid(), new DateTime(2017, 1, 11), new DateTime(2017, 2, 11));
                var thirdActivity = Activity.Create("Ping Pong", "Go to Play Again", "study", new Guid(), new DateTime(2017, 2, 11), new DateTime(2017, 3, 11));

                //Act
                repository.Add(activity);
                repository.Add(secondActivity);
                repository.Add(thirdActivity);
                repository.Delete(activity.Id);
                repository.Delete(secondActivity.Id);
                repository.Delete(thirdActivity.Id);

                //Assert
                var activitys = repository.GetAll();
                Assert.AreEqual(0, activitys.Count); // adaug 3 si count sa fie 3. ( la GetAll )
            });
        }



    }
}

