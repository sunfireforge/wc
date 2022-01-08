using stonkbot.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace stonkbot
{
    public partial class MainViewModel
    {
        public ICommand _startCommand;
        public ICommand StartCommand
        {
            get
            {
                if (_startCommand == null)
                {
                    _startCommand = new RelayCommand(
                        x => throw new NotImplementedException(),
                        x => false
                    );
                }

                return _startCommand;
            }

        }

        ICommand _enableCommand;
        public ICommand EnableCommand
        {
            get
            {
                if (_enableCommand == null)
                {
                    _enableCommand = new RelayCommand(
                        x => throw new NotImplementedException(),
                        x => false
                        );
                }
                return _enableCommand;
            }
        }

        ICommand _disableCommand;
        public ICommand DisableCommand
        {
            get
            {
                if (_disableCommand == null)
                {
                    _disableCommand = new RelayCommand(
                        x => throw new NotImplementedException(),
                        x => false
                        );
                }
                return _disableCommand;
            }
        }

        ICommand _copyLogCommand;
        public ICommand CopyLogCommand
        {
            get
            {
                if (_copyLogCommand == null)
                {
                    _copyLogCommand = new RelayCommand(
                            x => CopyLog()
                        );
                }
                return _copyLogCommand;
            }
        }

        ICommand _cutLogCommand;
        public ICommand CutLogCommand
        {
            get
            {
                if (_cutLogCommand == null)
                {
                    _cutLogCommand = new RelayCommand(
                            x => CutLog()
                        );
                }
                return _cutLogCommand;
            }
        }
    }
}
