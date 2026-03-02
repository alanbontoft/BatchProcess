using BatchProcess.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BatchProcess.ViewModels;

public partial class SettingsPageViewModel : PageViewModelBase
{
    public SettingsPageViewModel()
    {
        PageName = ApplicationPageNames.SETTINGS;
    } 
}
