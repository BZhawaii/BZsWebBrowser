using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BZsWebBrowser2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function is called when the exit menu item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made by: BZ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// On click of this buttone the web control will display the pag requested.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            NavigateToPage();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Enabled = true;
            TextBox1.Enabled = true;
        }

        /// <summary>
        /// This is the core function that will perform navigation
        /// </summary>
        private void NavigateToPage()
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
            webBrowser1.Navigate(textBox1.Text);

        }

        /// <summary>
        /// This function will fire every time  a key is pushed and released
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if the keystroke was enter then do something
            if( e.KeyChar == (char)ConsoleKey.Enter)
            {
                NavigateToPage();

            }
        }
    }
}
