using WPFInjections.Interfaces;

namespace WPFInjections.Implemtations
{
    public class GBReadJson : IReadJson, IGBLogicService
    {
        public string Read()
        {
            return "Hej fra Write2Json";
        }
    }
}
