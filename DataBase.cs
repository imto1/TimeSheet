using System.Collections.Generic;
using System.Data.SQLite;

namespace timesheet
{
    public class DataBase
    {

        SQLiteConnection connection;
        public DataBase()
        {
            connection = new SQLiteConnection("Data Source=database.db;Version=3;");
        }

        //Commands
        public void addChange(Changes change = null)
        {
                string sql = "INSERT INTO changes (person, from_date, to_date, status, reason) VALUES " +
                    "(" + change.getPersonId() + ", '" +
                    change.getFromDate() + "', '" +
                    change.getToDate() + "', '" +
                    change.getStatus() + "', '" +
                    change.getReason() + "');";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
        }
        public void updateChange(Changes change)
        {
            string sql = "UPDATE changes SET person = " + change.getPersonId() +
                ", from_date = '" + change.getFromDate() +
                "', to_date = '" + change.getToDate() +
                "', status = '" + change.getStatus() +
                "', reason = '" + change.getReason() +
                "' WHERE id = " + change.getId() + ";";
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void deleteChange(int id)
        {
            string sql = "DELETE FROM changes WHERE id = " + id + ";";
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void addPerson(Personnel person)
        {
                string sql = "INSERT INTO personnel (name, start, work, rest, xp_id) VALUES " +
                    "('" + person.getName() + "', '" +
                    person.getStart() + "', " +
                    person.getWork() + ", " +
                    person.getRest() + ", " +
                    person.getXpId() + ");";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
        }
        public void updatePerson(Personnel person)
        {
            string sql = "UPDATE personnel SET name = '" + person.getName() +
                "', start = '" + person.getStart() +
                "', work = " + person.getWork() +
                ", rest = " + person.getRest() +
                ", xp_id = " + person.getXpId() +
                " WHERE id = " + person.getId() + ";";
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void deletePerson(int id)
        {
            string sql = "DELETE FROM personnel WHERE id = " + id + ";";
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void addExpertise(Expertise xp)
        {
                string sql = "INSERT INTO expertise (xp) VALUES ('" + xp.getXp() + "');";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
        }
        public void updateExpertise(Expertise xp)
        {
            string sql = "UPDATE expertise SET xp = '" + xp.getXp() +
                "' WHERE id = " + xp.getId() + ";";
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void deleteExpertise(int id)
        {
            string sql = "DELETE FROM expertise WHERE id = " + id + ";";
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }


        //Queries

        public List<Personnel> getPersonnel(int xpid = 0)
        {
            List<Personnel> personnel = new List<Personnel>();
            string sql = "SELECT personnel.id, personnel.name, personnel.start, " +
                "personnel.work, personnel.rest, personnel.xp_id, expertise.xp " +
                "FROM personnel INNER JOIN expertise ON personnel.xp_id = expertise.id";
            if (xpid != 0)
                sql += " WHERE personnel.xp_id = " + xpid;
            sql += " ORDER BY personnel.start;";
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Personnel person = new Personnel(int.Parse(reader["id"].ToString()), reader["name"].ToString(),
                        reader["start"].ToString(), int.Parse(reader["work"].ToString()), int.Parse(reader["rest"].ToString()),
                        int.Parse(reader["xp_id"].ToString()), reader["xp"].ToString());
                    personnel.Add(person);
                }
                connection.Close();
                return personnel;
            }
            catch (System.Exception)
            {
                connection.Close();
                return null;
            }
        }
        public Personnel getPerson(int id)
        {
            Personnel person = new Personnel();
            string sql = "SELECT personnel.id, personnel.name, personnel.start, " +
                "personnel.work, personnel.rest, personnel.xp_id, expertise.xp " +
                "FROM personnel INNER JOIN expertise ON personnel.xp_id = expertise.id" +
                " WHERE personnel.id = " + id;
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                    person = new Personnel(int.Parse(reader["id"].ToString()),
                        reader["name"].ToString(),
                        reader["start"].ToString(),
                        int.Parse(reader["work"].ToString()),
                        int.Parse(reader["rest"].ToString()),
                        int.Parse(reader["xp_id"].ToString()),
                        reader["xp"].ToString());

                connection.Close();
                return person;
            }
            catch (System.Exception)
            {
                connection.Close();
                return null;
            }
        }

        public List<Expertise> getExpertise()
        {
            List<Expertise> expertise = new List<Expertise>();
            string sql = "SELECT * FROM expertise ORDER BY expertise.id;";
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Expertise xp = new Expertise(int.Parse(reader["id"].ToString()), reader["xp"].ToString());
                    expertise.Add(xp);
                }
                connection.Close();
                return expertise;
            }
            catch (System.Exception)
            {
                connection.Close();
                return null;
            }
        }

        public List<Changes> getChanges(int person = 0, string from = "")
        {
            List<Changes> changes = new List<Changes>();
            string sql = "SELECT changes.id, changes.person, changes.from_date, " +
                "changes.to_date, changes.status, changes.reason, personnel.name " +
                "FROM changes INNER JOIN personnel ON changes.person = personnel.id";
            if (person != 0)
            {
                if (from != "")
                    sql += " WHERE (changes.person =" + person +
                        " AND changes.from_date LIKE '" + from + "')";
                else
                    sql += " WHERE changes.person =" + person;
            }
            sql += " ORDER BY changes.from_date;";

            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Changes change = new Changes(int.Parse(reader["id"].ToString()),
                        int.Parse(reader["person"].ToString()), reader["from_date"].ToString(),
                        reader["to_date"].ToString(), reader["status"].ToString(),
                        reader["reason"].ToString(), reader["name"].ToString());
                    changes.Add(change);
                }
                connection.Close();
                return changes;
            }
            catch (System.Exception)
            {
                connection.Close();
                return null;
            }
        }
        public Changes getChange(int person, string from)
        {
            string sql = "SELECT changes.id, changes.person, changes.from_date, " +
                "changes.to_date, changes.status, changes.reason, personnel.name " +
                "FROM changes INNER JOIN personnel ON changes.person = personnel.id" +
                " WHERE (changes.person = " + person + " AND changes.from_date LIKE '" + from + "');";

            Changes change = new Changes();
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    change = new Changes(int.Parse(reader["id"].ToString()),
                        int.Parse(reader["person"].ToString()), reader["from_date"].ToString(),
                        reader["to_date"].ToString(), reader["status"].ToString(),
                        reader["reason"].ToString(), reader["name"].ToString());
                }
                connection.Close();
                return change;
            }
            catch (System.Exception)
            {
                connection.Close();
                return null;
            }
        }
    }
}
