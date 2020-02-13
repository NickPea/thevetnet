
using System.Collections.Generic;

namespace theVetNetApi.Models
{
    public class PrivacySetting
    {
        public uint privacySettingId {get; set;}
        public bool isActive {get; set;}
        public bool stayLoggedIn {get; set;}
        public bool notificationsEnabled {get; set;}
        public bool isSearchable {get; set;}
        public bool detailsVisible {get; set;}
        public bool cookiesConsented {get; set;}
        public bool dataUsageConsent {get; set;}
        public bool userPhotoConsent {get; set;}

        //FK
        public uint userId {get; set;}

        //Navigation Properties
        public User User {get; set;}
        public List<BlockedUser> BlockedUsers {get; set;}
    }
}