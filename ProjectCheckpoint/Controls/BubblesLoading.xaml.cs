using System.Web.Mvc;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ProjectCheckpoint.Controls
{
    /// <summary>
    /// Логика взаимодействия для BubblesLoading.xaml
    /// </summary>
    public partial class BubblesLoading : UserControl
    {
        public bool IsStart
        {
            get { return (bool)GetValue(IsStartProperty); }
            set { SetValue(IsStartProperty, value); }
        }
                
        public static readonly DependencyProperty IsStartProperty =
                    DependencyProperty.Register("IsStart", typeof(bool), typeof(BubblesLoading), new PropertyMetadata(false));

        public Brush BubblesColor
        {
            get { return (Brush)GetValue(BubblesColorProperty); }
            set { SetValue(BubblesColorProperty, value); }
        }
                
        public static readonly DependencyProperty BubblesColorProperty =
                        DependencyProperty.Register("BubblesColor", typeof(Brush), typeof(BubblesLoading), new PropertyMetadata(Brushes.White));


        public Brush BubblesBorderColor
        {
            get { return (Brush)GetValue(BubblesBorderColorProperty); }
            set { SetValue(BubblesBorderColorProperty, value); }
        }
                
        public static readonly DependencyProperty BubblesBorderColorProperty =
                        DependencyProperty.Register("BubblesBorderColor", typeof(Brush), typeof(BubblesLoading), new PropertyMetadata(null));

        public static readonly RoutedEvent StartLoading = EventManager.RegisterRoutedEvent("Loading", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(BubblesLoading));

        public event RoutedEventHandler Loading
        {
            add { AddHandler(StartLoading, value); }
            remove {RemoveHandler(StartLoading, value); }
        }

        public void RaiseStartLoading()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(StartLoading);
            Ellipse1.RaiseEvent(newEventArgs);
        }

        public BubblesLoading()
        {
            InitializeComponent();
        }                
    }
}
