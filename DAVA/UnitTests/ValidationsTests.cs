using System;
using Data.Entities.Validation;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    class ValidationsTests
    {
        [Fact]
        public void Given_CorrectDateOrType_When_ValidatingDashboard_Should_BeTrue()
        {
            //Arrange
            var date = new DateTime(2017, 12, 22);
            var type = "housework";

            //Act
            var validation = Validations.ValidateDashboard(date, type);

            //Assert
            validation.Should().BeTrue();
        }

        [Fact]
        public void Given_IncorrectDateOrType_When_ValidatingDashboard_Should_ThrowEnitityException()
        {
            //Arrange
            var date = new DateTime(2017, 12, 22);
            var type = "invalidType";

            //Act
            Action validation = () =>
            {
                Validations.ValidateDashboard(date, type);
            };

            //Assert
            validation.ShouldThrow<EntityException>();
        }

        [Fact]
        public void Given_CorrectInput_When_ValidatingActivity_Should_BeTrue()
        {
            //Arrange
            var name = "name";
            var description = "description";
            var type = "leisure";
            var startingTime = new DateTime(2017, 12, 22);
            var endingTime = new DateTime(2017, 12, 23);

            //Act
            var validation = Validations.ValidateActivity(name, description, type, startingTime, endingTime);

            //Assert
            validation.Should().BeTrue();
        }

        [Fact]
        public void Given_IncorrectInput_When_ValidatingActivity_Should_ThrowEnitityException()
        {
            //Arrange
            var name = "name";
            var description = "description";
            var type = "leisure";
            var startingTime = new DateTime(2017, 12, 22);
            var endingTime = new DateTime(2017, 12, 23);

            //Act
            Action validation = () =>
            {
                Validations.ValidateActivity(name, description, type, startingTime, endingTime);
            };

            //Assert
            validation.ShouldThrow<EntityException>();
        }
    }
}
