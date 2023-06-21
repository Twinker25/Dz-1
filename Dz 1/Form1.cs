namespace Dz_1
{
    public partial class Form1 : Form
    {
        DateTime date;
        private int timeSec;
        private int timeMin;
        private int timeHour;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            if (time.Hour == timeHour && time.Minute == timeMin && time.Second == timeSec)
            {
                timer1.Stop();
                MessageBox.Show($"Time to do this task: {textBox4.Text}", "Time`s out!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
            timeHour = int.Parse(textBox3.Text);
            timeMin = int.Parse(textBox2.Text);
            timeSec = int.Parse(textBox1.Text);
            timer1.Start();
        }
    }
}