
using System;

namespace theVetNetApi.Models
{
    public class Registration
    {
        public uint registrationId {get; set;}
        public string governingBody {get; set;}
        public string regoType {get; set;}
        public string? regoNumber {get; set;}
        public string regoStatus {get; set;}
        public DateTime? whenRenewal {get; set;}
        public string? regoVerificationDocument {get; set;}
        
        //FK
        public uint userId {get; set;}
        
        //Navigation Properties
        public User User {get; set;}
        
    }
}