using WPFInjections.Interfaces;

namespace WPFInjections.Implemtations
{
    public class EUReadJson : IReadJson, IEULogicService
    {
        public string Read()
        {
            return "Hej fra Write2Json";
        }
    }
}
