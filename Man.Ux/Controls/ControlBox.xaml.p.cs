using System.Windows;
using System.Windows.Input;

namespace stonkbot.Controls
{
    public partial class ControlBox
    {

        public static DependencyProperty CommandProperty = DependencyProperty.Register("Command", typeof(ICommand), typeof(ControlBox));
        public ICommand Command
        {
            get
            {
                return (ICommand)GetValue(CommandProperty);
            }
            set
            {
                SetValue(CommandProperty, value);
            }
        }

        #region ShowMaximize (DependencyProperty)

        /// <summary>
        /// A description of the property.
        /// </summary>
        public bool ShowMaximize
        {
            get { return (bool)GetValue(ShowMaximizeProperty); }
            set { SetValue(ShowMaximizeProperty, value); }
        }
        public static readonly DependencyProperty ShowMaximizeProperty =
            DependencyProperty.Register("ShowMaximize", typeof(bool), typeof(ControlBox),
            new PropertyMetadata(true, new PropertyChangedCallback(OnShowMaximizeChanged)));

        private static void OnShowMaximizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ControlBox)d).OnShowMaximizeChanged(e);
        }

        protected virtual void OnShowMaximizeChanged(DependencyPropertyChangedEventArgs e)
        {
            MaxButton.Visibility = (bool)e.NewValue ? Visibility.Visible : Visibility.Collapsed;
        }

        #endregion


        #region ShowMinimize (DependencyProperty)

        /// <summary>
        /// A description of the property.
        /// </summary>
        public bool ShowMinimize
        {
            get { return (bool)GetValue(ShowMinimizeProperty); }
            set { SetValue(ShowMinimizeProperty, value); }
        }
        public static readonly DependencyProperty ShowMinimizeProperty =
            DependencyProperty.Register("ShowMinimize", typeof(bool), typeof(ControlBox),
            new PropertyMetadata(true, new PropertyChangedCallback(OnShowMinimizeChanged)));

        private static void OnShowMinimizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ControlBox)d).OnShowMinimizeChanged(e);
        }

        protected virtual void OnShowMinimizeChanged(DependencyPropertyChangedEventArgs e)
        {
            MinButton.Visibility = (bool)e.NewValue ? Visibility.Visible : Visibility.Collapsed;
        }

        #endregion


        #region ShowExit (DependencyProperty)

        /// <summary>
        /// A description of the property.
        /// </summary>
        public bool ShowExit
        {
            get { return (bool)GetValue(ShowExitProperty); }
            set { SetValue(ShowExitProperty, value); }
        }
        public static readonly DependencyProperty ShowExitProperty =
            DependencyProperty.Register("ShowExit", typeof(bool), typeof(ControlBox),
            new PropertyMetadata(true, new PropertyChangedCallback(OnShowExitChanged)));

        private static void OnShowExitChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ControlBox)d).OnShowExitChanged(e);
        }

        protected virtual void OnShowExitChanged(DependencyPropertyChangedEventArgs e)
        {
            ExitButton.Visibility = (bool)e.NewValue ? Visibility.Visible : Visibility.Collapsed;
        }

        #endregion



    }
}
