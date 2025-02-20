namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string labeltext;
        public Form1()
        {
            InitializeComponent();
            labeltext = label1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(labeltext.IndexOf(','));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(labeltext.Insert(10, "[INSERTED]"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] st = {"JOIN", "STRING","///"};
            string delim = " ";
            label2.Text = Convert.ToString(String.Join(delim,st));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(labeltext.LastIndexOf('!'));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(labeltext.Remove(20));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(labeltext.Replace("?", "[QUESTION]"));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = String.Join(" ", labeltext.Split(' ', 'A'));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(labeltext.Substring(5, 10));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(labeltext.ToLower());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = (labeltext.Trim(' ', '.', '?', '!'));
        }
    }
}
