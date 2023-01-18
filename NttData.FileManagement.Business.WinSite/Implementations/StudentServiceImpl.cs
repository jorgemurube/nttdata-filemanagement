using NttData.FileManagement.Business.WinSite.Contracts;
using NttData.FileManagement.Common.Model;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NttData.FileManagement.DataAcces.Repository.Contracts;
using NttData.FileManagement.DataAcces.Repository.Implementations;
using System.Runtime.Remoting.Messaging;

namespace NttData.FileManagement.Business.WinSite.Implementations
{
    public class StudentServiceImpl : IStudentService
    {
        private IStudentRepository StudentRepository = new StudentRepositoryImpl();
        public bool Add(Student student)
        {
            int age = AgeCalculator(student);

            if (age > 0)
            {
                student.Age = age;
                IStudentRepository studentRepository = new StudentRepositoryImpl();
                studentRepository.Add(student);
            }
            return true;

        }


        public int AgeCalculator(Student student)
        {
            int edad = DateTime.Today.Year - student.Birthay.Year;
            if (DateTime.Today < student.Birthay.AddYears(edad))
                --edad;

            return edad;
        }
    }
}
