using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StimulsoftRedirector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SelectedServer.SelectedIndexChanged += SelectedServer_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectedServer.SelectedIndex = 0;
            
        }

        private void SelectedServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectedServer.SelectedIndex == 0) 
            {
                //Заполнить PrintFormTypeList значениями для test
            }
            else
            {
                //Заполнить PrintFormTypeList значениями для stage
            }
        }
    }
}
