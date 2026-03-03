using System.Diagnostics;
using BatchProcess.Factories;
using BatchProcess.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExCSS;

namespace BatchProcess.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{

    // page factory is injected into constructor
    private PageFactory _pageFactory;

    [ObservableProperty]
    private PageViewModelBase _currentPage;

    public MainWindowViewModel(PageFactory pageFactory)
    {
        _pageFactory = pageFactory;
        CurrentPage = _pageFactory.GetPageViewModel(Models.ApplicationPageNames.HOME);
    }

    [RelayCommand]
    private void SelectPage(object o)
    {
        var page = (string)o;

        switch (page)
        {
            case "HOME":
            default:
                CurrentPage = getModel(Models.ApplicationPageNames.HOME); break;
            case "PROCESS":
                CurrentPage = getModel(Models.ApplicationPageNames.PROCESS); break;
            case "ACTIONS":
                CurrentPage = getModel(Models.ApplicationPageNames.ACTIONS); break;
            case "MACROS":
                CurrentPage = getModel(Models.ApplicationPageNames.MACROS); break;
            case "REPORTER":
                CurrentPage = getModel(Models.ApplicationPageNames.REPORTER); break;
            case "HISTORY":
                CurrentPage = getModel(Models.ApplicationPageNames.HISTORY); break;
            case "SETTINGS":
                CurrentPage = getModel(Models.ApplicationPageNames.SETTINGS); break;
        }
    }

    // simple lambda function to create ViewModels using the Page Factory
    private PageViewModelBase getModel(ApplicationPageNames name) => _pageFactory.GetPageViewModel(name);

}