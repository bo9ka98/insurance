using Model;

namespace Presenter
{
    public static class Delegates
    {
        public delegate void TransmitDataOfSearchAtCreatNuturalClient(string surname, string name, string middlename);
        public delegate void TransmitDataOfSearchAtCreatLegalClient(string organisationName, string utn);
        public delegate void TransmitDataOfCreatAtVisualizeNuturalClient(NuturalClient nuturalClient);
    }

}
