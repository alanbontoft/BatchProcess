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
    
    [RelayCommand]
    private void Process()
    {
        Debug.WriteLine("PROCESS");
    }
    
    [RelayCommand]
    private void Actions()
    {
        Debug.WriteLine("ACTIONS");
    }
    
    [RelayCommand]
    private void Macros()
    {
        Debug.WriteLine("MACROS");
    }
    
    [RelayCommand]
    private void Reporter()
    {
        Debug.WriteLine("REPORTER");
    }
    
    [RelayCommand]
    private void History()
    {
        Debug.WriteLine("HISTORY");
    }
    
    [RelayCommand]
    private void Settings()
    {
        Debug.WriteLine("SETTINGS");
    }
}