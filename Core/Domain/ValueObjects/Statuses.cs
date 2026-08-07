namespace Domain.ValueObjects
    {
        public enum StudentStatus
        {
            Active,
            Inactive,
            Suspended
        }
        public enum ClassStatus
        {
            Active,
            Full,
            Ongoing,
            Deleted
        }
        public enum RegistrationStatus
        {
            Active,
            Promoted,
            Suspended,
            Dropped,
            Repeated,
        }
        public enum AttendanceStatus
        {
            Active,
            Present,
            Absent,
            Late,
            Excused,
            Deleted,
            UnTaken
            
        }
}