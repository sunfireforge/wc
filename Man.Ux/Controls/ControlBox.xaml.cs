using System;
using System.Windows;
using System.Windows.Controls;

namespace stonkbot.Controls
{
    /// <summary>
    /// Interaction logic for ControlBox.xaml
    /// </summary>
    public partial class ControlBox : UserControl
    {

        public event EventHandler<ControlBoxEventArgs> ButtonClick;


        public ControlBox()
        {
            InitializeComponent();
        }

        void OnButtonClick(Buttons buttonName)
        {
            if (this.Command != null && this.Command.CanExecute(buttonName))
            {
                this.Command.Execute(buttonName);
            }

            if (this.ButtonClick != null)
            {
                this.ButtonClick(this, new ControlBoxEventArgs(buttonName));
            }
        }

        private void MinButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
            //OnButtonClick(Buttons.Minimize);
        }

        private void MaxButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
            //OnButtonClick(Buttons.Maximize);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            //OnButtonClick(Buttons.Exit);
        }

    }

    public enum Buttons
    {
        Minimize,
        Maximize,
        Exit,
    }

    public class ControlBoxEventArgs : EventArgs
    {
        public ControlBoxEventArgs(Buttons button)
        {
            this.Button = button;
        }

        public Buttons Button
        {
            get;
            set;
        }
    }
}
