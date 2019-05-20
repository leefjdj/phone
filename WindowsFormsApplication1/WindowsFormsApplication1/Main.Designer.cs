namespace WindowsFormsApplication1
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid_phone = new System.Windows.Forms.DataGridView();
            this.phone_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_made = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_ram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_bat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnbuy = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_buy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_buylist = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_in = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_update = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_count = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_t = new System.Windows.Forms.ToolStripMenuItem();
            this.combo_color = new System.Windows.Forms.ComboBox();
            this.combo_size = new System.Windows.Forms.ComboBox();
            this.combo_search = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_display = new System.Windows.Forms.Label();
            this.lbl_ram = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_company = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl_bat = new System.Windows.Forms.Label();
            this.lbl_os = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.lbl_backcamera = new System.Windows.Forms.Label();
            this.lbl_frontcamera = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.btnwarehouse = new System.Windows.Forms.Button();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_phone)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_phone
            // 
            this.Grid_phone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid_phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_phone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phone_name,
            this.phone_price,
            this.phone_made,
            this.phone_OS,
            this.phone_birth,
            this.phone_ram,
            this.phone_bat,
            this.Column1});
            this.Grid_phone.Location = new System.Drawing.Point(12, 70);
            this.Grid_phone.Name = "Grid_phone";
            this.Grid_phone.ReadOnly = true;
            this.Grid_phone.RowTemplate.Height = 23;
            this.Grid_phone.Size = new System.Drawing.Size(576, 511);
            this.Grid_phone.TabIndex = 0;
            this.Grid_phone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_phone_CellContentClick);
            this.Grid_phone.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Grid_phone_RowPostPaint);
            // 
            // phone_name
            // 
            this.phone_name.HeaderText = "기기명";
            this.phone_name.Name = "phone_name";
            this.phone_name.ReadOnly = true;
            this.phone_name.Width = 66;
            // 
            // phone_price
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.phone_price.DefaultCellStyle = dataGridViewCellStyle2;
            this.phone_price.HeaderText = "가격";
            this.phone_price.Name = "phone_price";
            this.phone_price.ReadOnly = true;
            this.phone_price.Width = 54;
            // 
            // phone_made
            // 
            this.phone_made.HeaderText = "제조사";
            this.phone_made.Name = "phone_made";
            this.phone_made.ReadOnly = true;
            this.phone_made.Width = 66;
            // 
            // phone_OS
            // 
            this.phone_OS.HeaderText = "운영체제";
            this.phone_OS.Name = "phone_OS";
            this.phone_OS.ReadOnly = true;
            this.phone_OS.Width = 78;
            // 
            // phone_birth
            // 
            this.phone_birth.HeaderText = "출시일";
            this.phone_birth.Name = "phone_birth";
            this.phone_birth.ReadOnly = true;
            this.phone_birth.Width = 66;
            // 
            // phone_ram
            // 
            this.phone_ram.HeaderText = "RAM";
            this.phone_ram.Name = "phone_ram";
            this.phone_ram.ReadOnly = true;
            this.phone_ram.Width = 57;
            // 
            // phone_bat
            // 
            this.phone_bat.HeaderText = "배터리";
            this.phone_bat.Name = "phone_bat";
            this.phone_bat.ReadOnly = true;
            this.phone_bat.Width = 66;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "남은 수량";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 82;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Bisque;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl1.Location = new System.Drawing.Point(599, 304);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(121, 25);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "기기명";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnbuy
            // 
            this.btnbuy.Location = new System.Drawing.Point(621, 532);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(113, 49);
            this.btnbuy.TabIndex = 3;
            this.btnbuy.Text = "구매";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.menu_buy,
            this.menu_in,
            this.menu_t});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1143, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_exit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(98, 22);
            this.menu_exit.Text = "종료";
            // 
            // menu_buy
            // 
            this.menu_buy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_buylist});
            this.menu_buy.Name = "menu_buy";
            this.menu_buy.Size = new System.Drawing.Size(43, 20);
            this.menu_buy.Text = "구매";
            // 
            // menu_buylist
            // 
            this.menu_buylist.Name = "menu_buylist";
            this.menu_buylist.Size = new System.Drawing.Size(122, 22);
            this.menu_buylist.Text = "구매목록";
            this.menu_buylist.Click += new System.EventHandler(this.menu_buylist_Click);
            // 
            // menu_in
            // 
            this.menu_in.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_insert,
            this.menu_update,
            this.menu_count});
            this.menu_in.Name = "menu_in";
            this.menu_in.Size = new System.Drawing.Size(43, 20);
            this.menu_in.Text = "등록";
            // 
            // menu_insert
            // 
            this.menu_insert.Name = "menu_insert";
            this.menu_insert.Size = new System.Drawing.Size(152, 22);
            this.menu_insert.Text = "입력";
            this.menu_insert.Click += new System.EventHandler(this.menu_insert_Click);
            // 
            // menu_update
            // 
            this.menu_update.Name = "menu_update";
            this.menu_update.Size = new System.Drawing.Size(98, 22);
            this.menu_update.Text = "수정";
            // 
            // menu_count
            // 
            this.menu_count.Name = "menu_count";
            this.menu_count.Size = new System.Drawing.Size(98, 22);
            this.menu_count.Text = "입고";
            // 
            // menu_t
            // 
            this.menu_t.Name = "menu_t";
            this.menu_t.Size = new System.Drawing.Size(43, 20);
            this.menu_t.Text = "통계";
            // 
            // combo_color
            // 
            this.combo_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_color.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combo_color.FormattingEnabled = true;
            this.combo_color.Location = new System.Drawing.Point(984, 454);
            this.combo_color.Name = "combo_color";
            this.combo_color.Size = new System.Drawing.Size(147, 25);
            this.combo_color.TabIndex = 5;
            this.combo_color.SelectedIndexChanged += new System.EventHandler(this.combo_color_SelectedIndexChanged);
            // 
            // combo_size
            // 
            this.combo_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_size.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combo_size.FormattingEnabled = true;
            this.combo_size.Location = new System.Drawing.Point(719, 454);
            this.combo_size.Name = "combo_size";
            this.combo_size.Size = new System.Drawing.Size(146, 25);
            this.combo_size.TabIndex = 2;
            this.combo_size.SelectedIndexChanged += new System.EventHandler(this.combo_size_SelectedIndexChanged);
            // 
            // combo_search
            // 
            this.combo_search.FormattingEnabled = true;
            this.combo_search.Items.AddRange(new object[] {
            "기기명",
            "제조사"});
            this.combo_search.Location = new System.Drawing.Point(12, 33);
            this.combo_search.Name = "combo_search";
            this.combo_search.Size = new System.Drawing.Size(102, 20);
            this.combo_search.TabIndex = 5;
            this.combo_search.Text = "기기명";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(120, 33);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(191, 21);
            this.txt_search.TabIndex = 6;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(317, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Bisque;
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl2.Location = new System.Drawing.Point(599, 329);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(121, 25);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "크기";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Bisque;
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl3.Location = new System.Drawing.Point(599, 354);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(121, 25);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "디스플레이";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.Bisque;
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl4.Location = new System.Drawing.Point(599, 379);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(121, 25);
            this.lbl4.TabIndex = 2;
            this.lbl4.Text = "RAM";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_size
            // 
            this.lbl_size.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_size.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_size.Location = new System.Drawing.Point(719, 329);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(412, 25);
            this.lbl_size.TabIndex = 2;
            this.lbl_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_display
            // 
            this.lbl_display.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_display.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_display.Location = new System.Drawing.Point(719, 354);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(412, 25);
            this.lbl_display.TabIndex = 2;
            this.lbl_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ram
            // 
            this.lbl_ram.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ram.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_ram.Location = new System.Drawing.Point(719, 379);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(147, 25);
            this.lbl_ram.TabIndex = 2;
            this.lbl_ram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_name.Location = new System.Drawing.Point(719, 304);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(412, 25);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_company
            // 
            this.lbl_company.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_company.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_company.Location = new System.Drawing.Point(984, 379);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(147, 25);
            this.lbl_company.TabIndex = 2;
            this.lbl_company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.Bisque;
            this.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl5.Location = new System.Drawing.Point(864, 379);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(121, 25);
            this.lbl5.TabIndex = 2;
            this.lbl5.Text = "제조사";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_bat
            // 
            this.lbl_bat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_bat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_bat.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_bat.Location = new System.Drawing.Point(719, 404);
            this.lbl_bat.Name = "lbl_bat";
            this.lbl_bat.Size = new System.Drawing.Size(147, 25);
            this.lbl_bat.TabIndex = 2;
            this.lbl_bat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_os
            // 
            this.lbl_os.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_os.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_os.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_os.Location = new System.Drawing.Point(984, 404);
            this.lbl_os.Name = "lbl_os";
            this.lbl_os.Size = new System.Drawing.Size(147, 25);
            this.lbl_os.TabIndex = 2;
            this.lbl_os.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6
            // 
            this.lbl6.BackColor = System.Drawing.Color.Bisque;
            this.lbl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl6.Location = new System.Drawing.Point(599, 404);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(121, 25);
            this.lbl6.TabIndex = 2;
            this.lbl6.Text = "배터리";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl7
            // 
            this.lbl7.BackColor = System.Drawing.Color.Bisque;
            this.lbl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl7.Location = new System.Drawing.Point(864, 404);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(121, 25);
            this.lbl7.TabIndex = 2;
            this.lbl7.Text = "os";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl10
            // 
            this.lbl10.BackColor = System.Drawing.Color.Bisque;
            this.lbl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl10.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl10.Location = new System.Drawing.Point(599, 454);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(121, 25);
            this.lbl10.TabIndex = 2;
            this.lbl10.Text = "저장공간";
            this.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl11
            // 
            this.lbl11.BackColor = System.Drawing.Color.Bisque;
            this.lbl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl11.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl11.Location = new System.Drawing.Point(864, 454);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(121, 25);
            this.lbl11.TabIndex = 2;
            this.lbl11.Text = "색상";
            this.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_price
            // 
            this.lbl_price.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_price.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_price.Location = new System.Drawing.Point(719, 504);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(412, 25);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl13
            // 
            this.lbl13.BackColor = System.Drawing.Color.Bisque;
            this.lbl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl13.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl13.Location = new System.Drawing.Point(599, 504);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(121, 25);
            this.lbl13.TabIndex = 2;
            this.lbl13.Text = "가격";
            this.lbl13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_backcamera
            // 
            this.lbl_backcamera.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_backcamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_backcamera.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_backcamera.Location = new System.Drawing.Point(719, 429);
            this.lbl_backcamera.Name = "lbl_backcamera";
            this.lbl_backcamera.Size = new System.Drawing.Size(147, 25);
            this.lbl_backcamera.TabIndex = 2;
            this.lbl_backcamera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_frontcamera
            // 
            this.lbl_frontcamera.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_frontcamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_frontcamera.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_frontcamera.Location = new System.Drawing.Point(984, 429);
            this.lbl_frontcamera.Name = "lbl_frontcamera";
            this.lbl_frontcamera.Size = new System.Drawing.Size(147, 25);
            this.lbl_frontcamera.TabIndex = 2;
            this.lbl_frontcamera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl8
            // 
            this.lbl8.BackColor = System.Drawing.Color.Bisque;
            this.lbl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl8.Location = new System.Drawing.Point(599, 429);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(121, 25);
            this.lbl8.TabIndex = 2;
            this.lbl8.Text = "후면카메라";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl9
            // 
            this.lbl9.BackColor = System.Drawing.Color.Bisque;
            this.lbl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl9.Location = new System.Drawing.Point(864, 429);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(121, 25);
            this.lbl9.TabIndex = 2;
            this.lbl9.Text = "전면카메라";
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnwarehouse
            // 
            this.btnwarehouse.Location = new System.Drawing.Point(801, 532);
            this.btnwarehouse.Name = "btnwarehouse";
            this.btnwarehouse.Size = new System.Drawing.Size(113, 49);
            this.btnwarehouse.TabIndex = 3;
            this.btnwarehouse.Text = "입고";
            this.btnwarehouse.UseVisualStyleBackColor = true;
            this.btnwarehouse.Click += new System.EventHandler(this.btnwarehouse_Click);
            // 
            // lbl_count
            // 
            this.lbl_count.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_count.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_count.Location = new System.Drawing.Point(719, 479);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(412, 25);
            this.lbl_count.TabIndex = 2;
            this.lbl_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl12
            // 
            this.lbl12.BackColor = System.Drawing.Color.Bisque;
            this.lbl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl12.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl12.Location = new System.Drawing.Point(599, 479);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(121, 25);
            this.lbl12.TabIndex = 2;
            this.lbl12.Text = "수량";
            this.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic1
            // 
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic1.Location = new System.Drawing.Point(599, 70);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(386, 220);
            this.pic1.TabIndex = 7;
            this.pic1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1143, 593);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.combo_size);
            this.Controls.Add(this.combo_search);
            this.Controls.Add(this.combo_color);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btnwarehouse);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl_frontcamera);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl_os);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbl13);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl_backcamera);
            this.Controls.Add(this.lbl_company);
            this.Controls.Add(this.lbl_bat);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_ram);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.Grid_phone);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "구매";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_phone)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_phone;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_buy;
        private System.Windows.Forms.ToolStripMenuItem menu_t;
        private System.Windows.Forms.ComboBox combo_color;
        private System.Windows.Forms.ComboBox combo_size;
        private System.Windows.Forms.ComboBox combo_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ToolStripMenuItem menu_in;
        private System.Windows.Forms.ToolStripMenuItem menu_insert;
        private System.Windows.Forms.ToolStripMenuItem menu_update;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_display;
        private System.Windows.Forms.Label lbl_ram;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_company;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl_bat;
        private System.Windows.Forms.Label lbl_os;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbl_backcamera;
        private System.Windows.Forms.Label lbl_frontcamera;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.ToolStripMenuItem menu_count;
        private System.Windows.Forms.Button btnwarehouse;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.ToolStripMenuItem menu_buylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_made;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_ram;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_bat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.PictureBox pic1;
    }
}

