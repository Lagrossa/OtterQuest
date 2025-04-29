namespace OtterQuest
{
    partial class RangerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangerMenu));
            rangerLabel = new Label();
            rangerToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            focusButton = new Button();
            focusTextbox = new TextBox();
            whereToMenu = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            characterToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            playerToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            whereToMenu.SuspendLayout();
            SuspendLayout();
            // 
            // rangerLabel
            // 
            rangerLabel.AutoSize = true;
            rangerLabel.Font = new Font("Determination Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rangerLabel.ForeColor = Color.Snow;
            rangerLabel.Location = new Point(12, 38);
            rangerLabel.Name = "rangerLabel";
            rangerLabel.Size = new Size(97, 29);
            rangerLabel.TabIndex = 2;
            rangerLabel.Text = "Ranger";
            rangerLabel.Click += playerLabel_Click;
            // 
            // rangerToolStripMenuItem
            // 
            rangerToolStripMenuItem.Name = "rangerToolStripMenuItem";
            rangerToolStripMenuItem.Size = new Size(32, 19);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(440, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // focusButton
            // 
            focusButton.BackColor = Color.FromArgb(28, 28, 28);
            focusButton.FlatAppearance.BorderSize = 0;
            focusButton.FlatStyle = FlatStyle.Flat;
            focusButton.Font = new Font("Determination Mono", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            focusButton.ForeColor = SystemColors.ControlLightLight;
            focusButton.Location = new Point(12, 87);
            focusButton.Name = "focusButton";
            focusButton.Size = new Size(174, 40);
            focusButton.TabIndex = 8;
            focusButton.TabStop = false;
            focusButton.Text = "Perma-Focus";
            focusButton.TextAlign = ContentAlignment.MiddleLeft;
            focusButton.UseVisualStyleBackColor = false;
            focusButton.Click += focusButton_Click;
            // 
            // focusTextbox
            // 
            focusTextbox.Font = new Font("Segoe UI", 14F);
            focusTextbox.Location = new Point(191, 92);
            focusTextbox.Name = "focusTextbox";
            focusTextbox.Size = new Size(132, 32);
            focusTextbox.TabIndex = 7;
            focusTextbox.TextChanged += focusTextbox_TextChanged;
            // 
            // whereToMenu
            // 
            whereToMenu.Font = new Font("Determination Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            whereToMenu.ImageScalingSize = new Size(24, 24);
            whereToMenu.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, characterToolStripMenuItem, playerToolStripMenuItem });
            whereToMenu.Location = new Point(0, 0);
            whereToMenu.Name = "whereToMenu";
            whereToMenu.Size = new Size(800, 24);
            whereToMenu.TabIndex = 9;
            whereToMenu.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(47, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // characterToolStripMenuItem
            // 
            characterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            characterToolStripMenuItem.Size = new Size(82, 20);
            characterToolStripMenuItem.Text = "Character";
            characterToolStripMenuItem.Click += characterToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(116, 22);
            toolStripMenuItem1.Text = "Ranger";
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(61, 20);
            playerToolStripMenuItem.Text = "Player";
            playerToolStripMenuItem.Click += playerToolStripMenuItem_Click;
            // 
            // RangerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(800, 450);
            Controls.Add(whereToMenu);
            Controls.Add(focusButton);
            Controls.Add(focusTextbox);
            Controls.Add(pictureBox1);
            Controls.Add(rangerLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RangerMenu";
            Text = "Ranger Menu";
            Load += RangerMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            whereToMenu.ResumeLayout(false);
            whereToMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label rangerLabel;
        private PictureBox pictureBox1;
        private Button button1;
        private ToolStripMenuItem rangerToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Button focusButton;
        private TextBox focusTextbox;
        private MenuStrip whereToMenu;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem characterToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem playerToolStripMenuItem;
    }
}