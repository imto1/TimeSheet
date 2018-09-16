

namespace timesheet
{
    public class Changes
    {
        int id, person;
        string name, from, to, reason, status;

        public Changes() { }
        public Changes(int id, int person, string from, string to, string status, string reason, string name = null)
        {
            this.id = id;
            this.person = person;
            this.from = from;
            this.to = to;
            this.status = status;
            this.reason = reason;
            this.name = name;
        }
        public Changes(int person, string from, string status)
        {
            this.person = person;
            this.from = from;
            this.status = status;
        }

        //Queries
        public int getId() { return id; }

        public int getPersonId() { return person; }

        public string getPersonName() { return name; }

        public string getFromDate() { return from; }

        public string getToDate() { return to; }

        public string getStatus() { return status; }

        public string getReason() { return reason; }


        //Commands
        public void setId(int id) { this.id = id; }

        public void setPersonId(int person) { this.person = person; }

        public void setPersonName(string name) { this.name = name; }

        public void setFromDate(string from) { this.from = from; }

        public void setToDate(string to) { this.to = to; }

        public void setStatus(string status) { this.status = status; }

        public void setReason(string reason) { this.reason = reason; }
    }
}
