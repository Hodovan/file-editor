namespace FileEditor
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mitSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mitPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mitPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mitExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mitSearch = new System.Windows.Forms.ToolStripTextBox();
            this.mitReplace = new System.Windows.Forms.ToolStripTextBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 33);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitOpen,
            this.mitSave,
            this.mitPrintPreview,
            this.mitPrint,
            this.mitExit});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mitOpen
            // 
            this.mitOpen.Name = "mitOpen";
            this.mitOpen.Size = new System.Drawing.Size(195, 30);
            this.mitOpen.Text = "Open";
            this.mitOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // mitSave
            // 
            this.mitSave.Name = "mitSave";
            this.mitSave.Size = new System.Drawing.Size(195, 30);
            this.mitSave.Text = "Save";
            this.mitSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // mitPrintPreview
            // 
            this.mitPrintPreview.Name = "mitPrintPreview";
            this.mitPrintPreview.Size = new System.Drawing.Size(195, 30);
            this.mitPrintPreview.Text = "Print Preview";
            this.mitPrintPreview.Click += new System.EventHandler(this.mitPrintPreview_Click);
            // 
            // mitPrint
            // 
            this.mitPrint.Name = "mitPrint";
            this.mitPrint.Size = new System.Drawing.Size(195, 30);
            this.mitPrint.Text = "Print";
            this.mitPrint.Click += new System.EventHandler(this.mitPrint_Click);
            // 
            // mitExit
            // 
            this.mitExit.Name = "mitExit";
            this.mitExit.Size = new System.Drawing.Size(195, 30);
            this.mitExit.Text = "Exit";
            this.mitExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitFont,
            this.mitSearch,
            this.mitReplace});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mitFont
            // 
            this.mitFont.Name = "mitFont";
            this.mitFont.Size = new System.Drawing.Size(160, 30);
            this.mitFont.Text = "Font";
            this.mitFont.Click += new System.EventHandler(this.mitFont_Click);
            // 
            // mitSearch
            // 
            this.mitSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mitSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.mitSearch.Name = "mitSearch";
            this.mitSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mitSearch.Size = new System.Drawing.Size(100, 23);
            this.mitSearch.Text = "Search...";
            this.mitSearch.ToolTipText = "Search...";
            this.mitSearch.DoubleClick += new System.EventHandler(this.mitSearch_DoubleClick);
            // 
            // mitReplace
            // 
            this.mitReplace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mitReplace.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.mitReplace.Name = "mitReplace";
            this.mitReplace.Size = new System.Drawing.Size(100, 23);
            this.mitReplace.Tag = "";
            this.mitReplace.Text = "Replace...";
            this.mitReplace.ToolTipText = "Replace...";
            this.mitReplace.DoubleClick += new System.EventHandler(this.mitReplace_DoubleClick);
            // 
            // rtbContent
            // 
            this.rtbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbContent.Location = new System.Drawing.Point(0, 33);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(800, 417);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "rtf";
            this.saveFileDialog.Filter = "Rich Text Format | *.rtf";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "rtf";
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Rich Text Format|*.rtf|All files|*.*";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.Text = "File Editor";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitOpen;
        private System.Windows.Forms.ToolStripMenuItem mitSave;
        private System.Windows.Forms.ToolStripMenuItem mitExit;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox mitSearch;
        private System.Windows.Forms.ToolStripTextBox mitReplace;
        private System.Windows.Forms.ToolStripMenuItem mitFont;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem mitPrintPreview;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.ToolStripMenuItem mitPrint;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}

