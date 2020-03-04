namespace StimulsoftRedirector
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
            this.SelectedServer = new System.Windows.Forms.ComboBox();
            this.Server = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintFormTypeList = new System.Windows.Forms.ComboBox();
            this.PrintFormGUID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectedServer
            // 
            this.SelectedServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedServer.FormattingEnabled = true;
            this.SelectedServer.Items.AddRange(new object[] {
            "Test",
            "Stage"});
            this.SelectedServer.Location = new System.Drawing.Point(12, 33);
            this.SelectedServer.Name = "SelectedServer";
            this.SelectedServer.Size = new System.Drawing.Size(121, 24);
            this.SelectedServer.TabIndex = 1;
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Location = new System.Drawing.Point(13, 13);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(48, 17);
            this.Server.TabIndex = 2;
            this.Server.Text = "Стенд";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ПФ";
            // 
            // PrintFormTypeList
            // 
            this.PrintFormTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrintFormTypeList.FormattingEnabled = true;
            this.PrintFormTypeList.Location = new System.Drawing.Point(12, 102);
            this.PrintFormTypeList.Name = "PrintFormTypeList";
            this.PrintFormTypeList.Size = new System.Drawing.Size(288, 24);
            this.PrintFormTypeList.TabIndex = 4;
            // 
            // PrintFormGUID
            // 
            this.PrintFormGUID.AutoSize = true;
            this.PrintFormGUID.Location = new System.Drawing.Point(13, 144);
            this.PrintFormGUID.Name = "PrintFormGUID";
            this.PrintFormGUID.Size = new System.Drawing.Size(80, 17);
            this.PrintFormGUID.TabIndex = 5;
            this.PrintFormGUID.Text = "PrintFormId";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrintFormGUID);
            this.Controls.Add(this.PrintFormTypeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.SelectedServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectedServer;
        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PrintFormTypeList;
        private System.Windows.Forms.Label PrintFormGUID;
    }
}

