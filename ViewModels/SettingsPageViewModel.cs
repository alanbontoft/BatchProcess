using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using BatchProcess.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BatchProcess.ViewModels;

public partial class SettingsPageViewModel : PageViewModelBase
{
    public SettingsPageViewModel()
    {
        PageName = ApplicationPageNames.SETTINGS;
    }

    [RelayCommand]
    void Shutdown()
    {
        if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.Shutdown();
        }
    }
}
