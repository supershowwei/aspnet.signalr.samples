namespace AspNetSignalRWindowsClient
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.MessagesBlock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(77, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(152, 25);
            this.NameTextBox.TabIndex = 0;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(77, 43);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(152, 25);
            this.MessageTextBox.TabIndex = 1;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(131, 74);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(98, 34);
            this.SendMessageButton.TabIndex = 2;
            this.SendMessageButton.Text = "向大家問好";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // MessagesBlock
            // 
            this.MessagesBlock.Location = new System.Drawing.Point(15, 114);
            this.MessagesBlock.Multiline = true;
            this.MessagesBlock.Name = "MessagesBlock";
            this.MessagesBlock.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MessagesBlock.Size = new System.Drawing.Size(547, 375);
            this.MessagesBlock.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessagesBlock);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.TextBox MessagesBlock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

