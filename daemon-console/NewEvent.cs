using System;
using System.Collections.Generic;
using System.Text;

namespace daemon_console
{
    public class NewEvent
    {
        public string subject;
        public Start start;
        public End end;
        public bool isOnlineMeeting;
        public string onlineMeetingProvider;
        public IList<Attendee> attendees;
        public class Start
        {
            public string dateTime;
            public string timeZone;
        }

        public class End
        {
            public string dateTime;
            public string timeZone;
        }

        public class EmailAddress
        {
            public string address;
            public string name;

            
        }

        public class Attendee
        {
            public EmailAddress emailAddress;
            public string type;

        }


    }


}
