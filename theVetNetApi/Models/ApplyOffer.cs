using System;
using System.Collections.Generic;


namespace theVetNetApi.Models
{
    public class ApplyOffer
    {
        //FK
        public uint? userId { get; set; }
        //FK
        public uint jobAdvertId { get; set; }
        public uint createdBy {get; set;}
        public bool isAccepted {get; set;}
        public bool isDeleted {get; set;}
        public DateTime whenCreated {get; set;}

        //Navigation Properties
        public User User {get; set;}
        public JobAdvert JobAdvert {get; set;}
        public List<Message> Messages {get; set;}
        




    }
}