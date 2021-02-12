using Microsoft.Extensions.Configuration;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Threading;
using WPF_GUI_04.Controls;
using WPF_GUI_04.Pages;

namespace WPF_GUI_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IConfiguration config) // IConfiguration config
        {
            InitializeComponent();

            this.frame.Content = new EditorPage();
            // this.frame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed) this.DragMove();
        }

        private void OnBtnCloseClicked(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void OnMenuButtonClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menü clicked");
        }

        private void OnBtnMenuItemClicked(object sender, MouseButtonEventArgs e)
        {
            // MessageBox.Show("Hallo Fabian Clicked");

            MenuButton menuButton = e.Source as MenuButton;
            string name = menuButton.Name;

            switch(name)
            {
                case "btnRover":
                    this.frame.Content = new EditorPage();
                    break;

                case "btnAtom":
                    this.frame.Content = new EditorPage();
                    break;

                case "btnStation":
                    this.frame.Content = new EditorPage();
                    break;

                case "btnSaturn":
                    this.frame.Content = new EditorPage();
                    break;

                case "btnSolarSystem":
                    this.frame.Content = new EditorPage();
                    break;

                case "btnRocket":
                    this.frame.Content = new EditorPage();
                    break;

                case "btnMarsianer":
                    this.frame.Content = new SettingsPage();
                    break;
            }
        }










        /// //////////////////////////////////////////////////////////////////////
        /// //////////////////////////////////////////////////////////////////////
        /// //////////////////////////////////////////////////////////////////////

        //private void MainFrame_OnNavigating(object sender, NavigatingCancelEventArgs e)
        //{
        //    Duration _duration = new Duration(TimeSpan.FromSeconds(1));
        //    DoubleAnimation animation0 = new DoubleAnimation();
        //    animation0.From = frame.ActualWidth;
        //    animation0.To = 0;
        //    animation0.Duration = _duration;
        //    // animation0.Completed += SlideCompleted;
        //    // frame.BeginAnimation(WidthProperty, animation0);

        //    (e.Content as Page).BeginAnimation(WidthProperty, animation0);
        //}


        
        // https://stackoverflow.com/questions/2135113/how-do-you-do-transition-effects-using-the-frame-control-in-wpf
        private void MainFrame_OnNavigating(object sender, NavigatingCancelEventArgs e)
        {
            var ta = new ThicknessAnimation();
            ta.Duration = TimeSpan.FromSeconds(0.3);
            ta.DecelerationRatio = 0.7;
            ta.To = new Thickness(0, 0, 0, 0);

            if (e.NavigationMode == NavigationMode.New)
            {
                ta.From = new Thickness(500, 0, 0, 0);
            }
            else if (e.NavigationMode == NavigationMode.Back)
            {
                ta.From = new Thickness(0, 0, 500, 0);
            }

            (e.Content as Page).BeginAnimation(MarginProperty, ta);
        }
        
    }
}