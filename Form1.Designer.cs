namespace DicomFInder
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.dcmCountTxt = new System.Windows.Forms.Label();
            this.mcsCountTxt = new System.Windows.Forms.Label();
            this.stateTxt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxt_Birth = new System.Windows.Forms.TextBox();
            this.searchTxt_Date = new System.Windows.Forms.TextBox();
            this.searchTxt_Name = new System.Windows.Forms.TextBox();
            this.searchTxt_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTable = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(57, 28);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(356, 29);
            this.pathTextBox.TabIndex = 1;
            // 
            // pathBtn
            // 
            this.pathBtn.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pathBtn.Location = new System.Drawing.Point(419, 28);
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.Size = new System.Drawing.Size(35, 29);
            this.pathBtn.TabIndex = 2;
            this.pathBtn.Text = "...";
            this.pathBtn.UseVisualStyleBackColor = true;
            this.pathBtn.Click += new System.EventHandler(this.PathBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startBtn.Location = new System.Drawing.Point(6, 63);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(80, 40);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // dcmCountTxt
            // 
            this.dcmCountTxt.AutoSize = true;
            this.dcmCountTxt.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dcmCountTxt.Location = new System.Drawing.Point(286, 63);
            this.dcmCountTxt.Name = "dcmCountTxt";
            this.dcmCountTxt.Size = new System.Drawing.Size(112, 19);
            this.dcmCountTxt.TabIndex = 4;
            this.dcmCountTxt.Text = "DCM : 0 files";
            this.dcmCountTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mcsCountTxt
            // 
            this.mcsCountTxt.AutoSize = true;
            this.mcsCountTxt.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mcsCountTxt.Location = new System.Drawing.Point(286, 84);
            this.mcsCountTxt.Name = "mcsCountTxt";
            this.mcsCountTxt.Size = new System.Drawing.Size(112, 19);
            this.mcsCountTxt.TabIndex = 4;
            this.mcsCountTxt.Text = "MCS : 0 files";
            this.mcsCountTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateTxt
            // 
            this.stateTxt.AutoSize = true;
            this.stateTxt.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stateTxt.Location = new System.Drawing.Point(130, 74);
            this.stateTxt.Name = "stateTxt";
            this.stateTxt.Size = new System.Drawing.Size(119, 19);
            this.stateTxt.TabIndex = 5;
            this.stateTxt.Text = "Press Search";
            this.stateTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mcsCountTxt);
            this.groupBox1.Controls.Add(this.stateTxt);
            this.groupBox1.Controls.Add(this.dcmCountTxt);
            this.groupBox1.Controls.Add(this.pathTextBox);
            this.groupBox1.Controls.Add(this.pathBtn);
            this.groupBox1.Controls.Add(this.startBtn);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 115);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Files";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.searchTxt_Birth);
            this.groupBox2.Controls.Add(this.searchTxt_Date);
            this.groupBox2.Controls.Add(this.searchTxt_Name);
            this.groupBox2.Controls.Add(this.searchTxt_ID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(10, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 238);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search DCM";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(376, 54);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(78, 64);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // searchTxt_Birth
            // 
            this.searchTxt_Birth.Location = new System.Drawing.Point(245, 54);
            this.searchTxt_Birth.Name = "searchTxt_Birth";
            this.searchTxt_Birth.Size = new System.Drawing.Size(115, 29);
            this.searchTxt_Birth.TabIndex = 15;
            this.searchTxt_Birth.Tag = "birth";
            // 
            // searchTxt_Date
            // 
            this.searchTxt_Date.Location = new System.Drawing.Point(246, 89);
            this.searchTxt_Date.Name = "searchTxt_Date";
            this.searchTxt_Date.Size = new System.Drawing.Size(114, 29);
            this.searchTxt_Date.TabIndex = 14;
            // 
            // searchTxt_Name
            // 
            this.searchTxt_Name.Location = new System.Drawing.Point(67, 89);
            this.searchTxt_Name.Name = "searchTxt_Name";
            this.searchTxt_Name.Size = new System.Drawing.Size(115, 29);
            this.searchTxt_Name.TabIndex = 13;
            // 
            // searchTxt_ID
            // 
            this.searchTxt_ID.Location = new System.Drawing.Point(67, 54);
            this.searchTxt_ID.Name = "searchTxt_ID";
            this.searchTxt_ID.Size = new System.Drawing.Size(115, 29);
            this.searchTxt_ID.TabIndex = 12;
            this.searchTxt_ID.Tag = "name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "DICOM 데이터로부터 환자 정보 및 파일 위치를 검색합니다.";
            // 
            // resultTable
            // 
            this.resultTable.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.resultTable.AllowColumnReorder = true;
            this.resultTable.HideSelection = false;
            this.resultTable.Location = new System.Drawing.Point(6, 28);
            this.resultTable.Name = "resultTable";
            this.resultTable.Size = new System.Drawing.Size(448, 214);
            this.resultTable.TabIndex = 8;
            this.resultTable.UseCompatibleStateImageBehavior = false;
            this.resultTable.View = System.Windows.Forms.View.Details;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resultTable);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(10, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 248);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(395, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(500, 630);
            this.MinimumSize = new System.Drawing.Size(500, 630);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button pathBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label dcmCountTxt;
        private System.Windows.Forms.Label mcsCountTxt;
        private System.Windows.Forms.Label stateTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTxt_Birth;
        private System.Windows.Forms.TextBox searchTxt_Date;
        private System.Windows.Forms.TextBox searchTxt_Name;
        private System.Windows.Forms.TextBox searchTxt_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView resultTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button button1;
    }
}

