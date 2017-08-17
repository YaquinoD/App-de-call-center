using System;
using System.Windows.Forms;

namespace Support_manager { 
    public partial class Downtimes : Form
    {
        public Downtimes()
        {
            InitializeComponent();

            string connetionString = null;
            MySqlConnection cnn; connetionString = "server=localhost;uid=root;database=sspm;pwd=smart123;";
            cnn = new MySqlConnection(connetionString); 
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
