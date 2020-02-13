
using System;

namespace theVetNetApi.Models
{
    public class Education
    {
        public uint educationId {get; set;}
        public string Institution {get; set;}
        public string Qualification {get; set;}
        public string enrollmentStatus {get; set;}
        public DateTime? whenCommenced {get; set;}
        public DateTime? whenGraduated {get; set;}
        public string? eduShortDesc {get; set;}
        public string? eduVerificationDocument {get; set;}
        
        //FK
        public uint userId {get; set;}

        //Navigation Properties
        public User User {get; set;}
        
    }
}