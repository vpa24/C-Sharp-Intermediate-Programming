namespace Vu_CEIS209_Part1
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button addButton;
            System.Windows.Forms.Button allSongsButton;
            System.Windows.Forms.Button findButton;
            System.Windows.Forms.Button clearButton;
            System.Windows.Forms.Button playButton;
            this.titleLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.artistText = new System.Windows.Forms.TextBox();
            this.genreText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.songList = new System.Windows.Forms.ListBox();
            this.webBrowserDisplay = new System.Windows.Forms.WebBrowser();
            addButton = new System.Windows.Forms.Button();
            allSongsButton = new System.Windows.Forms.Button();
            findButton = new System.Windows.Forms.Button();
            clearButton = new System.Windows.Forms.Button();
            playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            addButton.Location = new System.Drawing.Point(92, 281);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(230, 30);
            addButton.TabIndex = 10;
            addButton.Text = "Add Song";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // allSongsButton
            // 
            allSongsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            allSongsButton.Location = new System.Drawing.Point(92, 348);
            allSongsButton.Name = "allSongsButton";
            allSongsButton.Size = new System.Drawing.Size(230, 30);
            allSongsButton.TabIndex = 15;
            allSongsButton.Text = "Show All Songs";
            allSongsButton.UseVisualStyleBackColor = false;
            allSongsButton.Click += new System.EventHandler(this.allSongsButton_Click);
            // 
            // findButton
            // 
            findButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            findButton.Location = new System.Drawing.Point(92, 409);
            findButton.Name = "findButton";
            findButton.Size = new System.Drawing.Size(230, 30);
            findButton.TabIndex = 17;
            findButton.Text = "Find Song";
            findButton.UseVisualStyleBackColor = false;
            findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // clearButton
            // 
            clearButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            clearButton.Location = new System.Drawing.Point(92, 476);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(230, 30);
            clearButton.TabIndex = 18;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // playButton
            // 
            playButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            playButton.Location = new System.Drawing.Point(1029, 618);
            playButton.Name = "playButton";
            playButton.Size = new System.Drawing.Size(230, 30);
            playButton.TabIndex = 20;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(22, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(41, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.Location = new System.Drawing.Point(22, 76);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(49, 20);
            this.artistLabel.TabIndex = 1;
            this.artistLabel.Text = "Artist";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(22, 124);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(55, 20);
            this.genreLabel.TabIndex = 2;
            this.genreLabel.Text = "Genre";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(22, 175);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(43, 20);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(28, 220);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(43, 20);
            this.urlLabel.TabIndex = 4;
            this.urlLabel.Text = "URL";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(92, 32);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(230, 22);
            this.titleText.TabIndex = 5;
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(92, 76);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(230, 22);
            this.artistText.TabIndex = 6;
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(92, 124);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(230, 22);
            this.genreText.TabIndex = 7;
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(92, 178);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(230, 22);
            this.yearText.TabIndex = 8;
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(92, 220);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(230, 22);
            this.urlText.TabIndex = 9;
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(410, 381);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(475, 267);
            this.outputText.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Song List";
            // 
            // songList
            // 
            this.songList.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.ItemHeight = 22;
            this.songList.Location = new System.Drawing.Point(410, 76);
            this.songList.Name = "songList";
            this.songList.ScrollAlwaysVisible = true;
            this.songList.Size = new System.Drawing.Size(475, 268);
            this.songList.TabIndex = 16;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.songList_SelectedIndexChanged);
            // 
            // webBrowserDisplay
            // 
            this.webBrowserDisplay.Location = new System.Drawing.Point(924, 76);
            this.webBrowserDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserDisplay.Name = "webBrowserDisplay";
            this.webBrowserDisplay.Size = new System.Drawing.Size(402, 505);
            this.webBrowserDisplay.TabIndex = 19;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 680);
            this.Controls.Add(playButton);
            this.Controls.Add(this.webBrowserDisplay);
            this.Controls.Add(clearButton);
            this.Controls.Add(findButton);
            this.Controls.Add(this.songList);
            this.Controls.Add(allSongsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputText);
            this.Controls.Add(addButton);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "mainForm";
            this.Text = "Video Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.WebBrowser webBrowserDisplay;
    }
}

