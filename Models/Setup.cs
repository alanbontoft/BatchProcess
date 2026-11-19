using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BatchProcess.Models
{
    public partial class Setup : ObservableObject
    {
        [ObservableProperty]
        private string name;

        public Setup()
        {
            Name = "This is setup";
        }

    }
}
