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
            whereToMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("Determination Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerLabel.ForeColor = Color.Snow;
            playerLabel.Location = new Point(17, 63);
            playerLabel.Margin = new Padding(4, 0, 4, 0);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(151, 43);
            playerLabel.TabIndex = 2;
            playerLabel.Text = "Player";
            // 
            // whereToMenu
            // 
            whereToMenu.Font = new Font("Determination Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            whereToMenu.ImageScalingSize = new Size(24, 24);
            whereToMenu.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, characterToolStripMenuItem });
            whereToMenu.Location = new Point(0, 0);
            whereToMenu.Name = "whereToMenu";
            whereToMenu.Padding = new Padding(9, 3, 0, 3);
            whereToMenu.Size = new Size(1143, 32);
            whereToMenu.TabIndex = 3;
            whereToMenu.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(70, 26);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // characterToolStripMenuItem
            // 
            characterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rangerToolStripMenuItem });
            characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            characterToolStripMenuItem.Size = new Size(125, 26);
            characterToolStripMenuItem.Text = "Character";
            // 
            // rangerToolStripMenuItem
            // 
            rangerToolStripMenuItem.Name = "rangerToolStripMenuItem";
            rangerToolStripMenuItem.Size = new Size(176, 34);
            rangerToolStripMenuItem.Text = "Ranger";
            rangerToolStripMenuItem.Click += rangerToolStripMenuItem_Click;
            // 
            // eCellsTextbox
            // 
            eCellsTextbox.Font = new Font("Segoe UI", 14F);
            eCellsTextbox.Location = new Point(273, 132);
            eCellsTextbox.Margin = new Padding(4, 5, 4, 5);
            eCellsTextbox.Name = "eCellsTextbox";
            eCellsTextbox.Size = new Size(187, 45);
            eCellsTextbox.TabIndex = 4;
            eCellsTextbox.TextChanged += wrenchCountTextBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(629, 237);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 499);
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
            setECellsButton.Location = new Point(17, 123);
            setECellsButton.Margin = new Padding(4, 5, 4, 5);
            setECellsButton.Name = "setECellsButton";
            setECellsButton.Size = new Size(248, 67);
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
            setRerollsButton.Location = new Point(17, 200);
            setRerollsButton.Margin = new Padding(4, 5, 4, 5);
            setRerollsButton.Name = "setRerollsButton";
            setRerollsButton.Size = new Size(248, 67);
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
            rerollsTextbox.Location = new Point(273, 208);
            rerollsTextbox.Margin = new Padding(4, 5, 4, 5);
            rerollsTextbox.Name = "rerollsTextbox";
            rerollsTextbox.Size = new Size(187, 45);
            rerollsTextbox.TabIndex = 9;
            // 
            // setGoldJarButton
            // 
            setGoldJarButton.BackColor = Color.FromArgb(28, 28, 28);
            setGoldJarButton.FlatAppearance.BorderSize = 0;
            setGoldJarButton.FlatStyle = FlatStyle.Flat;
            setGoldJarButton.Font = new Font("Determination Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setGoldJarButton.ForeColor = SystemColors.ControlLightLight;
            setGoldJarButton.Location = new Point(17, 277);
            setGoldJarButton.Margin = new Padding(4, 5, 4, 5);
            setGoldJarButton.Name = "setGoldJarButton";
            setGoldJarButton.Size = new Size(248, 67);
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
            goldJarTextbox.Location = new Point(273, 285);
            goldJarTextbox.Margin = new Padding(4, 5, 4, 5);
            goldJarTextbox.Name = "goldJarTextbox";
            goldJarTextbox.Size = new Size(187, 45);
            goldJarTextbox.TabIndex = 11;
            // 
            // setPerksButton
            // 
            setPerksButton.BackColor = Color.FromArgb(28, 28, 28);
            setPerksButton.FlatAppearance.BorderSize = 0;
            setPerksButton.FlatStyle = FlatStyle.Flat;
            setPerksButton.Font = new Font("Determination Mono", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setPerksButton.ForeColor = SystemColors.ControlLightLight;
            setPerksButton.Location = new Point(17, 353);
            setPerksButton.Margin = new Padding(4, 5, 4, 5);
            setPerksButton.Name = "setPerksButton";
            setPerksButton.Size = new Size(248, 67);
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
            perksTextbox.Location = new Point(273, 362);
            perksTextbox.Margin = new Padding(4, 5, 4, 5);
            perksTextbox.Name = "perksTextbox";
            perksTextbox.Size = new Size(187, 45);
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
            setSmithTokenButton.Location = new Point(17, 430);
            setSmithTokenButton.Margin = new Padding(4, 5, 4, 5);
            setSmithTokenButton.Name = "setSmithTokenButton";
            setSmithTokenButton.Size = new Size(248, 67);
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
            smithTokenTextbox.Location = new Point(273, 438);
            smithTokenTextbox.Margin = new Padding(4, 5, 4, 5);
            smithTokenTextbox.Name = "smithTokenTextbox";
            smithTokenTextbox.Size = new Size(187, 45);
            smithTokenTextbox.TabIndex = 15;
            // 
            // noCellCostCheckBox
            // 
            noCellCostCheckBox.AutoSize = true;
            noCellCostCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            noCellCostCheckBox.FlatStyle = FlatStyle.Flat;
            noCellCostCheckBox.Font = new Font("Determination Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noCellCostCheckBox.ForeColor = Color.White;
            noCellCostCheckBox.Location = new Point(17, 530);
            noCellCostCheckBox.Margin = new Padding(4, 5, 4, 5);
            noCellCostCheckBox.Name = "noCellCostCheckBox";
            noCellCostCheckBox.Size = new Size(291, 39);
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
            // PlayerMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1143, 750);
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
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "PlayerMenu";
            Text = "Form2";
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
    }
}