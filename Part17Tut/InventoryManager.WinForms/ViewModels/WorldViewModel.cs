﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using InventoryManager.Data;
using System.Runtime.CompilerServices;

namespace InventoryManager.WinForms.ViewModels
{
    class WorldViewModel  : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Filename { get; set; }
        
        public World World { get; set; }

      

    }
}