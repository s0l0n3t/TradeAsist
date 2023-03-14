using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using static System.Net.WebRequestMethods;

namespace TradeAsist
{
    public partial class Form1 : Form
    {
        private Label label_textbox;
        public Form1()
        {
            InitializeComponent();
            /*
            textBox1.Multiline = true;
            textBox1.MinimumSize = new Size(200, 30);
            textBox1.Size = new Size(200, 30);
            textBox1.Multiline = false;
            */
            label_textbox = new Label();
            label_textbox.Dock = DockStyle.Fill;
            label_textbox.AutoSize = false;
            label_textbox.BackColor = Color.DimGray;
            label_textbox.TextAlign = ContentAlignment.MiddleLeft;
            label_textbox.Padding = new Padding(8, 0, 0, 0);
            label_textbox.Font = new Font(this.Font.Name, 10F);
            

        }
        private void AdjustComboBoxDimensions()
        {
            textBox1.Width = label_textbox.Width;
            textBox1.Location = new Point()
            {
                X = this.Width - this.Padding.Right - textBox1.Width,
                Y = label_textbox.Bottom - textBox1.Height

            };

        }

        SQLiteDataAdapter Adapter;
        SQLiteConnection Connector;
        SQLiteCommand User_Command;
        DataSet db_ds;
        int Move_panel;
        int Move_X;
        int Move_Y;
        
        void GetTable()
        {

            Connector = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            Adapter = new SQLiteDataAdapter("Select *From Item", Connector);
            db_ds = new DataSet();
            Connector.Open();
            Adapter.Fill(db_ds  , "Item");
            dataGridView1.DataSource = db_ds.Tables["Item"];
            Connector.Close();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists("MyDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite");

                string sql = @"CREATE TABLE Item(
                               ID INTEGER PRIMARY KEY AUTOINCREMENT ,
                               FirstName           TEXT      NOT NULL,
                               LastName            TEXT       NOT NULL
                            );";
                Connector = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                Connector.Open();
                User_Command = new SQLiteCommand(sql, Connector);
                User_Command.ExecuteNonQuery();
                Connector.Close();
                
            }
            GetTable();
        }
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(customComboBox1.SelectedIndex == 0)
            {
                pictureBox1.Enabled= false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move_panel = 1;
            Move_X= e.X;
            Move_Y= e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move_panel = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(Move_panel == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Move_X,MousePosition.Y - Move_Y);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rect = new Rectangle(this.textBox1.Location.X, textBox1.Location.Y, textBox1.ClientSize.Width, textBox1.ClientSize.Height);


            rect.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rect,
Color.IndianRed, ButtonBorderStyle.Solid);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox1.ClientRectangle, Color.IndianRed, ButtonBorderStyle.Solid);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C start https://github.com/s0l0n3t/",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            };
            Process.Start(psi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Command = new SQLiteCommand();
            Connector.Open();
            User_Command.Connection = Connector;
            User_Command.CommandText = "insert into Item(Name,Feature,Price,Date,Time) values ('" + customComboBox1.SelectedItem+ "','" + customComboBox2.SelectedItem + "','" + textBox1.Text + "','" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.ToShortTimeString() + "')";
            User_Command.ExecuteNonQuery();
            Connector.Close();
            GetTable();
           
            
        }
    }
}
// DateTime.Now.ToShortTimeString()