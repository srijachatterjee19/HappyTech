using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace HappyTechApp
{
    class Databaselinks
    {
        //this is a private object of the databaselinks class
        private static Databaselinks DBinstance;

        //This is a connection string
        private string DBConnectionstrg;

        //this is the Connection to the database
        private SqlConnection DBlink;

        //this is a constructor linked to the database
        private Databaselinks()
        {
            DBConnectionstrg = Properties.Settings.Default.HappyTechConstrg;

        }

        //this is a static method which will create a unique object of its own class
        public static Databaselinks DatabaseConnInstance()
        {
            //this will creates an object only if the doesnt already exist.
            if (DBinstance == null)
                DBinstance = new Databaselinks();
            return DBinstance;
        }

        //this code will get a dataset created based on the query sent as a parameter
        public DataSet retrieveData(string sqlQuery)
        {
            DataSet datast = new DataSet();

            using (DBlink = new SqlConnection(DBConnectionstrg))
            {
                //this line of code will open the database connection
                DBlink.Open();

                //this line of code will be used to send query to the database
                SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlQuery, DBlink);

                //this will be used to fill the dataset
                dtAdapter.Fill(datast);

                //this line of code will close the database connection 
                DBlink.Close();

            };
            return datast;

            
        }

        //this method will be used to insert or save data into the database
        public void insertToDB(string sqlQuery, string FirstName, string LastName, string Email, string Gender, string Department, int Age)
        {
            using (DBlink = new SqlConnection(DBConnectionstrg))
            {
                //this line of code will open the database connection
                DBlink.Open();

                //creating an instance of sql command 
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, DBlink);

                //this will set the command type to text which will read interpret text as an query
                //this in short is setting the sql command properties.
                sqlCmd.CommandType = CommandType.Text;

                //this will add parameters to the sqlcommand
                sqlCmd.Parameters.Add(new SqlParameter("FirstName", FirstName));
                sqlCmd.Parameters.Add(new SqlParameter("LastName", LastName));
                sqlCmd.Parameters.Add(new SqlParameter("Age", Age));
                sqlCmd.Parameters.Add(new SqlParameter("Gender", Gender));
                sqlCmd.Parameters.Add(new SqlParameter("Email", Email));
                sqlCmd.Parameters.Add(new SqlParameter("Department", Department));


                //this will execute the command
                sqlCmd.ExecuteNonQuery();
            }


        }

        //this will enable access to the textboxes from the Login form
        static Login Log = Application.OpenForms.OfType<Login>().FirstOrDefault();
        public DataSet login(string sqlQuery)
        {
            DataSet dst = new DataSet();
            using (DBlink = new SqlConnection(DBConnectionstrg))
            {
                //this line of code will open the database connection
                DBlink.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, DBlink);

                //this will set the command type to text which will read interpret text as an query
                //this in short is setting the sql command properties.
                sqlCmd.CommandType = CommandType.Text;

                //this will add parameters to the sqlcommand
                sqlCmd.Parameters.AddWithValue("@Username", Log.txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@Password", Log.txtPassword.Text);

                //this line of code will be used to send query to the database
                SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlCmd);

                //this will be used to fill the dataset
                dtAdapter.Fill(dst);

                //this is check the database tables for verification
                int count = dst.Tables[0].Rows.Count;

                if (count == 1)
                {

                    MainMenu MN = new MainMenu();
                    MN.Show();

                }
                else
                {
                    //message will be displayed if wrong login details are entered
                    MessageBox.Show("Invalid username or Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //database connection is closed 
                DBlink.Close();

                return dst;
            }

        }

        // this will save the feedback into the database
        public void saveFeedback(string QuerySQL, string FeedbackTitle, string FeedbackReceiver, string Email, DateTime DateSaved, string GivenFeedback)
        {
            using (DBlink = new SqlConnection(DBConnectionstrg))
            {
                //this line of code will open the database connection
                DBlink.Open();

                //creating an instance of sql command 
                SqlCommand sqlCmd = new SqlCommand(QuerySQL, DBlink);

                //this will set the command type to text which will read interpret text as an query
                //this in short is setting the sql command properties.
                sqlCmd.CommandType = CommandType.Text;

                //this will add parameters to the sqlcommand
                sqlCmd.Parameters.Add(new SqlParameter("FeedbackTitle", FeedbackTitle));
                sqlCmd.Parameters.Add(new SqlParameter("FeedbackReceiver", FeedbackReceiver));
                sqlCmd.Parameters.Add(new SqlParameter("Email", Email));
                sqlCmd.Parameters.Add(new SqlParameter("DateSaved", DateSaved));
                sqlCmd.Parameters.Add(new SqlParameter("GivenFeedback", GivenFeedback));

                //this will execute the command
                sqlCmd.ExecuteNonQuery();
            }

        }



        public void Update(string sqlQuery, string GivenFeedback)
        {

            using (DBlink = new SqlConnection(DBConnectionstrg))
            {
                //this line of code will open the database connection
                DBlink.Open();

                //creating an instance of sql command
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, DBlink);

                sqlCmd.CommandType = CommandType.Text;

                //adding parameter 

                sqlCmd.Parameters.Add(new SqlParameter("GivenFeedback", GivenFeedback));


                //this will execute the command
                sqlCmd.ExecuteNonQuery();
            }

        }


        public void FeedbackDetails(string sqlQuery, string FeedbackTitle, string FeedbackReceiver, string Email, DateTime DateSaved, string GivenFeedback, int FeedbackID)
        {
            using (DBlink = new SqlConnection(DBConnectionstrg))
            {
                //this line of code will open the database connection
                DBlink.Open();

                //creating an instance of sql command
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, DBlink);

                //this will set the command type to text which will read interpret text as an query
                //this in short is setting the sql command properties.
                sqlCmd.CommandType = CommandType.Text;

                //this will add parameters to the sqlcommand
                sqlCmd.Parameters.Add(new SqlParameter("Feedback_ID", FeedbackID));
                sqlCmd.Parameters.Add(new SqlParameter("FeedbackTitle", FeedbackTitle));
                sqlCmd.Parameters.Add(new SqlParameter("FeedbackReceiver", FeedbackReceiver));
                sqlCmd.Parameters.Add(new SqlParameter("Email", Email));
                sqlCmd.Parameters.Add(new SqlParameter("DateSaved", DateSaved));
                sqlCmd.Parameters.Add(new SqlParameter("GivenFeedback", GivenFeedback));


                //this will execute the command
                sqlCmd.ExecuteNonQuery();
            }

        }


        public void SendAll(string sqlQuery)
        {
            using (DBlink = new SqlConnection(DBConnectionstrg))
            {
                SqlDataReader reader;

                // this line of code will open the database connection
                DBlink.Open();

                //this will set the command type to text which will read interpret text as an query
                //this in short is setting the sql command properties.
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, DBlink);

                //Accessing emails from table as an arraylist
                ArrayList EmailArray = new ArrayList();
                reader = sqlCmd.ExecuteReader();

                //this will be creating a list for details of the email 
                var multipleMail = new List<Emaildetails>();

                while (reader.Read())
                {
                    multipleMail.Add(new Emaildetails
                    {
                        //Accessing the details from the query and placing them in a while loop
                        FeedbackTitle = Convert.ToString(reader["FeedbackTitle"]),
                        FeedbackReceiver = Convert.ToString(reader["FeedbackReceiver"]),
                        Email = Convert.ToString(reader["Email"]),
                        GivenFeedback = Convert.ToString(reader["GivenFeedback"]),
                    }
                      ) ; 
                }

                foreach (Emaildetails email in multipleMail)
                {
                    // this will be used to communicate with google smtp servers.
                    SmtpClient client = new SmtpClient();

                    // this will set google's gmail as the host
                    client.Host = "smtp.gmail.com";

                    // this is used to access port 587 which is the port accepted by google
                    client.Port = 587;

                    //this line of code is enabled to establish a secured encrypted connection between server and client
                    client.EnableSsl = true;

                    //this sets how long the request will wait until it timesout
                    client.Timeout = 10000;

                    //this line of code will be used to set out the means of delivery for the email
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;

                    //this line will be used to verify credentials when connecting to the server
                    client.Credentials = new NetworkCredential("bbasabanana@gmail.com", "VAGA0244044687");

                    //this section of the code will be used to set the various properties of the email that is the sender, receiver, subject and body 
                    MailMessage msg = new MailMessage();

                    //this will get and set email addressed from email from database 
                    msg.To.Add(email.Email);

                    //this line of code gets the sender's emails
                    msg.From = new MailAddress("bbasabanana@gmail.com");


                    msg.Subject = email.FeedbackTitle;
                    msg.IsBodyHtml = false;

                    // this line of code will set the message body
                    msg.Body = "Hi " + email.FeedbackReceiver + "Below you can find your feedback" + email.GivenFeedback;

                    //this will be send email 
                    client.Send(msg);

                    // this is an interractive form which will noticy the user that their emails was successfully sent. 
                    MessageBox.Show("Email Sent");
                }
                
            }


        }


        public void Creatingtemplate(string sqlQuery, string Template_Type, string Education1, string Education2, string Experience1, string Experience2, string Skills1, string Skills2)
        {
            using (DBlink = new SqlConnection(DBConnectionstrg))
            {
                // this line of code will open the database connection
                DBlink.Open();

                //creating an instance of sql command
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, DBlink);

                //this will set the command type to text which will read interpret text as an query
                //this in short is setting the sql command properties.
                sqlCmd.CommandType = CommandType.Text;

                //this will add parameters to the sqlcommand
                sqlCmd.Parameters.Add(new SqlParameter("Template_Type", Template_Type));
                sqlCmd.Parameters.Add(new SqlParameter("Education1", Education1));
                sqlCmd.Parameters.Add(new SqlParameter("Education2", Education2));
                sqlCmd.Parameters.Add(new SqlParameter("Experience1", Experience1));
                sqlCmd.Parameters.Add(new SqlParameter("Experience2", Experience2));
                sqlCmd.Parameters.Add(new SqlParameter("Skills1", Skills1));
                sqlCmd.Parameters.Add(new SqlParameter("Skills2", Skills2));



                //this will execute the command
                sqlCmd.ExecuteNonQuery();
            }

        }
    }
}
