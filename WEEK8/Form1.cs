﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
           Calculator();
          // btnSum.Text=(lblResult.Text == "4")? "Multiply":"Salak";
        }

        private void Calculator()
        {
//            Random neRandom=new Random();
//            txtNumSecond.Text= neRandom.Next(1, 49).ToString();
            var num1 = Convert.ToInt16(txtNumFirst.Text);
            var num2 = Convert.ToInt16(txtNumSecond.Text);
            var result = num1+num2;
            lblResult.Text = result.ToString();
            
        }
    }
}
