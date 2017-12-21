using System;

namespace Data.Entities.Validation
{
    public class Validations
    {
        public static bool ValidateDashboard(DateTime date, string type)
        {
            if (date <= DateTime.Now)
            {
                throw new EntityException("Dashboard date cannot be earlier than today.");
            }
            if (type != "leisure" && type != "study/work" && type != "housework")
            {
                throw new EntityException("Dashboard type can only be leisure, housework or study/work.");
            }
            return true;
        }

        public static bool ValidateActivity(string name, string description, string type, DateTime startingTime, DateTime endingTime)
        {
            if (name == "")
            {
                throw new EntityException("Name field cannot be empty.");
            }
            if (name.Length > 50)
            {
                throw new EntityException("Name cannot be longer than 50 characters.");
            }
            if (description == "")
            {
                throw new EntityException("Description field cannot be empty.");
            }
            if (description.Length > 200)
            {
                throw new EntityException("Description cannot be longer than 200 characters.");
            }
            if (type != "leisure" && type != "study/work" && type != "housework")
            {
                throw new EntityException("Activity type can only be leisure, housework or study/work.");
            }
            if (startingTime <= DateTime.Now)
            {
                throw new EntityException("StartingTime cannot be earlier than today.");
            }
            if (endingTime <= startingTime)
            {
                throw new EntityException("EndingTime cannot be earlier than StartingTime.");
            }
            return true;
        }
    }
}
