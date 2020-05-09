using Cwiczenia3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia3.Services
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students = new List<Student>
        {
            new Student{ IdStudent = 1, FirstName = "Janek", LastName = "Kos", IndexNumber = "s12343" },
            new Student{ IdStudent = 2, FirstName = "Jan", LastName = "Witos", IndexNumber = "s12345" },
            new Student{ IdStudent = 3, FirstName = "Marcin", LastName = "J.", IndexNumber = "s12341" },
        };

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }

    }
}
