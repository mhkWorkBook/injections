using WPFInjections.Interfaces;

namespace WPFInjections.Implemtations
{
    public class EUWriteJson : IWriteJson, IEULogicService
    {
        public string Insert()
        {
            return "Hej fra Write2Json";
        }
    }
}
