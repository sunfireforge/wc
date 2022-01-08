using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace stonkbot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainViewModel MainView { get; set; }


        public MainWindow()
        {
            MainView = new MainViewModel();
            DataContext = MainView;

            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MainView.Start();
        }

        private void TitleRect_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                else
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                DragMove();
            }
        }
    }
}
