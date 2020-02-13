
using System;
using System.Collections.Generic;

namespace theVetNetApi.Models
{
    public class Message
    {
        public uint messageId {get; set;}
        public uint createdBy {get; set;}
        public DateTime whenCreated {get; set;}
        public bool isViewed {get; set;}
        public string? messageTitle {get; set;}
        public string messageBody {get; set;}

        //FK
        public uint userId {get; set;}
        //FK
        public uint jobAdvertId {get; set;}

        //Navigation Properties
        public ApplyOffer ApplyOffer {get; set;}
        public List<MessageAttachment> MessageAttachments {get; set;}
        
        



    }
}