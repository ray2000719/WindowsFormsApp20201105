namespace WindowsFormsApp20201105
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbshow = new System.Windows.Forms.RichTextBox();
            this.pbshow = new System.Windows.Forms.PictureBox();
            this.btnpump = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbshow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(136, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "你今天的籤運";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(480, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "測試";
            // 
            // rtbshow
            // 
            this.rtbshow.Location = new System.Drawing.Point(485, 245);
            this.rtbshow.Name = "rtbshow";
            this.rtbshow.Size = new System.Drawing.Size(149, 131);
            this.rtbshow.TabIndex = 2;
            this.rtbshow.Text = "";
            // 
            // pbshow
            // 
            this.pbshow.Image = global::WindowsFormsApp20201105.Properties.Resources.a4;
            this.pbshow.Location = new System.Drawing.Point(141, 94);
            this.pbshow.Name = "pbshow";
            this.pbshow.Size = new System.Drawing.Size(182, 282);
            this.pbshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbshow.TabIndex = 3;
            this.pbshow.TabStop = false;
            // 
            // btnpump
            // 
            this.btnpump.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpump.Location = new System.Drawing.Point(485, 39);
            this.btnpump.Name = "btnpump";
            this.btnpump.Size = new System.Drawing.Size(149, 126);
            this.btnpump.TabIndex = 4;
            this.btnpump.Text = "抽";
            this.btnpump.UseVisualStyleBackColor = true;
            this.btnpump.Click += new System.EventHandler(this.Btnpump_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpump);
            this.Controls.Add(this.pbshow);
            this.Controls.Add(this.rtbshow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbshow;
        private System.Windows.Forms.PictureBox pbshow;
        private System.Windows.Forms.Button btnpump;
    }
}

