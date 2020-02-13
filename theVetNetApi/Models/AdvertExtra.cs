
using System;

namespace theVetNetApi.Models
{
    public class AdvertExtra
    {
        //FK
        public uint jobAdvertId {get; set;}
        //FK
        public string featureType {get; set;}
        public DateTime whenPurchased {get; set;}

        //Navigation Properties
        public JobAdvert JobAdvert {get; set;}
        public ExtraFeature ExtraFeature {get; set;}

    }
}