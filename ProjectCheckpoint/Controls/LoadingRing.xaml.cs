using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ProjectCheckpoint.Controls
{
    /// <summary>
    /// Логика взаимодействия для LoadingRing.xaml
    /// </summary>
    public partial class LoadingRing : UserControl
    {        
        public Brush RingColor
        {
            get { return (Brush)GetValue(RingColorProperty); }
            set { SetValue(RingColorProperty, value); }
        }
                
        public static readonly DependencyProperty RingColorProperty =
                                        DependencyProperty.Register("RingColor", typeof(Brush), typeof(LoadingRing), new PropertyMetadata(Brushes.Transparent));        

        public Brush RingBorderColor
        {
            get { return (Brush)GetValue(RingBorderColorProperty); }
            set { SetValue(RingBorderColorProperty, value); }
        }
                
        public static readonly DependencyProperty RingBorderColorProperty =
                                        DependencyProperty.Register("RingBorderColor", typeof(Brush), typeof(LoadingRing), new PropertyMetadata(Brushes.Transparent));

        public LoadingRing()
        {
            InitializeComponent();
        }
    }
}
