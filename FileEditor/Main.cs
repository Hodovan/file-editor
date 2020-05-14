using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                rtbContent.SaveFile(saveFileDialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rtbContent.LoadFile(openFileDialog.FileName);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void mitSearch_DoubleClick(object sender, EventArgs e)
        {
            if (mitSearch.Text.Length > 0)
            {
                int start = rtbContent.Find(mitSearch.Text);

                rtbContent.Select(start, mitSearch.Text.Length);
                rtbContent.SelectionBackColor = Color.Yellow;
            }
        }

        private void mitReplace_DoubleClick(object sender, EventArgs e)
        {
            rtbContent.Text = rtbContent.Text.Replace(mitSearch.Text, mitReplace.Text);
        }

        private void mitFont_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            rtbContent.Font = fontDialog.Font;
        }

        private void mitPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbContent.Text, rtbContent.Font, Brushes.Black,
                                  e.MarginBounds, StringFormat.GenericTypographic);
        }

        private void mitPrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}
