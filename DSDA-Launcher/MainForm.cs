using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSDA_Launcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
            UpdateDemoStatus();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void demos_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDemoStatus();
        }

        private void settings_button_application_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Browse for application",
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "Executable files (*.exe)|*.exe"
            };
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                settings_input_application.Text = dialog.FileName;
            }
        }

        private void settings_button_iwad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Browse for IWAD",
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "WAD files (*.wad)|*.wad"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                settings_input_iwad.Text = dialog.FileName;
            }
        }

        private void settings_button_pwad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Browse for PWAD",
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = true,
                Filter = "WAD files (*.wad)|*.wad"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string files = "";
                foreach(String file in dialog.FileNames)
                {
                    files += file + " ";
                }
                files = files.Trim();
                settings_input_pwad.Text = files;
            }
        }

        private void demos_button_browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                demos_input_location.Text = dialog.SelectedPath;
            }
        }

        private void button_launch_Click(object sender, EventArgs e)
        {
            Launch();
        }

        private void Launch()
        {
            string cmd = $"{settings_input_application.Text} " +
                $"-iwad {settings_input_iwad.Text} " +
                $"-file {settings_input_pwad.Text} " +
                //$"-skill {parameters_combo_box_skill.SelectedIndex + 1} " +
                $"{(parameters_input_warp.Text.Length != 0 ? $"-warp {parameters_input_warp.Text} " : "")}" +
                $"-complevel {GetCompFromIndex(parameters_combo_box_comp.SelectedIndex)} " +
                $"{(parameters_checkbox_nomo.Checked ? "-nomonsters " : "")}" +
                $"{(parameters_checkbox_nomusic.Checked ? "-nomusic " : "")}" +
                $"{(parameters_checkbox_shorttics.Checked ? "-shorttics " : "")}" +
                $"{(demos_checkbox.Checked ? $"-record {demos_input_location.Text}\\{demos_input_name.Text} " : "")}" +
                $"{parameters_input_additional.Text}";

            //System.Diagnostics.Debug.WriteLine(cmd);
            System.Diagnostics.Process.Start("CMD.exe", "/c " + cmd);
        }

        private string GetCompFromIndex(int index)
        {
            switch(index)
            {
                case 0:
                    return "2";
                case 1:
                    return "3";
                case 2:
                    return "4";
                case 3:
                    return "9";
                case 4:
                    return "11";
                case 5:
                    return "21";
                default:
                    throw new ArgumentException();
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.application = settings_input_application.Text;
            Properties.Settings.Default.iwad = settings_input_iwad.Text;
            Properties.Settings.Default.pwad = settings_input_pwad.Text;
            Properties.Settings.Default.skill = parameters_combo_box_skill.SelectedIndex;
            Properties.Settings.Default.comp = parameters_combo_box_comp.SelectedIndex;
            Properties.Settings.Default.warp = parameters_input_warp.Text;
            Properties.Settings.Default.nomo = parameters_checkbox_nomo.Checked;
            Properties.Settings.Default.nomus = parameters_checkbox_nomusic.Checked;
            Properties.Settings.Default.shorttics = parameters_checkbox_shorttics.Checked;
            Properties.Settings.Default.additional = parameters_input_additional.Text;
            Properties.Settings.Default.demo = demos_checkbox.Checked;
            Properties.Settings.Default.demoname = demos_input_name.Text;
            Properties.Settings.Default.demolocation = demos_input_location.Text;
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            settings_input_application.Text = Properties.Settings.Default.application;
            settings_input_iwad.Text = Properties.Settings.Default.iwad;
            settings_input_pwad.Text = Properties.Settings.Default.pwad;
            parameters_combo_box_skill.SelectedIndex = Properties.Settings.Default.skill;
            parameters_combo_box_comp.SelectedIndex = Properties.Settings.Default.comp;
            parameters_input_warp.Text = Properties.Settings.Default.warp;
            parameters_checkbox_nomo.Checked = Properties.Settings.Default.nomo;
            parameters_checkbox_nomusic.Checked = Properties.Settings.Default.nomus;
            parameters_checkbox_shorttics.Checked = Properties.Settings.Default.shorttics;
            parameters_input_additional.Text = Properties.Settings.Default.additional;
            demos_checkbox.Checked = Properties.Settings.Default.demo;
            demos_input_name.Text = Properties.Settings.Default.demoname;
            demos_input_location.Text = Properties.Settings.Default.demolocation;
        }

        private void UpdateDemoStatus()
        {
            if (demos_checkbox.Checked)
            {
                demos_input_name.Enabled = true;
                demos_input_location.Enabled = true;
                demos_button_browse.Enabled = true;
            }
            else
            {
                demos_input_name.Enabled = false;
                demos_input_location.Enabled = false;
                demos_button_browse.Enabled = false;
            }
        }
    }
}
