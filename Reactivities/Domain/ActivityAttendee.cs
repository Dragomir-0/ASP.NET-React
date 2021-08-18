using System;

namespace Domain
{
    public class ActivityAttendee
    {
        public string AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public Guid ActivityID { get; set; }
        public Activity Activity { get; set; }
        public bool IsHost { get; set; }
    }
}