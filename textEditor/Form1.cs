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

namespace textEditor
{
    public partial class Form1 : Form
    {
        private OpenFileDialog ofd;
        public Form1()
        {
            InitializeComponent();
        }

        int n = 0;
        int u = 0;
        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save";
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt" + "|" +
                                "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                                "All Files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                rtbUpis.Text = saveFileDialog.FileName;
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
              string text = File.ReadAllText(ofd.FileName);
                rtbUpis.Text = text;
            }       
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
        
                rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Bold);
            n++;
            if(n == 2)
            {
                rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Regular);
                n = 0;
            }
              
        }

        private void btnUnder_Click(object sender, EventArgs e)
        {
            rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Underline);
            u++;
            if (u == 2)
            {
                rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Regular);
                u = 0;
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Italic);
            i++;
            if (i == 2)
            {
                rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Regular);
                i = 0;
            }
        }
    }
}
