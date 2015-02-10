﻿namespace lxzh
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnScan = new System.Windows.Forms.Button();
            this.fbdSelectDir = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.gbShortCutKey = new System.Windows.Forms.GroupBox();
            this.cbbKeys5 = new lxzh.LComboBox();
            this.chkWin5 = new lxzh.LCheckBox();
            this.chkAlt5 = new lxzh.LCheckBox();
            this.chkShift5 = new lxzh.LCheckBox();
            this.chkCtrl5 = new lxzh.LCheckBox();
            this.lxzhTipLabel1 = new lxzh.LxzhTipLabel();
            this.cbbKeys4 = new lxzh.LComboBox();
            this.chkWin4 = new lxzh.LCheckBox();
            this.chkAlt4 = new lxzh.LCheckBox();
            this.chkShift4 = new lxzh.LCheckBox();
            this.chkCtrl4 = new lxzh.LCheckBox();
            this.lbl4 = new lxzh.LxzhTipLabel();
            this.cbbKeys3 = new lxzh.LComboBox();
            this.chkWin3 = new lxzh.LCheckBox();
            this.chkAlt3 = new lxzh.LCheckBox();
            this.chkShift3 = new lxzh.LCheckBox();
            this.chkCtrl3 = new lxzh.LCheckBox();
            this.lbl3 = new lxzh.LxzhTipLabel();
            this.cbbKeys2 = new lxzh.LComboBox();
            this.chkWin2 = new lxzh.LCheckBox();
            this.chkAlt2 = new lxzh.LCheckBox();
            this.chkShift2 = new lxzh.LCheckBox();
            this.chkCtrl2 = new lxzh.LCheckBox();
            this.lbl2 = new lxzh.LxzhTipLabel();
            this.lbl1 = new lxzh.LxzhTipLabel();
            this.cbbKeys1 = new lxzh.LComboBox();
            this.chkWin1 = new lxzh.LCheckBox();
            this.chkAlt1 = new lxzh.LCheckBox();
            this.chkShift1 = new lxzh.LCheckBox();
            this.chkCtrl1 = new lxzh.LCheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.lblExtension = new System.Windows.Forms.Label();
            this.cmsSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.niSetting = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbbExtension = new lxzh.LComboBox();
            this.txtSavePath = new lxzh.LTextBox();
            this.chkSPO = new lxzh.LCheckBox();
            this.gbShortCutKey.SuspendLayout();
            this.cmsSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScan.Location = new System.Drawing.Point(210, 30);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(69, 25);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "浏览...";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Location = new System.Drawing.Point(12, 9);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(97, 15);
            this.lblSavePath.TabIndex = 0;
            this.lblSavePath.Text = "截图保存目录";
            // 
            // gbShortCutKey
            // 
            this.gbShortCutKey.Controls.Add(this.cbbKeys5);
            this.gbShortCutKey.Controls.Add(this.chkWin5);
            this.gbShortCutKey.Controls.Add(this.chkAlt5);
            this.gbShortCutKey.Controls.Add(this.chkShift5);
            this.gbShortCutKey.Controls.Add(this.chkCtrl5);
            this.gbShortCutKey.Controls.Add(this.lxzhTipLabel1);
            this.gbShortCutKey.Controls.Add(this.cbbKeys4);
            this.gbShortCutKey.Controls.Add(this.chkWin4);
            this.gbShortCutKey.Controls.Add(this.chkAlt4);
            this.gbShortCutKey.Controls.Add(this.chkShift4);
            this.gbShortCutKey.Controls.Add(this.chkCtrl4);
            this.gbShortCutKey.Controls.Add(this.lbl4);
            this.gbShortCutKey.Controls.Add(this.cbbKeys3);
            this.gbShortCutKey.Controls.Add(this.chkWin3);
            this.gbShortCutKey.Controls.Add(this.chkAlt3);
            this.gbShortCutKey.Controls.Add(this.chkShift3);
            this.gbShortCutKey.Controls.Add(this.chkCtrl3);
            this.gbShortCutKey.Controls.Add(this.lbl3);
            this.gbShortCutKey.Controls.Add(this.cbbKeys2);
            this.gbShortCutKey.Controls.Add(this.chkWin2);
            this.gbShortCutKey.Controls.Add(this.chkAlt2);
            this.gbShortCutKey.Controls.Add(this.chkShift2);
            this.gbShortCutKey.Controls.Add(this.chkCtrl2);
            this.gbShortCutKey.Controls.Add(this.lbl2);
            this.gbShortCutKey.Controls.Add(this.lbl1);
            this.gbShortCutKey.Controls.Add(this.cbbKeys1);
            this.gbShortCutKey.Controls.Add(this.chkWin1);
            this.gbShortCutKey.Controls.Add(this.chkAlt1);
            this.gbShortCutKey.Controls.Add(this.chkShift1);
            this.gbShortCutKey.Controls.Add(this.chkCtrl1);
            this.gbShortCutKey.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbShortCutKey.Location = new System.Drawing.Point(12, 83);
            this.gbShortCutKey.Name = "gbShortCutKey";
            this.gbShortCutKey.Size = new System.Drawing.Size(568, 217);
            this.gbShortCutKey.TabIndex = 4;
            this.gbShortCutKey.TabStop = false;
            this.gbShortCutKey.Text = "截图快捷键设置";
            // 
            // cbbKeys5
            // 
            this.cbbKeys5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbKeys5.FormattingEnabled = true;
            this.cbbKeys5.Location = new System.Drawing.Point(451, 187);
            this.cbbKeys5.Name = "cbbKeys5";
            this.cbbKeys5.OriIndex = 0;
            this.cbbKeys5.Size = new System.Drawing.Size(107, 23);
            this.cbbKeys5.TabIndex = 29;
            // 
            // chkWin5
            // 
            this.chkWin5.AutoSize = true;
            this.chkWin5.Location = new System.Drawing.Point(375, 189);
            this.chkWin5.Name = "chkWin5";
            this.chkWin5.OriState = false;
            this.chkWin5.Size = new System.Drawing.Size(53, 19);
            this.chkWin5.TabIndex = 28;
            this.chkWin5.Text = "Win";
            this.chkWin5.UseVisualStyleBackColor = true;
            // 
            // chkAlt5
            // 
            this.chkAlt5.AutoSize = true;
            this.chkAlt5.Location = new System.Drawing.Point(299, 189);
            this.chkAlt5.Name = "chkAlt5";
            this.chkAlt5.OriState = false;
            this.chkAlt5.Size = new System.Drawing.Size(53, 19);
            this.chkAlt5.TabIndex = 27;
            this.chkAlt5.Text = "Alt";
            this.chkAlt5.UseVisualStyleBackColor = true;
            // 
            // chkShift5
            // 
            this.chkShift5.AutoSize = true;
            this.chkShift5.Checked = true;
            this.chkShift5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShift5.Location = new System.Drawing.Point(207, 189);
            this.chkShift5.Name = "chkShift5";
            this.chkShift5.OriState = false;
            this.chkShift5.Size = new System.Drawing.Size(69, 19);
            this.chkShift5.TabIndex = 26;
            this.chkShift5.Text = "Shift";
            this.chkShift5.UseVisualStyleBackColor = true;
            // 
            // chkCtrl5
            // 
            this.chkCtrl5.AutoSize = true;
            this.chkCtrl5.Checked = true;
            this.chkCtrl5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCtrl5.Location = new System.Drawing.Point(123, 189);
            this.chkCtrl5.Name = "chkCtrl5";
            this.chkCtrl5.OriState = false;
            this.chkCtrl5.Size = new System.Drawing.Size(61, 19);
            this.chkCtrl5.TabIndex = 25;
            this.chkCtrl5.Text = "Ctrl";
            this.chkCtrl5.UseVisualStyleBackColor = true;
            // 
            // lxzhTipLabel1
            // 
            this.lxzhTipLabel1.AutoSize = true;
            this.lxzhTipLabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lxzhTipLabel1.Location = new System.Drawing.Point(10, 191);
            this.lxzhTipLabel1.Name = "lxzhTipLabel1";
            this.lxzhTipLabel1.Size = new System.Drawing.Size(82, 15);
            this.lxzhTipLabel1.TabIndex = 0;
            this.lxzhTipLabel1.Text = "剪切板截图";
            this.lxzhTipLabel1.TipInfo = "从剪切板截图";
            // 
            // cbbKeys4
            // 
            this.cbbKeys4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbKeys4.FormattingEnabled = true;
            this.cbbKeys4.Location = new System.Drawing.Point(452, 147);
            this.cbbKeys4.Name = "cbbKeys4";
            this.cbbKeys4.OriIndex = 0;
            this.cbbKeys4.Size = new System.Drawing.Size(107, 23);
            this.cbbKeys4.TabIndex = 24;
            // 
            // chkWin4
            // 
            this.chkWin4.AutoSize = true;
            this.chkWin4.Location = new System.Drawing.Point(376, 149);
            this.chkWin4.Name = "chkWin4";
            this.chkWin4.OriState = false;
            this.chkWin4.Size = new System.Drawing.Size(53, 19);
            this.chkWin4.TabIndex = 23;
            this.chkWin4.Text = "Win";
            this.chkWin4.UseVisualStyleBackColor = true;
            // 
            // chkAlt4
            // 
            this.chkAlt4.AutoSize = true;
            this.chkAlt4.Checked = true;
            this.chkAlt4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlt4.Location = new System.Drawing.Point(300, 149);
            this.chkAlt4.Name = "chkAlt4";
            this.chkAlt4.OriState = false;
            this.chkAlt4.Size = new System.Drawing.Size(53, 19);
            this.chkAlt4.TabIndex = 22;
            this.chkAlt4.Text = "Alt";
            this.chkAlt4.UseVisualStyleBackColor = true;
            // 
            // chkShift4
            // 
            this.chkShift4.AutoSize = true;
            this.chkShift4.Location = new System.Drawing.Point(208, 149);
            this.chkShift4.Name = "chkShift4";
            this.chkShift4.OriState = false;
            this.chkShift4.Size = new System.Drawing.Size(69, 19);
            this.chkShift4.TabIndex = 21;
            this.chkShift4.Text = "Shift";
            this.chkShift4.UseVisualStyleBackColor = true;
            // 
            // chkCtrl4
            // 
            this.chkCtrl4.AutoSize = true;
            this.chkCtrl4.Checked = true;
            this.chkCtrl4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCtrl4.Location = new System.Drawing.Point(124, 149);
            this.chkCtrl4.Name = "chkCtrl4";
            this.chkCtrl4.OriState = false;
            this.chkCtrl4.Size = new System.Drawing.Size(61, 19);
            this.chkCtrl4.TabIndex = 20;
            this.chkCtrl4.Text = "Ctrl";
            this.chkCtrl4.UseVisualStyleBackColor = true;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl4.Location = new System.Drawing.Point(11, 151);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(67, 15);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "重复上次";
            this.lbl4.TipInfo = "重复上次位置截图";
            // 
            // cbbKeys3
            // 
            this.cbbKeys3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbKeys3.FormattingEnabled = true;
            this.cbbKeys3.Location = new System.Drawing.Point(452, 107);
            this.cbbKeys3.Name = "cbbKeys3";
            this.cbbKeys3.OriIndex = 0;
            this.cbbKeys3.Size = new System.Drawing.Size(107, 23);
            this.cbbKeys3.TabIndex = 19;
            // 
            // chkWin3
            // 
            this.chkWin3.AutoSize = true;
            this.chkWin3.Location = new System.Drawing.Point(376, 109);
            this.chkWin3.Name = "chkWin3";
            this.chkWin3.OriState = false;
            this.chkWin3.Size = new System.Drawing.Size(53, 19);
            this.chkWin3.TabIndex = 18;
            this.chkWin3.Text = "Win";
            this.chkWin3.UseVisualStyleBackColor = true;
            // 
            // chkAlt3
            // 
            this.chkAlt3.AutoSize = true;
            this.chkAlt3.Checked = true;
            this.chkAlt3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlt3.Location = new System.Drawing.Point(300, 109);
            this.chkAlt3.Name = "chkAlt3";
            this.chkAlt3.OriState = false;
            this.chkAlt3.Size = new System.Drawing.Size(53, 19);
            this.chkAlt3.TabIndex = 17;
            this.chkAlt3.Text = "Alt";
            this.chkAlt3.UseVisualStyleBackColor = true;
            // 
            // chkShift3
            // 
            this.chkShift3.AutoSize = true;
            this.chkShift3.Location = new System.Drawing.Point(208, 109);
            this.chkShift3.Name = "chkShift3";
            this.chkShift3.OriState = false;
            this.chkShift3.Size = new System.Drawing.Size(69, 19);
            this.chkShift3.TabIndex = 16;
            this.chkShift3.Text = "Shift";
            this.chkShift3.UseVisualStyleBackColor = true;
            // 
            // chkCtrl3
            // 
            this.chkCtrl3.AutoSize = true;
            this.chkCtrl3.Checked = true;
            this.chkCtrl3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCtrl3.Location = new System.Drawing.Point(124, 109);
            this.chkCtrl3.Name = "chkCtrl3";
            this.chkCtrl3.OriState = false;
            this.chkCtrl3.Size = new System.Drawing.Size(61, 19);
            this.chkCtrl3.TabIndex = 15;
            this.chkCtrl3.Text = "Ctrl";
            this.chkCtrl3.UseVisualStyleBackColor = true;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl3.Location = new System.Drawing.Point(11, 111);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(67, 15);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "自由截图";
            this.lbl3.TipInfo = "自由选择截图";
            // 
            // cbbKeys2
            // 
            this.cbbKeys2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbKeys2.FormattingEnabled = true;
            this.cbbKeys2.Location = new System.Drawing.Point(452, 67);
            this.cbbKeys2.Name = "cbbKeys2";
            this.cbbKeys2.OriIndex = 0;
            this.cbbKeys2.Size = new System.Drawing.Size(107, 23);
            this.cbbKeys2.TabIndex = 14;
            // 
            // chkWin2
            // 
            this.chkWin2.AutoSize = true;
            this.chkWin2.Location = new System.Drawing.Point(376, 69);
            this.chkWin2.Name = "chkWin2";
            this.chkWin2.OriState = false;
            this.chkWin2.Size = new System.Drawing.Size(53, 19);
            this.chkWin2.TabIndex = 13;
            this.chkWin2.Text = "Win";
            this.chkWin2.UseVisualStyleBackColor = true;
            // 
            // chkAlt2
            // 
            this.chkAlt2.AutoSize = true;
            this.chkAlt2.Checked = true;
            this.chkAlt2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlt2.Location = new System.Drawing.Point(300, 69);
            this.chkAlt2.Name = "chkAlt2";
            this.chkAlt2.OriState = false;
            this.chkAlt2.Size = new System.Drawing.Size(53, 19);
            this.chkAlt2.TabIndex = 12;
            this.chkAlt2.Text = "Alt";
            this.chkAlt2.UseVisualStyleBackColor = true;
            // 
            // chkShift2
            // 
            this.chkShift2.AutoSize = true;
            this.chkShift2.Location = new System.Drawing.Point(208, 69);
            this.chkShift2.Name = "chkShift2";
            this.chkShift2.OriState = false;
            this.chkShift2.Size = new System.Drawing.Size(69, 19);
            this.chkShift2.TabIndex = 11;
            this.chkShift2.Text = "Shift";
            this.chkShift2.UseVisualStyleBackColor = true;
            // 
            // chkCtrl2
            // 
            this.chkCtrl2.AutoSize = true;
            this.chkCtrl2.Location = new System.Drawing.Point(124, 69);
            this.chkCtrl2.Name = "chkCtrl2";
            this.chkCtrl2.OriState = false;
            this.chkCtrl2.Size = new System.Drawing.Size(61, 19);
            this.chkCtrl2.TabIndex = 10;
            this.chkCtrl2.Text = "Ctrl";
            this.chkCtrl2.UseVisualStyleBackColor = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl2.Location = new System.Drawing.Point(11, 71);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(67, 15);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "活动窗体";
            this.lbl2.TipInfo = "截取当前活动窗体";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1.Location = new System.Drawing.Point(11, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(67, 15);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "全屏截图";
            this.lbl1.TipInfo = "全屏截图";
            // 
            // cbbKeys1
            // 
            this.cbbKeys1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbKeys1.FormattingEnabled = true;
            this.cbbKeys1.Location = new System.Drawing.Point(452, 27);
            this.cbbKeys1.Name = "cbbKeys1";
            this.cbbKeys1.OriIndex = 0;
            this.cbbKeys1.Size = new System.Drawing.Size(107, 23);
            this.cbbKeys1.TabIndex = 9;
            // 
            // chkWin1
            // 
            this.chkWin1.AutoSize = true;
            this.chkWin1.Checked = true;
            this.chkWin1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWin1.Location = new System.Drawing.Point(376, 31);
            this.chkWin1.Name = "chkWin1";
            this.chkWin1.OriState = false;
            this.chkWin1.Size = new System.Drawing.Size(53, 19);
            this.chkWin1.TabIndex = 8;
            this.chkWin1.Text = "Win";
            this.chkWin1.UseVisualStyleBackColor = true;
            // 
            // chkAlt1
            // 
            this.chkAlt1.AutoSize = true;
            this.chkAlt1.Location = new System.Drawing.Point(300, 29);
            this.chkAlt1.Name = "chkAlt1";
            this.chkAlt1.OriState = false;
            this.chkAlt1.Size = new System.Drawing.Size(53, 19);
            this.chkAlt1.TabIndex = 7;
            this.chkAlt1.Text = "Alt";
            this.chkAlt1.UseVisualStyleBackColor = true;
            // 
            // chkShift1
            // 
            this.chkShift1.AutoSize = true;
            this.chkShift1.Location = new System.Drawing.Point(208, 29);
            this.chkShift1.Name = "chkShift1";
            this.chkShift1.OriState = false;
            this.chkShift1.Size = new System.Drawing.Size(69, 19);
            this.chkShift1.TabIndex = 6;
            this.chkShift1.Text = "Shift";
            this.chkShift1.UseVisualStyleBackColor = true;
            // 
            // chkCtrl1
            // 
            this.chkCtrl1.AutoSize = true;
            this.chkCtrl1.Location = new System.Drawing.Point(124, 29);
            this.chkCtrl1.Name = "chkCtrl1";
            this.chkCtrl1.OriState = false;
            this.chkCtrl1.Size = new System.Drawing.Size(61, 19);
            this.chkCtrl1.TabIndex = 5;
            this.chkCtrl1.Text = "Ctrl";
            this.chkCtrl1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(388, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "保存(S)";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancle.Location = new System.Drawing.Point(502, 306);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 29);
            this.btnCancle.TabIndex = 31;
            this.btnCancle.Text = "取消(C)";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(309, 35);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(52, 15);
            this.lblExtension.TabIndex = 0;
            this.lblExtension.Text = "扩展名";
            // 
            // cmsSetting
            // 
            this.cmsSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetting,
            this.tsmiExit});
            this.cmsSetting.Name = "cmsSetting";
            this.cmsSetting.Size = new System.Drawing.Size(109, 52);
            this.cmsSetting.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsSetting_ItemClicked);
            // 
            // tsmiSetting
            // 
            this.tsmiSetting.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSetting.Image")));
            this.tsmiSetting.Name = "tsmiSetting";
            this.tsmiSetting.Size = new System.Drawing.Size(108, 24);
            this.tsmiSetting.Text = "设置";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = global::lxzh.Properties.Resources.exit;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(108, 24);
            this.tsmiExit.Text = "退出";
            // 
            // niSetting
            // 
            this.niSetting.ContextMenuStrip = this.cmsSetting;
            this.niSetting.Icon = ((System.Drawing.Icon)(resources.GetObject("niSetting.Icon")));
            this.niSetting.Text = "截图";
            this.niSetting.Visible = true;
            // 
            // cbbExtension
            // 
            this.cbbExtension.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbExtension.FormattingEnabled = true;
            this.cbbExtension.Location = new System.Drawing.Point(366, 31);
            this.cbbExtension.Name = "cbbExtension";
            this.cbbExtension.OriIndex = 0;
            this.cbbExtension.Size = new System.Drawing.Size(72, 23);
            this.cbbExtension.TabIndex = 3;
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(12, 30);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.OriText = null;
            this.txtSavePath.Size = new System.Drawing.Size(200, 25);
            this.txtSavePath.TabIndex = 1;
            // 
            // chkSPO
            // 
            this.chkSPO.AutoSize = true;
            this.chkSPO.Checked = true;
            this.chkSPO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSPO.Location = new System.Drawing.Point(464, 33);
            this.chkSPO.Name = "chkSPO";
            this.chkSPO.OriState = false;
            this.chkSPO.Size = new System.Drawing.Size(119, 19);
            this.chkSPO.TabIndex = 4;
            this.chkSPO.Text = "开机自动启动";
            this.chkSPO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSPO.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(595, 345);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbbExtension);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.gbShortCutKey);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.chkSPO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbShortCutKey.ResumeLayout(false);
            this.gbShortCutKey.PerformLayout();
            this.cmsSetting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lxzh.LCheckBox chkSPO;
        private lxzh.LTextBox txtSavePath;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.FolderBrowserDialog fbdSelectDir;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.GroupBox gbShortCutKey;
        private lxzh.LCheckBox chkAlt1;
        private lxzh.LCheckBox chkShift1;
        private lxzh.LCheckBox chkCtrl1;
        private lxzh.LComboBox cbbKeys1;
        private lxzh.LCheckBox chkWin1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private lxzh.LComboBox cbbExtension;
        private System.Windows.Forms.Label lblExtension;
        private lxzh.LxzhTipLabel lbl1;
        private lxzh.LComboBox cbbKeys3;
        private lxzh.LCheckBox chkWin3;
        private lxzh.LCheckBox chkAlt3;
        private lxzh.LCheckBox chkShift3;
        private lxzh.LCheckBox chkCtrl3;
        private lxzh.LxzhTipLabel lbl3;
        private lxzh.LComboBox cbbKeys2;
        private lxzh.LCheckBox chkWin2;
        private lxzh.LCheckBox chkAlt2;
        private lxzh.LCheckBox chkShift2;
        private lxzh.LCheckBox chkCtrl2;
        private lxzh.LxzhTipLabel lbl2;
        private lxzh.LComboBox cbbKeys4;
        private lxzh.LCheckBox chkWin4;
        private lxzh.LCheckBox chkAlt4;
        private lxzh.LCheckBox chkShift4;
        private lxzh.LCheckBox chkCtrl4;
        private lxzh.LxzhTipLabel lbl4;
        private System.Windows.Forms.ContextMenuStrip cmsSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.NotifyIcon niSetting;
        private LComboBox cbbKeys5;
        private LCheckBox chkWin5;
        private LCheckBox chkAlt5;
        private LCheckBox chkShift5;
        private LCheckBox chkCtrl5;
        private LxzhTipLabel lxzhTipLabel1;
    }
}