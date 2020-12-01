using Microsoft.Extensions.DependencyInjection;
using WPFInjections.ViewModels;

namespace WPFInjections
{
    public class ViewModelLocator
    {
        public MainWindowViewModel MainWindowViewModel
            => App.ServiceProvider.GetRequiredService<MainWindowViewModel>();
    }
}
