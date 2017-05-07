using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Run_NURBS
{
    public partial class Main : Form
    {
        public Main()
        {           
            InitializeComponent();
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string[] files = Directory.GetFiles(path, "*.bat");
            foreach(string x in files)
            {
                listBatFiles.Items.Add(Path.GetFileName(x));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool empty()
        {
            int x = 0;
            if (string.IsNullOrWhiteSpace(textPoints.Text))
                return true;
            if (string.IsNullOrWhiteSpace(textWeights.Text))
                return true;
            if (string.IsNullOrWhiteSpace(textKnotsU.Text))
                return true;
            if (string.IsNullOrWhiteSpace(textKnotsV.Text))
                return true;
            if (string.IsNullOrWhiteSpace(textMakeFile.Text))
                return true;
            if (!Int32.TryParse(textNumSurface.Text, out x))
                return true;
            else if (x > 10 || x < 1)
                return true;
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string space = " ";
            string extension = textMakeFile.Text + ".bat";
            path = path + "\\" + extension;
            
            if (!empty()) 
            { 
                TextWriter tw = new StreamWriter(path, true);
                tw.WriteLine("NURBS.exe " + textNumSurface.Text + space + textPoints.Text + space 
                + textWeights.Text + space + textKnotsU.Text + space + textKnotsV.Text);
                tw.Close();
                listBatFiles.Items.Add(extension);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textPoints.Text = Path.GetFileName(openFileDialog1.FileName);              
            else { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textWeights.Text = Path.GetFileName(openFileDialog1.FileName);
            else { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textKnotsU.Text = Path.GetFileName(openFileDialog1.FileName);
            else { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textKnotsU.Text = Path.GetFileName(openFileDialog1.FileName);
            else { }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            if (listBatFiles.SelectedItems.Count == 1)
                Process.Start(listBatFiles.SelectedItems[0].Text);
        }

        private void labNumSurface_Click(object sender, EventArgs e)
        {

        }
    }
}
