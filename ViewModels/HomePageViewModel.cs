using BatchProcess.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BatchProcess.ViewModels;

public partial class HomePageViewModel : PageViewModelBase
{
    public HomePageViewModel()
    {
        PageName = ApplicationPageNames.HOME;
    } 
}
