
namespace timesheet
{
    public class Personnel
    {
        int id, work, rest, xp_id;
        string name, start, xp;
        public Personnel() { }
        public Personnel(int id, string name, string start, int work, int rest, int xpid, string xp) {
            this.id = id;
            this.name = name;
            this.start = start;
            this.work = work;
            this.rest = rest;
            this.xp_id = xpid;
            this.xp = xp;
        }

        //Queries
        public int getId() {
            return id;
        }
        public int getWork() {
            return work;
        }
        public int getRest() {
            return rest;
        }
        public int getXpId() {
            return xp_id;
        }
        public string getName() {
            return name;
        }
        public string getStart() {
            return start;
        }
        public string getXp() {
            return xp;
        }

        //Commands
        public void setId(int id)
        {
            this.id = id;
        }
        public void setWork(int work)
        {
            this.work = work;
        }
        public void setRest(int rest)
        {
            this.rest = rest;
        }
        public void setXpId(int xp)
        {
            this.xp_id = xp;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setStart(string start)
        {
            this.start = start;
        }

    }
}
