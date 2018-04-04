namespace MockServer
{
    partial class frmEditMock
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cboResponseStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboContentType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResponseBody = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResponseDelay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkResponseDelay = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboVerb = new System.Windows.Forms.ComboBox();
            this.txtContentEncoding = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(118, 89);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(379, 20);
            this.txtPath.TabIndex = 1;
            // 
            // cboResponseStatus
            // 
            this.cboResponseStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResponseStatus.FormattingEnabled = true;
            this.cboResponseStatus.Location = new System.Drawing.Point(118, 115);
            this.cboResponseStatus.Name = "cboResponseStatus";
            this.cboResponseStatus.Size = new System.Drawing.Size(190, 21);
            this.cboResponseStatus.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Response status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Content-Type";
            // 
            // cboContentType
            // 
            this.cboContentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContentType.FormattingEnabled = true;
            this.cboContentType.Location = new System.Drawing.Point(118, 169);
            this.cboContentType.Name = "cboContentType";
            this.cboContentType.Size = new System.Drawing.Size(190, 21);
            this.cboContentType.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Content-Encoding";
            // 
            // txtResponseBody
            // 
            this.txtResponseBody.Location = new System.Drawing.Point(118, 223);
            this.txtResponseBody.Multiline = true;
            this.txtResponseBody.Name = "txtResponseBody";
            this.txtResponseBody.Size = new System.Drawing.Size(379, 97);
            this.txtResponseBody.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Response body";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(118, 37);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(379, 20);
            this.txtDisplayName.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Display name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(118, 63);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(379, 20);
            this.txtDescription.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Description";
            // 
            // txtResponseDelay
            // 
            this.txtResponseDelay.Enabled = false;
            this.txtResponseDelay.Location = new System.Drawing.Point(139, 324);
            this.txtResponseDelay.Name = "txtResponseDelay";
            this.txtResponseDelay.Size = new System.Drawing.Size(50, 20);
            this.txtResponseDelay.TabIndex = 23;
            this.txtResponseDelay.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Response delay";
            // 
            // chkResponseDelay
            // 
            this.chkResponseDelay.AutoSize = true;
            this.chkResponseDelay.Location = new System.Drawing.Point(118, 327);
            this.chkResponseDelay.Name = "chkResponseDelay";
            this.chkResponseDelay.Size = new System.Drawing.Size(15, 14);
            this.chkResponseDelay.TabIndex = 24;
            this.chkResponseDelay.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "in seconds";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(508, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(508, 53);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Verb";
            // 
            // cboVerb
            // 
            this.cboVerb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVerb.FormattingEnabled = true;
            this.cboVerb.Location = new System.Drawing.Point(118, 142);
            this.cboVerb.Name = "cboVerb";
            this.cboVerb.Size = new System.Drawing.Size(190, 21);
            this.cboVerb.TabIndex = 28;
            // 
            // txtContentEncoding
            // 
            this.txtContentEncoding.Location = new System.Drawing.Point(118, 196);
            this.txtContentEncoding.Name = "txtContentEncoding";
            this.txtContentEncoding.Size = new System.Drawing.Size(190, 20);
            this.txtContentEncoding.TabIndex = 30;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(441, 198);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 31;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // frmEditMock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 360);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtContentEncoding);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboVerb);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkResponseDelay);
            this.Controls.Add(this.txtResponseDelay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtResponseBody);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboContentType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboResponseStatus);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(614, 399);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(614, 399);
            this.Name = "frmEditMock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mock Details";
            this.Load += new System.EventHandler(this.frmEditMock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ComboBox cboResponseStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboContentType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResponseBody;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResponseDelay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkResponseDelay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboVerb;
        private System.Windows.Forms.TextBox txtContentEncoding;
        private System.Windows.Forms.CheckBox chkActive;
    }
}