using ProjectCheckpoint.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectCheckpoint.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthenticationWindow.xaml
    /// </summary>
    public partial class AuthenticationWindow : Window
    {

        private UnitOfWork _unitOfWork = new UnitOfWork();

        public AuthenticationWindow()
        {
            InitializeComponent();

            App.LanguageChanged += LanguageChanged;
            
            CultureInfo currLang = App.Language;

            //Заполняем меню смены языка:
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLanguage.Items.Add(menuLang);
            }
        }

        private void ChangeLanguageClick(object sender, RoutedEventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
        }

        private void LanguageChanged(object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            //Task.Factory.StartNew(() =>
            //{
            //    bool isExist = _unitOfWork.UserRepository.IsExits(loginInput.Text, passwordInput.Password);

            //    if (!isExist)
            //    {
            //        MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            //        return;
            //    }

            //});

            //Task<bool> task = new Task<bool>(S);
            //task.Start();

            //if (!task.Result)
            //{
            //    MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            //    return;
            //}        

            //string login = loginInput.Text;
            //string password = passwordInput.Password;

            //Task task = new Task(() =>
            //{
            //    if (!_unitOfWork.UserRepository.IsExits(login, password))
            //    {
            //        MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            //        return;
            //    }


            //    //Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, CreateWindow, null);


            //    //MainWindow mWindow = new MainWindow();
            //    //mWindow.Show();
            //    //this.Close();
            //});
            //task.Start();

            //var t = Task.Factory.StartNew(S);
            //t.ContinueWith(t1 => { MessageBox.Show(t1.Exception.InnerException.Message); }, System.Threading.CancellationToken.None, 
            //                                TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.FromCurrentSynchronizationContext());

            //exitButton.Command = ApplicationCommands.Close
            
            MainWindow mWindow = new MainWindow();
            mWindow.Show();
            this.Close();
        }

        private void CreateWindow()
        {
            MainWindow mWindow = new MainWindow();
            mWindow.Show();
            this.Close();
        }

        private void S()
        {
            //UnitOfWork _unitOfWork = new UnitOfWork();
            //return _unitOfWork.UserRepository.IsExits(loginInput.Text, passwordInput.Password);
            string login = loginInput.Text;
            string password = passwordInput.Password;
            
            if (!_unitOfWork.UserRepository.IsExits(login, password))
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            MainWindow mWindow = new MainWindow();
            mWindow.Show();
            this.Close();            
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {            
            //LoadingWindow lW = new LoadingWindow();
            //lW.Owner = this;
            //lW.Show();
        }

        private void CloseCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
