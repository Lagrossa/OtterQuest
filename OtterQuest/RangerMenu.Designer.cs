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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            rangerLabel = new Label();
            rangerToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            setFocusButton = new Button();
            focusTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rangerLabel
            // 
            rangerLabel.AutoSize = true;
            rangerLabel.Font = new Font("Determination Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rangerLabel.ForeColor = Color.Snow;
            rangerLabel.Location = new Point(17, 63);
            rangerLabel.Margin = new Padding(4, 0, 4, 0);
            rangerLabel.Name = "rangerLabel";
            rangerLabel.Size = new Size(151, 43);
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
            pictureBox1.Location = new Point(629, 237);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 499);
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
            // setFocusButton
            // 
            setFocusButton.BackColor = Color.FromArgb(28, 28, 28);
            setFocusButton.FlatAppearance.BorderSize = 0;
            setFocusButton.FlatStyle = FlatStyle.Flat;
            setFocusButton.Font = new Font("Determination Mono", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setFocusButton.ForeColor = SystemColors.ControlLightLight;
            setFocusButton.Location = new Point(17, 145);
            setFocusButton.Margin = new Padding(4, 5, 4, 5);
            setFocusButton.Name = "setFocusButton";
            setFocusButton.Size = new Size(248, 67);
            setFocusButton.TabIndex = 8;
            setFocusButton.TabStop = false;
            setFocusButton.Text = "Perma-Focus";
            setFocusButton.TextAlign = ContentAlignment.MiddleLeft;
            setFocusButton.UseVisualStyleBackColor = false;
            setFocusButton.Click += setECellsButton_Click_2;
            // 
            // focusTextbox
            // 
            focusTextbox.Font = new Font("Segoe UI", 14F);
            focusTextbox.Location = new Point(273, 154);
            focusTextbox.Margin = new Padding(4, 5, 4, 5);
            focusTextbox.Name = "focusTextbox";
            focusTextbox.Size = new Size(187, 45);
            focusTextbox.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1143, 750);
            Controls.Add(setFocusButton);
            Controls.Add(focusTextbox);
            Controls.Add(pictureBox1);
            Controls.Add(rangerLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label rangerLabel;
        private PictureBox pictureBox1;
        private Button button1;
        private ToolStripMenuItem rangerToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Button setFocusButton;
        private TextBox focusTextbox;
    }
}