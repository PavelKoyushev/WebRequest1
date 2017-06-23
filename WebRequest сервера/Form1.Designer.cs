namespace WebRequest_сервера
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txb_url = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_sourceCode = new System.Windows.Forms.TextBox();
            this.txb_serverInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL-adress";
            // 
            // txb_url
            // 
            this.txb_url.Location = new System.Drawing.Point(90, 6);
            this.txb_url.Name = "txb_url";
            this.txb_url.Size = new System.Drawing.Size(200, 20);
            this.txb_url.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Получить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_sourceCode
            // 
            this.txb_sourceCode.Location = new System.Drawing.Point(33, 61);
            this.txb_sourceCode.Multiline = true;
            this.txb_sourceCode.Name = "txb_sourceCode";
            this.txb_sourceCode.Size = new System.Drawing.Size(385, 192);
            this.txb_sourceCode.TabIndex = 3;
            // 
            // txb_serverInfo
            // 
            this.txb_serverInfo.Location = new System.Drawing.Point(33, 270);
            this.txb_serverInfo.Multiline = true;
            this.txb_serverInfo.Name = "txb_serverInfo";
            this.txb_serverInfo.Size = new System.Drawing.Size(385, 203);
            this.txb_serverInfo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "c http";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_serverInfo);
            this.Controls.Add(this.txb_sourceCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_url);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_url;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_sourceCode;
        private System.Windows.Forms.TextBox txb_serverInfo;
        private System.Windows.Forms.Label label2;
    }
}

