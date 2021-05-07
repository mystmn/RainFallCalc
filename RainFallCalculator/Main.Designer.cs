
namespace RainFallCalculator
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
            this.buttonUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTotalRows = new System.Windows.Forms.Label();
            this.labelTotalGood = new System.Windows.Forms.Label();
            this.labelBadRows = new System.Windows.Forms.Label();
            this.labelMinValue = new System.Windows.Forms.Label();
            this.labelMaxValue = new System.Windows.Forms.Label();
            this.textBoxTotalRows = new System.Windows.Forms.TextBox();
            this.textBoxGood = new System.Windows.Forms.TextBox();
            this.textBoxBad = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.labelAverage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(299, 325);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(95, 50);
            this.buttonUpload.TabIndex = 2;
            this.buttonUpload.Text = "Upload Document";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(83, 71);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse File";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Path:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(137, 22);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(83, 13);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "directory path ...";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(456, 325);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(95, 50);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTotalRows
            // 
            this.labelTotalRows.AutoSize = true;
            this.labelTotalRows.Location = new System.Drawing.Point(80, 129);
            this.labelTotalRows.Name = "labelTotalRows";
            this.labelTotalRows.Size = new System.Drawing.Size(67, 13);
            this.labelTotalRows.TabIndex = 6;
            this.labelTotalRows.Text = "Total Rows: ";
            // 
            // labelTotalGood
            // 
            this.labelTotalGood.AutoSize = true;
            this.labelTotalGood.Location = new System.Drawing.Point(80, 166);
            this.labelTotalGood.Name = "labelTotalGood";
            this.labelTotalGood.Size = new System.Drawing.Size(69, 13);
            this.labelTotalGood.TabIndex = 7;
            this.labelTotalGood.Text = "Good Rows: ";
            // 
            // labelBadRows
            // 
            this.labelBadRows.AutoSize = true;
            this.labelBadRows.Location = new System.Drawing.Point(90, 200);
            this.labelBadRows.Name = "labelBadRows";
            this.labelBadRows.Size = new System.Drawing.Size(59, 13);
            this.labelBadRows.TabIndex = 8;
            this.labelBadRows.Text = "Bad Rows:";
            // 
            // labelMinValue
            // 
            this.labelMinValue.AutoSize = true;
            this.labelMinValue.Location = new System.Drawing.Point(90, 234);
            this.labelMinValue.Name = "labelMinValue";
            this.labelMinValue.Size = new System.Drawing.Size(57, 13);
            this.labelMinValue.TabIndex = 9;
            this.labelMinValue.Text = "Min Value:";
            // 
            // labelMaxValue
            // 
            this.labelMaxValue.AutoSize = true;
            this.labelMaxValue.Location = new System.Drawing.Point(89, 266);
            this.labelMaxValue.Name = "labelMaxValue";
            this.labelMaxValue.Size = new System.Drawing.Size(60, 13);
            this.labelMaxValue.TabIndex = 10;
            this.labelMaxValue.Text = "Max Value:";
            // 
            // textBoxTotalRows
            // 
            this.textBoxTotalRows.Location = new System.Drawing.Point(180, 126);
            this.textBoxTotalRows.Name = "textBoxTotalRows";
            this.textBoxTotalRows.ReadOnly = true;
            this.textBoxTotalRows.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalRows.TabIndex = 20;
            // 
            // textBoxGood
            // 
            this.textBoxGood.Location = new System.Drawing.Point(180, 163);
            this.textBoxGood.Name = "textBoxGood";
            this.textBoxGood.ReadOnly = true;
            this.textBoxGood.Size = new System.Drawing.Size(100, 20);
            this.textBoxGood.TabIndex = 21;
            // 
            // textBoxBad
            // 
            this.textBoxBad.Location = new System.Drawing.Point(180, 197);
            this.textBoxBad.Name = "textBoxBad";
            this.textBoxBad.ReadOnly = true;
            this.textBoxBad.Size = new System.Drawing.Size(100, 20);
            this.textBoxBad.TabIndex = 22;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(180, 227);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxMin.TabIndex = 23;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(180, 263);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax.TabIndex = 24;
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(180, 301);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(100, 20);
            this.textBoxAverage.TabIndex = 26;
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(69, 304);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(80, 13);
            this.labelAverage.TabIndex = 25;
            this.labelAverage.Text = "Average Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Paul Cameron";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "05/06/2021";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAverage);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxBad);
            this.Controls.Add(this.textBoxGood);
            this.Controls.Add(this.textBoxTotalRows);
            this.Controls.Add(this.labelMaxValue);
            this.Controls.Add(this.labelMinValue);
            this.Controls.Add(this.labelBadRows);
            this.Controls.Add(this.labelTotalGood);
            this.Controls.Add(this.labelTotalRows);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.buttonUpload);
            this.Name = "Main";
            this.Text = "RainFall Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTotalRows;
        private System.Windows.Forms.Label labelTotalGood;
        private System.Windows.Forms.Label labelBadRows;
        private System.Windows.Forms.Label labelMinValue;
        private System.Windows.Forms.Label labelMaxValue;
        private System.Windows.Forms.TextBox textBoxTotalRows;
        private System.Windows.Forms.TextBox textBoxGood;
        private System.Windows.Forms.TextBox textBoxBad;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

