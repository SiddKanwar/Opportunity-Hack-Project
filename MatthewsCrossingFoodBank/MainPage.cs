using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.IO;

namespace MatthewsCrossingFoodBank
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.ShowDialog();
            string fileName = fileChooser.FileName;

            txtFilenamePath.Text = fileName;

            List<Donor> donors = getDonors(fileName);

            foreach(Donor d in donors)
            {
                dataGridViewEntries.Rows.Add(d.firstName, d.lastName, d.email);
            }
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewEntries.SelectedRows)
            {
                dataGridViewEntries.Rows.RemoveAt(item.Index);
            }
        }

        private void btnSendEmails_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow row in dataGridViewEntries.Rows)
                {
                    string htmlBody;
                    string stmpServer = "smtp.gmail.com";
                    string fromEmail = "opportunityhackpaypal@gmail.com";
                    string fromPassword = "appleorange123";

                    string subject = "Test Mail";

                    string body;

                    StringBuilder sb = new StringBuilder();

                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        sb.Append(cell.Value);
                        sb.Append("-");
                    }
                   
                    body = sb.ToString();

                    string toEmail = "opportunityhackpaypal@gmail.com";

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient(stmpServer);

                    mail.From = new MailAddress(fromEmail);
                    mail.To.Add(toEmail);
                    mail.Subject = subject;
                    mail.Body = body;

                    //mail.IsBodyHtml = true;
                    //htmlBody = "";
                    //mail.Body = htmlBody;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(fromEmail, fromPassword);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }

                MessageBox.Show("Messages sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Unable to send email to " + ex.Message);
                
                Console.WriteLine("Exception Message: " + ex.Message + "\n\n");
                Console.WriteLine("Exception String: " + ex.ToString());
            }
        }

        public List<Donor> getDonors(String filename)
        {
            string path = @"" + filename;
            string line;
            string[] parsedLine;

            List<Donor> donorList = new List<Donor>();

            StreamReader sr = new StreamReader(path);
            while ((line = sr.ReadLine()) != null)
            {
                parsedLine = SplitCSV(line);

                donorList.Add(addDonor(parsedLine));
            }

            sr.Close();

            return donorList;
        }

        public static Donor addDonor(string[] donorArray)
        {
            Donor temp = new Donor();

            temp.firstName = donorArray[1].Replace("\"", "");
            temp.lastName = donorArray[2].Replace("\"", "");
            temp.streetAddress = donorArray[3].Replace("\"", "");
            temp.apartment = donorArray[4].Replace("\"", "");
            temp.cityTown = donorArray[5].Replace("\"", "");
            temp.stateProvince = donorArray[6].Replace("\"", "");
            temp.zipPostalCode = donorArray[7].Replace("\"", "");
            temp.email = "opportunityhackpaypal@gmail.com";

            return temp;
        }

        public static string[] SplitCSV(string input)
        {
            Regex csvSplit = new Regex("(?:^|,)(\"(?:[^\"]+|\"\")*\"|[^,]*)", RegexOptions.Compiled);
            List<string> list = new List<string>();
            string curr = null;
            foreach (Match match in csvSplit.Matches(input))
            {
                curr = match.Value;
                if (0 == curr.Length)
                {
                    list.Add("");
                }
                list.Add(curr.TrimStart(','));
            }
            return list.ToArray<string>();
        }
    }
}
