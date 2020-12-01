using WPFInjections.Interfaces;

namespace WPFInjections.Implemtations
{
    public class DKWriteJson : IWriteJson, IDKLogicService
    {
        public string Insert()
        {
            return "hej hej";
        }
    }
}
