using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Progetto_Oleoni_Sampietro
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Questa è la funzione che premendo il bottone (Salva html), salva appunto il documento html.
        /// </summary>
        private void btn_html_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(sv.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(txt_html.Text);
                }
            }
        }
        /// <summary>
        /// Questa è la funzione che premendo il bottone (Salva css), salva appunto il documento css.
        /// </summary>
        private void btn_css_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(sv.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(txt_css);
                }
            }
        }

        private void txt_css_TextChanged(object sender, EventArgs e)
        {
            Ub();
        }

        private void txt_html_TextChanged(object sender, EventArgs e)
        {
            Ub();
        }
        ///<summary>
        /// Questa è la funzione che permette di simulare nel webbrowser lo scritto delle due richtextbox. Ed infine di collegare css con html.
        ///</summary>
        private void Ub()
        {
            webBrowser1.DocumentText = txt_html.Text.Replace("@lol", txt_css.Text);
        }

        private void txt_html_KeyUp(object sender, KeyEventArgs e)
        {
            Ub();
        }

        private void txt_css_KeyUp(object sender, KeyEventArgs e)
        {
            Ub();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
