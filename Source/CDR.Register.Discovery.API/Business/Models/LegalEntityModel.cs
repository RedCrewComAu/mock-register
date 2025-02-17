﻿namespace CDR.Register.Discovery.API.Business.Models
{
    public class LegalEntityModel
    {
        public string LegalEntityId { get; set; }
        public string LegalEntityName { get; set; }
        public string LogoUri { get; set; }
        public string RegistrationNumber { get; set; }
        public string RegistrationDate { get; set; }
        public string RegisteredCountry { get; set; }
        public string Abn { get; set; }
        public string Acn { get; set; }
        public string Arbn { get; set; }
        public string IndustryCode { get; set; }
        public string OrganisationType { get; set; }
    }
}
