using System.Collections.Generic;

namespace AccountOwnerServer.Models
{
    public static class DataManager
    {
        public static List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Age = 25,
                    Gender = "Male",
                    Name = "John",
                    Surname = "Smith"
                },
                new Student
                {
                    Age = 20,
                    Gender = "Female",
                    Name = "Janette",
                    Surname = "Smitherine"
                },
            };
        }
    }
}
