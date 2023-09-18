using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Net;
using iTextSharp.text.pdf;



namespace HappyTechApp
{
    


    public class Emaildetails
    {
        //this will get and set from database and query
          public string FeedbackTitle { get; set; } 
          public string FeedbackReceiver { get; set; }
          public string Email { get; set; }
          public string GivenFeedback { get; set; }
    }

    static class BackEnd
    {
        public static string a;
        public static string b;
        public static string c;
        public static string d;
        public static string ex;
        public static string f;

        public static string temptype;

        
        public static void GenerateCode(Template Temp)
            {
                // try catch was used here to prevent this line nof code from break the whole application
                try
                {
                    //this if statement is linked to the radiobuttons from the template form. this will help generated different feedbacks based on the radiobutton user chooses. 
                    if (Temp.rbEditEducation1.Checked)
                    {
                        Temp.txtFB.Text = ("I am happy to write to you that the CV you provided had everything we are looking for in an applicant. We will like to carry this forward and get you in for an induction");
                    }
                    if (Temp.rbEditEducation2.Checked)
                    {
                        Temp.txtFB.Text = ("You have some great information about you in your CV but unfortunately the level of work experience require to acheive this role is insufficicent");
                    }
                    if (Temp.rbEditExperience1.Checked)
                    {
                        Temp.txtFB.Text = ("You have some great information about you in your CV but unfortunately the level of work experience require to acheive this role is insufficicent");
                    }
                    if (Temp.rbEditExperience1.Checked)
                    {
                        Temp.txtFB.Text = ("You have some great information about you in your CV but unfortunately the level of work experience require to acheive this role is insufficicent");
                    }
                    if (Temp.rbEditExperience1.Checked)
                    {
                        Temp.txtFB.Text = ("You have some great information about you in your CV but unfortunately the level of work experience require to acheive this role is insufficicent");
                    }
                    if (Temp.rbEditExperience1.Checked)
                    {
                        Temp.txtFB.Text = ("You have some great information about you in your CV but unfortunately the level of work experience require to acheive this role is insufficicent");
                    }

            }
                catch
                {
                    MessageBox.Show("Error Occurred, Please Restart Application");
                }


            }

            public static void AppcntDetails(Applicant B)
            {
           
               
               try
               {
                // this line of code is linked to the applicantinfo form, this calls allows for the button to be accessed
                ApplicantInfo A = new ApplicantInfo();
               
                //this code will get and set applicant details from applicant datagridview into its respective textboxes on the applicant info form.
                A.txtAppID.Text = B.ddgvApplicant.CurrentRow.Cells["Applicant_ID"].Value.ToString();
                A.txtFirstname.Text = B.ddgvApplicant.CurrentRow.Cells["FirstName"].Value.ToString();
                A.txtLastname.Text = B.ddgvApplicant.CurrentRow.Cells["LastName"].Value.ToString();
                A.txtAge.Text = B.ddgvApplicant.CurrentRow.Cells["Age"].Value.ToString();
                A.txtGender.Text = B.ddgvApplicant.CurrentRow.Cells["Gender"].Value.ToString();
                A.txtEmail.Text = B.ddgvApplicant.CurrentRow.Cells["Email"].Value.ToString();
                A.txtDepartment.Text = B.ddgvApplicant.CurrentRow.Cells["Department"].Value.ToString();
                A.ShowDialog(); 

                
               }
                catch(Exception)
               {
                MessageBox.Show("Error Occurred, Please Restart Application");
               }

            }


        public static void FeedbackDetails(Feedback F) //this method allows the feedback info to be stored in the textboxes in the FeedbackDetail class
        {

             FeedbackDetail fbd = new FeedbackDetail();
             fbd.feedbackID.Text = F.dgvFeedback.CurrentRow.Cells["Feedback_ID"].Value.ToString();
             fbd.txtFBTitle.Text = F.dgvFeedback.CurrentRow.Cells["FeedbackTitle"].Value.ToString();
             fbd.txtAppName.Text = F.dgvFeedback.CurrentRow.Cells["FeedbackReceiver"].Value.ToString();
              fbd.txtEmail.Text = F.dgvFeedback.CurrentRow.Cells["Email"].Value.ToString();
            fbd.dateTimeFB.Text = F.dgvFeedback.CurrentRow.Cells["DateSaved"].Value.ToString();
             fbd.txtFBInput.Text = F.dgvFeedback.CurrentRow.Cells["GivenFeedback"].Value.ToString();
             fbd.ShowDialog();         

        }

        public static void SendMail(FeedbackDetail FD)
        {
            try
            {

                using (SmtpClient client = new SmtpClient()) // this will be used to communicate with google smtp servers.
                {
                    // this will set google's gmail as the host 
                    client.Host = "smtp.gmail.com";

                    // this is used to access port 587 which is the port accepted by google
                    client.Port = 587; 
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;

                    //this is to set gmail credentials for authentication
                    client.Credentials = new NetworkCredential("bbasabanana@gmail.com", "VAGA0244044687"); 
                    MailMessage msg = new MailMessage();

                    //this will get and set email addressed from email textbox 
                    msg.To.Add(FD.txtEmail.Text);

                    //this line of code gets the sender's emails
                    msg.From = new MailAddress("bbasabanana@gmail.com");

                    //this code will set the subject of the email when sent and this subject will be extracted from feedback title textbox
                    msg.Subject = FD.txtFBTitle.Text;

                    // this will get text from the feedback textbox as the body of the email
                    msg.Body = FD.txtFBInput.Text;

                    //this will send drafted message to email
                    client.Send(msg);

                    // this is an interractive form which will noticy the user that their emails was successfully sent. 
                    MessageBox.Show("Email Sent");
                }
                
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        public static void SaveCode(CreateTemplate CrtTemp)
        {

            //this method will save the text box content from CreateTemplate for each code in strings 

            if (CrtTemp.rbEducation1.Checked)
            {
                string code1 = CrtTemp.TxtCode.Text;
                CrtTemp.txtcodeone.Text = code1;
                CrtTemp.TxtCode.Text = "Enter text here..";
            }
            if (CrtTemp.rbEducation2.Checked)
            {
                string code2 = CrtTemp.TxtCode.Text;
                CrtTemp.txtcodetwo.Text = code2;
                CrtTemp.TxtCode.Text = "Enter text here..";


            }
            if (CrtTemp.rbExperience1.Checked)
            {
                string code3 = CrtTemp.TxtCode.Text;
                CrtTemp.txtcodethree.Text = code3;
                CrtTemp.TxtCode.Text = "Enter text here..";
            }
            if (CrtTemp.rbExperience2.Checked)
            {
                string code4 = CrtTemp.TxtCode.Text;
                CrtTemp.txtcodefour.Text = code4;
                CrtTemp.TxtCode.Text = "Enter text here..";

            }
            if (CrtTemp.rbSkills1.Checked)
            {
                string code5 = CrtTemp.TxtCode.Text;
                CrtTemp.txtcodefive.Text = code5;
                CrtTemp.TxtCode.Text = "Enter text here..";

            }
            if (CrtTemp.rbSkills2.Checked)
            {
                string code6 = CrtTemp.TxtCode.Text;
                CrtTemp.txtcodesix.Text = code6;
                CrtTemp.TxtCode.Text = "Enter text here..";
            }

           

        }

        public static void SaveTemplateName()
        {
            // this method is used to edit the Template type label in the Create Template form

            SaveTempType stn = new SaveTempType();
            stn.ShowDialog();
            temptype = stn.txtTempType.Text;

        }
        public static void TemplateDetails(TemplateList tL)
        //this method allows the template info to be stored in the textboxes in the TemplateDetails class
        {


            try
            {

                TemplateDetails td = new TemplateDetails();

                td.txtTempID.Text = tL.dgvTemplateList.CurrentRow.Cells["Template_ID"].Value.ToString();
                td.txtTemplateType.Text = tL.dgvTemplateList.CurrentRow.Cells["Template_Type"].Value.ToString();
                td.txtcode1.Text = tL.dgvTemplateList.CurrentRow.Cells["Education1"].Value.ToString();
                td.txtcode2.Text = tL.dgvTemplateList.CurrentRow.Cells["Education2"].Value.ToString();
                td.txtcode3.Text = tL.dgvTemplateList.CurrentRow.Cells["Experience1"].Value.ToString();
                td.txtcode4.Text = tL.dgvTemplateList.CurrentRow.Cells["Experience1"].Value.ToString();
                td.txtcode5.Text = tL.dgvTemplateList.CurrentRow.Cells["Experience2"].Value.ToString();
                td.txtcode6.Text = tL.dgvTemplateList.CurrentRow.Cells["Skills1"].Value.ToString();
                td.ShowDialog();


            }
            catch (Exception)
            {
                MessageBox.Show("Error Occurred, Please Restart Application");
            }

        }
        public static void EditTemplate(TemplateDetails tdet)
        {
            //variables that will hold the strings obtained from TemplateDetails textboxes

            a = tdet.txtcode1.Text;
            b = tdet.txtcode2.Text;
            c = tdet.txtcode3.Text;
            d = tdet.txtcode4.Text;
            ex = tdet.txtcode5.Text;
            f = tdet.txtcode6.Text;




        }

        public static void PersonalisedFeedback(Template editTemp)// this method generates code for each radio button in the Template class
        {
            if (editTemp.rbEditEducation1.Checked)
            {
                editTemp.txtFB.Text = a;

            }
            if (editTemp.rbEditEducation2.Checked)
            {
                editTemp.txtFB.Text = b;

            }
            if (editTemp.rbEditExperience1.Checked)
            {
                editTemp.txtFB.Text = c;

            }
            if (editTemp.rbEditExperience2.Checked)
            {
                editTemp.txtFB.Text = d;

            }
            if (editTemp.rbEditSkills1.Checked)
            {
                editTemp.txtFB.Text = ex;

            }
            if (editTemp.rbEditSkills2.Checked)
            {
                editTemp.txtFB.Text = f;

            }
        }

        public static void CreatePDF(Template TempPDF)

        //this method saves the feedback text from Template class as a PDF file
        {
            using (SaveFileDialog savefiledialog = new SaveFileDialog() { Filter = "PDF File|*.pdf", ValidateNames = true })
            {
                if (savefiledialog.ShowDialog() == DialogResult.OK)
                {

                    {
                        iTextSharp.text.Document document = new iTextSharp.text.Document();
                        try
                        {


                            // savefiledialog.pdfname = ApplicantInfo.ApplicantName;
                            PdfWriter.GetInstance(document, new FileStream(savefiledialog.FileName, FileMode.Create));
                            document.Open();
                            document.Add(new iTextSharp.text.Paragraph(TempPDF.rtbFeedbacktext.Text));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            document.Close();
                        }
                    }
                }


            }
        }

      
    }
     

}

   

