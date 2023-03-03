using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worpadkiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            var bytes = wc.DownloadData("https://en.wikipedia.org/wiki/Main_Page");
            var str = Encoding.Default.GetString(bytes);
            File.WriteAllText("site.txt", str);
        }

        private void boldbtn_Click(object sender, EventArgs e)
        {
            maininput.Font=new Font(Font.FontFamily,Font.Size,FontStyle.Bold);
        }

        private void underlinebtn_Click(object sender, EventArgs e)
        {
            maininput.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Underline);
        }

        private void italicbtn_Click(object sender, EventArgs e)
        {
            maininput.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Italic);
        }

        private void leftbtn_Click(object sender, EventArgs e)
        {
            maininput.TextAlign = HorizontalAlignment.Left;
        }

        private void centerbtn_Click(object sender, EventArgs e)
        {
            maininput.TextAlign = HorizontalAlignment.Center;
        }

        private void rightbtn_Click(object sender, EventArgs e)
        {
            maininput.TextAlign = HorizontalAlignment.Right;
        }

        private void sizeinput_SelectedIndexChanged(object sender, EventArgs e)
        {
            maininput.Font = new Font(Font.FontFamily, sizeinput.SelectedIndex);
        }

        private void colorinput_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (colorinput.SelectedItem)
            {
                case "Red":
                    maininput.ForeColor = Color.Red;
                    break;
                case "Black":
                    maininput.ForeColor = Color.Black;
                    break;
                case "Blue":
                    maininput.ForeColor = Color.Blue;
                    break;
                case "Green":
                    maininput.ForeColor = Color.Green;
                    break;
                case "Yellow":
                    maininput.ForeColor = Color.Yellow;
                    break;
                default:
                    maininput.ForeColor = Color.Blue;
                    break;
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(savenameinput.Text, maininput.Text);
            
        }
    }
}
