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

        /// <summary>
        /// This is an useless command with useless summary :)
        /// </summary>
        public ICommand UselessCommand { get; set; }
        public ICommand ItemNameChangeCommand { get; set; }

        public ViewModel()
        {
            Item = new Item();
            ClearCommand = new Command(HandleClearCommand);
            UselessCommand = new Command(HandleUselessCommand);
            ItemNameChangeCommand = new Command(HandleItemNameChangeCommand);
        }

        void HandleItemNameChangeCommand()
        {
            Item.Name = "BotoTocat";
        }

        void HandleClearCommand()
        {
            Item.Name = string.Empty;
        }

        void HandleUselessCommand()
        {
            Item.Name = "Now I'm useless";
        }
    }
}
