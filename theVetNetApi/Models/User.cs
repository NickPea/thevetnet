
using System;
using System.Collections.Generic;

namespace theVetNetApi.Models
{
    public class User
    {
        public uint userId {get; set;}
        public string userFirstName {get; set;}
        public string userLastName {get; set;}
        public string? userGender {get; set;}
        public DateTime? userDOB {get; set;}
        public ulong? userPhone {get; set;}
        public string? userEmail {get; set;}
        public string userPassword {get; set;}
        public string? userPhoto {get; set;}
        public bool jobSeekerFlag {get; set;}
        public bool isSeeking {get; set;}
        public string? positionSought {get; set;}
        public string? seekerDesc {get; set;}
        public string? resumeFileUpload {get; set;}
        public bool jobProviderFlag {get; set;}
        public bool isProviding {get; set;}
        public string? positionHeld {get; set;}
        public string? providerDesc {get; set;}

        //Navigation Properties
        public List<UserLog> UserLogs {get; set;}
        public PrivacySetting PrivacySetting {get; set;}
        public GeneralInfo GeneralInfo {get; set;}
        public List<Education> Educations {get; set;}
        public List<Registration> Registrations {get; set;}
        public List<Experience> Experiences {get; set;}
        public List<Referee> Referees {get; set;}
        public CompanyProfile CompanyProfile {get; set;}
        public List<BusinessProfile> BusinessProfiles {get; set;}
        public List<ApplyOffer> ApplyOffers {get; set;}
    }
}