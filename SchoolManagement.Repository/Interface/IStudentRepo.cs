using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repository
{
    public interface IStudentRepo
    {
        void Add(Student data);
        void Update(Student data);
        List<Student> GetList();
        Student GetById(int id);

       void Delete(int id);
      // void Delete(Student id);

       // Student Delete(Student id);

    }
}
