
using System;
using System.Collections.Generic;

namespace theVetNetApi.Models
{
    public class JobAdvert
    {
        public uint jobAdvertId {get; set;}
        public DateTime whenCreated {get; set;}
        public string advertTitle {get; set;}
        public string jobRole {get; set;}
        public string employType {get; set;}
        public string? workHours {get; set;}
        public string? shortDesc {get; set;}
        public string? longDesc {get; set;}
        public string? renumeration {get; set;}
        public string? otherPerks {get; set;}
        public bool isDeleted {get; set;}

        //FK
        public uint businessId {get; set;}

        //Navigation Properties
        public BusinessProfile BusinessProfile {get; set;}
        public List<ApplyOffer> ApplyOffers {get; set;}
        public List<AdvertExtra> AdvertExtras {get; set;}
    }
}