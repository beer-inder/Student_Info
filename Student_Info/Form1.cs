using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Info
{
    public partial class Form1 : Form
    {
        public string connectionString = @"Data Source=T2181\SQLEXPRESS; Initial Catalog=student;Integrated Security=True;Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False ";
        SqlConnection con = new SqlConnection("Data Source=T2181\\SQLEXPRESS; Initial Catalog=student;Integrated Security=True;Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False ");
        SqlCommand Command = new SqlCommand();
        SqlDataReader reader;
        String SqlStmt;
        int PK = 0;
        public Form1()
        {
            InitializeComponent();
            //connection string to connect to database
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(connectionString);
            //string com = "Select * from Stud_Details";
            //Command = new SqlCommand(com, con);

            ////Open connection
            //con.Open();

            ////Start Database reader
            //reader = Command.ExecuteReader();
            //while (reader.Read())
            //{
            //    LB_Student.Items.Add((reader["S_ID"] + " -" + reader["S_Name"] + " " + reader["lastName"] + " (" + reader["Mobile"] + ")"));
            //}

            ////Close Database reader
            //reader.Close();
            ////Close Connection
            //con.Close();
            Load_ListBox();
        }

        public void Load_ListBox()
        {
            //SqlConnection con = new SqlConnection(connectionString);
            SqlStmt = "Select * from Stud_Details";
            Command = new SqlCommand(SqlStmt, con);

            //Open connection
            con.Open();

            //Start Database reader
            reader = Command.ExecuteReader();
            while (reader.Read())
            {
                LB_Student.Items.Add((reader["S_ID"] + " -" + reader["S_Name"] + " " + reader["lastName"] + " (" + reader["Mobile"] + ")"));
            }

            //Close Database reader
            reader.Close();
            //Close Connection
            con.Close();
        }

        public void Clear_Fields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            LB_Student.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//            Command.Connection = con;
            Random rnd_num = new Random();
            int S_ID = rnd_num.Next(1, 10000);
            string S_Name = textBox1.Text;
            string lName = textBox2.Text;
            string Mobile = textBox3.Text;
            //SqlStmt = "Insert into Stud_Details(S_ID, S_Name, lastName, Mobile) values (@S_ID, @S_Name, @lName, @Mobile)";
            //using (Command = new SqlCommand(SqlStmt, con))
            //{
            //    Command.Parameters.AddWithValue("@S_ID", S_ID);
            //    Command.Parameters.AddWithValue("@S_Name", S_Name);
            //    Command.Parameters.AddWithValue("@lastName", lName);
            //    Command.Parameters.AddWithValue("@Mobile", Mobile);
            //    con.Open();
            //    Command.ExecuteNonQuery();
            //    con.Close();
            //}

            bool StudentAdded = AddStudent(S_ID, textBox1.Text, textBox2.Text, textBox3.Text);
            if (StudentAdded)
            {
                Clear_Fields();
                Load_ListBox();
                
            }
        }

        public bool AddStudent(int S_ID, string S_Name, string lastName, string Mobile)
        {
            bool studentAdded = false;
            SqlStmt = "Insert into Stud_Details(S_ID, S_Name, lastName, Mobile) values (@ID, @FName, @LName, @Mobile)";
            using (Command = new SqlCommand(SqlStmt, con))
            {
                Command.Parameters.AddWithValue("@ID", S_ID);
                Command.Parameters.AddWithValue("@FName", S_Name);
                Command.Parameters.AddWithValue("@LName", lastName);
                Command.Parameters.AddWithValue("@Mobile", Mobile);
                con.Open();
                int rowsadded = Command.ExecuteNonQuery();

                if (rowsadded > 0)
                {
                    studentAdded = true;
                    MessageBox.Show("Record Added");
                }
                con.Close();
            }

            return studentAdded;

        }

        public bool Load_Data(int S_ID)
        {
            SqlStmt = "Select * from Stud_Details where S_ID = " + S_ID;
            using (Command = new SqlCommand(SqlStmt, con))
            {
                con.Open();
                reader = Command.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBox1.Text = reader["S_Name"].ToString();
                        textBox2.Text = reader["lastName"].ToString();
                        textBox3.Text = reader["Mobile"].ToString();
                    }
                        
                }
                con.Close();
            }
            return true;
        }

        private void LB_Student_MouseClick(object sender, MouseEventArgs e)
        {
            var selectedValue = LB_Student.SelectedItem;
            if(selectedValue != null)
            {
                MessageBox.Show(selectedValue.ToString());
            }
            string fetchedData = LB_Student.SelectedItem.ToString();
            string[] words = fetchedData.Split(' ');
            PK = Int16.Parse( words[0]);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            Load_Data(PK);
        }

        private void Update_Record_Click(object sender, EventArgs e)
        {
            string S_Name = textBox1.Text;
            string lName = textBox2.Text;
            string Mobile = textBox3.Text;

            bool record_updated = UpdateStudent(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        public bool UpdateStudent(string S_Name, string lastName, string Mobile)
        {
            bool record_Updated = false;
            SqlStmt = "Update Stud_Details set S_Name = @FName, lastName = @LName, Mobile = @Mobile where S_ID = " + PK;

            using (Command = new SqlCommand(SqlStmt, con))
            {
                //                Command.Parameters.AddWithValue("@ID", S_ID);
                Command.Parameters.AddWithValue("@FName", S_Name);
                Command.Parameters.AddWithValue("@LName", lastName);
                Command.Parameters.AddWithValue("@Mobile", Mobile);
                Command.CommandText = SqlStmt;
                con.Open();
                int dataUpdated = Command.ExecuteNonQuery();
                if(dataUpdated > 0)
                {
                    record_Updated = true;
                    con.Close();
                    Clear_Fields();
                    Load_ListBox();
                }
                
            }

                return record_Updated;
        }

        private void Delete_Record_Click(object sender, EventArgs e)
        {
            SqlStmt = "Delete from Stud_Details where S_ID = " + PK;
            using (Command = new SqlCommand(SqlStmt, con))
            {
                con.Open();
                Command.ExecuteNonQuery();
                con.Close();
                Clear_Fields();
                Load_ListBox();
                
            }
        }
            
    }
}
