using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp_WinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1() // Startup of program/form. Do not overload this. Make any heavy code in here multithreaded.
        {
            InitializeComponent(); // Required to start the program, I believe. Anything under this is called on program startup.
        }

        private void button1_Click(object sender, EventArgs e) // Event for clicking the specified control in the form (in this case, the button).
        {
            MessageBox.Show("Hello, World!", "Hi, there!"); // User clicked the button, so say "Hello"!
        }
    }
}
