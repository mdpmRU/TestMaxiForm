using Entities;

namespace TestData
{
    public class Stubs
    {
        public static List<Department> Departments =
        [
            new()
            {
                Id = 1,
                Name = "FirstDepartment"
            },
            new()
            {
                Id = 2,
                Name = "SecondDepartment"
            },
            new()
            {
                Id = 3,
                Name = "ThirdDepartment"
            },
            new()
            {
                Id = 4,
                Name = "FourthDepartment"
            },
        ];

        public static List<Position> Positions =
            [
            new()
            {
                Id = 1,
                Name = "FirstPosition"
            },
            new()
            {
                Id = 2,
                Name = "SecondPosition"
            },
            new()
            {
                Id = 3,
                Name = "ThirdPosition"
            },
            new()
            {
                Id = 4,
                Name = "FourthPosition"
            },
        ];

        public static List<Employee> Employees =
            [
            new()
            {
                Id = 1,
                Name = "FirstName",
                LastName = "FirstLastName",
                Email = "FirstEmail",
                DateOfBirth = new DateTime(1992,3,23),
                Department = Departments[0],
                Position = Positions[0]
            },
            new()
            {
                Id = 2,
                Name = "SecondName",
                LastName = "SecondLastName",
                Email = "SecondEmail",
                DateOfBirth = new DateTime(1992,1,21),
                Department = Departments[2],
                Position = Positions[1]
            },
            new()
            {
                Id = 3,
                Name = "ThirdName",
                LastName = "ThirdLastName",
                Email = "ThirdEmail",
                DateOfBirth = new DateTime(1982,3,11),
                Department = Departments[1],
                Position = Positions[3],
            },
            new()
            {
                Id = 4,
                Name = "SecondName",
                LastName = "SecondLastName",
                Email = "FourthEmail",
                DateOfBirth = new DateTime(1982,6,12),
                Department = Departments[3],
                Position = Positions[2],
            },
            new()
            {
                Id = 5,
                Name = "FirstName",
                LastName = "ThirdLastName",
                Email = "FifthEmail",
                DateOfBirth = new DateTime(1993,3,8),
                Department = Departments[2],
                Position = Positions[3],
            },
            new()
            {
                Id = 6,
                Name = "SecondName",
                LastName = "FirstLastName",
                Email = "SixthEmail",
                DateOfBirth = new DateTime(1997,1,13),
                Department = Departments[1],
                Position = Positions[1],
            },
            new()
            {
                Id = 7,
                Name = "FourthName",
                LastName = "FourthLastName",
                Email = "SeventhEmail",
                DateOfBirth = new DateTime(1998,5,25),
                Department = Departments[2],
                Position = Positions[1]
            }
            ];

    }
}
