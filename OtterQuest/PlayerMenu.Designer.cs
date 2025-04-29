namespace OtterQuest
{
    partial class PlayerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerMenu));
            playerLabel = new Label();
            whereToMenu = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            characterToolStripMenuItem = new ToolStripMenuItem();
            rangerToolStripMenuItem = new ToolStripMenuItem();
            playerToolStripMenuItem = new ToolStripMenuItem();
            eCellsTextbox = new TextBox();
            pictureBox1 = new PictureBox();
            setECellsButton = new Button();
            setRerollsButton = new Button();
            rerollsTextbox = new TextBox();
            setGoldJarButton = new Button();
            goldJarTextbox = new TextBox();
            setPerksButton = new Button();
            perksTextbox = new TextBox();
            setSmithTokenButton = new Button();
            smithTokenTextbox = new TextBox();
            noCellCostCheckBox = new CheckBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            whereToMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("Determination Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerLabel.ForeColor = Color.Snow;
            playerLabel.Location = new Point(12, 38);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(97, 29);
            playerLabel.TabIndex = 2;
            playerLabel.Text = "Player";
            // 
            // whereToMenu
            // 
            whereToMenu.Font = new Font("Determination Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            whereToMenu.ImageScalingSize = new Size(24, 24);
            whereToMenu.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, characterToolStripMenuItem, playerToolStripMenuItem });
            whereToMenu.Location = new Point(0, 0);
            whereToMenu.Name = "whereToMenu";
            whereToMenu.Size = new Size(800, 24);
            whereToMenu.TabIndex = 3;
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
            characterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rangerToolStripMenuItem });
            characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            characterToolStripMenuItem.Size = new Size(82, 20);
            characterToolStripMenuItem.Text = "Character";
            // 
            // rangerToolStripMenuItem
            // 
            rangerToolStripMenuItem.Name = "rangerToolStripMenuItem";
            rangerToolStripMenuItem.Size = new Size(116, 22);
            rangerToolStripMenuItem.Text = "Ranger";
            rangerToolStripMenuItem.Click += rangerToolStripMenuItem_Click;
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(61, 20);
            playerToolStripMenuItem.Text = "Player";
            // 
            // eCellsTextbox
            // 
            eCellsTextbox.Font = new Font("Segoe UI", 14F);
            eCellsTextbox.Location = new Point(191, 79);
            eCellsTextbox.Name = "eCellsTextbox";
            eCellsTextbox.Size = new Size(132, 32);
            eCellsTextbox.TabIndex = 4;
            eCellsTextbox.TextChanged += wrenchCountTextBox_TextChanged;
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
            // setECellsButton
            // 
            setECellsButton.BackColor = Color.FromArgb(28, 28, 28);
            setECellsButton.FlatAppearance.BorderSize = 0;
            setECellsButton.FlatStyle = FlatStyle.Flat;
            setECellsButton.Font = new Font("Determination Mono", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setECellsButton.ForeColor = SystemColors.ControlLightLight;
            setECellsButton.Location = new Point(12, 74);
            setECellsButton.Name = "setECellsButton";
            setECellsButton.Size = new Size(174, 40);
            setECellsButton.TabIndex = 6;
            setECellsButton.TabStop = false;
            setECellsButton.Text = "Set ECells";
            setECellsButton.TextAlign = ContentAlignment.MiddleLeft;
            setECellsButton.UseVisualStyleBackColor = false;
            setECellsButton.Click += setECellsButton_Click;
            // 
            // setRerollsButton
            // 
            setRerollsButton.BackColor = Color.FromArgb(28, 28, 28);
            setRerollsButton.FlatAppearance.BorderSize = 0;
            setRerollsButton.FlatStyle = FlatStyle.Flat;
            setRerollsButton.Font = new Font("Determination Mono", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setRerollsButton.ForeColor = SystemColors.ControlLightLight;
            setRerollsButton.Location = new Point(12, 120);
            setRerollsButton.Name = "setRerollsButton";
            setRerollsButton.Size = new Size(174, 40);
            setRerollsButton.TabIndex = 10;
            setRerollsButton.TabStop = false;
            setRerollsButton.Text = "Set Rerolls";
            setRerollsButton.TextAlign = ContentAlignment.MiddleLeft;
            setRerollsButton.UseVisualStyleBackColor = false;
            setRerollsButton.Click += setRerollsButton_Click;
            // 
            // rerollsTextbox
            // 
            rerollsTextbox.Font = new Font("Segoe UI", 14F);
            rerollsTextbox.Location = new Point(191, 125);
            rerollsTextbox.Name = "rerollsTextbox";
            rerollsTextbox.Size = new Size(132, 32);
            rerollsTextbox.TabIndex = 9;
            // 
            // setGoldJarButton
            // 
            setGoldJarButton.BackColor = Color.FromArgb(28, 28, 28);
            setGoldJarButton.FlatAppearance.BorderSize = 0;
            setGoldJarButton.FlatStyle = FlatStyle.Flat;
            setGoldJarButton.Font = new Font("Determination Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setGoldJarButton.ForeColor = SystemColors.ControlLightLight;
            setGoldJarButton.Location = new Point(12, 166);
            setGoldJarButton.Name = "setGoldJarButton";
            setGoldJarButton.Size = new Size(174, 40);
            setGoldJarButton.TabIndex = 12;
            setGoldJarButton.TabStop = false;
            setGoldJarButton.Text = "Set Crystal Powder";
            setGoldJarButton.TextAlign = ContentAlignment.MiddleLeft;
            setGoldJarButton.UseVisualStyleBackColor = false;
            setGoldJarButton.Click += setGoldJarButton_Click;
            // 
            // goldJarTextbox
            // 
            goldJarTextbox.Font = new Font("Segoe UI", 14F);
            goldJarTextbox.Location = new Point(191, 171);
            goldJarTextbox.Name = "goldJarTextbox";
            goldJarTextbox.Size = new Size(132, 32);
            goldJarTextbox.TabIndex = 11;
            // 
            // setPerksButton
            // 
            setPerksButton.BackColor = Color.FromArgb(28, 28, 28);
            setPerksButton.FlatAppearance.BorderSize = 0;
            setPerksButton.FlatStyle = FlatStyle.Flat;
            setPerksButton.Font = new Font("Determination Mono", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setPerksButton.ForeColor = SystemColors.ControlLightLight;
            setPerksButton.Location = new Point(12, 212);
            setPerksButton.Name = "setPerksButton";
            setPerksButton.Size = new Size(174, 40);
            setPerksButton.TabIndex = 14;
            setPerksButton.TabStop = false;
            setPerksButton.Text = "Set Perks";
            setPerksButton.TextAlign = ContentAlignment.MiddleLeft;
            setPerksButton.UseVisualStyleBackColor = false;
            setPerksButton.Click += setPerksButton_Click;
            // 
            // perksTextbox
            // 
            perksTextbox.Font = new Font("Segoe UI", 14F);
            perksTextbox.Location = new Point(191, 217);
            perksTextbox.Name = "perksTextbox";
            perksTextbox.Size = new Size(132, 32);
            perksTextbox.TabIndex = 13;
            perksTextbox.TextChanged += textBox3_TextChanged;
            // 
            // setSmithTokenButton
            // 
            setSmithTokenButton.BackColor = Color.FromArgb(28, 28, 28);
            setSmithTokenButton.FlatAppearance.BorderSize = 0;
            setSmithTokenButton.FlatStyle = FlatStyle.Flat;
            setSmithTokenButton.Font = new Font("Determination Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setSmithTokenButton.ForeColor = SystemColors.ControlLightLight;
            setSmithTokenButton.Location = new Point(12, 291);
            setSmithTokenButton.Name = "setSmithTokenButton";
            setSmithTokenButton.Size = new Size(174, 40);
            setSmithTokenButton.TabIndex = 16;
            setSmithTokenButton.TabStop = false;
            setSmithTokenButton.Text = "Set Smith Token";
            setSmithTokenButton.TextAlign = ContentAlignment.MiddleLeft;
            setSmithTokenButton.UseVisualStyleBackColor = false;
            setSmithTokenButton.Click += setSmithTokenButton_Click;
            // 
            // smithTokenTextbox
            // 
            smithTokenTextbox.Font = new Font("Segoe UI", 14F);
            smithTokenTextbox.Location = new Point(191, 294);
            smithTokenTextbox.Name = "smithTokenTextbox";
            smithTokenTextbox.Size = new Size(132, 32);
            smithTokenTextbox.TabIndex = 15;
            // 
            // noCellCostCheckBox
            // 
            noCellCostCheckBox.AutoSize = true;
            noCellCostCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            noCellCostCheckBox.FlatStyle = FlatStyle.Flat;
            noCellCostCheckBox.Font = new Font("Determination Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noCellCostCheckBox.ForeColor = Color.White;
            noCellCostCheckBox.Location = new Point(12, 346);
            noCellCostCheckBox.Name = "noCellCostCheckBox";
            noCellCostCheckBox.Size = new Size(191, 27);
            noCellCostCheckBox.TabIndex = 8;
            noCellCostCheckBox.Text = "No Cell Cost   ";
            noCellCostCheckBox.TextAlign = ContentAlignment.MiddleRight;
            noCellCostCheckBox.UseMnemonic = false;
            noCellCostCheckBox.UseVisualStyleBackColor = true;
            noCellCostCheckBox.CheckedChanged += noCellCostCheckBox_CheckedChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Determination Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 255);
            label1.Name = "label1";
            label1.Size = new Size(364, 14);
            label1.TabIndex = 17;
            label1.Text = "(Only use if you have 1 or more upgrades available)";
            // 
            // PlayerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(setSmithTokenButton);
            Controls.Add(smithTokenTextbox);
            Controls.Add(setPerksButton);
            Controls.Add(perksTextbox);
            Controls.Add(setGoldJarButton);
            Controls.Add(goldJarTextbox);
            Controls.Add(setRerollsButton);
            Controls.Add(rerollsTextbox);
            Controls.Add(noCellCostCheckBox);
            Controls.Add(setECellsButton);
            Controls.Add(pictureBox1);
            Controls.Add(eCellsTextbox);
            Controls.Add(playerLabel);
            Controls.Add(whereToMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = whereToMenu;
            MaximizeBox = false;
            Name = "PlayerMenu";
            Text = "Player Menu";
            Load += Form2_Load;
            whereToMenu.ResumeLayout(false);
            whereToMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label playerLabel;
        private MenuStrip whereToMenu;
        private TextBox eCellsTextbox;
        private ToolStripMenuItem homeToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button setECellsButton;
        private Button button1;
        private Button setRerollsButton;
        private TextBox rerollsTextbox;
        private Button setGoldJarButton;
        private TextBox goldJarTextbox;
        private Button setPerksButton;
        private TextBox perksTextbox;
        private Button setSmithTokenButton;
        private TextBox smithTokenTextbox;
        private CheckBox noCellCostCheckBox;
        private ToolStripMenuItem characterToolStripMenuItem;
        private ToolStripMenuItem rangerToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem playerToolStripMenuItem;
        private Label label1;
    }
}