﻿namespace Belfer
{
    partial class frmKontrolaNieobecnosci
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
            this.components = new System.ComponentModel.Container();
            this.nudAbsencja = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tlvStudent = new BrightIdeasSoftware.TreeListView();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.pbrStudent = new System.Windows.Forms.ProgressBar();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKlasa = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.pbrKlasa = new System.Windows.Forms.ProgressBar();
            this.txtSeek = new System.Windows.Forms.TextBox();
            this.cbSeek = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbsencja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlvStudent)).BeginInit();
            this.pnlProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudAbsencja
            // 
            this.nudAbsencja.Location = new System.Drawing.Point(296, 12);
            this.nudAbsencja.Name = "nudAbsencja";
            this.nudAbsencja.Size = new System.Drawing.Size(46, 20);
            this.nudAbsencja.TabIndex = 0;
            this.nudAbsencja.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Absencja (%) >=";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd  MMMM  yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(48, 12);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(153, 20);
            this.dtpData.TabIndex = 4;
            this.dtpData.Value = new System.DateTime(2017, 10, 16, 17, 16, 0, 0);
            this.dtpData.CloseUp += new System.EventHandler(this.dtpData_CloseUp);
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data";
            // 
            // tlvStudent
            // 
            this.tlvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlvStudent.CellEditUseWholeCell = false;
            this.tlvStudent.Location = new System.Drawing.Point(12, 38);
            this.tlvStudent.Name = "tlvStudent";
            this.tlvStudent.ShowGroups = false;
            this.tlvStudent.Size = new System.Drawing.Size(717, 397);
            this.tlvStudent.TabIndex = 6;
            this.tlvStudent.UseCompatibleStateImageBehavior = false;
            this.tlvStudent.View = System.Windows.Forms.View.Details;
            this.tlvStudent.VirtualMode = true;
            this.tlvStudent.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.tlvStudent_ItemSelectionChanged);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRefresh.Image = global::Belfer.Properties.Resources.refresh_24;
			this.cmdRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdRefresh.Location = new System.Drawing.Point(735, 38);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(93, 36);
            this.cmdRefresh.TabIndex = 248;
            this.cmdRefresh.Text = "Odśwież";
            this.cmdRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdPrint.Image = global::Belfer.Properties.Resources.print_24;
			this.cmdPrint.Location = new System.Drawing.Point(735, 80);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(93, 35);
            this.cmdPrint.TabIndex = 247;
            this.cmdPrint.Text = "&Drukuj ...";
            this.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdClose.Image = global::Belfer.Properties.Resources.close_22;
			this.cmdClose.Location = new System.Drawing.Point(735, 400);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(93, 35);
            this.cmdClose.TabIndex = 249;
            this.cmdClose.Text = "&Zamknij";
            this.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // Label8
            // 
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(12, 445);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(45, 13);
            this.Label8.TabIndex = 250;
            this.Label8.Text = "Rekord:";
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRecord.ForeColor = System.Drawing.Color.Red;
            this.lblRecord.Location = new System.Drawing.Point(60, 445);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(14, 13);
            this.lblRecord.TabIndex = 251;
            this.lblRecord.Text = "0";
            // 
            // pbrStudent
            // 
            this.pbrStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbrStudent.Location = new System.Drawing.Point(213, 3);
            this.pbrStudent.Maximum = 422;
            this.pbrStudent.Name = "pbrStudent";
            this.pbrStudent.Size = new System.Drawing.Size(120, 20);
            this.pbrStudent.Step = 1;
            this.pbrStudent.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbrStudent.TabIndex = 253;
            // 
            // pnlProgress
            // 
            this.pnlProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlProgress.Controls.Add(this.label4);
            this.pnlProgress.Controls.Add(this.label3);
            this.pnlProgress.Controls.Add(this.lblKlasa);
            this.pnlProgress.Controls.Add(this.lblStudent);
            this.pnlProgress.Controls.Add(this.pbrKlasa);
            this.pnlProgress.Controls.Add(this.pbrStudent);
            this.pnlProgress.Location = new System.Drawing.Point(117, 438);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(339, 26);
            this.pnlProgress.TabIndex = 254;
            this.pnlProgress.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 258;
            this.label4.Text = "Uczeń";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 257;
            this.label3.Text = "Klasa";
            // 
            // lblKlasa
            // 
            this.lblKlasa.AutoSize = true;
            this.lblKlasa.BackColor = System.Drawing.Color.Transparent;
            this.lblKlasa.Location = new System.Drawing.Point(91, 7);
            this.lblKlasa.Name = "lblKlasa";
            this.lblKlasa.Size = new System.Drawing.Size(24, 13);
            this.lblKlasa.TabIndex = 256;
            this.lblKlasa.Text = "0/0";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblStudent.Location = new System.Drawing.Point(264, 7);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(24, 13);
            this.lblStudent.TabIndex = 255;
            this.lblStudent.Text = "0/0";
            // 
            // pbrKlasa
            // 
            this.pbrKlasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbrKlasa.Location = new System.Drawing.Point(43, 3);
            this.pbrKlasa.Maximum = 422;
            this.pbrKlasa.Name = "pbrKlasa";
            this.pbrKlasa.Size = new System.Drawing.Size(120, 20);
            this.pbrKlasa.Step = 1;
            this.pbrKlasa.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbrKlasa.TabIndex = 254;
            // 
            // txtSeek
            // 
            this.txtSeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeek.Location = new System.Drawing.Point(589, 442);
            this.txtSeek.Name = "txtSeek";
            this.txtSeek.Size = new System.Drawing.Size(140, 20);
            this.txtSeek.TabIndex = 255;
            this.txtSeek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeek_KeyPress);
            // 
            // cbSeek
            // 
            this.cbSeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeek.DropDownWidth = 100;
            this.cbSeek.FormattingEnabled = true;
            this.cbSeek.Location = new System.Drawing.Point(516, 442);
            this.cbSeek.Name = "cbSeek";
            this.cbSeek.Size = new System.Drawing.Size(67, 21);
            this.cbSeek.TabIndex = 257;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 258;
            this.label5.Text = "Filtruj wg";
            // 
            // frmKontrolaNieobecnosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 467);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSeek);
            this.Controls.Add(this.txtSeek);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.tlvStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudAbsencja);
            this.Name = "frmKontrolaNieobecnosci";
            this.Text = "Kontrola nieobecności uczniów";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKontrolaNieobecnosci_FormClosed);
            this.Shown += new System.EventHandler(this.frmKontrolaNieobecnosci_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudAbsencja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlvStudent)).EndInit();
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAbsencja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label2;
        private BrightIdeasSoftware.TreeListView tlvStudent;
        internal System.Windows.Forms.Button cmdRefresh;
        internal System.Windows.Forms.Button cmdPrint;
        internal System.Windows.Forms.Button cmdClose;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label lblRecord;
        internal System.Windows.Forms.ProgressBar pbrStudent;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Label lblKlasa;
        private System.Windows.Forms.Label lblStudent;
        internal System.Windows.Forms.ProgressBar pbrKlasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtSeek;
        internal System.Windows.Forms.ComboBox cbSeek;
        private System.Windows.Forms.Label label5;
    }
}