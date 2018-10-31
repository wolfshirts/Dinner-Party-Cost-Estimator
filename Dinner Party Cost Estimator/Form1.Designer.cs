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
            this.label1 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfPeopleControl = new System.Windows.Forms.NumericUpDown();
            this.fancyDecorationCheckBox = new System.Windows.Forms.CheckBox();
            this.healthyCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleControl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(116, 101);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(43, 15);
            this.costLabel.TabIndex = 1;
            this.costLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost";
            // 
            // numberOfPeopleControl
            // 
            this.numberOfPeopleControl.Location = new System.Drawing.Point(81, 25);
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
            this.numberOfPeopleControl.TabIndex = 3;
            this.numberOfPeopleControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPeopleControl.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fancyDecorationCheckBox
            // 
            this.fancyDecorationCheckBox.AutoSize = true;
            this.fancyDecorationCheckBox.Location = new System.Drawing.Point(81, 51);
            this.fancyDecorationCheckBox.Name = "fancyDecorationCheckBox";
            this.fancyDecorationCheckBox.Size = new System.Drawing.Size(115, 17);
            this.fancyDecorationCheckBox.TabIndex = 4;
            this.fancyDecorationCheckBox.Text = "Fancy Decorations";
            this.fancyDecorationCheckBox.UseVisualStyleBackColor = true;
            this.fancyDecorationCheckBox.CheckedChanged += new System.EventHandler(this.fancyDecorationCheckBox_CheckedChanged);
            // 
            // healthyCheckBox
            // 
            this.healthyCheckBox.AutoSize = true;
            this.healthyCheckBox.Location = new System.Drawing.Point(81, 74);
            this.healthyCheckBox.Name = "healthyCheckBox";
            this.healthyCheckBox.Size = new System.Drawing.Size(96, 17);
            this.healthyCheckBox.TabIndex = 5;
            this.healthyCheckBox.Text = "Healthy Option";
            this.healthyCheckBox.UseVisualStyleBackColor = true;
            this.healthyCheckBox.CheckedChanged += new System.EventHandler(this.healthyCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 155);
            this.Controls.Add(this.healthyCheckBox);
            this.Controls.Add(this.fancyDecorationCheckBox);
            this.Controls.Add(this.numberOfPeopleControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberOfPeopleControl;
        private System.Windows.Forms.CheckBox fancyDecorationCheckBox;
        private System.Windows.Forms.CheckBox healthyCheckBox;
    }
}

