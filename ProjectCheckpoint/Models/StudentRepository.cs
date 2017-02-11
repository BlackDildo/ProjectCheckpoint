using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace ProjectCheckpoint.Models
{
    public class StudentRepository : IRepository<Student>, ISearchRepository<Student>
    {
        private DataContext dataContext;

        public StudentRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Create(Student entity)
        {            
            dataContext.Student.Add(entity);
        }

        public void Delete(Student entity)
        {
            if (entity != null)
                dataContext.Student.Remove(entity);
        }

        public void Update(Student entity)
        {
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public Student GetById(int id)
        {
            return dataContext.Student.Where(stundet => stundet.StudentId == id).First();
        }

        public Student GetBySurname(string surname)
        {            
            return dataContext.Student.Where(student => student.Surname.ToLower().Trim().Contains(surname.ToLower().Trim())).First();
        }

        public Student GetByName(string name)
        {
            return dataContext.Student.Where(student => student.Name.ToLower().Trim().Contains(name.ToLower().Trim())).First();
        }

        public Student GetByPatronymic(string patronymic)
        {
            return dataContext.Student.Where(student => student.Patronymic.ToLower().Trim().Contains(patronymic.ToLower().Trim())).First();
        }

        public Student GetByRfidId(byte[] rfidId)
        {
            return dataContext.Student.Where(student => student.RfidId.SequenceEqual(rfidId)).First();
        }

        public Student GetByIIN(string IIN)
        {
            return dataContext.Student.Where(student => student.IIN == IIN).First();
        }

        public IQueryable<Student> GetAllRecords()
        {
            return dataContext.Student.Where(student => student.StudentId > 0);
        }

        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    dataContext.Dispose();
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~StudentRepository() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            GC.SuppressFinalize(this);
        }        
        #endregion
    }
}
