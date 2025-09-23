namespace Server
{
    partial class ServerFrm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
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
            this.cmTextBox_LOG.Location = new System.Drawing.Point(10, 11);
            this.cmTextBox_LOG.Multiline = true;
            this.cmTextBox_LOG.Name = "cmTextBox_LOG";
            this.cmTextBox_LOG.ReadOnly = true;
            this.cmTextBox_LOG.Size = new System.Drawing.Size(335, 336);
            this.cmTextBox_LOG.TabIndex = 0;
            this.cmTextBox_LOG.TextType = MateClass.CmEnums.TextType.Text;
            // 
            // cmTextBox_SEND
            // 
            this.cmTextBox_SEND.BackColor = System.Drawing.Color.White;
            this.cmTextBox_SEND.ConvertLang = false;
            this.cmTextBox_SEND.Location = new System.Drawing.Point(8, 359);
            this.cmTextBox_SEND.Multiline = true;
            this.cmTextBox_SEND.Name = "cmTextBox_SEND";
            this.cmTextBox_SEND.Size = new System.Drawing.Size(267, 91);
            this.cmTextBox_SEND.TabIndex = 1;
            this.cmTextBox_SEND.TextType = MateClass.CmEnums.TextType.Text;
            this.cmTextBox_SEND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmTextBox_SEND_KeyPress);
            // 
            // cmButton_SEND
            // 
            this.cmButton_SEND.BackColor = System.Drawing.Color.Gold;
            this.cmButton_SEND.ConvertLang = true;
            this.cmButton_SEND.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmButton_SEND.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmButton_SEND.Location = new System.Drawing.Point(285, 362);
            this.cmButton_SEND.Name = "cmButton_SEND";
            this.cmButton_SEND.Size = new System.Drawing.Size(59, 87);
            this.cmButton_SEND.TabIndex = 2;
            this.cmButton_SEND.Text = " 전송";
            this.cmButton_SEND.UseVisualStyleBackColor = false;
            this.cmButton_SEND.Click += new System.EventHandler(this.cmButton_SEND_Click);
            // 
            // ServerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 460);
            this.Controls.Add(this.cmButton_SEND);
            this.Controls.Add(this.cmTextBox_SEND);
            this.Controls.Add(this.cmTextBox_LOG);
            this.Name = "ServerFrm";
            this.Text = "대화방(Server)";
            this.Load += new System.EventHandler(this.ServerFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerFrm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MateControls.CmTextBox cmTextBox_LOG;
        private MateControls.CmTextBox cmTextBox_SEND;
        private MateControls.CmButton cmButton_SEND;
    }
}

