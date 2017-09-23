using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElliottProject3
{
    public partial class Form1 : Form
    {
        Queue myQueue = new Queue();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(textBox1.Text, out value))
            {
                myQueue.addQueue(value);
                label1.Text = myQueue.Display();
            }
            else
                MessageBox.Show("Error: Only enter integer values.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(myQueue.deQueue() == null)
            {
                MessageBox.Show("Error: There is no value to remove.", "Empty Queue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label1.Text = myQueue.Display();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.SelectAll();
        }
    }
}
