using LiveCharts;
using LiveCharts.Wpf;
using stonkbot.Behaviors;
using stonkbot.Controls;


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shell;
using System.Windows.Threading;

namespace stonkbot
{
    public partial class MainViewModel : DependencyObject
    {
        SoundPlayer alert;
        FlashWindowHelper flash;
        public MainViewModel()
        {

            flash = new FlashWindowHelper(Application.Current);
            alert = new SoundPlayer(@"C:\Windows\Media\Windows Proximity Notification.wav");
        }
        Task _messagePump;
        private Task _dataPump;

        public void CopyLog()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Output1)
            {
                if (item.IsSelected)
                {
                    sb.AppendLine(item.Value);
                }
            }

            Clipboard.SetDataObject(sb.ToString());
        }

        public void CutLog()
        {
            var itemsToRemove = Output1.Where(x => x.IsSelected).ToList();
            foreach (var item in itemsToRemove)
            {
                if (item.IsSelected)
                {
                    Output1.Remove(item);
                }
            }
        }

        public void Start()
        {
            _messagePump = Task.Factory.StartNew(MessagePump, TaskCreationOptions.LongRunning);
            _dataPump = Task.Factory.StartNew(DataPump, TaskCreationOptions.LongRunning);
        }

        public void DataPump()
        {
            while (true)
            {
                Thread.Sleep(_updateSpeed);
            }
        }

        public void MessagePump()
        {
            string message;
            while (true)
            {
                message = "baaaaap";
                Thread.Sleep(50);
            }
        }
    }
}
