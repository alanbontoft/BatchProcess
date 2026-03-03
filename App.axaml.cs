using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using System.Linq;
using Avalonia.Markup.Xaml;
using BatchProcess.ViewModels;
using BatchProcess.Views;
using Microsoft.Extensions.DependencyInjection;
using BatchProcess.Factories;
using System;
using BatchProcess.Models;

namespace BatchProcess;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {

        var collection = new ServiceCollection();

        collection.AddSingleton<MainWindowViewModel>();
        collection.AddTransient<HomePageViewModel>();
        collection.AddTransient<ProcessPageViewModel>();
        collection.AddTransient<ActionsPageViewModel>();
        collection.AddTransient<MacrosPageViewModel>();
        collection.AddTransient<ReporterPageViewModel>();
        collection.AddTransient<HistoryPageViewModel>();
        collection.AddTransient<SettingsPageViewModel>();

        // add a function to use the injected ServiceProvider (param x)
        // the switch then calls GetRequiredService with the type of ViewModel required 
        // this creates transient viewmodels on the fly as they are required
        collection.AddSingleton<Func<ApplicationPageNames, PageViewModelBase>>(x => name => name switch
        {
            ApplicationPageNames.HOME => x.GetRequiredService<HomePageViewModel>(),
            ApplicationPageNames.PROCESS => x.GetRequiredService<ProcessPageViewModel>(),
            ApplicationPageNames.ACTIONS => x.GetRequiredService<ActionsPageViewModel>(),
            ApplicationPageNames.MACROS => x.GetRequiredService<MacrosPageViewModel>(),
            ApplicationPageNames.REPORTER => x.GetRequiredService<ReporterPageViewModel>(),
            ApplicationPageNames.HISTORY => x.GetRequiredService<HistoryPageViewModel>(),
            ApplicationPageNames.SETTINGS => x.GetRequiredService<SettingsPageViewModel>(),
            _ => throw new InvalidOperationException()
        });

        // page factory to be injected into MainWindowViewModel
        collection.AddSingleton<PageFactory>();

        var services = collection.BuildServiceProvider();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Avoid duplicate validations from both Avalonia and the CommunityToolkit. 
            // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
            DisableAvaloniaDataAnnotationValidation();
            desktop.MainWindow = new MainWindow
            {
                DataContext = services.GetRequiredService<MainWindowViewModel>()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    private void DisableAvaloniaDataAnnotationValidation()
    {
        // Get an array of plugins to remove
        var dataValidationPluginsToRemove =
            BindingPlugins.DataValidators.OfType<DataAnnotationsValidationPlugin>().ToArray();

        // remove each entry found
        foreach (var plugin in dataValidationPluginsToRemove)
        {
            BindingPlugins.DataValidators.Remove(plugin);
        }
    }
}