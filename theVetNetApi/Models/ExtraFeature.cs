
using System.Collections.Generic;

namespace theVetNetApi.Models
{
    public class ExtraFeature
    {

        public string featureType {get; set;}
        public string featureDesc {get; set;}
        public decimal featureCost {get; set;}
        public uint featureDuration {get; set;}

        //Navigation Properties
        public List<AdvertExtra> AdvertExtras {get; set;}
        
    }
}