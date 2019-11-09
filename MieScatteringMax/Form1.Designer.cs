namespace MieScatteringMax
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.labelLambda = new System.Windows.Forms.Label();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(273, 159);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(118, 44);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // labelLambda
            // 
            this.labelLambda.AutoSize = true;
            this.labelLambda.Location = new System.Drawing.Point(78, 62);
            this.labelLambda.Name = "labelLambda";
            this.labelLambda.Size = new System.Drawing.Size(47, 13);
            this.labelLambda.TabIndex = 1;
            this.labelLambda.Text = "lambda :";
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(131, 62);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(100, 20);
            this.txtLambda.TabIndex = 1;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(367, 62);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(47, 13);
            this.labelVolume.TabIndex = 1;
            this.labelVolume.Text = "volume :";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(420, 62);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(100, 20);
            this.txtVolume.TabIndex = 2;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(318, 330);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(24, 25);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.labelLambda);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label labelLambda;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label labelResult;
    }
}

