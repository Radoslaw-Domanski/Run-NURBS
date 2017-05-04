namespace Run_NURBS
{
    partial class Main
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
            this.butMakeFile = new System.Windows.Forms.Button();
            this.labPoints = new System.Windows.Forms.Label();
            this.textPoints = new System.Windows.Forms.TextBox();
            this.textWeights = new System.Windows.Forms.TextBox();
            this.labWeights = new System.Windows.Forms.Label();
            this.textKnotsU = new System.Windows.Forms.TextBox();
            this.labKnotsU = new System.Windows.Forms.Label();
            this.textKnotsV = new System.Windows.Forms.TextBox();
            this.labKnotsV = new System.Windows.Forms.Label();
            this.textNumSurface = new System.Windows.Forms.TextBox();
            this.labNumSurface = new System.Windows.Forms.Label();
            this.textMakeFile = new System.Windows.Forms.TextBox();
            this.labMakeFile = new System.Windows.Forms.Label();
            this.listBatFiles = new System.Windows.Forms.ListView();
            this.butRunNurbs = new System.Windows.Forms.Button();
            this.labBatFiles = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.butPoints = new System.Windows.Forms.Button();
            this.butWeights = new System.Windows.Forms.Button();
            this.butKnotsU = new System.Windows.Forms.Button();
            this.butKnotsV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butMakeFile
            // 
            this.butMakeFile.Location = new System.Drawing.Point(134, 115);
            this.butMakeFile.Name = "butMakeFile";
            this.butMakeFile.Size = new System.Drawing.Size(100, 21);
            this.butMakeFile.TabIndex = 0;
            this.butMakeFile.Text = "Generuj plik";
            this.butMakeFile.UseVisualStyleBackColor = true;
            this.butMakeFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // labPoints
            // 
            this.labPoints.AutoSize = true;
            this.labPoints.Location = new System.Drawing.Point(9, 21);
            this.labPoints.Name = "labPoints";
            this.labPoints.Size = new System.Drawing.Size(40, 13);
            this.labPoints.TabIndex = 1;
            this.labPoints.Text = "Punkty";
            // 
            // textPoints
            // 
            this.textPoints.Location = new System.Drawing.Point(12, 37);
            this.textPoints.Name = "textPoints";
            this.textPoints.Size = new System.Drawing.Size(100, 20);
            this.textPoints.TabIndex = 2;
            this.textPoints.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textWeights
            // 
            this.textWeights.Location = new System.Drawing.Point(12, 76);
            this.textWeights.Name = "textWeights";
            this.textWeights.Size = new System.Drawing.Size(100, 20);
            this.textWeights.TabIndex = 4;
            // 
            // labWeights
            // 
            this.labWeights.AutoSize = true;
            this.labWeights.Location = new System.Drawing.Point(9, 60);
            this.labWeights.Name = "labWeights";
            this.labWeights.Size = new System.Drawing.Size(32, 13);
            this.labWeights.TabIndex = 3;
            this.labWeights.Text = "Wagi";
            // 
            // textKnotsU
            // 
            this.textKnotsU.Location = new System.Drawing.Point(12, 115);
            this.textKnotsU.Name = "textKnotsU";
            this.textKnotsU.Size = new System.Drawing.Size(100, 20);
            this.textKnotsU.TabIndex = 6;
            // 
            // labKnotsU
            // 
            this.labKnotsU.AutoSize = true;
            this.labKnotsU.Location = new System.Drawing.Point(9, 99);
            this.labKnotsU.Name = "labKnotsU";
            this.labKnotsU.Size = new System.Drawing.Size(49, 13);
            this.labKnotsU.TabIndex = 5;
            this.labKnotsU.Text = "Węzły U";
            // 
            // textKnotsV
            // 
            this.textKnotsV.Location = new System.Drawing.Point(12, 154);
            this.textKnotsV.Name = "textKnotsV";
            this.textKnotsV.Size = new System.Drawing.Size(100, 20);
            this.textKnotsV.TabIndex = 8;
            // 
            // labKnotsV
            // 
            this.labKnotsV.AutoSize = true;
            this.labKnotsV.Location = new System.Drawing.Point(9, 138);
            this.labKnotsV.Name = "labKnotsV";
            this.labKnotsV.Size = new System.Drawing.Size(48, 13);
            this.labKnotsV.TabIndex = 7;
            this.labKnotsV.Text = "Węzły V";
            // 
            // textNumSurface
            // 
            this.textNumSurface.Location = new System.Drawing.Point(134, 76);
            this.textNumSurface.Name = "textNumSurface";
            this.textNumSurface.Size = new System.Drawing.Size(100, 20);
            this.textNumSurface.TabIndex = 10;
            // 
            // labNumSurface
            // 
            this.labNumSurface.AutoSize = true;
            this.labNumSurface.Location = new System.Drawing.Point(131, 60);
            this.labNumSurface.Name = "labNumSurface";
            this.labNumSurface.Size = new System.Drawing.Size(103, 13);
            this.labNumSurface.TabIndex = 9;
            this.labNumSurface.Text = "Ilość powierzchni (5)";
            // 
            // textMakeFile
            // 
            this.textMakeFile.Location = new System.Drawing.Point(134, 37);
            this.textMakeFile.Name = "textMakeFile";
            this.textMakeFile.Size = new System.Drawing.Size(100, 20);
            this.textMakeFile.TabIndex = 12;
            // 
            // labMakeFile
            // 
            this.labMakeFile.AutoSize = true;
            this.labMakeFile.Location = new System.Drawing.Point(131, 21);
            this.labMakeFile.Name = "labMakeFile";
            this.labMakeFile.Size = new System.Drawing.Size(103, 13);
            this.labMakeFile.TabIndex = 11;
            this.labMakeFile.Text = "Tworzony plik (*.bat)";
            // 
            // listBatFiles
            // 
            this.listBatFiles.Location = new System.Drawing.Point(254, 37);
            this.listBatFiles.Name = "listBatFiles";
            this.listBatFiles.Size = new System.Drawing.Size(108, 98);
            this.listBatFiles.TabIndex = 13;
            this.listBatFiles.UseCompatibleStateImageBehavior = false;
            this.listBatFiles.View = System.Windows.Forms.View.List;
            this.listBatFiles.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // butRunNurbs
            // 
            this.butRunNurbs.Location = new System.Drawing.Point(134, 153);
            this.butRunNurbs.Name = "butRunNurbs";
            this.butRunNurbs.Size = new System.Drawing.Size(228, 21);
            this.butRunNurbs.TabIndex = 14;
            this.butRunNurbs.Text = "Modeluj";
            this.butRunNurbs.UseVisualStyleBackColor = true;
            this.butRunNurbs.Click += new System.EventHandler(this.button2_Click);
            // 
            // labBatFiles
            // 
            this.labBatFiles.AutoSize = true;
            this.labBatFiles.Location = new System.Drawing.Point(251, 21);
            this.labBatFiles.Name = "labBatFiles";
            this.labBatFiles.Size = new System.Drawing.Size(95, 13);
            this.labBatFiles.TabIndex = 15;
            this.labBatFiles.Text = "Modelowane dane";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "dialogPlikow";
            // 
            // butPoints
            // 
            this.butPoints.Location = new System.Drawing.Point(94, 37);
            this.butPoints.Name = "butPoints";
            this.butPoints.Size = new System.Drawing.Size(18, 20);
            this.butPoints.TabIndex = 16;
            this.butPoints.UseVisualStyleBackColor = true;
            this.butPoints.Click += new System.EventHandler(this.button3_Click);
            // 
            // butWeights
            // 
            this.butWeights.Location = new System.Drawing.Point(94, 75);
            this.butWeights.Name = "butWeights";
            this.butWeights.Size = new System.Drawing.Size(18, 20);
            this.butWeights.TabIndex = 17;
            this.butWeights.UseVisualStyleBackColor = true;
            this.butWeights.Click += new System.EventHandler(this.button4_Click);
            // 
            // butKnotsU
            // 
            this.butKnotsU.Location = new System.Drawing.Point(94, 114);
            this.butKnotsU.Name = "butKnotsU";
            this.butKnotsU.Size = new System.Drawing.Size(18, 20);
            this.butKnotsU.TabIndex = 18;
            this.butKnotsU.UseVisualStyleBackColor = true;
            this.butKnotsU.Click += new System.EventHandler(this.button5_Click);
            // 
            // butKnotsV
            // 
            this.butKnotsV.Location = new System.Drawing.Point(94, 153);
            this.butKnotsV.Name = "butKnotsV";
            this.butKnotsV.Size = new System.Drawing.Size(18, 20);
            this.butKnotsV.TabIndex = 19;
            this.butKnotsV.UseVisualStyleBackColor = true;
            this.butKnotsV.Click += new System.EventHandler(this.button6_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 187);
            this.Controls.Add(this.butKnotsV);
            this.Controls.Add(this.butKnotsU);
            this.Controls.Add(this.butWeights);
            this.Controls.Add(this.butPoints);
            this.Controls.Add(this.labBatFiles);
            this.Controls.Add(this.butRunNurbs);
            this.Controls.Add(this.listBatFiles);
            this.Controls.Add(this.textMakeFile);
            this.Controls.Add(this.labMakeFile);
            this.Controls.Add(this.textNumSurface);
            this.Controls.Add(this.labNumSurface);
            this.Controls.Add(this.textKnotsV);
            this.Controls.Add(this.labKnotsV);
            this.Controls.Add(this.textKnotsU);
            this.Controls.Add(this.labKnotsU);
            this.Controls.Add(this.textWeights);
            this.Controls.Add(this.labWeights);
            this.Controls.Add(this.textPoints);
            this.Controls.Add(this.labPoints);
            this.Controls.Add(this.butMakeFile);
            this.Name = "Main";
            this.Text = "Run NURBS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butMakeFile;
        private System.Windows.Forms.Label labPoints;
        private System.Windows.Forms.TextBox textPoints;
        private System.Windows.Forms.TextBox textWeights;
        private System.Windows.Forms.Label labWeights;
        private System.Windows.Forms.TextBox textKnotsU;
        private System.Windows.Forms.Label labKnotsU;
        private System.Windows.Forms.TextBox textKnotsV;
        private System.Windows.Forms.Label labKnotsV;
        private System.Windows.Forms.TextBox textNumSurface;
        private System.Windows.Forms.Label labNumSurface;
        private System.Windows.Forms.TextBox textMakeFile;
        private System.Windows.Forms.Label labMakeFile;
        private System.Windows.Forms.ListView listBatFiles;
        private System.Windows.Forms.Button butRunNurbs;
        private System.Windows.Forms.Label labBatFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button butPoints;
        private System.Windows.Forms.Button butWeights;
        private System.Windows.Forms.Button butKnotsU;
        private System.Windows.Forms.Button butKnotsV;
    }
}

