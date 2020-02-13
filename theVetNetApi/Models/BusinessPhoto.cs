namespace theVetNetApi.Models
{
    public class BusinessPhoto
    {
        public uint businessPhotoId {get; set;}
        public string? photoTitle {get; set;}
        public string photoFile {get; set;}

        //FK
        public uint businessId {get; set;}

        //Navigation Properties
        public BusinessProfile BusinessProfile {get; set;}
        


    }
}