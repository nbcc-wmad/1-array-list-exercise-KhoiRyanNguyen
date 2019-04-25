using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ArrayList message = new ArrayList();

        private bool forward = true;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            message.Add("I");
            message.Add("love");
            message.Add("programming");
            message.Add("so");
            message.Add("much");
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            lblMessage.ResetText();

            string x = "";
            for (int i = 0; i < message.Count; i++)
            {
                x += message[i] + " ";
            }
            lblMessage.Text = x;

            
            
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            message.Reverse();
            string x = "";
            for (int i = 0; i < message.Count; i++) 
            {
               
                x += message[i] + " ";
            }
            lblMessage.Text = x;
           



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            message.Insert(1, txtSecondPos.Text);
            string x = string.Empty;
            
            for (int i = 0; i < message.Count; i++)
            {
                
                x += message[i] + " ";
               
            }
           
            lblMessage.Text = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string x = string.Empty;

            for( int i = 0; i < message.Count; i ++)
            {
                x += message[i] + " ";
            }
            message.RemoveAt(1);
            lblMessage.Text = x;
        }
    }
}
