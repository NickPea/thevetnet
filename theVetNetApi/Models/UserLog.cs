
using System;

namespace theVetNetApi.Models
{
    public class UserLog
    {
        public DateTime whenLogged {get; set;}
        public string loggedDetails {get; set;}

        //FK
        public uint userId {get; set;}

        //Navigation Properties
        public User User {get; set;}
        
    }
}