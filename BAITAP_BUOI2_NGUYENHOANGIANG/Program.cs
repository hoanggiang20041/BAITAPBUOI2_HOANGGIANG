namespace BAITAP_BUOI2_NGUYENHOANGIANG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Tran Van An", Age = 15 },
                new Student { Id = 2, Name = "Nguyen Van Binh", Age = 17 },
                new Student { Id = 3, Name = "Tran The Anh", Age = 19 },
                new Student { Id = 4, Name = "Ho Van Cuong", Age = 14 },
                new Student { Id = 5, Name = "Bui Bich Diep", Age = 18 }
            };

            Console.WriteLine("Danh sach toan bo hoc sinh:");
            students.ForEach(student => Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}"));

            var studentsInAgeRange = students.Where(s => s.Age >= 15 && s.Age <= 18);
            Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
            foreach (var student in studentsInAgeRange)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            var studentsWithA = students.Where(s => s.Name.StartsWith("A"));
            Console.WriteLine("\nHoc sinh co ten bat dau bang chu 'A':");
            foreach (var student in studentsWithA)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

            int maxAge = students.Max(s => s.Age);
            var oldestStudents = students.Where(s => s.Age == maxAge);
            Console.WriteLine("\nHoc sinh co tuoi lon nhat:");
            foreach (var student in oldestStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            var sortedStudents = students.OrderBy(s => s.Age).ToList();
            Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
            sortedStudents.ForEach(student => Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}"));
        }
    }
}