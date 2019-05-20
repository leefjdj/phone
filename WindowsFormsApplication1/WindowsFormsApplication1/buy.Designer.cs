namespace WindowsFormsApplication1
{
    partial class buy
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.btnbuy = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.comgender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.commonth = new System.Windows.Forms.ComboBox();
            this.txtday = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(101, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtname.Location = new System.Drawing.Point(104, 49);
            this.txtname.MaxLength = 20;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(305, 29);
            this.txtname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(101, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "생년월일";
            // 
            // txtyear
            // 
            this.txtyear.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtyear.Location = new System.Drawing.Point(104, 109);
            this.txtyear.MaxLength = 4;
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(127, 29);
            this.txtyear.TabIndex = 1;
            this.txtyear.Text = "년(4자)";
            this.txtyear.Click += new System.EventHandler(this.txtyear_Click);
            this.txtyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtyear_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(101, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "성별";
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtmail.Location = new System.Drawing.Point(104, 231);
            this.txtmail.MaxLength = 40;
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(305, 29);
            this.txtmail.TabIndex = 5;
            // 
            // btnbuy
            // 
            this.btnbuy.Location = new System.Drawing.Point(104, 282);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(143, 49);
            this.btnbuy.TabIndex = 6;
            this.btnbuy.Text = "구매";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(266, 282);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(143, 49);
            this.btnno.TabIndex = 7;
            this.btnno.Text = "취소";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // comgender
            // 
            this.comgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comgender.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comgender.FormattingEnabled = true;
            this.comgender.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.comgender.Location = new System.Drawing.Point(104, 170);
            this.comgender.Name = "comgender";
            this.comgender.Size = new System.Drawing.Size(305, 29);
            this.comgender.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(101, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "본인 확인 이메일(선택)";
            // 
            // commonth
            // 
            this.commonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commonth.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.commonth.FormattingEnabled = true;
            this.commonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.commonth.Location = new System.Drawing.Point(237, 109);
            this.commonth.MaxDropDownItems = 10;
            this.commonth.Name = "commonth";
            this.commonth.Size = new System.Drawing.Size(79, 29);
            this.commonth.TabIndex = 2;
            // 
            // txtday
            // 
            this.txtday.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtday.Location = new System.Drawing.Point(322, 109);
            this.txtday.MaxLength = 2;
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(87, 29);
            this.txtday.TabIndex = 3;
            this.txtday.Text = "일";
            this.txtday.Click += new System.EventHandler(this.textday_Click);
            this.txtday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtday_KeyPress);
            // 
            // buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 356);
            this.Controls.Add(this.commonth);
            this.Controls.Add(this.comgender);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "buy";
            this.Text = "구매자 정보입력";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.ComboBox comgender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox commonth;
        private System.Windows.Forms.TextBox txtday;
    }
}