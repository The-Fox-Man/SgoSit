﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FoxManPr
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(one.Text == "" || two.Text == "" || five.Text == "" || four.Text == "" || threee.Text == "" || six.Text == "")
            {
                MessageBox.Show("Fuck you");      
            }
            else
            {
                File.AppendAllText("../../txt/users.txt", Environment.NewLine + one.Text + ", " + two.Text + ", "
                                       + threee.Text + ", " + four.Text + ", " + five.Text);
                MessageBox.Show("Yeee");
                Close();
            }
        }

        private void five_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
