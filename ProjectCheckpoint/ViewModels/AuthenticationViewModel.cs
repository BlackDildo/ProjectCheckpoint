using ProjectCheckpoint.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace ProjectCheckpoint.ViewModels
{
    public class AuthenticationViewModel : INotifyPropertyChanged, ICommand
    {
        //private UnitOfWork unitOfWork;
                
        private string login;
        private string password;

        public string Login
        {
            get
            {
                return login;
            }

            set
            {                
                login = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Login"));
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public bool isExist(string login, string password)
        {
            return ApplicationViewModel.UnitOfWork.UserRepository.IsExits(login, password);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }


    }
}
