namespace MegaDesk
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CreateQuoteButton = new System.Windows.Forms.Button();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.DeskSpecLabel = new System.Windows.Forms.Label();
            this.DeskWidthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.DrawersLabel = new System.Windows.Forms.Label();
            this.ShippingLabel = new System.Windows.Forms.Label();
            this.DrawersComboBox = new System.Windows.Forms.ComboBox();
            this.DateValueLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.DepthTextBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.WidthErrorLabel = new System.Windows.Forms.Label();
            this.DepthErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(24, 49);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(151, 24);
            this.CustomerNameLabel.TabIndex = 0;
            this.CustomerNameLabel.Text = "Customer Name:";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CustomerNameTextBox.Location = new System.Drawing.Point(181, 50);
            this.CustomerNameTextBox.MaxLength = 100;
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(275, 27);
            this.CustomerNameTextBox.TabIndex = 1;
            this.CustomerNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CustomerNameTextBox_Validating);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.MistyRose;
            this.ExitButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(393, 356);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 30);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "×  &Cancel";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CreateQuoteButton
            // 
            this.CreateQuoteButton.BackColor = System.Drawing.Color.Honeydew;
            this.CreateQuoteButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateQuoteButton.Location = new System.Drawing.Point(316, 310);
            this.CreateQuoteButton.Name = "CreateQuoteButton";
            this.CreateQuoteButton.Size = new System.Drawing.Size(152, 40);
            this.CreateQuoteButton.TabIndex = 7;
            this.CreateQuoteButton.Text = "&Create Quote";
            this.CreateQuoteButton.UseVisualStyleBackColor = false;
            this.CreateQuoteButton.Click += new System.EventHandler(this.CreateQuoteButton_Click);
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialComboBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(180, 202);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(187, 27);
            this.MaterialComboBox.Sorted = true;
            this.MaterialComboBox.TabIndex = 4;
            // 
            // DeskSpecLabel
            // 
            this.DeskSpecLabel.AutoSize = true;
            this.DeskSpecLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskSpecLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.DeskSpecLabel.Location = new System.Drawing.Point(176, 94);
            this.DeskSpecLabel.Name = "DeskSpecLabel";
            this.DeskSpecLabel.Size = new System.Drawing.Size(191, 27);
            this.DeskSpecLabel.TabIndex = 2;
            this.DeskSpecLabel.Text = "Desk Specifications";
            this.DeskSpecLabel.Click += new System.EventHandler(this.DeskSpecLabel_Click);
            // 
            // DeskWidthLabel
            // 
            this.DeskWidthLabel.AutoSize = true;
            this.DeskWidthLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthLabel.Location = new System.Drawing.Point(36, 133);
            this.DeskWidthLabel.Name = "DeskWidthLabel";
            this.DeskWidthLabel.Size = new System.Drawing.Size(139, 24);
            this.DeskWidthLabel.TabIndex = 6;
            this.DeskWidthLabel.Text = "Width (inches):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quote Date:";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthLabel.Location = new System.Drawing.Point(34, 167);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(140, 24);
            this.DepthLabel.TabIndex = 8;
            this.DepthLabel.Text = "Depth (inches):";
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLabel.Location = new System.Drawing.Point(14, 201);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(162, 24);
            this.MaterialLabel.TabIndex = 9;
            this.MaterialLabel.Text = "Desktop Material:";
            // 
            // DrawersLabel
            // 
            this.DrawersLabel.AutoSize = true;
            this.DrawersLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawersLabel.Location = new System.Drawing.Point(88, 235);
            this.DrawersLabel.Name = "DrawersLabel";
            this.DrawersLabel.Size = new System.Drawing.Size(86, 24);
            this.DrawersLabel.TabIndex = 10;
            this.DrawersLabel.Text = "Drawers:";
            // 
            // ShippingLabel
            // 
            this.ShippingLabel.AutoSize = true;
            this.ShippingLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingLabel.Location = new System.Drawing.Point(32, 269);
            this.ShippingLabel.Name = "ShippingLabel";
            this.ShippingLabel.Size = new System.Drawing.Size(142, 24);
            this.ShippingLabel.TabIndex = 11;
            this.ShippingLabel.Text = "Build/Shipping:";
            // 
            // DrawersComboBox
            // 
            this.DrawersComboBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawersComboBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DrawersComboBox.FormattingEnabled = true;
            this.DrawersComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawersComboBox.Location = new System.Drawing.Point(181, 236);
            this.DrawersComboBox.Name = "DrawersComboBox";
            this.DrawersComboBox.Size = new System.Drawing.Size(80, 27);
            this.DrawersComboBox.Sorted = true;
            this.DrawersComboBox.TabIndex = 5;
            this.DrawersComboBox.Text = "0";
            // 
            // DateValueLabel
            // 
            this.DateValueLabel.AutoSize = true;
            this.DateValueLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateValueLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DateValueLabel.Location = new System.Drawing.Point(181, 21);
            this.DateValueLabel.Name = "DateValueLabel";
            this.DateValueLabel.Size = new System.Drawing.Size(187, 23);
            this.DateValueLabel.TabIndex = 13;
            this.DateValueLabel.Text = "DateTime Placeholder";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.WidthTextBox.Location = new System.Drawing.Point(180, 134);
            this.WidthTextBox.MaxLength = 100;
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(79, 27);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthTextBox_KeyPress);
            this.WidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthTextBox_Validating);
            // 
            // DepthTextBox
            // 
            this.DepthTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DepthTextBox.Location = new System.Drawing.Point(180, 168);
            this.DepthTextBox.MaxLength = 100;
            this.DepthTextBox.Name = "DepthTextBox";
            this.DepthTextBox.Size = new System.Drawing.Size(79, 27);
            this.DepthTextBox.TabIndex = 3;
            this.DepthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DepthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthTextBox_KeyPress);
            this.DepthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DepthTextBox_Validating);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(181, 275);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 22);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Normal (2 weeks)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(181, 299);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 22);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "7 day rush";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(181, 323);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 22);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.Text = "5 day rush";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(181, 347);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(88, 22);
            this.radioButton4.TabIndex = 19;
            this.radioButton4.Text = "3 day rush";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // WidthErrorLabel
            // 
            this.WidthErrorLabel.AutoSize = true;
            this.WidthErrorLabel.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.WidthErrorLabel.Location = new System.Drawing.Point(265, 141);
            this.WidthErrorLabel.Name = "WidthErrorLabel";
            this.WidthErrorLabel.Size = new System.Drawing.Size(105, 13);
            this.WidthErrorLabel.TabIndex = 20;
            this.WidthErrorLabel.Text = "☼ width input error";
            this.WidthErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DepthErrorLabel
            // 
            this.DepthErrorLabel.AutoSize = true;
            this.DepthErrorLabel.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.DepthErrorLabel.Location = new System.Drawing.Point(265, 175);
            this.DepthErrorLabel.Name = "DepthErrorLabel";
            this.DepthErrorLabel.Size = new System.Drawing.Size(105, 13);
            this.DepthErrorLabel.TabIndex = 21;
            this.DepthErrorLabel.Text = "☼ depth input error";
            this.DepthErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 400);
            this.Controls.Add(this.DepthErrorLabel);
            this.Controls.Add(this.WidthErrorLabel);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.DepthTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.DateValueLabel);
            this.Controls.Add(this.DrawersComboBox);
            this.Controls.Add(this.ShippingLabel);
            this.Controls.Add(this.DrawersLabel);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeskWidthLabel);
            this.Controls.Add(this.DeskSpecLabel);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.CreateQuoteButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CustomerNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk .:|:. Add New Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CreateQuoteButton;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.Label DeskSpecLabel;
        private System.Windows.Forms.Label DeskWidthLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label DrawersLabel;
        private System.Windows.Forms.Label ShippingLabel;
        private System.Windows.Forms.ComboBox DrawersComboBox;
        private System.Windows.Forms.Label DateValueLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox DepthTextBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label WidthErrorLabel;
        private System.Windows.Forms.Label DepthErrorLabel;
    }
}