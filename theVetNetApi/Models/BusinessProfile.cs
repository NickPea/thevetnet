
using System.Collections.Generic;

namespace theVetNetApi.Models
{
    public class BusinessProfile
    {
        public uint businessId {get; set;}
        public ulong? ABN {get; set;}
        public string businessName {get; set;}
        public string? businessLogoFile {get; set;}
        public string? businessSlogan {get; set;}
        public string businessType {get; set;}
        public string? businessDesc {get; set;}
        public string? businessAddress {get; set;}
        public string? businessSuburb {get; set;}
        public string? businessCity {get; set;}
        public string? businessState {get; set;}
        public string? businessPostCode {get; set;}
        public string? businessCountry {get; set;}
        public ulong? businessPhone {get; set;}
        public ulong? businessFax {get; set;}
        public string? businessEmail {get; set;}
        public string? businessWebsite {get; set;}
        public bool isDeleted {get; set;}

        //FK
        public uint userId {get; set;}

        //Navigation Properties
        public User User {get; set;}
        public List<BusinessPhoto> BusinessPhotos {get; set;}
        public List<JobAdvert> jobAdverts {get; set;}
        
        
    }
}