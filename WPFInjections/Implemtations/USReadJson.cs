using WPFInjections.Interfaces;

namespace WPFInjections.Implemtations
{
    public class USReadJson : IReadJson, IUSLogicService
    {
        public string Read()
        {
            return "Hej fra Write2Json";
        }
    }
}
