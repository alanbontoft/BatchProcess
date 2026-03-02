using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BatchProcess.ViewModels;

public partial class PageViewModelBase : ViewModelBase
{
    [ObservableProperty]
    private string _title;
}
