using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        private List<Participant> participants = new List<Participant>();
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public DateTime ActivityStartDate { get; set; }
        public DateTime ActivityEndDate { get; set; }
        public List<Participant> Participants { get { return participants; } }

        public void addParticipant(Participant participant) {
            participants.Add(participant);
        }
    }
}
