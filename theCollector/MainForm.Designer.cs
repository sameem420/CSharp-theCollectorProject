namespace theCollector
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_movieType = new System.Windows.Forms.ComboBox();
            this.txt_movieTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_releaseYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radiobtn_true = new System.Windows.Forms.RadioButton();
            this.radiobtn_false = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_seriesType = new System.Windows.Forms.ComboBox();
            this.txt_seriesTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_seasonNO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_relYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(577, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check Connection";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(577, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(28, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(851, 180);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(28, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 308);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Movies Collection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_movieType);
            this.panel2.Controls.Add(this.txt_movieTitle);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_releaseYear);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.radiobtn_true);
            this.panel2.Controls.Add(this.radiobtn_false);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(17, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 249);
            this.panel2.TabIndex = 0;
            // 
            // txt_movieType
            // 
            this.txt_movieType.FormattingEnabled = true;
            this.txt_movieType.Items.AddRange(new object[] {
            "Adventure",
            "Comedy",
            "Action",
            "Cartoon",
            "Romantic",
            "Fantasy",
            "Thriller",
            "Historic",
            "Drama",
            "Horor",
            "Sci-Fi",
            "Crime",
            "Biografy",
            "Documentary"});
            this.txt_movieType.Location = new System.Drawing.Point(134, 90);
            this.txt_movieType.MaxDropDownItems = 9;
            this.txt_movieType.Name = "txt_movieType";
            this.txt_movieType.Size = new System.Drawing.Size(121, 21);
            this.txt_movieType.TabIndex = 2;
            // 
            // txt_movieTitle
            // 
            this.txt_movieTitle.Location = new System.Drawing.Point(134, 19);
            this.txt_movieTitle.Name = "txt_movieTitle";
            this.txt_movieTitle.Size = new System.Drawing.Size(302, 20);
            this.txt_movieTitle.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Watched :";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Save.Location = new System.Drawing.Point(308, 187);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 48);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Type:";
            // 
            // txt_releaseYear
            // 
            this.txt_releaseYear.Location = new System.Drawing.Point(134, 54);
            this.txt_releaseYear.Name = "txt_releaseYear";
            this.txt_releaseYear.Size = new System.Drawing.Size(121, 20);
            this.txt_releaseYear.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Year:";
            // 
            // radiobtn_true
            // 
            this.radiobtn_true.AutoSize = true;
            this.radiobtn_true.Location = new System.Drawing.Point(134, 126);
            this.radiobtn_true.Name = "radiobtn_true";
            this.radiobtn_true.Size = new System.Drawing.Size(43, 17);
            this.radiobtn_true.TabIndex = 3;
            this.radiobtn_true.TabStop = true;
            this.radiobtn_true.Text = "Yes";
            this.radiobtn_true.UseVisualStyleBackColor = true;
            // 
            // radiobtn_false
            // 
            this.radiobtn_false.AutoSize = true;
            this.radiobtn_false.Location = new System.Drawing.Point(134, 149);
            this.radiobtn_false.Name = "radiobtn_false";
            this.radiobtn_false.Size = new System.Drawing.Size(39, 17);
            this.radiobtn_false.TabIndex = 4;
            this.radiobtn_false.TabStop = true;
            this.radiobtn_false.Text = "No";
            this.radiobtn_false.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Movie Title :";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Series Collection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_seriesType);
            this.panel1.Controls.Add(this.txt_seriesTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txt_seasonNO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_relYear);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(17, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 249);
            this.panel1.TabIndex = 0;
            // 
            // txt_seriesType
            // 
            this.txt_seriesType.FormattingEnabled = true;
            this.txt_seriesType.Items.AddRange(new object[] {
            "Adventure",
            "Comedy",
            "Action",
            "Cartoon",
            "Romantic",
            "Fantasy",
            "Thriller",
            "Historic",
            "Drama",
            "Horor",
            "Sci-Fi",
            "Crime",
            "Biografy",
            "Documentary"});
            this.txt_seriesType.Location = new System.Drawing.Point(114, 108);
            this.txt_seriesType.MaxDropDownItems = 9;
            this.txt_seriesType.Name = "txt_seriesType";
            this.txt_seriesType.Size = new System.Drawing.Size(121, 21);
            this.txt_seriesType.TabIndex = 3;
            // 
            // txt_seriesTitle
            // 
            this.txt_seriesTitle.Location = new System.Drawing.Point(114, 30);
            this.txt_seriesTitle.Name = "txt_seriesTitle";
            this.txt_seriesTitle.Size = new System.Drawing.Size(332, 20);
            this.txt_seriesTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Watched : ";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(316, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_seasonNO
            // 
            this.txt_seasonNO.Location = new System.Drawing.Point(114, 56);
            this.txt_seasonNO.Name = "txt_seasonNO";
            this.txt_seasonNO.Size = new System.Drawing.Size(332, 20);
            this.txt_seasonNO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Type: ";
            // 
            // txt_relYear
            // 
            this.txt_relYear.Location = new System.Drawing.Point(114, 82);
            this.txt_relYear.Name = "txt_relYear";
            this.txt_relYear.Size = new System.Drawing.Size(121, 20);
            this.txt_relYear.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Year:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(114, 135);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Yes";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Season: ";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(114, 158);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(39, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "No";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "TV Series Title : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 527);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "the Collector : Entertainment Edition";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox txt_movieType;
        private System.Windows.Forms.TextBox txt_movieTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_releaseYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radiobtn_true;
        private System.Windows.Forms.RadioButton radiobtn_false;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txt_seriesType;
        private System.Windows.Forms.TextBox txt_seriesTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_seasonNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_relYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label5;
    }
}

