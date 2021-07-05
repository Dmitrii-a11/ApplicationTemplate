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
            inputViewModel = new Pages.ViewModels.InputViewModel();
            resultViewModel = new Pages.ViewModels.ResultViewModel();

            selectedView = inputViewModel;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnProperryChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private object selectedView;

        private Pages.ViewModels.InputViewModel inputViewModel;
        private Pages.ViewModels.ResultViewModel resultViewModel;

        private RelayCommand showInputCommand;
        private RelayCommand showResultCommand;

        public RelayCommand ShowInputCommand
        {
            get
            {
                return showInputCommand ??= new RelayCommand(() =>
                  {
                      SelectedView = inputViewModel;
                  }, () =>
                  {
                      return inputViewModel != null;
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
                      SelectedView = resultViewModel;
                  }, () =>
                  {
                      return resultViewModel != null;
                  });
            }
        }

        public object SelectedView
        {
            get => selectedView;

            set
            {
                selectedView = value;
                OnProperryChanged("");
            }
        }
    }
}
