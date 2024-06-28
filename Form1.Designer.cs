namespace MovieApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMovieName = new Label();
            txtMovieName = new TextBox();
            txtRating = new TextBox();
            txtDirector = new TextBox();
            lblRating = new Label();
            Director = new Label();
            cbcountry = new ComboBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            label13 = new Label();
            label14 = new Label();
            label11 = new Label();
            label12 = new Label();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtSearch = new TextBox();
            label4 = new Label();
            btnSearch = new Button();
            tabPage2 = new TabPage();
            button2 = new Button();
            label3 = new Label();
            txtimage = new TextBox();
            label2 = new Label();
            button1 = new Button();
            richSummary = new RichTextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog2 = new FolderBrowserDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMovieName.Location = new Point(37, 77);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(234, 48);
            lblMovieName.TabIndex = 0;
            lblMovieName.Text = "Movie Name";
            lblMovieName.Click += label1_Click;
            // 
            // txtMovieName
            // 
            txtMovieName.BorderStyle = BorderStyle.FixedSingle;
            txtMovieName.Location = new Point(319, 77);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(579, 55);
            txtMovieName.TabIndex = 1;
            // 
            // txtRating
            // 
            txtRating.BorderStyle = BorderStyle.FixedSingle;
            txtRating.Location = new Point(319, 229);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(579, 55);
            txtRating.TabIndex = 2;
            // 
            // txtDirector
            // 
            txtDirector.BorderStyle = BorderStyle.FixedSingle;
            txtDirector.Location = new Point(310, 392);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(588, 55);
            txtDirector.TabIndex = 3;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRating.Location = new Point(22, 229);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(246, 48);
            lblRating.TabIndex = 4;
            lblRating.Text = "Movie Rating";
            // 
            // Director
            // 
            Director.AutoSize = true;
            Director.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Director.Location = new Point(22, 392);
            Director.Name = "Director";
            Director.Size = new Size(272, 48);
            Director.TabIndex = 5;
            Director.Text = "Movie Director";
            // 
            // cbcountry
            // 
            cbcountry.FormattingEnabled = true;
            cbcountry.Location = new Point(319, 557);
            cbcountry.Name = "cbcountry";
            cbcountry.Size = new Size(579, 56);
            cbcountry.TabIndex = 6;
            cbcountry.SelectedIndexChanged += cbcountry_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 557);
            label1.Name = "label1";
            label1.Size = new Size(265, 48);
            label1.TabIndex = 7;
            label1.Text = "Select Country";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2792, 1362);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Location = new Point(12, 69);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(2768, 1281);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "SearchMovie";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1606, 306);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1113, 674);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1427, 324);
            label15.Name = "label15";
            label15.Size = new Size(119, 48);
            label15.TabIndex = 13;
            label15.Text = "Image";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(394, 855);
            label13.Name = "label13";
            label13.Size = new Size(0, 48);
            label13.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(91, 855);
            label14.Name = "label14";
            label14.Size = new Size(145, 48);
            label14.TabIndex = 11;
            label14.Text = "Country";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(362, 739);
            label11.Name = "label11";
            label11.Size = new Size(0, 48);
            label11.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(91, 739);
            label12.Name = "label12";
            label12.Size = new Size(169, 48);
            label12.TabIndex = 9;
            label12.Text = "Summary";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(394, 627);
            label9.Name = "label9";
            label9.Size = new Size(0, 48);
            label9.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(91, 627);
            label10.Name = "label10";
            label10.Size = new Size(149, 48);
            label10.TabIndex = 7;
            label10.Text = "Director";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(394, 512);
            label7.Name = "label7";
            label7.Size = new Size(0, 48);
            label7.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(91, 512);
            label8.Name = "label8";
            label8.Size = new Size(122, 48);
            label8.TabIndex = 5;
            label8.Text = "Rating";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 411);
            label6.Name = "label6";
            label6.Size = new Size(0, 48);
            label6.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 411);
            label5.Name = "label5";
            label5.Size = new Size(223, 48);
            label5.TabIndex = 3;
            label5.Text = "Movie Name";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(733, 126);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(780, 55);
            txtSearch.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(482, 129);
            label4.Name = "label4";
            label4.Size = new Size(234, 48);
            label4.TabIndex = 1;
            label4.Text = "Search Movie";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1576, 126);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(225, 69);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtimage);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(richSummary);
            tabPage2.Controls.Add(cbcountry);
            tabPage2.Controls.Add(lblMovieName);
            tabPage2.Controls.Add(txtMovieName);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtRating);
            tabPage2.Controls.Add(Director);
            tabPage2.Controls.Add(txtDirector);
            tabPage2.Controls.Add(lblRating);
            tabPage2.Location = new Point(12, 69);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(2768, 1281);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "AddMovie";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1129, 883);
            button2.Name = "button2";
            button2.Size = new Size(297, 89);
            button2.TabIndex = 13;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 706);
            label3.Name = "label3";
            label3.Size = new Size(233, 48);
            label3.TabIndex = 12;
            label3.Text = "Select Image";
            // 
            // txtimage
            // 
            txtimage.BorderStyle = BorderStyle.FixedSingle;
            txtimage.Location = new Point(317, 716);
            txtimage.Name = "txtimage";
            txtimage.Size = new Size(579, 55);
            txtimage.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1205, 77);
            label2.Name = "label2";
            label2.Size = new Size(296, 48);
            label2.TabIndex = 10;
            label2.Text = "Movie Summary";
            // 
            // button1
            // 
            button1.Location = new Point(923, 708);
            button1.Name = "button1";
            button1.Size = new Size(225, 69);
            button1.TabIndex = 9;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richSummary
            // 
            richSummary.BorderStyle = BorderStyle.FixedSingle;
            richSummary.Location = new Point(1541, 58);
            richSummary.Name = "richSummary";
            richSummary.Size = new Size(1055, 497);
            richSummary.TabIndex = 8;
            richSummary.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // folderBrowserDialog2
            // 
            folderBrowserDialog2.HelpRequest += folderBrowserDialog2_HelpRequest;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2851, 1412);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMovieName;
        private TextBox txtMovieName;
        private TextBox txtRating;
        private TextBox txtDirector;
        private Label lblRating;
        private Label Director;
        private ComboBox cbcountry;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private TextBox txtimage;
        private Label label2;
        private Button button1;
        private RichTextBox richSummary;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog2;
        private TextBox txtSearch;
        private Label label4;
        private Button btnSearch;
        private Label label11;
        private Label label12;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox1;
        private Label label15;
    }
}
