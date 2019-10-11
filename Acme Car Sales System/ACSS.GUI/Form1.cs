using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACSS.Business;
using ACSS.DAL;

namespace ACSS.GUI
{
    public partial class Form1 : Form
    {
        private Repository _repo = new Repository();

        public Form1()
        {
            InitializeComponent();

            //Vi testar att hämta en lista med bilar
            //och visar den i listboxen
            foreach (Car c in _repo.Get())
            {
                listBox1.Items.Add(c);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Här hamnar du om du väljer något i listboxen
            Car c = (Car)listBox1.SelectedItem;
            MessageBox.Show(c.Model);
        }
    }
}
