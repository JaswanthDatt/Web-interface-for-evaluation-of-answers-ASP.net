using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.Sql;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public static MySqlConnection mysql_connection()
    {
        MySqlConnection conn;
        conn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectString"].ToString());
        return conn;
    }

    public bool Create(student s)
    {
        MySqlConnection conn = mysql_connection();
        conn.Open();
        MySqlTransaction trans = conn.BeginTransaction();
        MySqlDataReader r;
        try
        {
            string query = "INSERT INTO students(Id,FName,LName,MI,Male_Female,Birth_Date,Date_Added) VALUES (@Id, @Fname, @LName,@MI,@Male_Female,@Birth_Date,@Date_Added)";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@Id", s.Student_id);
            command.Parameters.AddWithValue("@Fname", s.fname);
            command.Parameters.AddWithValue("@LName", s.lname);
            command.Parameters.AddWithValue("@MI", s.mi);
            command.Parameters.AddWithValue("@Male_Female", s.male_female);
            command.Parameters.AddWithValue("@Birth_Date", s.birth_Date);
            command.Parameters.AddWithValue("@Date_Added", s.date_Added);
            r = command.ExecuteReader();
            r.Close();
            trans.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            trans.Rollback();
            conn.Close();
            return false;
        }
        conn.Close();
        return true;
    }

    public bool UpdateById(student s)
    {
        MySqlConnection conn = mysql_connection();
        conn.Open();
        MySqlTransaction trans = conn.BeginTransaction();
        try
        {
            String query = "update students set Fname=@fname,LName=@lname,MI=@mi,Male_Female=@male_female,Birth_Date=@birth_date,Date_Added=@date_added where Id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", s.Student_id);
            cmd.Parameters.AddWithValue("@fname", s.fname);
            cmd.Parameters.AddWithValue("@lname", s.lname);
            cmd.Parameters.AddWithValue("@mi", s.mi);
            cmd.Parameters.AddWithValue("@male_female", s.male_female);
            cmd.Parameters.AddWithValue("@birth_date", s.birth_Date);
            cmd.Parameters.AddWithValue("@date_added", s.date_Added);
            MySqlDataReader r = cmd.ExecuteReader();
            r.Close();
            trans.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            trans.Rollback();
            conn.Close();
            return false;
        }
        conn.Close();
        return true;
    }

    public bool DeleteById(int id)
    {
        MySqlConnection conn = null;
        MySqlTransaction trans = null;
        try
        {
            conn = mysql_connection();
            conn.Open();
            trans = conn.BeginTransaction();

            String query = "delete FROM students WHERE id = @Id";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@Id", id);
            MySqlDataReader r = command.ExecuteReader();

            r.Close();
            trans.Commit();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            if (trans != null)
            {
                trans.Rollback();
            }
            if (conn != null)
            {
                conn.Close();
            }
            return false;
        }
        conn.Close();
        return true;
    }

    public student FindById(int stud_id)
    {
        MySqlConnection conn = mysql_connection();
        conn.Open();
        MySqlTransaction trans = conn.BeginTransaction();
        student a = new student();
        try
        {
            String query = "SELECT * FROM students WHERE id =@Id";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@Id", stud_id);
            MySqlDataReader r = command.ExecuteReader();

            while (r.Read())
            {
                a.Student_id = Convert.ToInt32(r[0]);
                a.fname = Convert.ToString(r[1]);
                a.lname = Convert.ToString(r[2]);
                a.mi = Convert.ToString(r[3]);
                a.male_female = Convert.ToString(r[4]);
                a.birth_Date = Convert.ToDateTime(r[5]);
                a.date_Added = Convert.ToDateTime(r[6]);
            }

            r.Close();
            trans.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            conn.Close();
            trans.Rollback();
        }
        conn.Close();
        return a;
    }

    public IList<student> ReadAll()
    {
        IList<student> students = new List<student>();
        MySqlConnection conn = mysql_connection();
        conn.Open();
        MySqlTransaction trans = conn.BeginTransaction();
        try
        {
            String query = "select * from students";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader r = cmd.ExecuteReader();

            while (r.HasRows)
            {
                while (r.Read())
                {
                    student a = new student();
                    a.Student_id = Convert.ToInt32(r[0]);
                    a.fname = Convert.ToString(r[1]);
                    a.lname = Convert.ToString(r[2]);
                    a.mi = Convert.ToString(r[3]);
                    a.male_female = Convert.ToString(r[4]);
                    a.birth_Date = Convert.ToDateTime(r[5]);
                    a.date_Added = Convert.ToDateTime(r[6]);
                    students.Add(a);
                }


                r.NextResult();
            }
            r.Close();
            trans.Commit();
        }
        catch (Exception ex)
        {
            conn.Close();
            trans.Rollback();                                
            Console.WriteLine(ex.Message);
        }
        conn.Close();
        return students;
    }

}
