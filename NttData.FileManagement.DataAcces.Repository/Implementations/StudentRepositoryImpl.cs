using NttData.FileManagement.Common.Model;
using NttData.FileManagement.DataAcces.Repository.Contracts;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttData.FileManagement.DataAcces.Repository.Implementations
{
    public class StudentRepositoryImpl : IStudentRepository
    {
        public bool Add(Student student)
        {
            string path = ConfigurationManager.AppSettings.Get("FileStudentPath");


            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                    sw.WriteLine(student.ToString());
                
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(student.ToString());
                }
            }

            return true;
        }
    }
}
