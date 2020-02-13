
using System;

namespace theVetNetApi.Models
{
    public class BlockedUser
    {
        public uint blockedUserId {get; set;}
        //FK
        public uint privacySettingId {get; set;}
        public  DateTime whenBlocked {get; set;}
        public string? reasonBlocked {get; set;}

        //Navigation Properties
        public PrivacySetting PrivacySetting {get; set;}

    }
}