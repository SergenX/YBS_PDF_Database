namespace Ank_PDF_Database
{
    partial class DatabaseFounder_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseFounder_Form));
            Founder_BTN = new Button();
            Database_Selector_Box = new ComboBox();
            label1 = new Label();
            Found_Box = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            Status_Indicator = new Label();
            Reset_App = new Button();
            label8 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // Founder_BTN
            // 
            resources.ApplyResources(Founder_BTN, "Founder_BTN");
            Founder_BTN.Name = "Founder_BTN";
            Founder_BTN.UseVisualStyleBackColor = true;
            Founder_BTN.Click += button1_Click;
            // 
            // Database_Selector_Box
            // 
            resources.ApplyResources(Database_Selector_Box, "Database_Selector_Box");
            Database_Selector_Box.FormattingEnabled = true;
            Database_Selector_Box.Items.AddRange(new object[] { resources.GetString("Database_Selector_Box.Items"), resources.GetString("Database_Selector_Box.Items1"), resources.GetString("Database_Selector_Box.Items2"), resources.GetString("Database_Selector_Box.Items3"), resources.GetString("Database_Selector_Box.Items4") });
            Database_Selector_Box.Name = "Database_Selector_Box";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // Found_Box
            // 
            resources.ApplyResources(Found_Box, "Found_Box");
            Found_Box.FormattingEnabled = true;
            Found_Box.Name = "Found_Box";
            Found_Box.SelectedIndexChanged += Found_Box_SelectedIndexChanged;
            Found_Box.DoubleClick += Found_Box_DoubleClick;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // progressBar1
            // 
            resources.ApplyResources(progressBar1, "progressBar1");
            progressBar1.Name = "progressBar1";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(linkLabel1, "linkLabel1");
            linkLabel1.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabStop = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // Status_Indicator
            // 
            resources.ApplyResources(Status_Indicator, "Status_Indicator");
            Status_Indicator.Name = "Status_Indicator";
            // 
            // Reset_App
            // 
            resources.ApplyResources(Reset_App, "Reset_App");
            Reset_App.Name = "Reset_App";
            Reset_App.UseVisualStyleBackColor = true;
            Reset_App.Click += Reset_App_Click;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // DatabaseFounder_Form
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(label8);
            Controls.Add(Reset_App);
            Controls.Add(Status_Indicator);
            Controls.Add(label7);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Found_Box);
            Controls.Add(label1);
            Controls.Add(Database_Selector_Box);
            Controls.Add(Founder_BTN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DatabaseFounder_Form";
            Load += DatabaseFounder_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Founder_BTN;
        private ComboBox Database_Selector_Box;
        private Label label1;
        private ListBox Found_Box;
        private Label label3;
        private Label label4;
        private Label label2;
        private ProgressBar progressBar1;
        private LinkLabel linkLabel1;
        private Label label7;
        private Label Status_Indicator;
        private Button Reset_App;
        private Label label8;
        private Label label6;
    }
}
