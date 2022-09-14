﻿
namespace EmployeesDIR
{
    partial class EmployeesDIR
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorFormDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chooseButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.opsToolStripMenuItem,
            this.helpMenu,
            this.debugToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(622, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip2";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveItem,
            this.openItem,
            this.settingsItem,
            this.exitItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 24);
            this.fileMenu.Text = "File";
            // 
            // saveItem
            // 
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(224, 26);
            this.saveItem.Text = "Save";
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.Size = new System.Drawing.Size(224, 26);
            this.openItem.Text = "Open";
            this.openItem.Click += new System.EventHandler(this.openItem_Click);
            // 
            // settingsItem
            // 
            this.settingsItem.Name = "settingsItem";
            this.settingsItem.Size = new System.Drawing.Size(224, 26);
            this.settingsItem.Text = "Settings";
            this.settingsItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(224, 26);
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // opsToolStripMenuItem
            // 
            this.opsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEmployeeToolStripMenuItem});
            this.opsToolStripMenuItem.Name = "opsToolStripMenuItem";
            this.opsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.opsToolStripMenuItem.Text = "Operations";
            this.opsToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // newEmployeeToolStripMenuItem
            // 
            this.newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            this.newEmployeeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newEmployeeToolStripMenuItem.Text = "New Employee";
            this.newEmployeeToolStripMenuItem.Click += new System.EventHandler(this.newEmployeeToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(58, 24);
            this.helpMenu.Text = "Help";
            this.helpMenu.Click += new System.EventHandler(this.helpMenu_Click);
            // 
            // aboutItem
            // 
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(224, 26);
            this.aboutItem.Text = "About";
            this.aboutItem.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testDebugToolStripMenuItem,
            this.errorFormDebugToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // testDebugToolStripMenuItem
            // 
            this.testDebugToolStripMenuItem.Name = "testDebugToolStripMenuItem";
            this.testDebugToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.testDebugToolStripMenuItem.Text = "Test";
            this.testDebugToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click_1);
            // 
            // errorFormDebugToolStripMenuItem
            // 
            this.errorFormDebugToolStripMenuItem.Name = "errorFormDebugToolStripMenuItem";
            this.errorFormDebugToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.errorFormDebugToolStripMenuItem.Text = "ErrorForm";
            this.errorFormDebugToolStripMenuItem.Click += new System.EventHandler(this.errorFormToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(13, 47);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 364);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(180, 382);
            this.chooseButton.Margin = new System.Windows.Forms.Padding(4);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(100, 29);
            this.chooseButton.TabIndex = 2;
            this.chooseButton.Text = "Choose";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeesDIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeesDIR";
            this.Text = "EmployeesDIR - 3.0";
            this.Load += new System.EventHandler(this.EmployeesDIR_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripMenuItem opsToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem newEmployeeToolStripMenuItem;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.ToolStripMenuItem settingsItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testDebugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorFormDebugToolStripMenuItem;
    }
}

