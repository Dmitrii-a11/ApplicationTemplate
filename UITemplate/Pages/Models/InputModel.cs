using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UITemplate.Pages.Models
{
    public class InputModel : INotifyPropertyChanged
    {
        public InputModel()
        {
            text = "default text";
        }

        public string Text
        {
            get => text;

            set
            {
                text = value;
                OnPropertyChanged("");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private string text;
    }
}
