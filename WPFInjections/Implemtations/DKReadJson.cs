using WPFInjections.Interfaces;

namespace WPFInjections.Implemtations
{

    public class DKReadJson : IReadJson, IDKLogicService
    {
        public string Read()
        {
            return "Hej hej";
        }
    }
}
