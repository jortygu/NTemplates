using NTemplates;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LetterExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateLetter_Click(object sender, EventArgs e)
        {
            //First, we need an instance of the DocumentCreator class.
            DocumentCreator dc = new DocumentCreator();

            //Now, we need to pass the data we want in the report, to the document creator instance.
            //We are going to "query" and bind the data in a single method, for simplicity.
            AddDataForReport(dc);

            //Finally, we will create a report, based on our template and save it to a location.
            //I encourage you to explore other overloads of the function CreateDocument
            dc.CreateDocument(@"../../Documents/letterTemplate.rtf", @"../../Documents/generatedLetter.rtf");
        }


        private void AddDataForReport(DocumentCreator dc)
        {
            /* Here we are going to add the data that we want to display. Typically it would come from a Database, a file, or a
             * web service, but NTemplates doesn´t care about that, it´s up to you and your requirements.
             * NOTE: NTemplates accepts input data in several formats.
             *    - As ASP.Net data tables.
             *    - As lists of POCOs.
             *    - As variables.
             * Here we are going to start by using simple variables.
             * 
             * PLEASE NOTE THAT VARIABLE NAMES ARE CASE SENSITIVE */

            dc.AddString("title", "Mr.");

            dc.AddString("name", "Magoo");

            /* We could add a date in it´s native format and then format it as we wish  at the template itself. That´s the recommended way of doing
             * it because it provides much more flexibility for the end users.
             * In order to keep things simple we will add the date as string. I will introduce formatting functions in future 
             * articles. You can explore the examples inclued with the NTemplates downloads. */            
            dc.AddString("date", DateTime.Today.ToShortDateString());

            dc.AddString("address", "secret for now, and will be revealed at the last moment");

            dc.AddString("email","gmddmg@gmail.com");

            dc.AddString("inviterName", "Gonzalo Méndez");
        
            dc.AddString("inviterCompany", "gmddmg@gmail.com");

            dc.AddString("inviterUrl", "www.rocksolidlabs.com");

            Image ourLogo = Image.FromFile(@"../../Documents/rocksolidlogo.JPG");
            dc.AddImage("rocksolidlogo", ourLogo);
        }
    }
}
