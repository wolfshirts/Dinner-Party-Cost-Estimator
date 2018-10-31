namespace Dinner_Party_Cost_Estimator
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.healthyCheckBox = new System.Windows.Forms.CheckBox();
            this.fancyDecorationCheckBox = new System.Windows.Forms.CheckBox();
            this.numberOfPeopleControl = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.birthdayPeopleControl = new System.Windows.Forms.NumericUpDown();
            this.birthdayFancyDecorationControl = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.cakeWritingTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.birthdayCostLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleControl)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayPeopleControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(349, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.healthyCheckBox);
            this.tabPage1.Controls.Add(this.fancyDecorationCheckBox);
            this.tabPage1.Controls.Add(this.numberOfPeopleControl);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(341, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standard Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // healthyCheckBox
            // 
            this.healthyCheckBox.AutoSize = true;
            this.healthyCheckBox.Location = new System.Drawing.Point(112, 150);
            this.healthyCheckBox.Name = "healthyCheckBox";
            this.healthyCheckBox.Size = new System.Drawing.Size(96, 17);
            this.healthyCheckBox.TabIndex = 11;
            this.healthyCheckBox.Text = "Healthy Option";
            this.healthyCheckBox.UseVisualStyleBackColor = true;
            this.healthyCheckBox.CheckedChanged += new System.EventHandler(this.healthyCheckBox_CheckedChanged);
            // 
            // fancyDecorationCheckBox
            // 
            this.fancyDecorationCheckBox.AutoSize = true;
            this.fancyDecorationCheckBox.Location = new System.Drawing.Point(112, 127);
            this.fancyDecorationCheckBox.Name = "fancyDecorationCheckBox";
            this.fancyDecorationCheckBox.Size = new System.Drawing.Size(115, 17);
            this.fancyDecorationCheckBox.TabIndex = 10;
            this.fancyDecorationCheckBox.Text = "Fancy Decorations";
            this.fancyDecorationCheckBox.UseVisualStyleBackColor = true;
            this.fancyDecorationCheckBox.CheckedChanged += new System.EventHandler(this.fancyDecorationCheckBox_CheckedChanged);
            // 
            // numberOfPeopleControl
            // 
            this.numberOfPeopleControl.Location = new System.Drawing.Point(112, 101);
            this.numberOfPeopleControl.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberOfPeopleControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPeopleControl.Name = "numberOfPeopleControl";
            this.numberOfPeopleControl.Size = new System.Drawing.Size(120, 20);
            this.numberOfPeopleControl.TabIndex = 9;
            this.numberOfPeopleControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPeopleControl.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cost";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(147, 177);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(43, 15);
            this.costLabel.TabIndex = 7;
            this.costLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of People";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.birthdayCostLabel);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cakeWritingTextBox);
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.birthdayFancyDecorationControl);
            this.tabPage2.Controls.Add(this.birthdayPeopleControl);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(341, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of People";
            // 
            // birthdayPeopleControl
            // 
            this.birthdayPeopleControl.Location = new System.Drawing.Point(105, 19);
            this.birthdayPeopleControl.Name = "birthdayPeopleControl";
            this.birthdayPeopleControl.Size = new System.Drawing.Size(120, 20);
            this.birthdayPeopleControl.TabIndex = 1;
            // 
            // birthdayFancyDecorationControl
            // 
            this.birthdayFancyDecorationControl.AutoSize = true;
            this.birthdayFancyDecorationControl.Location = new System.Drawing.Point(105, 45);
            this.birthdayFancyDecorationControl.Name = "birthdayFancyDecorationControl";
            this.birthdayFancyDecorationControl.Size = new System.Drawing.Size(115, 17);
            this.birthdayFancyDecorationControl.TabIndex = 2;
            this.birthdayFancyDecorationControl.Text = "Fancy Decorations";
            this.birthdayFancyDecorationControl.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cake Writing";
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.DarkRed;
            this.tooLongLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tooLongLabel.Location = new System.Drawing.Point(172, 80);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(53, 13);
            this.tooLongLabel.TabIndex = 4;
            this.tooLongLabel.Text = "Too Long";
            // 
            // cakeWritingTextBox
            // 
            this.cakeWritingTextBox.Location = new System.Drawing.Point(105, 96);
            this.cakeWritingTextBox.Name = "cakeWritingTextBox";
            this.cakeWritingTextBox.Size = new System.Drawing.Size(120, 20);
            this.cakeWritingTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cost";
            // 
            // birthdayCostLabel
            // 
            this.birthdayCostLabel.AutoSize = true;
            this.birthdayCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayCostLabel.Location = new System.Drawing.Point(136, 129);
            this.birthdayCostLabel.Name = "birthdayCostLabel";
            this.birthdayCostLabel.Size = new System.Drawing.Size(43, 15);
            this.birthdayCostLabel.TabIndex = 7;
            this.birthdayCostLabel.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 303);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleControl)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayPeopleControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox healthyCheckBox;
        private System.Windows.Forms.CheckBox fancyDecorationCheckBox;
        private System.Windows.Forms.NumericUpDown numberOfPeopleControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label birthdayCostLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cakeWritingTextBox;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox birthdayFancyDecorationControl;
        private System.Windows.Forms.NumericUpDown birthdayPeopleControl;
        private System.Windows.Forms.Label label2;
    }
}

