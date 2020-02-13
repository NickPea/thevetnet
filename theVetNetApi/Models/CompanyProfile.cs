
using System.Collections.Generic;

namespace theVetNetApi.Models
{
    public class CompanyProfile
    {
        public uint companyId {get; set;}
        public string companyName {get; set;}
        public string? companyOpenHours {get; set;}
        public string? companyDesc {get; set; }
        public ulong? ACN {get; set;}
        public string? companyAddress {get; set;}
        public string? companySuburb {get; set;}
        public string? companyCity {get; set;}
        public string? companyState {get; set;}
        public string? companyPostCode {get; set;}
        public string? companyCountry {get; set;}
        public ulong? companyPhone {get; set;}
        public ulong? companyFax {get; set;}
        public string? companyEmail {get; set;}
        public string? companyLogoFile {get; set;}
        public string? companySlogan {get; set;}
        public string? companyWebsite {get; set;}
        public string? companySocialMedia {get; set;}

        //FK
        public uint userId {get; set;}

        //Navigation Properties
        public User User {get; set;}
        public List<CompanyPhoto> CompanyPhotos {get; set;}
        
    }
}