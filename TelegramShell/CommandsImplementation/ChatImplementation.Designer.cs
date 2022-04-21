
namespace TelegramShell.CommandsImplementation
{
    partial class ChatImplementation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendMessage = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.messageWindow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // sendMessage
            // 
            this.sendMessage.Location = new System.Drawing.Point(292, 309);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(141, 23);
            this.sendMessage.TabIndex = 6;
            this.sendMessage.Text = "Enviar Mensaje";
            this.sendMessage.UseVisualStyleBackColor = true;
            this.sendMessage.Click += new System.EventHandler(this.sendMessage_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 280);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(421, 23);
            this.messageBox.TabIndex = 7;
            // 
            // messageWindow
            // 
            this.messageWindow.Location = new System.Drawing.Point(12, 12);
            this.messageWindow.Name = "messageWindow";
            this.messageWindow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.messageWindow.Size = new System.Drawing.Size(421, 262);
            this.messageWindow.TabIndex = 8;
            this.messageWindow.Text = "";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 346);
            this.Controls.Add(this.messageWindow);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.sendMessage);
            this.Name = "ChatImplementation";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chat_FormClosing);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sendMessage;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.RichTextBox messageWindow;
    }
}