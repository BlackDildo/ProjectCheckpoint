using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProjectCheckpoint.Models;
using System.Threading.Tasks;


namespace ProjectCheckpoint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        public MainWindow()
        {
            InitializeComponent();            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student()
            {
                Surname = "asd",
                Name = "dsfa"
            };
            
            unitOfWork.StudentRepository.Create(student);
            unitOfWork.Save();
            //Task<Student> task = new Task<Student>(() => unitOfWork.StudentRepository.GetById(2));            
            //task.Start();
                        
            //Student student = unitOfWork.StudentRepository.GetById(2);
            //Title = student.Name;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Report<Student> report = new Report<Student>();
            //report.Create(unitOfWork.StudentRepository.GetAllRecords());
        }
    }
}
