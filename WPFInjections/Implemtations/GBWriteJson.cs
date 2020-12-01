using WPFInjections.Interfaces;

namespace WPFInjections.Implemtations
{
    public class GBWriteJson : IWriteJson, IGBLogicService
    {
        public string Insert()
        {
            return "Hej fra Write2Json";
        }
    }
}
