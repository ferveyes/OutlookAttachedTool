﻿namespace OutlookAttachedTool.SubWindow
{
	partial class AttachedCompressSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttachedCompressSetting));
            this.la_extension = new System.Windows.Forms.Label();
            this.tb_FileName = new System.Windows.Forms.TextBox();
            this.clist_files = new System.Windows.Forms.CheckedListBox();
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.cb_Pass = new System.Windows.Forms.CheckBox();
            this.tb_PassText = new System.Windows.Forms.TextBox();
            this.pict_extension = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pict_extension)).BeginInit();
            this.SuspendLayout();
            // 
            // la_extension
            // 
            this.la_extension.AutoSize = true;
            this.la_extension.Location = new System.Drawing.Point(348, 28);
            this.la_extension.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.la_extension.Name = "la_extension";
            this.la_extension.Size = new System.Drawing.Size(33, 18);
            this.la_extension.TabIndex = 6;
            this.la_extension.Text = ".zip";
            // 
            // tb_FileName
            // 
            this.tb_FileName.Location = new System.Drawing.Point(70, 18);
            this.tb_FileName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_FileName.Name = "tb_FileName";
            this.tb_FileName.Size = new System.Drawing.Size(272, 25);
            this.tb_FileName.TabIndex = 5;
            // 
            // clist_files
            // 
            this.clist_files.CheckOnClick = true;
            this.clist_files.FormattingEnabled = true;
            this.clist_files.Location = new System.Drawing.Point(12, 62);
            this.clist_files.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.clist_files.Name = "clist_files";
            this.clist_files.Size = new System.Drawing.Size(369, 164);
            this.clist_files.TabIndex = 8;
            this.clist_files.SelectedIndexChanged += new System.EventHandler(this.clist_files_SelectedIndexChanged);
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(123, 285);
            this.bt_OK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(125, 34);
            this.bt_OK.TabIndex = 10;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(258, 285);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(125, 34);
            this.bt_Cancel.TabIndex = 9;
            this.bt_Cancel.Text = "キャンセル";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // cb_Pass
            // 
            this.cb_Pass.AutoSize = true;
            this.cb_Pass.Checked = true;
            this.cb_Pass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Pass.Location = new System.Drawing.Point(12, 244);
            this.cb_Pass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cb_Pass.Name = "cb_Pass";
            this.cb_Pass.Size = new System.Drawing.Size(114, 22);
            this.cb_Pass.TabIndex = 11;
            this.cb_Pass.Text = "パスワード：";
            this.cb_Pass.UseVisualStyleBackColor = true;
            this.cb_Pass.CheckedChanged += new System.EventHandler(this.cb_Pass_CheckedChanged);
            // 
            // tb_PassText
            // 
            this.tb_PassText.Location = new System.Drawing.Point(137, 242);
            this.tb_PassText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_PassText.Name = "tb_PassText";
            this.tb_PassText.Size = new System.Drawing.Size(244, 25);
            this.tb_PassText.TabIndex = 12;
            // 
            // pict_extension
            // 
            this.pict_extension.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pict_extension.Location = new System.Drawing.Point(12, 9);
            this.pict_extension.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pict_extension.Name = "pict_extension";
            this.pict_extension.Size = new System.Drawing.Size(48, 44);
            this.pict_extension.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict_extension.TabIndex = 7;
            this.pict_extension.TabStop = false;
            // 
            // AttachedCompressSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 338);
            this.Controls.Add(this.tb_PassText);
            this.Controls.Add(this.cb_Pass);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.clist_files);
            this.Controls.Add(this.pict_extension);
            this.Controls.Add(this.la_extension);
            this.Controls.Add(this.tb_FileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AttachedCompressSetting";
            this.Text = "圧縮設定";
            this.Load += new System.EventHandler(this.AttachedCompressSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pict_extension)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pict_extension;
		private System.Windows.Forms.Label la_extension;
		private System.Windows.Forms.TextBox tb_FileName;
		private System.Windows.Forms.CheckedListBox clist_files;
		private System.Windows.Forms.Button bt_OK;
		private System.Windows.Forms.Button bt_Cancel;
		private System.Windows.Forms.CheckBox cb_Pass;
		private System.Windows.Forms.TextBox tb_PassText;
	}
}