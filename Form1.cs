using Azure.Storage.Blobs;
using System.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
//using System.Web.Script.Serialization;
namespace MovieApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string storageaccountURL = string.Empty;
        private string DBConnDetails = string.Empty;
        //private string instrumentationKey = ConfigurationManager.ConnectionStrings["instrumentationKey"].ConnectionString;
        

        private void getcountries()
        {

            //WriteLog("hitting get countries function");
            System.Net.HttpWebRequest request = WebRequest.Create("https://restcountries.com/v3.1/all") as HttpWebRequest;
            string url = "https://restcountries.com/v3.1/all";
            WebRequest request12 = HttpWebRequest.Create(url);
            WebResponse response = request12.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string urlText = reader.ReadToEnd(); // it takes the response from your url. now you can use as your need  
            dynamic stuff = JsonConvert.DeserializeObject(urlText);
            //WriteLog("loading countries");
            foreach (var s in stuff)
            {

                cbcountry.Items.Add(s.name.common);
            }
        }
        private async Task UploadFileAsync(string filePath)
        {
            var SAconnectionString = ConfigurationManager.ConnectionStrings["SAConnection"].ConnectionString;
            BlobServiceClient blobServiceClient = new BlobServiceClient(SAconnectionString);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient("test");
            await containerClient.CreateIfNotExistsAsync();
            string fileName = Path.GetFileName(filePath);
            BlobClient blobClient = containerClient.GetBlobClient(fileName);
            storageaccountURL = blobClient.Uri.AbsoluteUri;
            using FileStream fileStream = File.OpenRead(filePath);
            await blobClient.UploadAsync(fileStream, true);
        }
        public static void WriteLog(string strLog)
        {
            TelemetryConfiguration Tconfig = TelemetryConfiguration.CreateDefault();
            Tconfig.ConnectionString = ConfigurationManager.ConnectionStrings["AppinsightConnstring"].ConnectionString;;
            //Tconfig.InstrumentationKey = "a66414be-4fc9-4e67-bec3-2a15dc4c7f04";
            TelemetryClient telemetryClient = new TelemetryClient(Tconfig);
            telemetryClient.TrackTrace(strLog);

            StreamWriter log;
            FileStream fileStream = null;
            DirectoryInfo logDirInfo = null;
            FileInfo logFileInfo;

            string logFilePath = ConfigurationManager.ConnectionStrings["LogLocation"].ConnectionString;
            //logFilePath = logFilePath + "Movie-Log-" + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "txt";
            logFileInfo = new FileInfo(logFilePath);
            logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            if (!logFileInfo.Exists)
            {
                fileStream = logFileInfo.Create();
            }
            else
            {
                fileStream = new FileStream(logFilePath, FileMode.Append);
            }
            log = new StreamWriter(fileStream);
            log.WriteLine(strLog);
            log.Close();
            telemetryClient.Flush();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            WriteLog("Insert new data");
            var connectionString = "";
            var RoleFlag = ConfigurationManager.ConnectionStrings["RunwithRole"].ConnectionString;
            if (RoleFlag == "yes")
            {
                await readfromRole();
                connectionString = DBConnDetails;
                MessageBox.Show("The data pulled using Role is " + connectionString);
            }
            else
            {
                connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            }
            

            string containerName = "test";
            string filePath = txtimage.Text;
            await UploadFileAsync(filePath);
            WriteLog("New file uploaded from  " + txtimage.Text);
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    Console.WriteLine("Connection Open ! ");
                    string StrQuery = "INSERT INTO [dbo].[MovieTable] ([MovieName], [Rating], [Director], [country],[image],[summary]) VALUES (@MovieName,@Rating,@Director,@country,@image,@summary)";
                    //string StrQuery = "INSERT INTO MovieTable(Name, Rating, EmailAddress, country, Phone, customeraddress,customerinformation) VALUES(@Name, @CompanyName, @EmailAddress, @country, @Phone, @customeraddress,@customerinformation)";
                    SqlCommand command = new SqlCommand(StrQuery, cnn);
                    command.Parameters.AddWithValue("@MovieName", txtMovieName.Text);
                    command.Parameters.AddWithValue("@Rating", txtRating.Text);
                    command.Parameters.AddWithValue("@Director", txtDirector.Text);
                    command.Parameters.AddWithValue("@country", cbcountry.Text);
                    command.Parameters.AddWithValue("@image", storageaccountURL);
                    command.Parameters.AddWithValue("@summary", richSummary.Text);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    WriteLog("New Movie Details are adding Movie Name is " + txtMovieName.Text);
                    WriteLog("The Customer details are added sucessfully!!!!");
                    MessageBox.Show("The Customer details are added sucessfully!!!!");

                }
                catch (Exception ex)
                {
                    cnn.Close();
                    Console.WriteLine("Can not open connection ! ");
                    WriteLog("Exception while inserting New Movie. Details " + ex.Message);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //getcountries();

        }

        private void cbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private static string GetImagesDetails()
        {
            string selectedFilePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//  Set initial directory
            openFileDialog.Title = "Select a file to upload";
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Multiselect = false;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                Console.WriteLine($"Selected file path: {selectedFilePath}");
            }
            else
            {
                Console.WriteLine("File selection canceled.");
            }

            return selectedFilePath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtimage.Text = GetImagesDetails();
        }

        private async Task readfromRole()
        {
            const string secretName = "DbConn";
            var keyVaultName = "SecretsPlace";
            var kvUri = $"https://{keyVaultName}.vault.azure.net";
            var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
            Console.WriteLine($"Retrieving your secret from {keyVaultName}.");
            var secret = await client.GetSecretAsync(secretName);
            Console.WriteLine($"Your secret is '{secret.Value.Value}'.");
            DBConnDetails = secret.Value.Value;

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var connectionString = "";
            var RoleFlag = ConfigurationManager.ConnectionStrings["RunwithRole"].ConnectionString;
            if(RoleFlag == "yes")
            {
                await readfromRole();
                connectionString = DBConnDetails;
                MessageBox.Show("The data pulled using Role is " + connectionString);
            }
            else
            {
                connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            }
            
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    WriteLog("Searching for movie " + txtSearch.Text);
                    Console.WriteLine("Connection Open ! ");
                    String strQuery = "Select top 1 * from [MovieTable] where [MovieName] = '" + txtSearch.Text + "'";
                    SqlCommand command = new SqlCommand(strQuery, cnn);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //WriteLog("inserting new Name : " + reader["Name"]);
                            label6.Text = reader["MovieName"].ToString();
                            label7.Text = reader["Rating"].ToString();
                            label9.Text = reader["Director"].ToString();
                            label13.Text = reader["country"].ToString();
                            label11.Text = reader["summary"].ToString();
                            WriteLog("Movie searched is " + reader["MovieName"].ToString());

                            WebClient webClient = new WebClient();
                            byte[] imageData = webClient.DownloadData(reader["image"].ToString());

                            // Convert the downloaded image data to a Bitmap
                            using (MemoryStream memoryStream = new MemoryStream(imageData))
                            {
                                Image imagess = Image.FromStream(memoryStream);
                                pictureBox1.Image = imagess;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No records of any customer found with this name. Please provide vaild details");
                            //ClearData();
                        }
                    }
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Can not open connection ! ");
                    WriteLog("Exception while searching Movie. Details " + ex.Message);
                }
            }


        }
    }
}


