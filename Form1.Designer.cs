namespace TradeAsist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.customComboBox1 = new TradeAsist.tools.CustomComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.customComboBox2 = new TradeAsist.tools.CustomComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.CadetBlue;
            this.button1.Image = global::TradeAsist.Properties.Resources.icons8_add_48;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Image = global::TradeAsist.Properties.Resources.icons8_remove_24;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // customComboBox1
            // 
            this.customComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customComboBox1.Back_color = System.Drawing.Color.White;
            this.customComboBox1.BackColor = System.Drawing.Color.IndianRed;
            this.customComboBox1.BorderColor = System.Drawing.Color.IndianRed;
            this.customComboBox1.BorderSize = 1;
            this.customComboBox1.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            resources.ApplyResources(this.customComboBox1, "customComboBox1");
            this.customComboBox1.Font_color = System.Drawing.Color.IndianRed;
            this.customComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customComboBox1.Items.AddRange(new object[] {
            resources.GetString("customComboBox1.Items"),
            resources.GetString("customComboBox1.Items1"),
            resources.GetString("customComboBox1.Items2"),
            resources.GetString("customComboBox1.Items3"),
            resources.GetString("customComboBox1.Items4")});
            this.customComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.customComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Texts = "";
            this.customComboBox1.OnSelectedIndexChanged += new System.EventHandler(this.customComboBox1_OnSelectedIndexChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Image = global::TradeAsist.Properties.Resources.icons8_minimize_window_24;
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Image = global::TradeAsist.Properties.Resources.icons8_close_window_24;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // customComboBox2
            // 
            this.customComboBox2.Back_color = System.Drawing.Color.White;
            this.customComboBox2.BackColor = System.Drawing.Color.IndianRed;
            this.customComboBox2.BorderColor = System.Drawing.Color.IndianRed;
            this.customComboBox2.BorderSize = 1;
            this.customComboBox2.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBox2.Font_color = System.Drawing.Color.IndianRed;
            this.customComboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.customComboBox2.Items.AddRange(new object[] {
            resources.GetString("customComboBox2.Items"),
            resources.GetString("customComboBox2.Items1"),
            resources.GetString("customComboBox2.Items2"),
            resources.GetString("customComboBox2.Items3"),
            resources.GetString("customComboBox2.Items4"),
            resources.GetString("customComboBox2.Items5"),
            resources.GetString("customComboBox2.Items6"),
            resources.GetString("customComboBox2.Items7"),
            resources.GetString("customComboBox2.Items8"),
            resources.GetString("customComboBox2.Items9"),
            resources.GetString("customComboBox2.Items10")});
            this.customComboBox2.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.customComboBox2.ListTextColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.customComboBox2, "customComboBox2");
            this.customComboBox2.Name = "customComboBox2";
            this.customComboBox2.Texts = "";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customComboBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customComboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private tools.CustomComboBox customComboBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private tools.CustomComboBox customComboBox2;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}