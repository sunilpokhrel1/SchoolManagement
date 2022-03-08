using SchoolManagement.Core;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly Context context;

        public StudentRepo()
        {
            context = new Context();
        }
        public void Add(Student data)
        {

            context.Student.Add(data);
            context.SaveChanges();
        }

        public Student GetById(int id)
        {
            return context.Student.Find(id);
        }

        public List<Student> GetList()
        {
            return context.Student.ToList();
        }

        public void Update(Student data)
        {
            var entity = GetById(data.Id);
            //entity.Name = data.Name;
            //entity.Contact = data.Contact;
            //entity.Contact = data.Contact;
            //entity.Email = data.Email;
            //entity.Address = data.Address;
            //entity.Department = data.Department;
            //entity.Batch = data.Batch;
            //entity.AddmissionDate = data.AddmissionDate;
            //entity.RollNo = data.RollNo;

            context.Entry(entity).State = EntityState.Detached;
            context.Student.Attach(data);

            context.Entry(data).State = EntityState.Modified;

            context.SaveChanges();


        }

        public void Delete(int id)
        {
            var entity = context.Student.Find(id);
            context.Student.Remove(entity);
            context.SaveChanges();


        }
        //public void Delete(Student id)
        //{
        //    var entity = context.Student.Find(id);
        //    context.Student.Remove(entity);
        //    context.SaveChanges();

        //}
    }
}
