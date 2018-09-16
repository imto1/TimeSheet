
namespace timesheet
{
    public class Expertise
    {
        int id;
        string xp;
        public Expertise() { }
        public Expertise(int id, string xp)
        {
            this.id = id;
            this.xp = xp;
        }

        //Queries
        public int getId()
        {
            return id;
        }

        public string getXp()
        {
            return xp;
        }

        //Commands
        public void setId(int id)
        {
            this.id = id;
        }
        public void setXp(string xp)
        {
            this.xp = xp;
        }
    }
}
