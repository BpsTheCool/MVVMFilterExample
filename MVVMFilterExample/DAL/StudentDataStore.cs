using System.Collections.Generic;
using MVVMFilterExample.Models;

namespace MVVMFilterExample.DAL
{
    class StudentDataStore
    {
        private static readonly List<Student> Students = new List<Student>
        {
            new Student{Name = "Ali",Surname="Goodarzi",StudentCode = "1234567890"},
            new Student{Name = "Behnam",Surname="Rezayee",StudentCode = "1011121314"},
            new Student{Name = "Alireza",Surname="Beyranvand",StudentCode = "1516171819"},
        };

        public IReadOnlyList<Student> StudentsList => Students;
    }
}
