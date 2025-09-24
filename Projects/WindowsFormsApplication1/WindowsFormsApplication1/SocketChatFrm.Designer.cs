namespace SocketChat
{
    partial class SocketChatFrm
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
            this.cmTextBox_LOG = new MateControls.CmTextBox();
            this.cmTextBox_SEND = new MateControls.CmTextBox();
            this.SuspendLayout();
            // 
            // cmTextBox_LOG
            // 
            this.cmTextBox_LOG.BackColor = System.Drawing.Color.Black;
            this.cmTextBox_LOG.ConvertLang = false;
            this.cmTextBox_LOG.ForeColor = System.Drawing.SystemColors.Menu;
            this.cmTextBox_LOG.Location = new System.Drawing.Point(12, 11);
            this.cmTextBox_LOG.Multiline = true;
            this.cmTextBox_LOG.Name = "cmTextBox_LOG";
            this.cmTextBox_LOG.ReadOnly = true;
            this.cmTextBox_LOG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cmTextBox_LOG.Size = new System.Drawing.Size(303, 147);
            this.cmTextBox_LOG.TabIndex = 0;
            this.cmTextBox_LOG.TextType = MateClass.CmEnums.TextType.Text;
            // 
            // cmTextBox_SEND
            // 
            this.cmTextBox_SEND.BackColor = System.Drawing.Color.Black;
            this.cmTextBox_SEND.ConvertLang = false;
            this.cmTextBox_SEND.ForeColor = System.Drawing.SystemColors.Menu;
            this.cmTextBox_SEND.Location = new System.Drawing.Point(11, 164);
            this.cmTextBox_SEND.Multiline = true;
            this.cmTextBox_SEND.Name = "cmTextBox_SEND";
            this.cmTextBox_SEND.Size = new System.Drawing.Size(301, 54);
            this.cmTextBox_SEND.TabIndex = 1;
            this.cmTextBox_SEND.TextType = MateClass.CmEnums.TextType.Text;
            this.cmTextBox_SEND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmTextBox_SEND_KeyPress);
            // 
            // SocketChatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(324, 227);
            this.Controls.Add(this.cmTextBox_SEND);
            this.Controls.Add(this.cmTextBox_LOG);
            this.Name = "SocketChatFrm";
            this.Text = "대화방(Client)";
            this.Load += new System.EventHandler(this.SocketChatFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SocketChatFrm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MateControls.CmTextBox cmTextBox_LOG;
        private MateControls.CmTextBox cmTextBox_SEND;

    }
}