
namespace Pharmacy_management
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.销售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓储管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.财务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.药品信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.销售管理ToolStripMenuItem,
            this.仓储管理ToolStripMenuItem,
            this.财务管理ToolStripMenuItem,
            this.药品信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 销售管理ToolStripMenuItem
            // 
            this.销售管理ToolStripMenuItem.Name = "销售管理ToolStripMenuItem";
            this.销售管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.销售管理ToolStripMenuItem.Text = "销售管理";
            // 
            // 仓储管理ToolStripMenuItem
            // 
            this.仓储管理ToolStripMenuItem.Name = "仓储管理ToolStripMenuItem";
            this.仓储管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.仓储管理ToolStripMenuItem.Text = "仓储管理";
            // 
            // 财务管理ToolStripMenuItem
            // 
            this.财务管理ToolStripMenuItem.Name = "财务管理ToolStripMenuItem";
            this.财务管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.财务管理ToolStripMenuItem.Text = "财务管理";
            // 
            // 药品信息ToolStripMenuItem
            // 
            this.药品信息ToolStripMenuItem.Name = "药品信息ToolStripMenuItem";
            this.药品信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.药品信息ToolStripMenuItem.Text = "药品信息";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 641);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "药房管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 销售管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓储管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 财务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 药品信息ToolStripMenuItem;
    }
}