using System;


namespace BashSoft
{
    public static class ExceptionMessages
    {
        public const string ExampleExceptionMessage = "Example message!";
        public const string DataAlreadyInitializedException = "“Data is already initialized!”";
        public const string DataNotInitializedExceptionMessage =
            "The data structure must be initialized first in order to make any operations with it.";
        public const string InexistingStudentInDataBase =
            "The user name for the student you are trying to get does not exist!";
        public const string InexistingCourseInDataBase =
            "The course you are trying to get does not exist in the data base!";
        public const string UnautorizedExceptionMessage =
            "The folder/file you are trying to get access needs a higher level of rights than you currently have.";

        public const string ComparisonOfFilesWithDifferentSizes =
            "Files not of equal size, certain mismatch.";

        public const string UnabledToGoHigherInPartitionHerarchy =
            "Unabled to go higher in the partition herarchy";
        public const string UnableToParcenumber = "A number expected.";
        public const string InvalidDataFormat = "Invalid data format.";
        public const string InvalidStudentFilter =
            "The given filter is not one of the following: excellent/average/poor";
        public const string InvalidComparisonQuery = "Invalid comparison.";

        public const string InvalidTakeCommand = "Invalid take command.";
        public const string InvalidParseException = "The take command expected does not match the format wanted!";
        public const string StudentAlreadyEnrolledInGivenCourse = "Student is already enrolled in this course";
        public const string InvalidScore = "The number for the score you've entered is not in the range of 0 - 100";
        public const string NullOrEmptyValue = "The value of the variable CANNOT be null or empty!";
        public const string InvalidTakeQuantityParameter = "The take command expected does not match the format wanted!";
    }

}
