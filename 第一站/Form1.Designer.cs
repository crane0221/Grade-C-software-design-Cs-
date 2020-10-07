namespace 迴文判斷
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
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.btn05 = new System.Windows.Forms.Button();
            this.txtShow01 = new System.Windows.Forms.TextBox();
            this.txtShow02 = new System.Windows.Forms.TextBox();
            this.txtShow03 = new System.Windows.Forms.TextBox();
            this.txtShow04 = new System.Windows.Forms.TextBox();
            this.txtShow05 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(63, 52);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(125, 36);
            this.btn01.TabIndex = 0;
            this.btn01.Text = "第一題";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(296, 52);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(125, 36);
            this.btn02.TabIndex = 1;
            this.btn02.Text = "第二題";
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btn02_Click);
            // 
            // btn03
            // 
            this.btn03.Location = new System.Drawing.Point(531, 52);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(125, 36);
            this.btn03.TabIndex = 2;
            this.btn03.Text = "第三題";
            this.btn03.UseVisualStyleBackColor = true;
            this.btn03.Click += new System.EventHandler(this.btn03_Click);
            // 
            // btn04
            // 
            this.btn04.Location = new System.Drawing.Point(746, 52);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(125, 36);
            this.btn04.TabIndex = 3;
            this.btn04.Text = "第四題";
            this.btn04.UseVisualStyleBackColor = true;
            this.btn04.Click += new System.EventHandler(this.btn04_Click);
            // 
            // btn05
            // 
            this.btn05.Location = new System.Drawing.Point(985, 52);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(125, 36);
            this.btn05.TabIndex = 4;
            this.btn05.Text = "第五題";
            this.btn05.UseVisualStyleBackColor = true;
            this.btn05.Click += new System.EventHandler(this.btn05_Click);
            // 
            // txtShow01
            // 
            this.txtShow01.Location = new System.Drawing.Point(12, 120);
            this.txtShow01.Multiline = true;
            this.txtShow01.Name = "txtShow01";
            this.txtShow01.Size = new System.Drawing.Size(226, 223);
            this.txtShow01.TabIndex = 5;
            // 
            // txtShow02
            // 
            this.txtShow02.Location = new System.Drawing.Point(244, 120);
            this.txtShow02.Multiline = true;
            this.txtShow02.Name = "txtShow02";
            this.txtShow02.Size = new System.Drawing.Size(226, 223);
            this.txtShow02.TabIndex = 6;
            // 
            // txtShow03
            // 
            this.txtShow03.Location = new System.Drawing.Point(476, 120);
            this.txtShow03.Multiline = true;
            this.txtShow03.Name = "txtShow03";
            this.txtShow03.Size = new System.Drawing.Size(226, 223);
            this.txtShow03.TabIndex = 7;
            // 
            // txtShow04
            // 
            this.txtShow04.Location = new System.Drawing.Point(708, 120);
            this.txtShow04.Multiline = true;
            this.txtShow04.Name = "txtShow04";
            this.txtShow04.Size = new System.Drawing.Size(226, 223);
            this.txtShow04.TabIndex = 8;
            // 
            // txtShow05
            // 
            this.txtShow05.Location = new System.Drawing.Point(940, 120);
            this.txtShow05.Multiline = true;
            this.txtShow05.Name = "txtShow05";
            this.txtShow05.Size = new System.Drawing.Size(226, 223);
            this.txtShow05.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 363);
            this.Controls.Add(this.txtShow05);
            this.Controls.Add(this.txtShow04);
            this.Controls.Add(this.txtShow03);
            this.Controls.Add(this.txtShow02);
            this.Controls.Add(this.txtShow01);
            this.Controls.Add(this.btn05);
            this.Controls.Add(this.btn04);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btn04;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.TextBox txtShow01;
        private System.Windows.Forms.TextBox txtShow02;
        private System.Windows.Forms.TextBox txtShow03;
        private System.Windows.Forms.TextBox txtShow04;
        private System.Windows.Forms.TextBox txtShow05;
    }
}

