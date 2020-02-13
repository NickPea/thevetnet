namespace theVetNetApi.Models
{
    public class CompanyPhoto
    {
        public uint companyPhotoId {get; set;}
        public string? photoTitle {get; set;}
        public string photoFile {get; set;}

        //FK
        public uint companyId {get; set;}
        
        //Navigation Properties
        public CompanyProfile CompanyProfile {get; set;}
    }
}