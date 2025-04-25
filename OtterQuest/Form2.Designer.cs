namespace OtterQuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            playerLabel = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            wrenchCountTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            setWrenchesButton = new Button();
            infAmmoCheckBox = new CheckBox();
            noCellCostCheckBox = new CheckBox();
            menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Determination Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 32);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(70, 26);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // wrenchCountTextBox
            // 
            wrenchCountTextBox.Font = new Font("Segoe UI", 14F);
            wrenchCountTextBox.Location = new Point(273, 132);
            wrenchCountTextBox.Margin = new Padding(4, 5, 4, 5);
            wrenchCountTextBox.Name = "wrenchCountTextBox";
            wrenchCountTextBox.Size = new Size(187, 45);
            wrenchCountTextBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(641, 158);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 607);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // setWrenchesButton
            // 
            setWrenchesButton.BackColor = Color.FromArgb(28, 28, 28);
            setWrenchesButton.FlatAppearance.BorderSize = 0;
            setWrenchesButton.FlatStyle = FlatStyle.Flat;
            setWrenchesButton.Font = new Font("Determination Mono", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setWrenchesButton.ForeColor = SystemColors.ControlLightLight;
            setWrenchesButton.Location = new Point(17, 123);
            setWrenchesButton.Margin = new Padding(4, 5, 4, 5);
            setWrenchesButton.Name = "setWrenchesButton";
            setWrenchesButton.Size = new Size(224, 67);
            setWrenchesButton.TabIndex = 6;
            setWrenchesButton.TabStop = false;
            setWrenchesButton.Text = "Set Wrenches";
            setWrenchesButton.TextAlign = ContentAlignment.MiddleLeft;
            setWrenchesButton.UseVisualStyleBackColor = false;
            setWrenchesButton.Click += setWrenchesButton_Click;
            // 
            // infAmmoCheckBox
            // 
            infAmmoCheckBox.AutoSize = true;
            infAmmoCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            infAmmoCheckBox.FlatStyle = FlatStyle.Flat;
            infAmmoCheckBox.Font = new Font("Determination Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infAmmoCheckBox.ForeColor = Color.White;
            infAmmoCheckBox.Location = new Point(17, 238);
            infAmmoCheckBox.Margin = new Padding(4, 5, 4, 5);
            infAmmoCheckBox.Name = "infAmmoCheckBox";
            infAmmoCheckBox.Size = new Size(291, 39);
            infAmmoCheckBox.TabIndex = 7;
            infAmmoCheckBox.Text = "Infinite Ammo  ";
            infAmmoCheckBox.UseMnemonic = false;
            infAmmoCheckBox.UseVisualStyleBackColor = true;
            // 
            // noCellCostCheckBox
            // 
            noCellCostCheckBox.AutoSize = true;
            noCellCostCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            noCellCostCheckBox.FlatStyle = FlatStyle.Flat;
            noCellCostCheckBox.Font = new Font("Determination Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noCellCostCheckBox.ForeColor = Color.White;
            noCellCostCheckBox.Location = new Point(17, 318);
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1143, 750);
            Controls.Add(noCellCostCheckBox);
            Controls.Add(infAmmoCheckBox);
            Controls.Add(setWrenchesButton);
            Controls.Add(pictureBox1);
            Controls.Add(wrenchCountTextBox);
            Controls.Add(playerLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label playerLabel;
        private MenuStrip menuStrip1;
        private TextBox wrenchCountTextBox;
        private ToolStripMenuItem homeToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button setWrenchesButton;
        private Button button1;
        private CheckBox infAmmoCheckBox;
        private CheckBox noCellCostCheckBox;
    }
}