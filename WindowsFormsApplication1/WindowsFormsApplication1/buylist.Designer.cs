namespace WindowsFormsApplication1
{
    partial class buylist
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.blist = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buydate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(12, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(191, 21);
            this.txt_search.TabIndex = 8;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(209, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // blist
            // 
            this.blist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.age,
            this.address,
            this.phone,
            this.buydate});
            this.blist.Location = new System.Drawing.Point(12, 39);
            this.blist.Name = "blist";
            this.blist.Size = new System.Drawing.Size(447, 411);
            this.blist.TabIndex = 9;
            this.blist.UseCompatibleStateImageBehavior = false;
            this.blist.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "이름";
            this.name.Width = 58;
            // 
            // age
            // 
            this.age.Text = "나이";
            this.age.Width = 48;
            // 
            // address
            // 
            this.address.Text = "주소";
            this.address.Width = 53;
            // 
            // phone
            // 
            this.phone.Text = "기기명";
            this.phone.Width = 144;
            // 
            // buydate
            // 
            this.buydate.Text = "구매일";
            this.buydate.Width = 110;
            // 
            // buylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 462);
            this.Controls.Add(this.blist);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Name = "buylist";
            this.Text = "구매목록";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ListView blist;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader buydate;
        private System.Windows.Forms.ColumnHeader phone;
    }
}