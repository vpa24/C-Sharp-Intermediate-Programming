using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vu_CEIS209_Part1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private bool validInput()
        {
            bool isvalid = true;
            if (string.IsNullOrEmpty(titleText.Text))
            {
                MessageBox.Show("The song title cannot be blank");
            }
            else if (string.IsNullOrEmpty(artistText.Text))
            {
                MessageBox.Show("The artist cannot be blank");
            }
            else if (string.IsNullOrEmpty(genreText.Text))
            {
                MessageBox.Show("The genre cannot be blank");
            }
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                MessageBox.Show("The year cannot be blank");

            }
            else if(string.IsNullOrEmpty(urlText.Text))
            {
                MessageBox.Show("The URL cannot be blank");
            }
            return isvalid;
        }
        private void addButton_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder(string.Empty);
            string nl = "\r\n";

            if(validInput())
            {
                sb.Append("Title: " + titleText.Text);
                sb.Append(nl);
                sb.Append("Artist: " + artistText.Text);
                sb.Append(nl);
                sb.Append("Genre: " + genreText.Text);
                sb.Append(nl);
                sb.Append("Year: " + yearText.Text);
                sb.Append(nl);
                sb.Append("URL: " + urlText.Text);
                sb.Append(nl);

                outputText.Text = sb.ToString();
                songList.Items.Add(titleText.Text);
                
            }
        }

        private bool songInList(string songTitle)
        {
            foreach (var item in songList.Items)
            {
                string title = item.ToString();
                if (title == songTitle)
                {
                    return true;
                }
            }
            return false;
        }
        private void allSongsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string nl = "\r\n";

            foreach (var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(nl);
            }

            outputText.Text = sb.ToString();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (songInList(titleText.Text))
            {
                MessageBox.Show("Song found");
            }
            else
            {
                MessageBox.Show("Song not found");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            titleText.Text = artistText.Text = genreText.Text = yearText.Text = urlText.Text = "";
        }
    }
}
