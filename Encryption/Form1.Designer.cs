namespace Encryption
{
    partial class Form1
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
            this.matin = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel4 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // matin
            // 
            this.matin.Location = new System.Drawing.Point(49, 78);
            this.matin.Name = "matin";
            this.matin.Size = new System.Drawing.Size(270, 45);
            this.matin.TabIndex = 0;
            this.matin.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(49, 224);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(270, 124);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Sezir Encryption",
            "Polibiy"});
            this.metroComboBox1.Location = new System.Drawing.Point(49, 149);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(128, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(239, 149);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(80, 29);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Encryption";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(32, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(49, 53);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(52, 23);
            this.htmlLabel1.TabIndex = 4;
            this.htmlLabel1.Text = "Text";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(35, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(49, 124);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(52, 23);
            this.htmlLabel2.TabIndex = 5;
            this.htmlLabel2.Text = "Type";
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(76, 23);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(49, 198);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(89, 23);
            this.htmlLabel3.TabIndex = 6;
            this.htmlLabel3.Text = "Code on Text";
            // 
            // htmlLabel4
            // 
            this.htmlLabel4.AutoScroll = true;
            this.htmlLabel4.AutoScrollMinSize = new System.Drawing.Size(29, 23);
            this.htmlLabel4.AutoSize = false;
            this.htmlLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel4.Location = new System.Drawing.Point(176, 124);
            this.htmlLabel4.Name = "htmlLabel4";
            this.htmlLabel4.Size = new System.Drawing.Size(58, 23);
            this.htmlLabel4.TabIndex = 7;
            this.htmlLabel4.Text = "Key";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(29, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(183, 149);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(51, 23);
            this.metroTextBox1.TabIndex = 8;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(239, 188);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(80, 29);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "unEncryption";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 370);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.htmlLabel4);
            this.Controls.Add(this.htmlLabel3);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.matin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox matin;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}

