using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTechApp
{
    class queriesTable
    {

        

       //this will select datafrom the applicant table
        public static string ApplicantQuery = "SELECT * FROM Applicant";
        
        //this will select data from the department table
        public static string DepartmentQuery = "SELECT * FROM Department";
        
        //this will input data into the applicant details
        public static string Register = "INSERT INTO Applicant (FirstName, LastName, Age, Gender, Email, Department) VALUES (@FirstName, @LastName, @Age, @Email, @Gender, @Department)";
        
        //this will select data from the feedback table 
        public static string Retrieve_Feedback = "SELECT * FROM Feedback";
       
        //this query will validate the user login details
        public static string Login_Details = "select * from Login where Username=@Username and Password=@Password";
        
        //this query will save feedback into the feedback table
        public static string Save_Feedback = "INSERT INTO FEEDBACK(FeedbackTitle, FeedbackReceiver, Email, DateSaved, GivenFeedback) VALUES (@FeedbackTitle, @FeedbackReceiver, @Email, @DateSaved, @GivenFeedback)";
        
        //this query will update the applicant's details within the feedback table
        public static string Update_FeedbackDetails = "UPDATE Feedback SET FeedbackTitle=@FeedbackTitle, FeedbackReceiver=@FeedbackReceiver, Email=@Email, DateSaved=@DateSaved, GivenFeedback=@GivenFeedback where Feedback_ID=@Feedback_ID";

        //this query will delete feedback from the feedback table
        public static string Delete_Feedback = "Delete from Feedback where Feedback_ID=@Feedback_ID";

        //this query is to extract details needed to send email to applicant
        public static string Bulksend = "SELECT FeedbackTitle, FeedbackReceiver, Email, GivenFeedback FROM Feedback";

        //this will save data into the create template table
        public static string Save_CreatedTemplate = "INSERT INTO Create_Template(Template_Type,Education1, Education2, Experience1, Experience2,Skills1,Skills2) VALUES (@Template_Type,@Education1, @Education2, @Experience1, @Experience2, @Skills1, @Skills2)";

        //this will display data from the create template table
        public static string TemplateQuery = "SELECT * FROM Create_Template";
    }
}
