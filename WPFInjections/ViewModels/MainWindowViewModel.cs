using WPFInjections.Interfaces;

namespace WPFInjections.ViewModels
{
    public class MainWindowViewModel
    {
        private readonly IWriteJson _writeJson;

        public MainWindowViewModel(IWriteJson writeJson)
        {
            _writeJson = writeJson;

            var s = _writeJson.Insert();
        }
    }
}
