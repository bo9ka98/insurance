using Model;

namespace Presenter
{
    public static class Delegates
    {
        public delegate void TransmitDataOfSearchAtCreatNuturalClient(string surname, string name, string middlename);
        public delegate void TransmitDataOfSearchAtCreatLegalClient(AliasCompanu aliasCompanu);
        public delegate void TransmitDataOfCreatAtVisualizeNuturalClient(NuturalClient nuturalClient);
        public delegate void TransmitDataOfCreatAtVisualizeLegalClient(LegalСlient legalСlient);
    }

}
