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
            eCellsTextbox = new TextBox();
            pictureBox1 = new PictureBox();
            setECellsButton = new Button();
            infAmmoCheckBox = new CheckBox();
            noCellCostCheckBox = new CheckBox();
            setRerollsButton = new Button();
            rerollsTextbox = new TextBox();
            button3 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            textBox3 = new TextBox();
            button5 = new Button();
            textBox4 = new TextBox();
            button6 = new Button();
            textBox5 = new TextBox();
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
            // infAmmoCheckBox
            // 
            infAmmoCheckBox.AutoSize = true;
            infAmmoCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            infAmmoCheckBox.FlatStyle = FlatStyle.Flat;
            infAmmoCheckBox.Font = new Font("Determination Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infAmmoCheckBox.ForeColor = Color.White;
            infAmmoCheckBox.Location = new Point(17, 597);
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
            noCellCostCheckBox.Location = new Point(17, 677);
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
            // button3
            // 
            button3.BackColor = Color.FromArgb(28, 28, 28);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Determination Mono", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(17, 277);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(248, 67);
            button3.TabIndex = 12;
            button3.TabStop = false;
            button3.Text = "Set Wrenches";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(273, 285);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 45);
            textBox2.TabIndex = 11;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(28, 28, 28);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Determination Mono", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(17, 353);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(248, 67);
            button4.TabIndex = 14;
            button4.TabStop = false;
            button4.Text = "Set Wrenches";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14F);
            textBox3.Location = new Point(273, 362);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 45);
            textBox3.TabIndex = 13;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(28, 28, 28);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Determination Mono", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(17, 430);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(248, 67);
            button5.TabIndex = 16;
            button5.TabStop = false;
            button5.Text = "Set Wrenches";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14F);
            textBox4.Location = new Point(273, 438);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(187, 45);
            textBox4.TabIndex = 15;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(28, 28, 28);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Determination Mono", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(17, 507);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(248, 67);
            button6.TabIndex = 18;
            button6.TabStop = false;
            button6.Text = "Set Wrenches";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14F);
            textBox5.Location = new Point(273, 515);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(187, 45);
            textBox5.TabIndex = 17;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1143, 750);
            Controls.Add(button6);
            Controls.Add(textBox5);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(setRerollsButton);
            Controls.Add(rerollsTextbox);
            Controls.Add(noCellCostCheckBox);
            Controls.Add(infAmmoCheckBox);
            Controls.Add(setECellsButton);
            Controls.Add(pictureBox1);
            Controls.Add(eCellsTextbox);
            Controls.Add(playerLabel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private TextBox eCellsTextbox;
        private ToolStripMenuItem homeToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button setECellsButton;
        private Button button1;
        private CheckBox infAmmoCheckBox;
        private CheckBox noCellCostCheckBox;
        private Button setRerollsButton;
        private TextBox rerollsTextbox;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
        private TextBox textBox3;
        private Button button5;
        private TextBox textBox4;
        private Button button6;
        private TextBox textBox5;
    }
}