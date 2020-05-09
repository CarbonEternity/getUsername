namespace GetUserNameEx
{
    partial class WinAPIClass
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
            this.lblGetUserName = new System.Windows.Forms.Label();
            this.btnGetUserName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGetUserName
            // 
            this.lblGetUserName.Location = new System.Drawing.Point(168, 20);
            this.lblGetUserName.Name = "lblGetUserName";
            this.lblGetUserName.Size = new System.Drawing.Size(368, 23);
            this.lblGetUserName.TabIndex = 0;
            // 
            // btnGetUserName
            // 
            this.btnGetUserName.Location = new System.Drawing.Point(16, 20);
            this.btnGetUserName.Name = "btnGetUserName";
            this.btnGetUserName.Size = new System.Drawing.Size(75, 23);
            this.btnGetUserName.TabIndex = 1;
            this.btnGetUserName.Text = "Получить!";
            this.btnGetUserName.UseVisualStyleBackColor = true;
            this.btnGetUserName.Click += new System.EventHandler(this.btnGetUserName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 57);
            this.Controls.Add(this.btnGetUserName);
            this.Controls.Add(this.lblGetUserName);
            this.Name = "Form1";
            this.Text = "Получение имени пользователя";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGetUserName;
        private System.Windows.Forms.Button btnGetUserName;
    }
}

