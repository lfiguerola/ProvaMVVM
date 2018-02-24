using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaMVVM.Model
{
    public class Item : BaseModel
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public Item()
        {
            Name = "Unknown...";
        }
    }
}
