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
        
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            UserName = NameTextbox.Text;
            // UserAge = Convert.ToSingle(AgeTextbox.Text);
            UserAge = float.Parse(AgeTextbox.Text);
           
            OutPutlabel.Text = NameTextbox.Text + " " + AgeTextbox.Text;


        }

        private void Clear()
        {
            NameTextbox.Clear();
            AgeTextbox.Clear();
            BtnSubmit.Enabled = false;
        }

        private void Lab08_Load(object sender, EventArgs e)
        {
            BtnSubmit.Enabled = false;
            Clear();
        }

        private void InfoGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
