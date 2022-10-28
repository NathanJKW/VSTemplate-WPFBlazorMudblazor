using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

namespace FirstAttempt
{
    public static class DependancyInjectionSetup
    {
        public static void AddFirstAttempt(this ServiceCollection serviceCollection)
        {
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddMudServices();
        }
    }
}
