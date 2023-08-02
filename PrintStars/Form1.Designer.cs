namespace PrintStars
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rowChooser = new System.Windows.Forms.NumericUpDown();
            this.btPyramid = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rowChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btPrint
            // 
            this.btPrint.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btPrint.Location = new System.Drawing.Point(28, 119);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(217, 72);
            this.btPrint.TabIndex = 0;
            this.btPrint.Text = "產生星星階層";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "列數：";
            // 
            // rowChooser
            // 
            this.rowChooser.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rowChooser.Location = new System.Drawing.Point(127, 38);
            this.rowChooser.Name = "rowChooser";
            this.rowChooser.Size = new System.Drawing.Size(120, 43);
            this.rowChooser.TabIndex = 3;
            this.rowChooser.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.rowChooser.ValueChanged += new System.EventHandler(this.rowChooser_ValueChanged);
            // 
            // btPyramid
            // 
            this.btPyramid.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btPyramid.Location = new System.Drawing.Point(28, 219);
            this.btPyramid.Name = "btPyramid";
            this.btPyramid.Size = new System.Drawing.Size(217, 72);
            this.btPyramid.TabIndex = 4;
            this.btPyramid.Text = "產生金字塔";
            this.btPyramid.UseVisualStyleBackColor = true;
            this.btPyramid.Click += new System.EventHandler(this.btPyramid_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrintStars.Properties.Resources.star1;
            this.pictureBox1.Location = new System.Drawing.Point(301, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btPyramid);
            this.Controls.Add(this.rowChooser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPrint);
            this.Name = "Form1";
            this.Text = "Print Starts";
            ((System.ComponentModel.ISupportInitialize)(this.rowChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rowChooser;
        private System.Windows.Forms.Button btPyramid;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

