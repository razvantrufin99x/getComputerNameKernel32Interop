using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace getComputerNameKernel32Interop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        [DllImport("kernel32.DLL", CharSet = CharSet.Unicode)]
        public static extern bool GetComputerName(
        StringBuilder computerName, ref int size);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder buf = new StringBuilder(255);
            int size = buf.Capacity;
            GetComputerName(buf, ref size);
            textBox1.Text = buf.ToString() + " , Size =  " + size.ToString();
        }
    }
}
