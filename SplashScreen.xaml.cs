using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Certiflyte
{
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

    

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            double targetWidth = this.ActualWidth - 40; // Adjusted for margin

            DoubleAnimation progressAnimation = new DoubleAnimation
            {
                From = 0,
                To = targetWidth,
                Duration = TimeSpan.FromSeconds(3),
                FillBehavior = FillBehavior.HoldEnd
            };

            LoadingBarFill.BeginAnimation(WidthProperty, progressAnimation);
            
        }
    }
}
