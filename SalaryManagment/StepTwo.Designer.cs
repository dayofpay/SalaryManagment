namespace SalaryManagment
{
    partial class StepTwo
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StepTwo));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginStartLB = new System.Windows.Forms.Label();
            this.continueButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.mainLabel = new System.Windows.Forms.Label();
            this.sourceBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.nextButton = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalaryManagment.Properties.Resources.best_employee_23_1117676;
            this.pictureBox1.Location = new System.Drawing.Point(330, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginStartLB
            // 
            this.loginStartLB.AutoSize = true;
            this.loginStartLB.Font = new System.Drawing.Font("Microsoft Himalaya", 24F, System.Drawing.FontStyle.Bold);
            this.loginStartLB.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginStartLB.Location = new System.Drawing.Point(59, 140);
            this.loginStartLB.Name = "loginStartLB";
            this.loginStartLB.Size = new System.Drawing.Size(735, 32);
            this.loginStartLB.TabIndex = 5;
            this.loginStartLB.Text = "2. Информация за Управители/Съдружници/Собственици\r\n";
            // 
            // continueButton
            // 
            this.continueButton.ActiveBorderThickness = 1;
            this.continueButton.ActiveCornerRadius = 20;
            this.continueButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.continueButton.ActiveForecolor = System.Drawing.Color.White;
            this.continueButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.continueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.continueButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("continueButton.BackgroundImage")));
            this.continueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.continueButton.ButtonText = "НАПРЕД";
            this.continueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueButton.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueButton.ForeColor = System.Drawing.Color.Blue;
            this.continueButton.IdleBorderThickness = 1;
            this.continueButton.IdleCornerRadius = 20;
            this.continueButton.IdleFillColor = System.Drawing.Color.White;
            this.continueButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.continueButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.continueButton.Location = new System.Drawing.Point(254, 257);
            this.continueButton.Margin = new System.Windows.Forms.Padding(5);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(310, 41);
            this.continueButton.TabIndex = 6;
            this.continueButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(61, 203);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(113, 21);
            this.mainLabel.TabIndex = 7;
            this.mainLabel.Text = "${textSource}";
            // 
            // sourceBox
            // 
            this.sourceBox.AcceptsReturn = false;
            this.sourceBox.AcceptsTab = false;
            this.sourceBox.AnimationSpeed = 200;
            this.sourceBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.sourceBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.sourceBox.BackColor = System.Drawing.Color.White;
            this.sourceBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sourceBox.BackgroundImage")));
            this.sourceBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.sourceBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sourceBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.sourceBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.sourceBox.BorderRadius = 1;
            this.sourceBox.BorderThickness = 1;
            this.sourceBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.sourceBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sourceBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.sourceBox.DefaultText = "";
            this.sourceBox.FillColor = System.Drawing.Color.White;
            this.sourceBox.HideSelection = true;
            this.sourceBox.IconLeft = null;
            this.sourceBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.sourceBox.IconPadding = 10;
            this.sourceBox.IconRight = null;
            this.sourceBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.sourceBox.Lines = new string[0];
            this.sourceBox.Location = new System.Drawing.Point(275, 203);
            this.sourceBox.MaxLength = 32767;
            this.sourceBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.sourceBox.Modified = false;
            this.sourceBox.Multiline = false;
            this.sourceBox.Name = "sourceBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sourceBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.sourceBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sourceBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sourceBox.OnIdleState = stateProperties4;
            this.sourceBox.Padding = new System.Windows.Forms.Padding(3);
            this.sourceBox.PasswordChar = '\0';
            this.sourceBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.sourceBox.PlaceholderText = "Въведете текст...";
            this.sourceBox.ReadOnly = false;
            this.sourceBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sourceBox.SelectedText = "";
            this.sourceBox.SelectionLength = 0;
            this.sourceBox.SelectionStart = 0;
            this.sourceBox.ShortcutsEnabled = true;
            this.sourceBox.Size = new System.Drawing.Size(260, 21);
            this.sourceBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.sourceBox.TabIndex = 8;
            this.sourceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sourceBox.TextMarginBottom = 0;
            this.sourceBox.TextMarginLeft = 3;
            this.sourceBox.TextMarginTop = 0;
            this.sourceBox.TextPlaceholder = "Въведете текст...";
            this.sourceBox.UseSystemPasswordChar = false;
            this.sourceBox.WordWrap = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(773, -2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 9;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusLabel.Location = new System.Drawing.Point(337, 172);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(117, 21);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "${statusLabel}";
            this.statusLabel.Visible = false;
            // 
            // nextButton
            // 
            this.nextButton.ActiveBorderThickness = 1;
            this.nextButton.ActiveCornerRadius = 20;
            this.nextButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.nextButton.ActiveForecolor = System.Drawing.Color.White;
            this.nextButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextButton.ButtonText = "Следваща стъпка";
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.ForeColor = System.Drawing.Color.Blue;
            this.nextButton.IdleBorderThickness = 1;
            this.nextButton.IdleCornerRadius = 20;
            this.nextButton.IdleFillColor = System.Drawing.Color.White;
            this.nextButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.nextButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.nextButton.Location = new System.Drawing.Point(574, 257);
            this.nextButton.Margin = new System.Windows.Forms.Padding(5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(228, 41);
            this.nextButton.TabIndex = 11;
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // StepTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(830, 312);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.loginStartLB);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StepTwo";
            this.Text = "StepTwo";
            this.Load += new System.EventHandler(this.StepTwo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loginStartLB;
        private Bunifu.UI.WinForms.BunifuTextBox sourceBox;
        private System.Windows.Forms.Label mainLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 continueButton;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public System.Windows.Forms.Label statusLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 nextButton;
    }
}