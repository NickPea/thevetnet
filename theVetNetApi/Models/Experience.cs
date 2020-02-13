
using System;

namespace theVetNetApi.Models
{
    public class Experience
    {
        public uint experienceId {get; set;}
        public string position {get; set;}
        public string employType {get; set;}
        public DateTime whenStart {get; set;}
        public DateTime whenFinished {get; set;}
        public string? roleDesc {get; set;}
        
        //FK
        public uint userId {get; set;}
        //FK
        public uint? employerId {get; set;}
        
        //Navigation Properties
        public User User {get; set;}
        public Employer Employer {get; set;}
        
        
    }
}