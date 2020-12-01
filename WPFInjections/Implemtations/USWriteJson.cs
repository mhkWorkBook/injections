using WPFInjections.Interfaces;

namespace WPFInjections.Implemtations
{
    public class USWriteJson : IWriteJson, IUSLogicService
    {
        public string Insert()
        {
            return "Hej fra Write2Json";
        }
    }
}
