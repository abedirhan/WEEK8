using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8new
{
    public partial class Lab08 : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }
        public Lab08()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextbox.Text);
                BtnSubmit.Enabled = true;
            }
            catch (Exception exception)
            {
                BtnSubmit.Enabled = false;
             
            }
            
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            BtnSubmit.Enabled = (NameTextbox.Text.Length >= 2) ? true : false;
        }
        /// <summary>
        /// Event Handler for submit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            UserName = NameTextbox.Text;
           // UserAge = Convert.ToSingle(AgeTextbox.Text);
            UserAge = float.Parse(AgeTextbox.Text);
            NameTextbox.Clear();
            AgeTextbox.Clear();
            OutPutlabel.Text = NameTextbox.Text + " " + AgeTextbox.Text;


        }

        private void Lab08_Load(object sender, EventArgs e)
        {
            BtnSubmit.Enabled = false;
        }
    }
}
