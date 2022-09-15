namespace Broadcaster
{
    public partial class Form1 : Form
    {
        Class1 rmq = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rmq.InitRMQConnection();
            rmq.CreateRMQConnection();
            while (!rmq.connection.IsOpen) { /*loooping hingga koneksi terbuka*/ }
            rmq.CreateRMQChannel("workQ");
            while (!rmq.channel.IsOpen) { /*loooping hingga channel terbuka*/ }
            if (rmq.connection.IsOpen && rmq.channel.IsOpen)
            {
                bt_kirim.Enabled = true;
                bt_disconnect.Enabled = true;
                bt_connect.Enabled = true;
              

            }
        }

        private void bt_disconnect_Click(object sender, EventArgs e)
        {
            rmq.Disconnect();
            bt_kirim.Enabled = false;
            bt_disconnect.Enabled = false;
            bt_connect.Enabled = false;
        }

        private void bt_kirim_Click(object sender, EventArgs e)
        {
            rmq.SendMessage(tb_tujuan.Text, tb_pesan.Text);
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            rmq.CreateRMQConnection();
        }
    }
}