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
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblRefractiveIndex = new System.Windows.Forms.Label();
            this.lblIndexEquation = new System.Windows.Forms.Label();
            this.lblEqPart1 = new System.Windows.Forms.Label();
            this.txtM1 = new System.Windows.Forms.TextBox();
            this.lblEqPart2 = new System.Windows.Forms.Label();
            this.txtM2 = new System.Windows.Forms.TextBox();
            this.lblSizeParam = new System.Windows.Forms.Label();
            this.lblSizeParamEquation = new System.Windows.Forms.Label();
            this.lblK0 = new System.Windows.Forms.Label();
            this.txtK0 = new System.Windows.Forms.TextBox();
            this.lblWaveNum = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblSphereRadius = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblScatteringAngle = new System.Windows.Forms.Label();
            this.lblAngleEquation = new System.Windows.Forms.Label();
            this.lblTheta = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.txtTheta = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.groupBoxParams.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.txtM2);
            this.groupBoxParams.Controls.Add(this.lblEqPart2);
            this.groupBoxParams.Controls.Add(this.txtA);
            this.groupBoxParams.Controls.Add(this.txtTheta);
            this.groupBoxParams.Controls.Add(this.txtK0);
            this.groupBoxParams.Controls.Add(this.lblSphereRadius);
            this.groupBoxParams.Controls.Add(this.lblA);
            this.groupBoxParams.Controls.Add(this.lblDegree);
            this.groupBoxParams.Controls.Add(this.lblTheta);
            this.groupBoxParams.Controls.Add(this.lblWaveNum);
            this.groupBoxParams.Controls.Add(this.lblK0);
            this.groupBoxParams.Controls.Add(this.txtM1);
            this.groupBoxParams.Controls.Add(this.lblEqPart1);
            this.groupBoxParams.Controls.Add(this.lblAngleEquation);
            this.groupBoxParams.Controls.Add(this.lblSizeParamEquation);
            this.groupBoxParams.Controls.Add(this.lblScatteringAngle);
            this.groupBoxParams.Controls.Add(this.lblSizeParam);
            this.groupBoxParams.Controls.Add(this.lblIndexEquation);
            this.groupBoxParams.Controls.Add(this.lblRefractiveIndex);
            this.groupBoxParams.Location = new System.Drawing.Point(12, 12);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(850, 145);
            this.groupBoxParams.TabIndex = 0;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Parameters";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(358, 52);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(131, 43);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblRefractiveIndex
            // 
            this.lblRefractiveIndex.AutoSize = true;
            this.lblRefractiveIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefractiveIndex.Location = new System.Drawing.Point(36, 30);
            this.lblRefractiveIndex.Name = "lblRefractiveIndex";
            this.lblRefractiveIndex.Size = new System.Drawing.Size(163, 16);
            this.lblRefractiveIndex.TabIndex = 0;
            this.lblRefractiveIndex.Text = "Complex Refractive Index:";
            // 
            // lblIndexEquation
            // 
            this.lblIndexEquation.AutoSize = true;
            this.lblIndexEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexEquation.Location = new System.Drawing.Point(205, 30);
            this.lblIndexEquation.Name = "lblIndexEquation";
            this.lblIndexEquation.Size = new System.Drawing.Size(78, 16);
            this.lblIndexEquation.TabIndex = 0;
            this.lblIndexEquation.Text = "m = m\' + im\"";
            // 
            // lblEqPart1
            // 
            this.lblEqPart1.AutoSize = true;
            this.lblEqPart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqPart1.Location = new System.Drawing.Point(321, 30);
            this.lblEqPart1.Name = "lblEqPart1";
            this.lblEqPart1.Size = new System.Drawing.Size(32, 16);
            this.lblEqPart1.TabIndex = 0;
            this.lblEqPart1.Text = "m = ";
            // 
            // txtM1
            // 
            this.txtM1.Location = new System.Drawing.Point(352, 29);
            this.txtM1.Name = "txtM1";
            this.txtM1.Size = new System.Drawing.Size(55, 20);
            this.txtM1.TabIndex = 1;
            // 
            // lblEqPart2
            // 
            this.lblEqPart2.AutoSize = true;
            this.lblEqPart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqPart2.Location = new System.Drawing.Point(411, 30);
            this.lblEqPart2.Name = "lblEqPart2";
            this.lblEqPart2.Size = new System.Drawing.Size(21, 16);
            this.lblEqPart2.TabIndex = 0;
            this.lblEqPart2.Text = "+ i";
            // 
            // txtM2
            // 
            this.txtM2.Location = new System.Drawing.Point(434, 29);
            this.txtM2.Name = "txtM2";
            this.txtM2.Size = new System.Drawing.Size(55, 20);
            this.txtM2.TabIndex = 2;
            // 
            // lblSizeParam
            // 
            this.lblSizeParam.AutoSize = true;
            this.lblSizeParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeParam.Location = new System.Drawing.Point(36, 68);
            this.lblSizeParam.Name = "lblSizeParam";
            this.lblSizeParam.Size = new System.Drawing.Size(103, 16);
            this.lblSizeParam.TabIndex = 0;
            this.lblSizeParam.Text = "Size Parameter:";
            // 
            // lblSizeParamEquation
            // 
            this.lblSizeParamEquation.AutoSize = true;
            this.lblSizeParamEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeParamEquation.Location = new System.Drawing.Point(205, 68);
            this.lblSizeParamEquation.Name = "lblSizeParamEquation";
            this.lblSizeParamEquation.Size = new System.Drawing.Size(60, 16);
            this.lblSizeParamEquation.TabIndex = 0;
            this.lblSizeParamEquation.Text = "x = k0 * a";
            // 
            // lblK0
            // 
            this.lblK0.AutoSize = true;
            this.lblK0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblK0.Location = new System.Drawing.Point(409, 68);
            this.lblK0.Name = "lblK0";
            this.lblK0.Size = new System.Drawing.Size(25, 16);
            this.lblK0.TabIndex = 0;
            this.lblK0.Text = "k0:";
            // 
            // txtK0
            // 
            this.txtK0.Location = new System.Drawing.Point(434, 67);
            this.txtK0.Name = "txtK0";
            this.txtK0.Size = new System.Drawing.Size(55, 20);
            this.txtK0.TabIndex = 3;
            // 
            // lblWaveNum
            // 
            this.lblWaveNum.AutoSize = true;
            this.lblWaveNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaveNum.Location = new System.Drawing.Point(491, 68);
            this.lblWaveNum.Name = "lblWaveNum";
            this.lblWaveNum.Size = new System.Drawing.Size(96, 16);
            this.lblWaveNum.TabIndex = 0;
            this.lblWaveNum.Text = "(wave number)";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(620, 68);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(19, 16);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "a:";
            // 
            // lblSphereRadius
            // 
            this.lblSphereRadius.AutoSize = true;
            this.lblSphereRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSphereRadius.Location = new System.Drawing.Point(697, 68);
            this.lblSphereRadius.Name = "lblSphereRadius";
            this.lblSphereRadius.Size = new System.Drawing.Size(98, 16);
            this.lblSphereRadius.TabIndex = 0;
            this.lblSphereRadius.Text = "(sphere radius)";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(641, 67);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(54, 20);
            this.txtA.TabIndex = 4;
            // 
            // lblScatteringAngle
            // 
            this.lblScatteringAngle.AutoSize = true;
            this.lblScatteringAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScatteringAngle.Location = new System.Drawing.Point(36, 105);
            this.lblScatteringAngle.Name = "lblScatteringAngle";
            this.lblScatteringAngle.Size = new System.Drawing.Size(109, 16);
            this.lblScatteringAngle.TabIndex = 0;
            this.lblScatteringAngle.Text = "Scattering Angle:";
            // 
            // lblAngleEquation
            // 
            this.lblAngleEquation.AutoSize = true;
            this.lblAngleEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngleEquation.Location = new System.Drawing.Point(205, 105);
            this.lblAngleEquation.Name = "lblAngleEquation";
            this.lblAngleEquation.Size = new System.Drawing.Size(87, 16);
            this.lblAngleEquation.TabIndex = 0;
            this.lblAngleEquation.Text = "u = cos(theta)";
            // 
            // lblTheta
            // 
            this.lblTheta.AutoSize = true;
            this.lblTheta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheta.Location = new System.Drawing.Point(394, 105);
            this.lblTheta.Name = "lblTheta";
            this.lblTheta.Size = new System.Drawing.Size(40, 16);
            this.lblTheta.TabIndex = 0;
            this.lblTheta.Text = "theta:";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.Location = new System.Drawing.Point(491, 105);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(60, 16);
            this.lblDegree.TabIndex = 0;
            this.lblDegree.Text = "(degree)";
            // 
            // txtTheta
            // 
            this.txtTheta.Location = new System.Drawing.Point(434, 104);
            this.txtTheta.Name = "txtTheta";
            this.txtTheta.Size = new System.Drawing.Size(55, 20);
            this.txtTheta.TabIndex = 5;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.btnCalculate);
            this.groupBoxResult.Location = new System.Drawing.Point(12, 445);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(850, 142);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MieScatteringMax.Properties.Resources.mie_sky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(874, 599);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxParams);
            this.Name = "Form1";
            this.Text = "MieScatteringMax";
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label labelLambda;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.TextBox txtM2;
        private System.Windows.Forms.Label lblEqPart2;
        private System.Windows.Forms.TextBox txtM1;
        private System.Windows.Forms.Label lblEqPart1;
        private System.Windows.Forms.Label lblIndexEquation;
        private System.Windows.Forms.Label lblRefractiveIndex;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtK0;
        private System.Windows.Forms.Label lblSphereRadius;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblWaveNum;
        private System.Windows.Forms.Label lblK0;
        private System.Windows.Forms.Label lblSizeParamEquation;
        private System.Windows.Forms.Label lblSizeParam;
        private System.Windows.Forms.TextBox txtTheta;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblTheta;
        private System.Windows.Forms.Label lblAngleEquation;
        private System.Windows.Forms.Label lblScatteringAngle;
        private System.Windows.Forms.GroupBox groupBoxResult;
    }
}

