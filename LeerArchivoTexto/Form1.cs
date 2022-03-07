using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeerArchivoTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\prueba.txt");

                //Read the first line of text
                textBox1.Text = sr.ReadToEnd();

                sr.Close();
            }
            catch (Exception u)
            {
                //Console.WriteLine("Exception: " + u.Message);
                MessageBox.Show(u.Message);
            }
            finally
            {
                //Console.WriteLine("Executing finally block.");
                MessageBox.Show("Executing finally block.");
            }

        }


        private void btnAppend_Click(object sender, EventArgs e)
        {
            // Set a variable to the Documents path.
            string docPath =  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
            {
                outputFile.WriteLine(textBox1.Text);
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            // Create a string array with the lines of text
            string[] lines = { "First line", "Second line", "Third line" };

            // Set a variable to the Documents path.
            string docPath =    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }
    }
}
