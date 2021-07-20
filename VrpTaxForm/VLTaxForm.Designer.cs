
namespace VrpTaxForm
{
    partial class VLTaxForm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxCar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.rbPeriod = new System.Windows.Forms.RadioButton();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cbxMotorHorsePower = new System.Windows.Forms.ComboBox();
            this.listAnswer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(1039, 974);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(240, 81);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "取消重填";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEnter.Location = new System.Drawing.Point(467, 974);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(240, 81);
            this.btnEnter.TabIndex = 17;
            this.btnEnter.Text = "確定送出";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listAnswer);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(109, 1061);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1522, 478);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "試算結果";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxMotorHorsePower);
            this.groupBox2.Controls.Add(this.cbxCar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(109, 651);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1522, 289);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用途及排氣量";
            // 
            // cbxCar
            // 
            this.cbxCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCar.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxCar.FormattingEnabled = true;
            this.cbxCar.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cbxCar.Location = new System.Drawing.Point(579, 78);
            this.cbxCar.Name = "cbxCar";
            this.cbxCar.Size = new System.Drawing.Size(888, 55);
            this.cbxCar.TabIndex = 6;
            this.cbxCar.SelectedIndexChanged += new System.EventHandler(this.cbxCar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(247, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "用途";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(118, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 47);
            this.label3.TabIndex = 5;
            this.label3.Text = "汽缸CC數/馬達馬力";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.rbYear);
            this.groupBox1.Controls.Add(this.rbPeriod);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(109, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1522, 251);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "使用期間";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(350, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 47);
            this.label4.TabIndex = 14;
            this.label4.Text = "從";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(922, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 47);
            this.label5.TabIndex = 15;
            this.label5.Text = "至";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(449, 156);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(443, 57);
            this.dtpStart.TabIndex = 12;
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbYear.Location = new System.Drawing.Point(126, 70);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(162, 51);
            this.rbYear.TabIndex = 10;
            this.rbYear.TabStop = true;
            this.rbYear.Text = "全年度";
            this.rbYear.UseVisualStyleBackColor = true;
            this.rbYear.CheckedChanged += new System.EventHandler(this.rbYear_CheckedChanged);
            // 
            // rbPeriod
            // 
            this.rbPeriod.AutoSize = true;
            this.rbPeriod.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPeriod.Location = new System.Drawing.Point(126, 162);
            this.rbPeriod.Name = "rbPeriod";
            this.rbPeriod.Size = new System.Drawing.Size(162, 51);
            this.rbPeriod.TabIndex = 11;
            this.rbPeriod.TabStop = true;
            this.rbPeriod.Text = "依期間";
            this.rbPeriod.UseVisualStyleBackColor = true;
            this.rbPeriod.CheckedChanged += new System.EventHandler(this.rbPeriod_CheckedChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(1024, 156);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(443, 57);
            this.dtpEnd.TabIndex = 9;
            // 
            // cbxMotorHorsePower
            // 
            this.cbxMotorHorsePower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMotorHorsePower.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxMotorHorsePower.FormattingEnabled = true;
            this.cbxMotorHorsePower.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cbxMotorHorsePower.Location = new System.Drawing.Point(579, 188);
            this.cbxMotorHorsePower.Name = "cbxMotorHorsePower";
            this.cbxMotorHorsePower.Size = new System.Drawing.Size(888, 55);
            this.cbxMotorHorsePower.TabIndex = 7;
            // 
            // listAnswer
            // 
            this.listAnswer.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listAnswer.FormattingEnabled = true;
            this.listAnswer.ItemHeight = 47;
            this.listAnswer.Location = new System.Drawing.Point(41, 56);
            this.listAnswer.Name = "listAnswer";
            this.listAnswer.Size = new System.Drawing.Size(1452, 380);
            this.listAnswer.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(499, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 81);
            this.label1.TabIndex = 22;
            this.label1.Text = "使用牌照稅應納稅額試算";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(33, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 47);
            this.label6.TabIndex = 23;
            this.label6.Text = "貼心小叮嚀：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(33, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1518, 47);
            this.label7.TabIndex = 24;
            this.label7.Text = "１. 本表試算之稅額僅供參考之用，不做任何證明，實際應納稅額仍應以稽徵機關核定為準。";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.Location = new System.Drawing.Point(33, 261);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(778, 47);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "２. 使用牌照稅稅額對照表及電動車應納稅額表";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // VLTaxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 1588);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VLTaxForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VLTaxForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.RadioButton rbYear;
        private System.Windows.Forms.RadioButton rbPeriod;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cbxCar;
        private System.Windows.Forms.ComboBox cbxMotorHorsePower;
        private System.Windows.Forms.ListBox listAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

