using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectCheckpoint.Models;

namespace ProjectCheckpoint.ViewModels
{
    public class ApplicationViewModel
    {
        public static UnitOfWork UnitOfWork
        {
            get
            {
                if (unitOfWork == null)
                    unitOfWork = new UnitOfWork();

                return unitOfWork;
            }
        }

        private static UnitOfWork unitOfWork;

        //private UnitOfWork unitOfWork = new UnitOfWork();                
    }
}
