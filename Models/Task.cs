using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protofolio.Models
{
    public class Task
    {
        private long id;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private string status;
        private string assignedBy;

        public long Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string Status { get => status; set => status = value; }
        public string AssignedBy { get => assignedBy; set => assignedBy = value; }
    }
}