
namespace MID_09156242_2
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
            this.First_Number = new System.Windows.Forms.TextBox();
            this.Radiobutton_Plus = new System.Windows.Forms.RadioButton();
            this.Radiobutton_Minus = new System.Windows.Forms.RadioButton();
            this.Radiobutton_Mutiply = new System.Windows.Forms.RadioButton();
            this.Radiobutton_Divide = new System.Windows.Forms.RadioButton();
            this.Second_Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.Button_Count = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // First_Number
            // 
            this.First_Number.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.First_Number.Location = new System.Drawing.Point(74, 134);
            this.First_Number.Name = "First_Number";
            this.First_Number.Size = new System.Drawing.Size(70, 36);
            this.First_Number.TabIndex = 0;
            // 
            // Radiobutton_Plus
            // 
            this.Radiobutton_Plus.AutoSize = true;
            this.Radiobutton_Plus.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Radiobutton_Plus.Location = new System.Drawing.Point(188, 68);
            this.Radiobutton_Plus.Name = "Radiobutton_Plus";
            this.Radiobutton_Plus.Size = new System.Drawing.Size(53, 32);
            this.Radiobutton_Plus.TabIndex = 1;
            this.Radiobutton_Plus.TabStop = true;
            this.Radiobutton_Plus.Text = "+";
            this.Radiobutton_Plus.UseVisualStyleBackColor = true;
            // 
            // Radiobutton_Minus
            // 
            this.Radiobutton_Minus.AutoSize = true;
            this.Radiobutton_Minus.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Radiobutton_Minus.Location = new System.Drawing.Point(188, 112);
            this.Radiobutton_Minus.Name = "Radiobutton_Minus";
            this.Radiobutton_Minus.Size = new System.Drawing.Size(59, 32);
            this.Radiobutton_Minus.TabIndex = 1;
            this.Radiobutton_Minus.TabStop = true;
            this.Radiobutton_Minus.Text = "－";
            this.Radiobutton_Minus.UseVisualStyleBackColor = true;
            // 
            // Radiobutton_Mutiply
            // 
            this.Radiobutton_Mutiply.AutoSize = true;
            this.Radiobutton_Mutiply.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Radiobutton_Mutiply.Location = new System.Drawing.Point(188, 158);
            this.Radiobutton_Mutiply.Name = "Radiobutton_Mutiply";
            this.Radiobutton_Mutiply.Size = new System.Drawing.Size(53, 32);
            this.Radiobutton_Mutiply.TabIndex = 1;
            this.Radiobutton_Mutiply.TabStop = true;
            this.Radiobutton_Mutiply.Text = "×";
            this.Radiobutton_Mutiply.UseVisualStyleBackColor = true;
            // 
            // Radiobutton_Divide
            // 
            this.Radiobutton_Divide.AutoSize = true;
            this.Radiobutton_Divide.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Radiobutton_Divide.Location = new System.Drawing.Point(188, 199);
            this.Radiobutton_Divide.Name = "Radiobutton_Divide";
            this.Radiobutton_Divide.Size = new System.Drawing.Size(53, 32);
            this.Radiobutton_Divide.TabIndex = 1;
            this.Radiobutton_Divide.TabStop = true;
            this.Radiobutton_Divide.Text = "÷";
            this.Radiobutton_Divide.UseVisualStyleBackColor = true;
            // 
            // Second_Number
            // 
            this.Second_Number.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Second_Number.Location = new System.Drawing.Point(277, 134);
            this.Second_Number.Name = "Second_Number";
            this.Second_Number.Size = new System.Drawing.Size(70, 36);
            this.Second_Number.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(383, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Answer.Location = new System.Drawing.Point(443, 134);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(107, 56);
            this.Answer.TabIndex = 2;
            this.Answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer.Visible = false;
            // 
            // Button_Count
            // 
            this.Button_Count.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_Count.Location = new System.Drawing.Point(48, 277);
            this.Button_Count.Name = "Button_Count";
            this.Button_Count.Size = new System.Drawing.Size(363, 58);
            this.Button_Count.TabIndex = 3;
            this.Button_Count.Text = "計算";
            this.Button_Count.UseVisualStyleBackColor = true;
            this.Button_Count.Click += new System.EventHandler(this.Count);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(448, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Clear);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button_Count);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Radiobutton_Divide);
            this.Controls.Add(this.Radiobutton_Mutiply);
            this.Controls.Add(this.Radiobutton_Minus);
            this.Controls.Add(this.Radiobutton_Plus);
            this.Controls.Add(this.Second_Number);
            this.Controls.Add(this.First_Number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox First_Number;
        private System.Windows.Forms.RadioButton Radiobutton_Plus;
        private System.Windows.Forms.RadioButton Radiobutton_Minus;
        private System.Windows.Forms.RadioButton Radiobutton_Mutiply;
        private System.Windows.Forms.RadioButton Radiobutton_Divide;
        private System.Windows.Forms.TextBox Second_Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Button Button_Count;
        private System.Windows.Forms.Button button1;
    }
}

