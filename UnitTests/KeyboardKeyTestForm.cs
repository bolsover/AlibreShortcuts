using System.Windows.Forms;

namespace UnitTests
{
    public partial class KeyboardKeyTestForm : Form
    {
        public KeyboardKeyTestForm()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);  // Adds the KeyDown event handler
            this.KeyPreview = true;  // Allows the form to capture key events before they reach any control on the form
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.textBox1.Text = e.KeyCode.ToString() + " " + e.KeyValue.ToString();
            // Console.WriteLine("Key code: " + e.KeyCode + " " + e.KeyValue);
        }
    }
}