using ProjectCheckpoint.ViewModels.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCheckpoint.Models
{
    public class CurrentStudent : ViewModelBase
    {
        public int StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
                base.RaisePropertyChanged("StudentId");
            }
        }

        public byte[] RfidId
        {
            get
            {
                return rfidId;
            }
            set
            {
                rfidId = value;
                base.RaisePropertyChanged("RfidId");
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
                base.RaisePropertyChanged("Surname");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                base.RaisePropertyChanged("Name");
            }
        }

        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                patronymic = value;
                base.RaisePropertyChanged("Patronymic");
            }
        }

        public string IIN
        {
            get
            {
                return iin;
            }
            set
            {
                iin = value;
                base.RaisePropertyChanged("IIN");
            }
        }

        public byte[] Photo
        {
            get
            {
                return photo;
            }
            set
            {
                photo = value;
                base.RaisePropertyChanged("Photo");
            }
        }

        private int studentId;
        private byte[] rfidId;
        private string surname;
        private string name;
        private string patronymic;
        private string iin;
        private byte[] photo;
    }
}
