namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.ToString();

            // Creating array of string length 
            char[] ch = new char[str.Length];

            // Copy character by character into array 
            for (int i = 0; i < str.Length; i++)
            {
                ch[i] = str[i];
            }

            // Clear the list box
            listBox1.Items.Clear();

            // Printing content of array 
            foreach (char c in ch)
            {
                listBox1.Items.Add(c);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string words = textBox4.Text.Trim();
            textBox5.Text = ("" + CountWords(words));
        }
        private int CountWords(string words)
        {
            string[] allWords = words.Split(' ');
            return allWords.Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string backwards = textBox2.Text;

            textBox3.Text = Backwards(backwards);
        }
        public static string Backwards(string str)
        {
            string backwards = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                backwards += str[i];
            }
            return backwards;
        }
    }
}