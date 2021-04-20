
namespace MultiOpenCmd
{
    partial class FmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.PanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSplit1 = new System.Windows.Forms.ToolStripButton();
            this.btnSplit2 = new System.Windows.Forms.ToolStripButton();
            this.btnSplit4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMain.ColumnCount = 2;
            this.PanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelMain.Location = new System.Drawing.Point(0, 53);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.RowCount = 2;
            this.PanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelMain.Size = new System.Drawing.Size(748, 457);
            this.PanelMain.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnSplit1,
            this.btnSplit2,
            this.btnSplit4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(748, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "布局";
            // 
            // btnSplit1
            // 
            this.btnSplit1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSplit1.Image = ((System.Drawing.Image)(resources.GetObject("btnSplit1.Image")));
            this.btnSplit1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSplit1.Name = "btnSplit1";
            this.btnSplit1.Size = new System.Drawing.Size(23, 22);
            this.btnSplit1.Text = "toolStripButton1";
            this.btnSplit1.Click += new System.EventHandler(this.btnSplit1_Click);
            // 
            // btnSplit2
            // 
            this.btnSplit2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSplit2.Image = ((System.Drawing.Image)(resources.GetObject("btnSplit2.Image")));
            this.btnSplit2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSplit2.Name = "btnSplit2";
            this.btnSplit2.Size = new System.Drawing.Size(23, 22);
            this.btnSplit2.Text = "toolStripButton2";
            this.btnSplit2.Click += new System.EventHandler(this.btnSplit2_Click);
            // 
            // btnSplit4
            // 
            this.btnSplit4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSplit4.Image = ((System.Drawing.Image)(resources.GetObject("btnSplit4.Image")));
            this.btnSplit4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSplit4.Name = "btnSplit4";
            this.btnSplit4.Size = new System.Drawing.Size(23, 22);
            this.btnSplit4.Text = "toolStripButton3";
            this.btnSplit4.Click += new System.EventHandler(this.btnSplit4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItemFile.Text = "文件";
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 22);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripMenuItemSetting
            // 
            this.toolStripMenuItemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetting});
            this.toolStripMenuItemSetting.Name = "toolStripMenuItemSetting";
            this.toolStripMenuItemSetting.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItemSetting.Text = "设置";
            // 
            // btnSetting
            // 
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(112, 22);
            this.btnSetting.Text = "首选项";
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 512);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cmd多开工具";
            this.Load += new System.EventHandler(this.FmMain_Load);
            this.Resize += new System.EventHandler(this.FmMain_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSplit1;
        private System.Windows.Forms.ToolStripButton btnSplit2;
        private System.Windows.Forms.ToolStripButton btnSplit4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetting;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnSetting;
    }
}

