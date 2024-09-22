using Microsoft.VisualBasic.Logging;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Log("long running op");
            await Task.Delay(5000);
            await Log("done");
        }



        private async Task Log(string message)
        {
            txtLog.Text += $"{DateTime.Now.ToString("HH:mm:ss")}: {message} {Environment.NewLine}";
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //label1.Text = (e.X + Location.X) + ", " + (e.Y + Location.Y) + " ClickType:" + e.Button;
            Log("there was a click");
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSetTimer_Click(object sender, EventArgs e)
        {
            int timerSeconds = Convert.ToInt32(txtTimerSeconds.Text);
            await Log($"timer set to: {timerSeconds} seconds");

            btnSetTimer.Enabled = false;
            btnStopTimer.Enabled = true;
            timer1.Interval = timerSeconds * 1000;
            timer1.Start();
        }

        private async void btnStopTimer_Click(object sender, EventArgs e)
        {
            await Log("stop timer");

            btnSetTimer.Enabled = true;
            btnStopTimer.Enabled = false;
            timer1.Stop();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            Log("tick from timer");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomMouseClick clicker = new CustomMouseClick();
            clicker.ClickAt(4612, 743);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            var pos = Cursor.Position;

            Log($"{pos.X} / {pos.Y}");
        }
    }
}
