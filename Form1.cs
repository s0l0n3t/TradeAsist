using System.Data.SQLite;
using System.Data;

namespace TradeAsist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SQLiteDataAdapter Adapter;
        SQLiteConnection Connector;
        SQLiteCommand User_Command;
        DataSet db_ds;
        DataGridView data = new DataGridView();

        void GetTable()
        {
            Connector = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            Adapter = new SQLiteDataAdapter("Select *From Test", Connector);
            db_ds = new DataSet();
            Connector.Open();
            Adapter.Fill(db_ds, "Test");
            data.DataSource = db_ds.Tables["Test"];
            Connector.Close();
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
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
    }
}