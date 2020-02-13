namespace theVetNetApi.Models
{
    public class MessageAttachment
    {
        public uint messageAttachId {get; set;}
        public string fileUpload {get; set;}

        //FK
        public uint messageId {get; set;}

        //Navigation Properties
        public Message Message {get; set;}
        
    }
}