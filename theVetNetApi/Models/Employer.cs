namespace theVetNetApi.Models
{
    public class Employer
    {
        public uint employerId {get; set;}
        public string employerName {get; set;}
        public string employerAddress {get; set;}
        public string employerSuburb {get; set;}
        public string employerCity {get; set;}
        public string employerState {get; set;}
        public string employerPostCode {get; set;}
        public string employerCountry {get; set;}
        public ulong employerContact {get; set;}
        
        //Navigation Properties
        public Experience Experience {get; set;}
        
    }
}