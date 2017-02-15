using ProjectCheckpoint.Models.Repository;
using System;

namespace ProjectCheckpoint.Models
{
    public class UnitOfWork : IDisposable
    {
        private DataContext dataContext = new DataContext();

        private StudentRepository studentRepository;
        private UserRepository userRepository;

        public StudentRepository StudentRepository
        {
            get
            {
                if (studentRepository == null)
                    studentRepository = new StudentRepository(dataContext);

                return studentRepository;
            }            
        }

        public UserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(dataContext);

                return userRepository;
            }
        }

        public void Save()
        {
            dataContext.SaveChanges();            
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
        // ~UnitOfWork() {
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
