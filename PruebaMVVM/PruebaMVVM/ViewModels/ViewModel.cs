using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PruebaMVVM.Model;
using Xamarin.Forms;

namespace PruebaMVVM.ViewModels
{
    public class ViewModel : BindableObject
    {
        private Item _item;

        public Item Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }

        public ICommand ClearCommand { get; set; }  

        public ViewModel()
        {
            Item = new Item();
            ClearCommand = new Command(HandleClearCommand);
        }

        void HandleClearCommand()
        {
            Item.Name = string.Empty;
        }
    }
}
