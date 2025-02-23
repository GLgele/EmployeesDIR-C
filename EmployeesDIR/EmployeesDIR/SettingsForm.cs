﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesDIR
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Program.logger.Debug("New Settings Form.");
            Program.trans.Init(this);
            if(Config.config.Language.lang == "zh_cn")
            {
                //checkUpdateButton.Location.X = 186;
                checkUpdateButton.Location = new Point(176, 23);
            }
            languageComboBox.SelectedItem = Trans.langDict2[Config.config.Language.lang];
            downloadComboBox.SelectedItem = Config.config.Update.source;
            checkUpdateBox.Checked = Config.config.Update.autoCheck;
            dbTypeLabel.Text = Config.config.Database.dbType;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Config.CheckUpdate();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.config.Update.source = downloadComboBox.SelectedItem.ToString();
            Config.config.Update.autoCheck = checkUpdateBox.Checked;
            Config.SaveConfig();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
        
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Program.logger.Debug("Settings Form closed.");
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Config.SaveConfig();
            cancelButton_Click(sender, e);
        }
        /*public void IniSave()
        {   
            //save ini here
            //General.IniWriteValue(General.iniFilePath, "Language", "lang", languageComboBox.SelectedText);
            //General.IniWriteValue(General.iniFilePath, "Update", "source", downloadComboBox.SelectedText);
            //Console.WriteLine(languageComboBox.SelectedText);
            //IniHelper.Write("Language", "lang", trans.langDict[languageComboBox.SelectedItem.ToString()], General.iniFilePath);
            //IniHelper.Write("Update", "source", downloadComboBox.SelectedItem.ToString(),General.iniFilePath);
            StreamWriter sw = new StreamWriter("config.ini");
            sw.WriteLine("[Language]");
            sw.Write("lang=");
            sw.WriteLine(Trans.langDict[languageComboBox.SelectedItem.ToString()]);
            sw.WriteLine("[Update]");
            sw.Write("source=");
            sw.WriteLine(downloadComboBox.SelectedItem.ToString());
            sw.Write("autoCheck=");
            sw.WriteLine(checkUpdateBox.Checked);
            sw.Close();
        }*/

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.config.Language.lang = Trans.langDict[languageComboBox.SelectedItem.ToString()];
            Config.SaveConfig();
        }

        private void dbSetButton_Click(object sender, EventArgs e)
        {
            var form = new DBConnectForm();
            form.Show();
        }
    }
}
