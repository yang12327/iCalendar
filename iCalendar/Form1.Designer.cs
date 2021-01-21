
namespace iCalendar
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxATT = new System.Windows.Forms.TextBox();
            this.textBoxSUM = new System.Windows.Forms.TextBox();
            this.textBoxDES = new System.Windows.Forms.TextBox();
            this.textBoxLOC = new System.Windows.Forms.TextBox();
            this.buttonUPD = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBoxCancel = new System.Windows.Forms.CheckBox();
            this.textBoxORG = new System.Windows.Forms.TextBox();
            this.buttonOUT = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDEL = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerStart.CustomFormat = "yyyy MM dd T HH mm ss Z";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(13, 53);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.ShowUpDown = true;
            this.dateTimePickerStart.Size = new System.Drawing.Size(598, 29);
            this.dateTimePickerStart.TabIndex = 0;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEnd.CustomFormat = "yyyy MM dd T HH mm ss Z";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(13, 92);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.ShowUpDown = true;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(598, 29);
            this.dateTimePickerEnd.TabIndex = 0;
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxID.Location = new System.Drawing.Point(13, 13);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(598, 29);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.Text = "UID";
            // 
            // textBoxATT
            // 
            this.textBoxATT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxATT.Location = new System.Drawing.Point(13, 170);
            this.textBoxATT.Name = "textBoxATT";
            this.textBoxATT.Size = new System.Drawing.Size(598, 29);
            this.textBoxATT.TabIndex = 1;
            this.textBoxATT.Text = "收件者1:example1@gmail.com;收件者2:example2@gmail.com";
            // 
            // textBoxSUM
            // 
            this.textBoxSUM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSUM.Location = new System.Drawing.Point(13, 208);
            this.textBoxSUM.Name = "textBoxSUM";
            this.textBoxSUM.Size = new System.Drawing.Size(598, 29);
            this.textBoxSUM.TabIndex = 1;
            this.textBoxSUM.Text = "標題";
            // 
            // textBoxDES
            // 
            this.textBoxDES.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDES.Location = new System.Drawing.Point(13, 248);
            this.textBoxDES.Name = "textBoxDES";
            this.textBoxDES.Size = new System.Drawing.Size(598, 29);
            this.textBoxDES.TabIndex = 1;
            this.textBoxDES.Text = "描述";
            // 
            // textBoxLOC
            // 
            this.textBoxLOC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLOC.Location = new System.Drawing.Point(13, 287);
            this.textBoxLOC.Name = "textBoxLOC";
            this.textBoxLOC.Size = new System.Drawing.Size(598, 29);
            this.textBoxLOC.TabIndex = 1;
            this.textBoxLOC.Text = "地點";
            // 
            // buttonUPD
            // 
            this.buttonUPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUPD.Location = new System.Drawing.Point(3, 3);
            this.buttonUPD.Name = "buttonUPD";
            this.buttonUPD.Size = new System.Drawing.Size(293, 29);
            this.buttonUPD.TabIndex = 2;
            this.buttonUPD.Text = "更新";
            this.buttonUPD.UseVisualStyleBackColor = true;
            this.buttonUPD.Click += new System.EventHandler(this.buttonUPD_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 391);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(598, 164);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkBoxCancel
            // 
            this.checkBoxCancel.AutoSize = true;
            this.checkBoxCancel.Location = new System.Drawing.Point(13, 325);
            this.checkBoxCancel.Name = "checkBoxCancel";
            this.checkBoxCancel.Size = new System.Drawing.Size(92, 24);
            this.checkBoxCancel.TabIndex = 4;
            this.checkBoxCancel.Text = "取消活動";
            this.checkBoxCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxORG
            // 
            this.textBoxORG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxORG.Location = new System.Drawing.Point(13, 132);
            this.textBoxORG.Name = "textBoxORG";
            this.textBoxORG.Size = new System.Drawing.Size(598, 29);
            this.textBoxORG.TabIndex = 1;
            this.textBoxORG.Text = "寄件者:example@gmail.com";
            // 
            // buttonOUT
            // 
            this.buttonOUT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOUT.Location = new System.Drawing.Point(13, 559);
            this.buttonOUT.Name = "buttonOUT";
            this.buttonOUT.Size = new System.Drawing.Size(598, 29);
            this.buttonOUT.TabIndex = 2;
            this.buttonOUT.Text = "匯出";
            this.buttonOUT.UseVisualStyleBackColor = true;
            this.buttonOUT.Click += new System.EventHandler(this.buttonOUT_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "ics";
            this.saveFileDialog1.Filter = "iCalendar|*.ics";
            this.saveFileDialog1.Title = "選擇匯出位置";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonUPD, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonDEL, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 350);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 35);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonDEL
            // 
            this.buttonDEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDEL.Location = new System.Drawing.Point(302, 3);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(293, 29);
            this.buttonDEL.TabIndex = 2;
            this.buttonDEL.Text = "刪除";
            this.buttonDEL.UseVisualStyleBackColor = true;
            this.buttonDEL.Click += new System.EventHandler(this.buttonDEL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.checkBoxCancel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonOUT);
            this.Controls.Add(this.textBoxLOC);
            this.Controls.Add(this.textBoxDES);
            this.Controls.Add(this.textBoxSUM);
            this.Controls.Add(this.textBoxORG);
            this.Controls.Add(this.textBoxATT);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(280, 530);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCalendar";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxATT;
        private System.Windows.Forms.TextBox textBoxSUM;
        private System.Windows.Forms.TextBox textBoxDES;
        private System.Windows.Forms.TextBox textBoxLOC;
        private System.Windows.Forms.Button buttonUPD;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBoxCancel;
        private System.Windows.Forms.TextBox textBoxORG;
        private System.Windows.Forms.Button buttonOUT;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonDEL;
    }
}

