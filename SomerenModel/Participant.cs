using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Participant: User
    {
        public int UserId { get; set; }
        public int ActivityId { get; set; }
        public string ParticipancyType { get; set; }
        public Activity ParticipatingActivity { get; set; }
    }
}
