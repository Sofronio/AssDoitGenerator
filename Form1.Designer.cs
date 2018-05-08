namespace AssDoitGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox_videoExt = new System.Windows.Forms.GroupBox();
            this.radioButton_mkv = new System.Windows.Forms.RadioButton();
            this.radioButton_webm = new System.Windows.Forms.RadioButton();
            this.radioButton_mp4 = new System.Windows.Forms.RadioButton();
            this.groupBox_UploadSite = new System.Windows.Forms.GroupBox();
            this.checkBox_acfun = new System.Windows.Forms.CheckBox();
            this.checkBox_wechat = new System.Windows.Forms.CheckBox();
            this.checkBox_youku = new System.Windows.Forms.CheckBox();
            this.checkBox_weibo = new System.Windows.Forms.CheckBox();
            this.checkBox_bilibili = new System.Windows.Forms.CheckBox();
            this.groupBox_copyright = new System.Windows.Forms.GroupBox();
            this.radioButton_copyrightOff = new System.Windows.Forms.RadioButton();
            this.radioButton_copyrightOn = new System.Windows.Forms.RadioButton();
            this.textBox_bitRate = new System.Windows.Forms.TextBox();
            this.button_doit = new System.Windows.Forms.Button();
            this.groupBox_renderOption = new System.Windows.Forms.GroupBox();
            this.textBox_temp4kBitrate = new System.Windows.Forms.TextBox();
            this.checkBox_4k = new System.Windows.Forms.CheckBox();
            this.checkBox_delete = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_avi = new System.Windows.Forms.RadioButton();
            this.groupBox_videoExt.SuspendLayout();
            this.groupBox_UploadSite.SuspendLayout();
            this.groupBox_copyright.SuspendLayout();
            this.groupBox_renderOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 21);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox_videoExt
            // 
            this.groupBox_videoExt.Controls.Add(this.radioButton_avi);
            this.groupBox_videoExt.Controls.Add(this.radioButton_mkv);
            this.groupBox_videoExt.Controls.Add(this.radioButton_webm);
            this.groupBox_videoExt.Controls.Add(this.radioButton_mp4);
            this.groupBox_videoExt.Location = new System.Drawing.Point(34, 55);
            this.groupBox_videoExt.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_videoExt.Name = "groupBox_videoExt";
            this.groupBox_videoExt.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_videoExt.Size = new System.Drawing.Size(261, 57);
            this.groupBox_videoExt.TabIndex = 1;
            this.groupBox_videoExt.TabStop = false;
            this.groupBox_videoExt.Text = "Video format";
            // 
            // radioButton_mkv
            // 
            this.radioButton_mkv.AutoSize = true;
            this.radioButton_mkv.Location = new System.Drawing.Point(113, 23);
            this.radioButton_mkv.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_mkv.Name = "radioButton_mkv";
            this.radioButton_mkv.Size = new System.Drawing.Size(41, 16);
            this.radioButton_mkv.TabIndex = 2;
            this.radioButton_mkv.Text = "mkv";
            this.radioButton_mkv.UseVisualStyleBackColor = true;
            // 
            // radioButton_webm
            // 
            this.radioButton_webm.AutoSize = true;
            this.radioButton_webm.Location = new System.Drawing.Point(60, 23);
            this.radioButton_webm.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_webm.Name = "radioButton_webm";
            this.radioButton_webm.Size = new System.Drawing.Size(47, 16);
            this.radioButton_webm.TabIndex = 1;
            this.radioButton_webm.Text = "webm";
            this.radioButton_webm.UseVisualStyleBackColor = true;
            // 
            // radioButton_mp4
            // 
            this.radioButton_mp4.AutoSize = true;
            this.radioButton_mp4.Checked = true;
            this.radioButton_mp4.Location = new System.Drawing.Point(11, 23);
            this.radioButton_mp4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_mp4.Name = "radioButton_mp4";
            this.radioButton_mp4.Size = new System.Drawing.Size(41, 16);
            this.radioButton_mp4.TabIndex = 0;
            this.radioButton_mp4.TabStop = true;
            this.radioButton_mp4.Text = "mp4";
            this.radioButton_mp4.UseVisualStyleBackColor = true;
            // 
            // groupBox_UploadSite
            // 
            this.groupBox_UploadSite.Controls.Add(this.checkBox_acfun);
            this.groupBox_UploadSite.Controls.Add(this.checkBox_wechat);
            this.groupBox_UploadSite.Controls.Add(this.checkBox_youku);
            this.groupBox_UploadSite.Controls.Add(this.checkBox_weibo);
            this.groupBox_UploadSite.Controls.Add(this.checkBox_bilibili);
            this.groupBox_UploadSite.Location = new System.Drawing.Point(34, 124);
            this.groupBox_UploadSite.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_UploadSite.Name = "groupBox_UploadSite";
            this.groupBox_UploadSite.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_UploadSite.Size = new System.Drawing.Size(389, 57);
            this.groupBox_UploadSite.TabIndex = 2;
            this.groupBox_UploadSite.TabStop = false;
            this.groupBox_UploadSite.Text = "Upload Site";
            // 
            // checkBox_acfun
            // 
            this.checkBox_acfun.AutoSize = true;
            this.checkBox_acfun.Checked = true;
            this.checkBox_acfun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_acfun.Location = new System.Drawing.Point(236, 27);
            this.checkBox_acfun.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_acfun.Name = "checkBox_acfun";
            this.checkBox_acfun.Size = new System.Drawing.Size(54, 16);
            this.checkBox_acfun.TabIndex = 4;
            this.checkBox_acfun.Text = "Acfun";
            this.checkBox_acfun.UseVisualStyleBackColor = true;
            // 
            // checkBox_wechat
            // 
            this.checkBox_wechat.AutoSize = true;
            this.checkBox_wechat.Location = new System.Drawing.Point(310, 27);
            this.checkBox_wechat.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_wechat.Name = "checkBox_wechat";
            this.checkBox_wechat.Size = new System.Drawing.Size(48, 16);
            this.checkBox_wechat.TabIndex = 3;
            this.checkBox_wechat.Text = "微信";
            this.checkBox_wechat.UseVisualStyleBackColor = true;
            // 
            // checkBox_youku
            // 
            this.checkBox_youku.AutoSize = true;
            this.checkBox_youku.Checked = true;
            this.checkBox_youku.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_youku.Location = new System.Drawing.Point(170, 27);
            this.checkBox_youku.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_youku.Name = "checkBox_youku";
            this.checkBox_youku.Size = new System.Drawing.Size(48, 16);
            this.checkBox_youku.TabIndex = 2;
            this.checkBox_youku.Text = "优酷";
            this.checkBox_youku.UseVisualStyleBackColor = true;
            // 
            // checkBox_weibo
            // 
            this.checkBox_weibo.AutoSize = true;
            this.checkBox_weibo.Checked = true;
            this.checkBox_weibo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_weibo.Location = new System.Drawing.Point(103, 27);
            this.checkBox_weibo.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_weibo.Name = "checkBox_weibo";
            this.checkBox_weibo.Size = new System.Drawing.Size(48, 16);
            this.checkBox_weibo.TabIndex = 1;
            this.checkBox_weibo.Text = "微博";
            this.checkBox_weibo.UseVisualStyleBackColor = true;
            // 
            // checkBox_bilibili
            // 
            this.checkBox_bilibili.AutoSize = true;
            this.checkBox_bilibili.Checked = true;
            this.checkBox_bilibili.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_bilibili.Location = new System.Drawing.Point(11, 27);
            this.checkBox_bilibili.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_bilibili.Name = "checkBox_bilibili";
            this.checkBox_bilibili.Size = new System.Drawing.Size(72, 16);
            this.checkBox_bilibili.TabIndex = 0;
            this.checkBox_bilibili.Text = "Bilibili";
            this.checkBox_bilibili.UseVisualStyleBackColor = true;
            // 
            // groupBox_copyright
            // 
            this.groupBox_copyright.Controls.Add(this.radioButton_copyrightOff);
            this.groupBox_copyright.Controls.Add(this.radioButton_copyrightOn);
            this.groupBox_copyright.Location = new System.Drawing.Point(299, 55);
            this.groupBox_copyright.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_copyright.Name = "groupBox_copyright";
            this.groupBox_copyright.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_copyright.Size = new System.Drawing.Size(124, 57);
            this.groupBox_copyright.TabIndex = 3;
            this.groupBox_copyright.TabStop = false;
            this.groupBox_copyright.Text = "Copyright";
            // 
            // radioButton_copyrightOff
            // 
            this.radioButton_copyrightOff.AutoSize = true;
            this.radioButton_copyrightOff.Location = new System.Drawing.Point(64, 23);
            this.radioButton_copyrightOff.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_copyrightOff.Name = "radioButton_copyrightOff";
            this.radioButton_copyrightOff.Size = new System.Drawing.Size(41, 16);
            this.radioButton_copyrightOff.TabIndex = 1;
            this.radioButton_copyrightOff.Text = "off";
            this.radioButton_copyrightOff.UseVisualStyleBackColor = true;
            this.radioButton_copyrightOff.CheckedChanged += new System.EventHandler(this.radioButton_copyrightOff_CheckedChanged);
            // 
            // radioButton_copyrightOn
            // 
            this.radioButton_copyrightOn.AutoSize = true;
            this.radioButton_copyrightOn.Checked = true;
            this.radioButton_copyrightOn.Location = new System.Drawing.Point(15, 23);
            this.radioButton_copyrightOn.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_copyrightOn.Name = "radioButton_copyrightOn";
            this.radioButton_copyrightOn.Size = new System.Drawing.Size(35, 16);
            this.radioButton_copyrightOn.TabIndex = 0;
            this.radioButton_copyrightOn.TabStop = true;
            this.radioButton_copyrightOn.Text = "on";
            this.radioButton_copyrightOn.UseVisualStyleBackColor = true;
            // 
            // textBox_bitRate
            // 
            this.textBox_bitRate.Location = new System.Drawing.Point(211, 121);
            this.textBox_bitRate.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_bitRate.Name = "textBox_bitRate";
            this.textBox_bitRate.Size = new System.Drawing.Size(56, 21);
            this.textBox_bitRate.TabIndex = 0;
            this.textBox_bitRate.Text = "3500";
            // 
            // button_doit
            // 
            this.button_doit.Location = new System.Drawing.Point(344, 204);
            this.button_doit.Margin = new System.Windows.Forms.Padding(2);
            this.button_doit.Name = "button_doit";
            this.button_doit.Size = new System.Drawing.Size(79, 171);
            this.button_doit.TabIndex = 5;
            this.button_doit.Text = "Do it!";
            this.button_doit.UseVisualStyleBackColor = true;
            this.button_doit.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_renderOption
            // 
            this.groupBox_renderOption.Controls.Add(this.label2);
            this.groupBox_renderOption.Controls.Add(this.textBox_bitRate);
            this.groupBox_renderOption.Controls.Add(this.label1);
            this.groupBox_renderOption.Controls.Add(this.textBox_temp4kBitrate);
            this.groupBox_renderOption.Controls.Add(this.checkBox_4k);
            this.groupBox_renderOption.Controls.Add(this.checkBox_delete);
            this.groupBox_renderOption.Location = new System.Drawing.Point(34, 198);
            this.groupBox_renderOption.Name = "groupBox_renderOption";
            this.groupBox_renderOption.Size = new System.Drawing.Size(290, 177);
            this.groupBox_renderOption.TabIndex = 6;
            this.groupBox_renderOption.TabStop = false;
            this.groupBox_renderOption.Text = "Output option";
            // 
            // textBox_temp4kBitrate
            // 
            this.textBox_temp4kBitrate.Location = new System.Drawing.Point(211, 80);
            this.textBox_temp4kBitrate.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_temp4kBitrate.Name = "textBox_temp4kBitrate";
            this.textBox_temp4kBitrate.Size = new System.Drawing.Size(56, 21);
            this.textBox_temp4kBitrate.TabIndex = 0;
            this.textBox_temp4kBitrate.Text = "10000";
            // 
            // checkBox_4k
            // 
            this.checkBox_4k.AutoSize = true;
            this.checkBox_4k.Location = new System.Drawing.Point(11, 57);
            this.checkBox_4k.Name = "checkBox_4k";
            this.checkBox_4k.Size = new System.Drawing.Size(78, 16);
            this.checkBox_4k.TabIndex = 1;
            this.checkBox_4k.Text = "Output 4K";
            this.checkBox_4k.UseVisualStyleBackColor = true;
            this.checkBox_4k.CheckedChanged += new System.EventHandler(this.checkBox_4k_CheckedChanged);
            // 
            // checkBox_delete
            // 
            this.checkBox_delete.AutoSize = true;
            this.checkBox_delete.Checked = true;
            this.checkBox_delete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_delete.Location = new System.Drawing.Point(11, 29);
            this.checkBox_delete.Name = "checkBox_delete";
            this.checkBox_delete.Size = new System.Drawing.Size(120, 16);
            this.checkBox_delete.TabIndex = 0;
            this.checkBox_delete.Text = "Delete temp file";
            this.checkBox_delete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "HEVC temp file bitrate (kbps)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final video bitrate (kbps)";
            // 
            // radioButton_avi
            // 
            this.radioButton_avi.AutoSize = true;
            this.radioButton_avi.Location = new System.Drawing.Point(158, 23);
            this.radioButton_avi.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_avi.Name = "radioButton_avi";
            this.radioButton_avi.Size = new System.Drawing.Size(41, 16);
            this.radioButton_avi.TabIndex = 3;
            this.radioButton_avi.Text = "avi";
            this.radioButton_avi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 405);
            this.Controls.Add(this.groupBox_renderOption);
            this.Controls.Add(this.button_doit);
            this.Controls.Add(this.groupBox_copyright);
            this.Controls.Add(this.groupBox_UploadSite);
            this.Controls.Add(this.groupBox_videoExt);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "AssDoItGenerator v0.0.2 by Sofronio";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox_videoExt.ResumeLayout(false);
            this.groupBox_videoExt.PerformLayout();
            this.groupBox_UploadSite.ResumeLayout(false);
            this.groupBox_UploadSite.PerformLayout();
            this.groupBox_copyright.ResumeLayout(false);
            this.groupBox_copyright.PerformLayout();
            this.groupBox_renderOption.ResumeLayout(false);
            this.groupBox_renderOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox_videoExt;
        private System.Windows.Forms.RadioButton radioButton_mkv;
        private System.Windows.Forms.RadioButton radioButton_webm;
        private System.Windows.Forms.RadioButton radioButton_mp4;
        private System.Windows.Forms.GroupBox groupBox_UploadSite;
        private System.Windows.Forms.CheckBox checkBox_acfun;
        private System.Windows.Forms.CheckBox checkBox_wechat;
        private System.Windows.Forms.CheckBox checkBox_youku;
        private System.Windows.Forms.CheckBox checkBox_weibo;
        private System.Windows.Forms.CheckBox checkBox_bilibili;
        private System.Windows.Forms.GroupBox groupBox_copyright;
        private System.Windows.Forms.RadioButton radioButton_copyrightOff;
        private System.Windows.Forms.RadioButton radioButton_copyrightOn;
        private System.Windows.Forms.TextBox textBox_bitRate;
        private System.Windows.Forms.Button button_doit;
        private System.Windows.Forms.GroupBox groupBox_renderOption;
        private System.Windows.Forms.CheckBox checkBox_4k;
        private System.Windows.Forms.CheckBox checkBox_delete;
        private System.Windows.Forms.TextBox textBox_temp4kBitrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_avi;
        private System.Windows.Forms.Label label2;
    }
}

