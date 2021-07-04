using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UITemplate
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            ViewCollection = new Dictionary<string, UserControl>()
            {
                { "InputView", new Pages.Views.InputUserControl()  },
                { "ResultView", new Pages.Views.ResultUserControl() }
            };

            selectedView = ViewCollection.First().Value;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnProperryChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private UserControl selectedView;

        private RelayCommand showInputCommand;
        private RelayCommand showResultCommand;

        public RelayCommand ShowInputCommand
        {
            get
            {
                return showInputCommand ??= new RelayCommand(() =>
                  {
                      SelectedView = ViewCollection["InputView"];
                  }, () =>
                  {
                      return ViewCollection.Keys.Contains("InputView");
                  }
                );
            }
        }

        public RelayCommand ShowResultCommand
        {
            get
            {
                return showResultCommand ??= new RelayCommand(() =>
                  {
                      SelectedView = ViewCollection["ResultView"];
                  }, () =>
                  {
                      return ViewCollection.Keys.Contains("ResultView");
                  });
            }
        }

        public UserControl SelectedView
        {
            get => selectedView;

            set 
            {
                selectedView = value;
                OnProperryChanged("");
            }
        }

        public Dictionary<string, UserControl> ViewCollection { get; }
    }
}
