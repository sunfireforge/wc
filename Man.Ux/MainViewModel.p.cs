using LiveCharts;
using LiveCharts.Wpf;
using stonkbot.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace stonkbot
{
    public partial class MainViewModel
    {
        ObservableCollection<Selectable<string>> _output1;
        public ObservableCollection<Selectable<string>> Output1
        {
            get
            {
                if (_output1 == null)
                {
                    _output1 = new ObservableCollection<Selectable<string>>();
                }
                return _output1;
            }
        }

        ObservableCollection<KeyValuePair<string, string>> _output2;
        public ObservableCollection<KeyValuePair<string, string>> Output2
        {
            get
            {
                if (_output2 == null)
                {
                    _output2 = new ObservableCollection<KeyValuePair<string, string>>();
                }
                return _output2;
            }
        }

        ObservableCollection<KeyValuePair<string, string>> _output3;
        public ObservableCollection<KeyValuePair<string, string>> Output3
        {
            get
            {
                if (_output3 == null)
                {
                    _output3 = new ObservableCollection<KeyValuePair<string, string>>();
                }
                return _output3;
            }
        }

        AxesCollection _axesCollection;
        public AxesCollection AxesCollection
        {
            get
            {
                if (_axesCollection == null)
                {
                    _axesCollection = new AxesCollection();
                }

                return _axesCollection;
            }
            set
            {
                _axesCollection = value;
            }
        }

        SeriesCollection _seriesCollection;
        public SeriesCollection SeriesCollection
        {
            get
            {
                if (_seriesCollection == null)
                {
                    _seriesCollection = new SeriesCollection();
                }

                return _seriesCollection;
            }
            set
            {
                _seriesCollection = value;
            }
        }

        public ChartValues<double> PriceValues { get; set; } = new ChartValues<double>();
        public ChartValues<double> StopValues { get; set; } = new ChartValues<double>();
        public ChartValues<double> TargetValues { get; set; } = new ChartValues<double>();
        public ChartValues<double> FillValues { get; set; } = new ChartValues<double>();

        public ChartValues<double> Indicator1Values { get; set; } = new ChartValues<double>();

        public ChartValues<double> Indicator01Values { get; set; } = new ChartValues<double>();
        public ChartValues<double> Indicator02Values { get; set; } = new ChartValues<double>();
        public ChartValues<double> Indicator03Values { get; set; } = new ChartValues<double>();





        int _updateSpeed = 100;
        public string UpdateSpeed
        {
            get
            {
                return _updateSpeed.ToString();
            }
            set
            {
                if (int.TryParse(value, out int newvalue))
                {
                    _updateSpeed = newvalue;
                }
                else
                {
                    _updateSpeed = 100;
                }

            }
        }

        public bool AlertEnabled { get; set; }



    }
}
