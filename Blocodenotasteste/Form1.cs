using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Blocodenotasteste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.ShowDialog();
                savefile.Filter = "(*.txt)|*.txt|(*.pdf)|*.pdf|All Files(*.*)|*.*";
                savefile.Title = "Save";

                DialogResult dr = savefile.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    using (StreamWriter escrever = new StreamWriter(savefile.FileName))
                    {

                        textBox1.Text = escrever.ToString();
                   



                    }
                    


                }
            }
        }
        

       
    }


