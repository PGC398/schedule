namespace WindowsFormsApplication1
{
    partial class FormEdit
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.dtBeginTime = new System.Windows.Forms.DateTimePicker();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(708, 25);
            this.txtTitle.TabIndex = 0;
            // 
            // txtAdress
            // 
            this.txtAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdress.Location = new System.Drawing.Point(12, 55);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(708, 25);
            this.txtAdress.TabIndex = 1;
            // 
            // dtBeginTime
            // 
            this.dtBeginTime.Location = new System.Drawing.Point(12, 97);
            this.dtBeginTime.Name = "dtBeginTime";
            this.dtBeginTime.Size = new System.Drawing.Size(166, 25);
            this.dtBeginTime.TabIndex = 2;
            // 
            // dtEndTime
            // 
            this.dtEndTime.Location = new System.Drawing.Point(184, 97);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(166, 25);
            this.dtEndTime.TabIndex = 3;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(356, 99);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(146, 23);
            this.cboType.TabIndex = 4;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(619, 103);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(74, 19);
            this.cbStatus.TabIndex = 5;
            this.cbStatus.Text = "已完成";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 140);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(708, 257);
            this.txtContent.TabIndex = 6;
            this.txtContent.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(529, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(641, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 463);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.dtEndTime);
            this.Controls.Add(this.dtBeginTime);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtTitle);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.DateTimePicker dtBeginTime;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}