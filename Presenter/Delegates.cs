using Model;
using Model.entity;

namespace Presenter
{
    public static class Delegates
    {
        public delegate void VerificationUser(ControlUser controlUser);
        public delegate void RegistrPoliceCategori(PoliceCategori policeCategori);
        public delegate void RegistrInsuranceCases(InsuranceCases insuranceCases);

        public delegate void TransmitDataIndividSatC(AliasMan aliasMan);
        public delegate void TransmitDataLegalSatC(AliasCompanu aliasCompanu);
        public delegate void TransmitDataIndividCatV(IndividClient nuturalClient);
        public delegate void TransmitDataLegalCatV(LegalСlient legalСlient);

    }

}
