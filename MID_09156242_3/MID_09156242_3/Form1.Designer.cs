
namespace MID_09156242_3
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Minite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Button();
            this.Second = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Counting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Minite
            // 
            this.Minite.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Minite.Location = new System.Drawing.Point(46, 55);
            this.Minite.Name = "Minite";
            this.Minite.Size = new System.Drawing.Size(83, 39);
            this.Minite.TabIndex = 0;
            this.Minite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(147, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "分";
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Count.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Count.Location = new System.Drawing.Point(395, 49);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(152, 57);
            this.Count.TabIndex = 2;
            this.Count.Text = "開始計算";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Start);
            // 
            // Second
            // 
            this.Second.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Second.Location = new System.Drawing.Point(221, 55);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(83, 39);
            this.Second.TabIndex = 0;
            this.Second.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(332, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "秒";
            // 
            // Counting
            // 
            this.Counting.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Counting.ForeColor = System.Drawing.Color.Maroon;
            this.Counting.Location = new System.Drawing.Point(91, 145);
            this.Counting.Name = "Counting";
            this.Counting.Size = new System.Drawing.Size(385, 134);
            this.Counting.TabIndex = 1;
            this.Counting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 322);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Counting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.Minite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox Minite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.TextBox Second;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Counting;
    }
}

