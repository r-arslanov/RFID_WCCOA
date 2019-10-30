namespace RFID_WCCOA
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectBtn = new System.Windows.Forms.Button();
            this.strtScnBtn = new System.Windows.Forms.Button();
            this.stpScnBtn = new System.Windows.Forms.Button();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(13, 13);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(154, 23);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // strtScnBtn
            // 
            this.strtScnBtn.Location = new System.Drawing.Point(184, 15);
            this.strtScnBtn.Name = "strtScnBtn";
            this.strtScnBtn.Size = new System.Drawing.Size(168, 21);
            this.strtScnBtn.TabIndex = 1;
            this.strtScnBtn.Text = "Start scan";
            this.strtScnBtn.UseVisualStyleBackColor = true;
            this.strtScnBtn.Click += new System.EventHandler(this.strtScnBtn_Click);
            // 
            // stpScnBtn
            // 
            this.stpScnBtn.Location = new System.Drawing.Point(184, 42);
            this.stpScnBtn.Name = "stpScnBtn";
            this.stpScnBtn.Size = new System.Drawing.Size(168, 21);
            this.stpScnBtn.TabIndex = 2;
            this.stpScnBtn.Text = "Stop scan";
            this.stpScnBtn.UseVisualStyleBackColor = true;
            this.stpScnBtn.Click += new System.EventHandler(this.stpScnBtn_Click);
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(12, 99);
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(337, 20);
            this.txtRead.TabIndex = 3;
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(11, 128);
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(337, 20);
            this.txtWrite.TabIndex = 4;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(360, 98);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(168, 21);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(360, 128);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(168, 21);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.stpScnBtn);
            this.Controls.Add(this.strtScnBtn);
            this.Controls.Add(this.connectBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button strtScnBtn;
        private System.Windows.Forms.Button stpScnBtn;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
    }
}

