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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid_phone = new System.Windows.Forms.DataGridView();
            this.phone_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_made = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_ram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_bat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_display = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_backcamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_frontcamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuy = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구매ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.입력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combo_color = new System.Windows.Forms.ComboBox();
            this.combo_size = new System.Windows.Forms.ComboBox();
            this.combo_search = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_display = new System.Windows.Forms.Label();
            this.lbl_ram = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_company = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_bat = new System.Windows.Forms.Label();
            this.lbl_os = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_backcamera = new System.Windows.Forms.Label();
            this.lbl_frontcamera = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.phone_size,
            this.phone_display,
            this.phone_backcamera,
            this.phone_frontcamera});
            this.Grid_phone.Location = new System.Drawing.Point(12, 70);
            this.Grid_phone.Name = "Grid_phone";
            this.Grid_phone.ReadOnly = true;
            this.Grid_phone.RowTemplate.Height = 23;
            this.Grid_phone.Size = new System.Drawing.Size(576, 498);
            this.Grid_phone.TabIndex = 0;
            this.Grid_phone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_phone_CellContentClick);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.phone_price.DefaultCellStyle = dataGridViewCellStyle1;
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
            // phone_size
            // 
            this.phone_size.HeaderText = "크기";
            this.phone_size.Name = "phone_size";
            this.phone_size.ReadOnly = true;
            this.phone_size.Width = 54;
            // 
            // phone_display
            // 
            this.phone_display.HeaderText = "디스플레이";
            this.phone_display.Name = "phone_display";
            this.phone_display.ReadOnly = true;
            this.phone_display.Width = 90;
            // 
            // phone_backcamera
            // 
            this.phone_backcamera.HeaderText = "후면카메라";
            this.phone_backcamera.Name = "phone_backcamera";
            this.phone_backcamera.ReadOnly = true;
            this.phone_backcamera.Width = 90;
            // 
            // phone_frontcamera
            // 
            this.phone_frontcamera.HeaderText = "전면카메라";
            this.phone_frontcamera.Name = "phone_frontcamera";
            this.phone_frontcamera.ReadOnly = true;
            this.phone_frontcamera.Width = 90;
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(691, 70);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(159, 186);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(600, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "기기명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnbuy
            // 
            this.btnbuy.Location = new System.Drawing.Point(622, 519);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(113, 49);
            this.btnbuy.TabIndex = 3;
            this.btnbuy.Text = "구매";
            this.btnbuy.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.구매ToolStripMenuItem,
            this.등록ToolStripMenuItem,
            this.통계ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // 구매ToolStripMenuItem
            // 
            this.구매ToolStripMenuItem.Name = "구매ToolStripMenuItem";
            this.구매ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.구매ToolStripMenuItem.Text = "구매";
            // 
            // 등록ToolStripMenuItem
            // 
            this.등록ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.입력ToolStripMenuItem,
            this.수정ToolStripMenuItem});
            this.등록ToolStripMenuItem.Name = "등록ToolStripMenuItem";
            this.등록ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.등록ToolStripMenuItem.Text = "등록";
            // 
            // 입력ToolStripMenuItem
            // 
            this.입력ToolStripMenuItem.Name = "입력ToolStripMenuItem";
            this.입력ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.입력ToolStripMenuItem.Text = "입력";
            // 
            // 수정ToolStripMenuItem
            // 
            this.수정ToolStripMenuItem.Name = "수정ToolStripMenuItem";
            this.수정ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.수정ToolStripMenuItem.Text = "수정";
            // 
            // 통계ToolStripMenuItem
            // 
            this.통계ToolStripMenuItem.Name = "통계ToolStripMenuItem";
            this.통계ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.통계ToolStripMenuItem.Text = "통계";
            // 
            // combo_color
            // 
            this.combo_color.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combo_color.FormattingEnabled = true;
            this.combo_color.Location = new System.Drawing.Point(967, 426);
            this.combo_color.Name = "combo_color";
            this.combo_color.Size = new System.Drawing.Size(130, 25);
            this.combo_color.TabIndex = 5;
            // 
            // combo_size
            // 
            this.combo_size.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combo_size.FormattingEnabled = true;
            this.combo_size.Location = new System.Drawing.Point(720, 426);
            this.combo_size.Name = "combo_size";
            this.combo_size.Size = new System.Drawing.Size(128, 25);
            this.combo_size.TabIndex = 5;
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(600, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "크기";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(600, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "디스플레이";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(600, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "RAM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_size
            // 
            this.lbl_size.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_size.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_size.Location = new System.Drawing.Point(720, 301);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(377, 25);
            this.lbl_size.TabIndex = 2;
            this.lbl_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_display
            // 
            this.lbl_display.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_display.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_display.Location = new System.Drawing.Point(720, 326);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(377, 25);
            this.lbl_display.TabIndex = 2;
            this.lbl_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ram
            // 
            this.lbl_ram.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ram.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_ram.Location = new System.Drawing.Point(720, 351);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(130, 25);
            this.lbl_ram.TabIndex = 2;
            this.lbl_ram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_name.Location = new System.Drawing.Point(720, 276);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(377, 25);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_company
            // 
            this.lbl_company.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_company.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_company.Location = new System.Drawing.Point(967, 351);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(130, 25);
            this.lbl_company.TabIndex = 2;
            this.lbl_company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(847, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "제조사";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_bat
            // 
            this.lbl_bat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_bat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_bat.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_bat.Location = new System.Drawing.Point(720, 376);
            this.lbl_bat.Name = "lbl_bat";
            this.lbl_bat.Size = new System.Drawing.Size(130, 25);
            this.lbl_bat.TabIndex = 2;
            this.lbl_bat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_os
            // 
            this.lbl_os.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_os.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_os.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_os.Location = new System.Drawing.Point(967, 376);
            this.lbl_os.Name = "lbl_os";
            this.lbl_os.Size = new System.Drawing.Size(130, 25);
            this.lbl_os.TabIndex = 2;
            this.lbl_os.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(600, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "배터리";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(847, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "os";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(600, 426);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "저장공간";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(847, 426);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 25);
            this.label17.TabIndex = 2;
            this.label17.Text = "색상";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_price
            // 
            this.lbl_price.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_price.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_price.Location = new System.Drawing.Point(720, 451);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(377, 25);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(600, 451);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "가격";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_backcamera
            // 
            this.lbl_backcamera.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_backcamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_backcamera.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_backcamera.Location = new System.Drawing.Point(720, 401);
            this.lbl_backcamera.Name = "lbl_backcamera";
            this.lbl_backcamera.Size = new System.Drawing.Size(130, 25);
            this.lbl_backcamera.TabIndex = 2;
            this.lbl_backcamera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_frontcamera
            // 
            this.lbl_frontcamera.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_frontcamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_frontcamera.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_frontcamera.Location = new System.Drawing.Point(967, 401);
            this.lbl_frontcamera.Name = "lbl_frontcamera";
            this.lbl_frontcamera.Size = new System.Drawing.Size(130, 25);
            this.lbl_frontcamera.TabIndex = 2;
            this.lbl_frontcamera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(600, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "후면카메라";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(847, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "전면카메라";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 580);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.combo_size);
            this.Controls.Add(this.combo_search);
            this.Controls.Add(this.combo_color);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_frontcamera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_os);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_backcamera);
            this.Controls.Add(this.lbl_company);
            this.Controls.Add(this.lbl_bat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_ram);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.Grid_phone);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "구매";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_phone;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구매ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 통계ToolStripMenuItem;
        private System.Windows.Forms.ComboBox combo_color;
        private System.Windows.Forms.ComboBox combo_size;
        private System.Windows.Forms.ComboBox combo_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ToolStripMenuItem 등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 입력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_display;
        private System.Windows.Forms.Label lbl_ram;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_company;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_bat;
        private System.Windows.Forms.Label lbl_os;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_backcamera;
        private System.Windows.Forms.Label lbl_frontcamera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_made;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_ram;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_bat;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_display;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_backcamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_frontcamera;
    }
}

