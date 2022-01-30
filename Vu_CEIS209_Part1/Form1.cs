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
        string[] titlesArray = new string[5];
        string[] artistsArray = new string[5];
        string[] genresArray = new string[5];
        int[] yearArray = new int[5];
        string[] urlArray = new string[5];

        int songCount = 0;
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

            if (songCount == titlesArray.Length)
                MessageBox.Show("Song List is full!");

            else if(validInput())
            {
                // add title to song list
                songList.Items.Add(titleText.Text);

                
                titlesArray[songCount] = titleText.Text;
                artistsArray[songCount] = artistText.Text;
                genresArray[songCount] = genreText.Text;
                yearArray[songCount] = Int16.Parse(yearText.Text);
                urlArray[songCount] = urlText.Text;

                songCount++;

                // Build the output text
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
        
        private bool validTitle()
        {
            bool valid = true;
            if (string.IsNullOrEmpty(titleText.Text))
            {
                MessageBox.Show("The song title cannot be blank");
                valid = false;
            }
            return valid;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            int songIndex = 0;
            StringBuilder sb = new StringBuilder(string.Empty);
            string nl = "\r\n";

            if (validTitle())
            {
                if (songInList(titleText.Text))
                {
                    songIndex = getSongIndex(titleText.Text);
                    sb.Append(titleText.Text);
                    sb.Append(nl);
                    sb.Append(artistsArray[songIndex]);
                    sb.Append(nl);
                    sb.Append(genresArray[songIndex]);
                    sb.Append(nl);
                    sb.Append(yearArray[songIndex]);
                    sb.Append(nl);
                    sb.Append(urlArray[songIndex]);

                    MessageBox.Show("Song found");
                }
                else
                {
                    MessageBox.Show("Song not found");
                }
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            titleText.Text = artistText.Text = genreText.Text = yearText.Text = urlText.Text = "";
        }

        private int getSongIndex(string songTitle)
        {
            return songList.Items.IndexOf(songTitle);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int songIndex = songList.SelectedIndex;
            webBrowserDisplay.Navigate(new Uri(urlArray[songIndex]));
        }

        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string nl = "\r\n";
            int songIndex = -1;

            songIndex = songList.SelectedIndex;

            sb.Append(titlesArray[songIndex]);
            sb.Append(nl);
            sb.Append(artistsArray[songIndex]);
            sb.Append(nl);
            sb.Append(genresArray[songIndex]);
            sb.Append(nl);
            sb.Append(yearArray[songIndex]);
            sb.Append(nl);
            sb.Append(urlArray[songIndex]);
            sb.Append(nl);

            outputText.Text = sb.ToString();
        }
    }
}
