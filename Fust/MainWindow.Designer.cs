namespace Fust
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            scanTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            runningCheckBox = new CheckedListBox();
            label2 = new Label();
            closeAppBox = new CheckedListBox();
            appTextBox = new TextBox();
            leftAddButton = new Button();
            rightAddButton = new Button();
            clearButton = new Button();
            saveButton = new Button();
            notifyIcon = new NotifyIcon(components);
            iconContextMenuStrip = new ContextMenuStrip(components);
            exitToolStripMenuItem = new ToolStripMenuItem();
            iconContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // scanTimer
            // 
            scanTimer.Enabled = true;
            scanTimer.Interval = 1000;
            scanTimer.Tick += ScanTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 17);
            label1.TabIndex = 0;
            label1.Text = "When these apps running,";
            // 
            // runningCheckBox
            // 
            runningCheckBox.FormattingEnabled = true;
            runningCheckBox.Location = new Point(12, 29);
            runningCheckBox.Name = "runningCheckBox";
            runningCheckBox.Size = new Size(295, 310);
            runningCheckBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 9);
            label2.Name = "label2";
            label2.Size = new Size(353, 17);
            label2.TabIndex = 2;
            label2.Text = "close these apps and restart them until apps are all closed.";
            // 
            // closeAppBox
            // 
            closeAppBox.FormattingEnabled = true;
            closeAppBox.Location = new Point(396, 29);
            closeAppBox.Name = "closeAppBox";
            closeAppBox.Size = new Size(295, 310);
            closeAppBox.TabIndex = 3;
            // 
            // appTextBox
            // 
            appTextBox.Location = new Point(264, 370);
            appTextBox.Name = "appTextBox";
            appTextBox.Size = new Size(147, 23);
            appTextBox.TabIndex = 5;
            appTextBox.Text = "AppName";
            // 
            // leftAddButton
            // 
            leftAddButton.Location = new Point(152, 361);
            leftAddButton.Name = "leftAddButton";
            leftAddButton.Size = new Size(106, 40);
            leftAddButton.TabIndex = 6;
            leftAddButton.Text = "Add to Left";
            leftAddButton.UseVisualStyleBackColor = true;
            leftAddButton.Click += LeftAddButton_Click;
            // 
            // rightAddButton
            // 
            rightAddButton.Location = new Point(417, 362);
            rightAddButton.Name = "rightAddButton";
            rightAddButton.Size = new Size(106, 40);
            rightAddButton.TabIndex = 7;
            rightAddButton.Text = "Add to Right";
            rightAddButton.UseVisualStyleBackColor = true;
            rightAddButton.Click += RightAddButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 362);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(119, 38);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear All";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(584, 345);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(107, 57);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = iconContextMenuStrip;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Fust";
            notifyIcon.Visible = true;
            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
            // 
            // iconContextMenuStrip
            // 
            iconContextMenuStrip.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            iconContextMenuStrip.Name = "iconContextMenuStrip";
            iconContextMenuStrip.Size = new Size(97, 26);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(96, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 414);
            Controls.Add(clearButton);
            Controls.Add(rightAddButton);
            Controls.Add(leftAddButton);
            Controls.Add(appTextBox);
            Controls.Add(saveButton);
            Controls.Add(closeAppBox);
            Controls.Add(label2);
            Controls.Add(runningCheckBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "Fust";
            FormClosing += MainWindow_FormClosing;
            iconContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer scanTimer;
        private Label label1;
        private CheckedListBox runningCheckBox;
        private Label label2;
        private CheckedListBox closeAppBox;
        private Button saveButton;
        private TextBox appTextBox;
        private Button leftAddButton;
        private Button rightAddButton;
        private Button clearButton;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip iconContextMenuStrip;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}