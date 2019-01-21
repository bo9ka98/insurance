using Model;

namespace Presenter
{
    public static class Delegates
    {
        public delegate void VerificationUser(ControlUser controlUser);
        public delegate void TransmitDataIndividSatC(AliasMan aliasMan);
        public delegate void TransmitDataLegalSatC(AliasCompanu aliasCompanu);
        public delegate void TransmitDataIndividCatV(IndividClient nuturalClient);
        public delegate void TransmitDataLegalCatV(LegalСlient legalСlient);

    }

}
