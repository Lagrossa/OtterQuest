namespace OtterQuest
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            attachButton = new Button();
            pictureBox1 = new PictureBox();
            exitButton = new Button();
            statusLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.OtterQuest;
            pictureBox2.Location = new Point(17, 20);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(429, 283);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // attachButton
            // 
            attachButton.BackColor = Color.FromArgb(28, 28, 28);
            attachButton.DialogResult = DialogResult.No;
            attachButton.FlatAppearance.BorderSize = 0;
            attachButton.FlatStyle = FlatStyle.Flat;
            attachButton.Font = new Font("Determination Mono", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attachButton.ForeColor = SystemColors.ControlLightLight;
            attachButton.Location = new Point(97, 383);
            attachButton.Margin = new Padding(4, 5, 4, 5);
            attachButton.Name = "attachButton";
            attachButton.Size = new Size(224, 67);
            attachButton.TabIndex = 2;
            attachButton.TabStop = false;
            attachButton.Text = "Attach";
            attachButton.UseVisualStyleBackColor = false;
            attachButton.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Ottah1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(445, 124);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(665, 543);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(28, 28, 28);
            exitButton.DialogResult = DialogResult.No;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Determination Mono", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(97, 482);
            exitButton.Margin = new Padding(4, 5, 4, 5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(224, 67);
            exitButton.TabIndex = 4;
            exitButton.TabStop = false;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += button2_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Determination Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = SystemColors.ControlDark;
            statusLabel.Location = new Point(53, 330);
            statusLabel.Margin = new Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(349, 43);
            statusLabel.TabIndex = 6;
            statusLabel.Text = "Attach To Game!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(28, 28, 28);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1109, 640);
            Controls.Add(statusLabel);
            Controls.Add(exitButton);
            Controls.Add(pictureBox1);
            Controls.Add(attachButton);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "OTTRQUEST";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Button attachButton;
        private PictureBox pictureBox1;
        private Button exitButton;
        private Label statusLabel;
    }
}
