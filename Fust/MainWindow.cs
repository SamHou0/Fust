using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fust.Properties;

namespace Fust
{
    public partial class MainWindow : Form
    {
        List<string> killedApps = new();
        bool isClosing = false;
        public MainWindow()
        {
            InitializeComponent();
            if (Settings.Default.CheckApps != null)
            {
                foreach (var item in Settings.Default.CheckApps)
                {
                    runningCheckBox.Items.Add(item);
                }
                foreach (var item in Settings.Default.CloseApps)
                {
                    closeAppBox.Items.Add(item);
                }
            }
        }

        private void LeftAddButton_Click(object sender, EventArgs e)
        {
            runningCheckBox.Items.Add(appTextBox.Text);
        }

        private void RightAddButton_Click(object sender, EventArgs e)
        {
            closeAppBox.Items.Add(appTextBox.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            runningCheckBox.Items.Clear();
            closeAppBox.Items.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Settings.Default.CheckApps = new();
            Settings.Default.CloseApps = new();
            foreach (var item in runningCheckBox.Items)
            {
                Settings.Default.CheckApps.Add(item.ToString());
            }
            foreach (var item in closeAppBox.Items)
            {
                Settings.Default.CloseApps.Add(item.ToString());
            }
            Settings.Default.Save();
        }

        private void ScanTimer_Tick(object sender, EventArgs e)
        {
            if (CheckRunning())
            {
                KillApps();
            }
            else
            {
                RestartApps();
            }
        }

        private void RestartApps()
        {
            foreach (string item in killedApps)
            {
                Process.Start(item);
            }
            killedApps.Clear();
        }

        private bool CheckRunning()
        {
            foreach (string item in runningCheckBox.Items)
            {
                if (Process.GetProcessesByName(item).Length > 0)
                {
                    return true;
                }
            }
            return false;
        }
        private void KillApps()
        {
            foreach (string item in closeAppBox.Items)
            {
                Process[] processes = Process.GetProcessesByName(item);
                foreach (Process process in processes)
                {
                    killedApps.Add(process.MainModule.FileName);
                    process.Kill();
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isClosing = true;
            Close();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosing)
            {
                Hide();
                e.Cancel = true;
            }

        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
        }
    }
}
