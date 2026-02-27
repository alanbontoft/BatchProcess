using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExCSS;

namespace BatchProcess.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private int _count = 0;
    
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";

    [RelayCommand]
    private void Home()
    {
        Debug.WriteLine("HOME");
        Count++;
    }
}