using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCalendar
{
    public class iCalendar : List<iCalendar.vEvent>
    {
        public new void Add(vEvent item)
        {
            var old = FindIndex(x => x.UID == item.UID);
            if (old != -1) RemoveAt(old);
            base.Add(item);
        }
        //public List<vEvent> vEvents = new List<vEvent>();
        public string PRODID;
        public iCalendar(string ID)
        {
            PRODID = ID;
        }

        public override string ToString()
        {
            return $"BEGIN:VCALENDAR\r\nPRODID:{PRODID}\r\nVERSION:2.0\r\nCALSCALE:GREGORIAN\r\nMETHOD:REQUEST\r\n{string.Join("", this)}END:VCALENDAR";
        }

        public class vEvent
        {
            public string UID;
            public string ORGANIZER;
            public Dictionary<string, string> ATTENDEE = new Dictionary<string, string>();
            public string SUMMARY;
            public string DESCRIPTION;
            public string LOCATION;
            public DateTime DTSTART;
            public DateTime DTEND;
            public bool Cancel = false;
            public override string ToString()
            {
                var ATT = "";
                foreach (var item in ATTENDEE)
                    ATT += $"ATTENDEE;CUTYPE=INDIVIDUAL;ROLE=REQ-PARTICIPANT;PARTSTAT=ACCEPTED;CN={item.Value};X-NUM-GUESTS=0:mailto:{item.Key}\r\n";
                return "BEGIN:VEVENT\r\n" +
                    $"UID:{UID}\r\n" +
                    $"DTSTART:{DTSTART.ToString("yyyyMMddTHHmmssZ")}\r\n" +
                    $"DTEND:{DTEND.ToString("yyyyMMddTHHmmssZ")}\r\n" +
                    $"DTSTAMP:{DateTime.UtcNow.ToString("yyyyMMddTHHmmssZ")}\r\n" +
                    $"ORGANIZER;CN={ORGANIZER}\r\n" +
                    ATT +
                    $"SUMMARY:{SUMMARY}\r\n" +
                    $"DESCRIPTION:{DESCRIPTION}\r\n" +
                    $"LOCATION:{LOCATION}\r\n" +
                    (Cancel ? "METHOD:CANCEL\r\nSTATUS:CANCELLED\r\n" : "") +
                    "CLASS:PRIVATE\r\nSEQUENCE:0\r\nEND:VEVENT\r\n";
            }
        }
    }
}
