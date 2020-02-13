namespace theVetNetApi.Models
{
    public class GeneralInfo
    {
        public uint generalInfoId {get; set;}
        public string? careerObjectives {get; set;}
        public string? skills {get; set;}
        public string? achievements {get; set;}
        public string? interests {get; set;}
        
        //FK
        public uint userId {get; set;}

        //Navigation Properties
        public User User {get; set;}


    }
}