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
    private ViewModelBase _currentPage;

    private readonly HomePageViewModel _homePage = new();
    private readonly ProcessPageViewModel _processPage = new();
    private readonly ActionsPageViewModel _actionsPage = new();
    private readonly MacrosPageViewModel _macrosPage = new();
    private readonly ReporterPageViewModel _reporterPage = new();
    private readonly HistoryPageViewModel _historyPage = new();
    private readonly SettingsPageViewModel _settingsPage = new();

    [RelayCommand]
    private void SelectPage(object o)
    {
        var page = (string)o;

        switch (page)
        {
            case "HOME":
            default:
                CurrentPage = _homePage; break;
            case "PROCESS":
                CurrentPage = _processPage; break;
            case "ACTIONS":
                CurrentPage = _actionsPage; break;
            case "MACROS":
                CurrentPage = _macrosPage; break;
            case "REPORTER":
                CurrentPage = _reporterPage; break;
            case "HISTORY":
                CurrentPage = _historyPage; break;
            case "SETTINGS":
                CurrentPage = _settingsPage; break;
        }
    }

    [RelayCommand]
    private void Home()
    {
        CurrentPage = _homePage;
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

    public MainWindowViewModel()
    {
        CurrentPage = _homePage;
    }
}