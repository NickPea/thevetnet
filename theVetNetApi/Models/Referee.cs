namespace theVetNetApi.Models
{
    public class Referee
    {
        public uint refereeId {get; set;}
        public string refereeFirstName {get; set;}
        public string refereeLastName {get; set;}
        public ulong? refereePhone {get; set;}
        public string? refereeEmail {get; set;}
        public string? refereePosition {get; set;}
        public string refereeRelationship {get; set;}
        
        //FK
        public uint userId {get; set;}

        //Navigation Properties
        public User User {get; set;}
        
    }
}