using System.ComponentModel;

namespace ProjectCheckpoint.ViewModels.BaseClasses
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public string DisplayName { get; set; }
        #region INotifyPropertyChanged Members
        
        protected void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
