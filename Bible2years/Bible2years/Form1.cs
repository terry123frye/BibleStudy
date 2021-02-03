using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Bible2years
{
    public partial class Form1 : Form
    {
        private Data dataToRead;

        public Form1()
        {
            InitializeComponent();
            InitializeScreen();
        }

        private void InitializeScreen()
        {
            dataToRead = new Data();
            Icon ico = new System.Drawing.Icon("14_holy_bible_christian_religious_book_prayer_icon-icons.com_77049.ico");
            this.Icon = ico;
        }

        private void RefreshReading()
        {
            RefreshValues newValues = dataToRead.GetRefreshValues();

            lblVersesToRead.Text = newValues.VersesToRead;
            lblStart.Text = newValues.Start;
            lblCurrent.Text = newValues.Current;
            lblReadIndicator.Text = newValues.ReadIndicator;
            button4.Enabled = newValues.IsRead;
            pictureBox1.Image = newValues.image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataToRead.MarkAsRead();
            Form1.ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataToRead.GetNextDay();
            RefreshReading();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataToRead.GetPreviousDay();
            RefreshReading();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataToRead.MarkAsRead();
            RefreshReading();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            RefreshReading();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            lblStart.Visible = lblCurrent.Visible = !lblStart.Visible;
        }

        private void btnEscape_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
