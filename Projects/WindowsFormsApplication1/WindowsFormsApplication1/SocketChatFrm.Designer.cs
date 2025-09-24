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
            this.cmButton_SEND = new MateControls.CmButton();
            this.SuspendLayout();
            // 
            // cmTextBox_LOG
            // 
            this.cmTextBox_LOG.BackColor = System.Drawing.Color.White;
            this.cmTextBox_LOG.ConvertLang = false;
            this.cmTextBox_LOG.Location = new System.Drawing.Point(11, 11);
            this.cmTextBox_LOG.Multiline = true;
            this.cmTextBox_LOG.Name = "cmTextBox_LOG";
            this.cmTextBox_LOG.ReadOnly = true;
            this.cmTextBox_LOG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cmTextBox_LOG.Size = new System.Drawing.Size(303, 313);
            this.cmTextBox_LOG.TabIndex = 0;
            this.cmTextBox_LOG.TextType = MateClass.CmEnums.TextType.Text;
            // 
            // cmTextBox_SEND
            // 
            this.cmTextBox_SEND.BackColor = System.Drawing.Color.White;
            this.cmTextBox_SEND.ConvertLang = false;
            this.cmTextBox_SEND.Location = new System.Drawing.Point(11, 333);
            this.cmTextBox_SEND.Multiline = true;
            this.cmTextBox_SEND.Name = "cmTextBox_SEND";
            this.cmTextBox_SEND.Size = new System.Drawing.Size(234, 91);
            this.cmTextBox_SEND.TabIndex = 1;
            this.cmTextBox_SEND.TextType = MateClass.CmEnums.TextType.Text;
            this.cmTextBox_SEND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmTextBox_SEND_KeyPress);
            // 
            // cmButton_SEND
            // 
            this.cmButton_SEND.BackColor = System.Drawing.Color.Gold;
            this.cmButton_SEND.ConvertLang = true;
            this.cmButton_SEND.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmButton_SEND.Location = new System.Drawing.Point(250, 333);
            this.cmButton_SEND.Name = "cmButton_SEND";
            this.cmButton_SEND.Size = new System.Drawing.Size(64, 91);
            this.cmButton_SEND.TabIndex = 2;
            this.cmButton_SEND.Text = "전송";
            this.cmButton_SEND.UseVisualStyleBackColor = false;
            this.cmButton_SEND.Click += new System.EventHandler(this.cmButton_SEND_Click);
            // 
            // SocketChatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 436);
            this.Controls.Add(this.cmButton_SEND);
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
        private MateControls.CmButton cmButton_SEND;

    }
}