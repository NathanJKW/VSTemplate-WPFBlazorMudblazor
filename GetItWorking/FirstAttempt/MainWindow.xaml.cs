using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

namespace FirstAttempt;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var serviceCollection = new ServiceCollection();

        serviceCollection.AddFirstAttempt();

        Resources.Add("services", serviceCollection.BuildServiceProvider());
    }
}
