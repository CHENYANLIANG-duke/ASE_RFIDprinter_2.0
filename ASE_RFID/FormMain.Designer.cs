namespace ASE_RFID
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTapeType = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtVenderLot = new System.Windows.Forms.TextBox();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.txtASENo = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.venderdata = new System.Windows.Forms.TextBox();
            this.tapedata = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radinch_8 = new System.Windows.Forms.RadioButton();
            this.radinch_12 = new System.Windows.Forms.RadioButton();
            this.labInch = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrint.Location = new System.Drawing.Point(709, 255);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 52);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(359, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tape Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(359, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exp Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(359, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vender Lot:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(359, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Part no:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(359, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "ASE No:";
            // 
            // txtTapeType
            // 
            this.txtTapeType.BackColor = System.Drawing.Color.White;
            this.txtTapeType.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTapeType.Location = new System.Drawing.Point(464, 66);
            this.txtTapeType.Name = "txtTapeType";
            this.txtTapeType.Size = new System.Drawing.Size(339, 30);
            this.txtTapeType.TabIndex = 0;
            this.txtTapeType.Text = "NEX-130E4X-12-60-U1";
            this.txtTapeType.TextChanged += new System.EventHandler(this.txtTapeType_TextChanged);
            this.txtTapeType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTapeType_KeyDown);
            this.txtTapeType.Leave += new System.EventHandler(this.txtTapeType_Leave);
            this.txtTapeType.Enter += new System.EventHandler(this.txtTapeType_Enter);
            // 
            // txtExpDate
            // 
            this.txtExpDate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtExpDate.Location = new System.Drawing.Point(464, 102);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(339, 30);
            this.txtExpDate.TabIndex = 1;
            this.txtExpDate.Text = "20161103";
            this.txtExpDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpDate_KeyDown);
            this.txtExpDate.Leave += new System.EventHandler(this.txtExpDate_Leave);
            this.txtExpDate.Enter += new System.EventHandler(this.txtExpDate_Enter);
            // 
            // txtVenderLot
            // 
            this.txtVenderLot.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtVenderLot.Location = new System.Drawing.Point(464, 141);
            this.txtVenderLot.Name = "txtVenderLot";
            this.txtVenderLot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVenderLot.Size = new System.Drawing.Size(339, 30);
            this.txtVenderLot.TabIndex = 2;
            this.txtVenderLot.Text = "5B0403H1-2";
            this.txtVenderLot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVenderLot_KeyDown);
            this.txtVenderLot.Leave += new System.EventHandler(this.txtVenderLot_Leave);
            this.txtVenderLot.Enter += new System.EventHandler(this.txtVenderLot_Enter);
            // 
            // txtPartNo
            // 
            this.txtPartNo.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPartNo.Location = new System.Drawing.Point(464, 180);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(339, 30);
            this.txtPartNo.TabIndex = 3;
            this.txtPartNo.Text = "1500044112";
            this.txtPartNo.TextChanged += new System.EventHandler(this.txtPartNo_TextChanged);
            this.txtPartNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPartNo_KeyDown);
            this.txtPartNo.Leave += new System.EventHandler(this.txtPartNo_Leave);
            this.txtPartNo.Enter += new System.EventHandler(this.txtPartNo_Enter);
            // 
            // txtASENo
            // 
            this.txtASENo.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtASENo.Location = new System.Drawing.Point(464, 219);
            this.txtASENo.Name = "txtASENo";
            this.txtASENo.Size = new System.Drawing.Size(339, 30);
            this.txtASENo.TabIndex = 4;
            this.txtASENo.Text = "1500044112";
            this.txtASENo.TextChanged += new System.EventHandler(this.txtASENo_TextChanged);
            this.txtASENo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtASENo_KeyDown);
            this.txtASENo.Leave += new System.EventHandler(this.txtASENo_Leave);
            this.txtASENo.Enter += new System.EventHandler(this.txtASENo_Enter);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(593, 273);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clean all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // venderdata
            // 
            this.venderdata.Location = new System.Drawing.Point(176, 50);
            this.venderdata.Multiline = true;
            this.venderdata.Name = "venderdata";
            this.venderdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.venderdata.Size = new System.Drawing.Size(155, 232);
            this.venderdata.TabIndex = 8;
            // 
            // tapedata
            // 
            this.tapedata.Location = new System.Drawing.Point(6, 50);
            this.tapedata.Multiline = true;
            this.tapedata.Name = "tapedata";
            this.tapedata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tapedata.Size = new System.Drawing.Size(155, 234);
            this.tapedata.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_save.Location = new System.Drawing.Point(421, 273);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(166, 33);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "儲存比對資料";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tapedata);
            this.groupBox1.Controls.Add(this.venderdata);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 301);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "比對資料";
            // 
            // radinch_8
            // 
            this.radinch_8.AutoSize = true;
            this.radinch_8.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radinch_8.Location = new System.Drawing.Point(675, 16);
            this.radinch_8.Name = "radinch_8";
            this.radinch_8.Size = new System.Drawing.Size(48, 28);
            this.radinch_8.TabIndex = 13;
            this.radinch_8.Text = "8\"";
            this.radinch_8.UseVisualStyleBackColor = true;
            this.radinch_8.CheckedChanged += new System.EventHandler(this.radinch_8_CheckedChanged);
            // 
            // radinch_12
            // 
            this.radinch_12.AutoSize = true;
            this.radinch_12.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radinch_12.Location = new System.Drawing.Point(729, 16);
            this.radinch_12.Name = "radinch_12";
            this.radinch_12.Size = new System.Drawing.Size(59, 28);
            this.radinch_12.TabIndex = 14;
            this.radinch_12.Text = "12\"";
            this.radinch_12.UseVisualStyleBackColor = true;
            this.radinch_12.CheckedChanged += new System.EventHandler(this.radinch_12_CheckedChanged);
            // 
            // labInch
            // 
            this.labInch.AutoSize = true;
            this.labInch.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInch.Location = new System.Drawing.Point(376, 16);
            this.labInch.Name = "labInch";
            this.labInch.Size = new System.Drawing.Size(58, 24);
            this.labInch.TabIndex = 15;
            this.labInch.Text = "吋別";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(2, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tape Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(172, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Part\\ASE No:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(359, 282);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(51, 22);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 319);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labInch);
            this.Controls.Add(this.radinch_12);
            this.Controls.Add(this.radinch_8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtASENo);
            this.Controls.Add(this.txtPartNo);
            this.Controls.Add(this.txtVenderLot);
            this.Controls.Add(this.txtExpDate);
            this.Controls.Add(this.txtTapeType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASE Wafer Tape  Tag v2.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTapeType;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.TextBox txtVenderLot;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.TextBox txtASENo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox venderdata;
        private System.Windows.Forms.TextBox tapedata;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radinch_8;
        private System.Windows.Forms.RadioButton radinch_12;
        private System.Windows.Forms.Label labInch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

