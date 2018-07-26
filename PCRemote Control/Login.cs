using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCRemote_Control
{
    public partial class Login : Form
    {
        private bool username_passed = false;
        private bool pass_passed = false;
        public Form1 form;

        public Login(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            button1.Enabled = false;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Trim()!="") {
                username_passed = true;
                if (pass_passed) {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }

            }
            else
            {
                username_passed = true;
                button1.Enabled = false;
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox2.Text.Trim() != "")
            {
                pass_passed = true;
                if (username_passed)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }

            }
            else
            {
                pass_passed = false;
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,"I'am an unuseful button. \nMy destiny is to do nothing.\nPlease, don't click me.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string URL = "https://roccos.altervista.org/rest/login.php?&username=" + username + "&password=" + password + "";
            try
            {

                using (WebClient client = new WebClient())
                {
                    string response = client.DownloadString(URL);
                    if (!(response == "0 results"))
                    {
                        //var json = response;
                        form.passed = true;
                        //JObject o = JObject.Parse(json
                        Close();
                    }
                    else { MessageBox.Show("Verifica i dati", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error); form.passed = false; }
                    //Close();
                }
            }
            catch (Exception ex)
            {
                ex.GetType();
                MessageBox.Show("Connection error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
