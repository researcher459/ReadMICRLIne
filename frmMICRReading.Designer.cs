namespace MICR
{
    partial class frmMICRReading
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
             this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMICR = new System.Windows.Forms.DataGridView();
            this.BRN_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INST_nO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOC_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REF_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadMicr = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMICR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMICR);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 304);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MICR RESULT OUTPUT";
            // 
            // dgvMICR
            // 
            this.dgvMICR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMICR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BRN_CODE,
            this.INST_nO,
            this.ACCOUNT_NO,
            this.DOC_TYPE,
            this.REF_ID});
            this.dgvMICR.Location = new System.Drawing.Point(6, 21);
            this.dgvMICR.Name = "dgvMICR";
            this.dgvMICR.Size = new System.Drawing.Size(741, 272);
            this.dgvMICR.TabIndex = 1;
            // 
            // BRN_CODE
            // 
            this.BRN_CODE.HeaderText = "BRANCH CODE";
            this.BRN_CODE.Name = "BRN_CODE";
            this.BRN_CODE.ReadOnly = true;
            // 
            // INST_nO
            // 
            this.INST_nO.HeaderText = "INST NO";
            this.INST_nO.Name = "INST_nO";
            this.INST_nO.ReadOnly = true;
            this.INST_nO.Width = 120;
            // 
            // ACCOUNT_NO
            // 
            this.ACCOUNT_NO.HeaderText = "ACCOUNT NO";
            this.ACCOUNT_NO.Name = "ACCOUNT_NO";
            this.ACCOUNT_NO.ReadOnly = true;
            this.ACCOUNT_NO.Width = 200;
            // 
            // DOC_TYPE
            // 
            this.DOC_TYPE.HeaderText = "DOC_TYPE";
            this.DOC_TYPE.Name = "DOC_TYPE";
            this.DOC_TYPE.ReadOnly = true;
            // 
            // REF_ID
            // 
            this.REF_ID.HeaderText = "REFERENCE ID";
            this.REF_ID.Name = "REF_ID";
            this.REF_ID.ReadOnly = true;
            this.REF_ID.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnReadMicr);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHOOSE FILES PATH";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(361, 59);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(103, 40);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(22, 59);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(318, 27);
            this.txtPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHOOSE PATH :";
            // 
            // btnReadMicr
            // 
            this.btnReadMicr.Location = new System.Drawing.Point(524, 32);
            this.btnReadMicr.Name = "btnReadMicr";
            this.btnReadMicr.Size = new System.Drawing.Size(148, 77);
            this.btnReadMicr.TabIndex = 1;
            this.btnReadMicr.Text = "READ MAGNETIC INK CHARACTER RECOGNIZATION";
            this.btnReadMicr.UseVisualStyleBackColor = true;
            this.btnReadMicr.Click += new System.EventHandler(this.btnReadMicr_Click);
            // 
            // frmMICRReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmMICRReading";
            this.Text = "MICRReading";
            this.Load += new System.EventHandler(this.MICRReading_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMICR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMICR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRN_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INST_nO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOC_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF_ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadMicr;
        }

}
