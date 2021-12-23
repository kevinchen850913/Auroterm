namespace Auroterm
{
    partial class Form_Properties
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_FileSave = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_SerialPort_Open = new System.Windows.Forms.Button();
            this.bt_SerialPort_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_PortName = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_textBoxFont = new System.Windows.Forms.Button();
            this.bt_textBoxBackColor = new System.Windows.Forms.Button();
            this.bt_textBoxForeColor = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Size = new System.Drawing.Size(660, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SerialPort";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel15, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_PortName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 33);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 126);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 4;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.Controls.Add(this.bt_FileSave, 3, 0);
            this.tableLayoutPanel11.Controls.Add(this.bt_Clear, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.bt_SerialPort_Open, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.bt_SerialPort_Close, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(120, 41);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(526, 41);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // bt_FileSave
            // 
            this.bt_FileSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_FileSave.Location = new System.Drawing.Point(399, 5);
            this.bt_FileSave.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_FileSave.Name = "bt_FileSave";
            this.bt_FileSave.Size = new System.Drawing.Size(121, 31);
            this.bt_FileSave.TabIndex = 0;
            this.bt_FileSave.Text = "Save";
            this.bt_FileSave.UseVisualStyleBackColor = true;
            this.bt_FileSave.Click += new System.EventHandler(this.bt_FileSave_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Clear.Location = new System.Drawing.Point(268, 5);
            this.bt_Clear.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(119, 31);
            this.bt_Clear.TabIndex = 1;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_SerialPort_Open
            // 
            this.bt_SerialPort_Open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_SerialPort_Open.Location = new System.Drawing.Point(6, 5);
            this.bt_SerialPort_Open.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_SerialPort_Open.Name = "bt_SerialPort_Open";
            this.bt_SerialPort_Open.Size = new System.Drawing.Size(119, 31);
            this.bt_SerialPort_Open.TabIndex = 2;
            this.bt_SerialPort_Open.Text = "Open";
            this.bt_SerialPort_Open.UseVisualStyleBackColor = true;
            this.bt_SerialPort_Open.Click += new System.EventHandler(this.bt_SerialPort_Open_Click);
            // 
            // bt_SerialPort_Close
            // 
            this.bt_SerialPort_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_SerialPort_Close.Location = new System.Drawing.Point(137, 5);
            this.bt_SerialPort_Close.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_SerialPort_Close.Name = "bt_SerialPort_Close";
            this.bt_SerialPort_Close.Size = new System.Drawing.Size(119, 31);
            this.bt_SerialPort_Close.TabIndex = 3;
            this.bt_SerialPort_Close.Text = "Close";
            this.bt_SerialPort_Close.UseVisualStyleBackColor = true;
            this.bt_SerialPort_Close.Click += new System.EventHandler(this.bt_SerialPort_Close_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "PortName";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_PortName
            // 
            this.cmb_PortName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_PortName.FormattingEnabled = true;
            this.cmb_PortName.Location = new System.Drawing.Point(127, 7);
            this.cmb_PortName.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cmb_PortName.Name = "cmb_PortName";
            this.cmb_PortName.Size = new System.Drawing.Size(512, 29);
            this.cmb_PortName.TabIndex = 0;
            this.cmb_PortName.SelectedIndexChanged += new System.EventHandler(this.cmb_PortName_SelectedIndexChanged);
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 4;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel15.Controls.Add(this.bt_textBoxFont, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.bt_textBoxBackColor, 2, 0);
            this.tableLayoutPanel15.Controls.Add(this.bt_textBoxForeColor, 1, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(120, 82);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(526, 44);
            this.tableLayoutPanel15.TabIndex = 0;
            // 
            // bt_textBoxFont
            // 
            this.bt_textBoxFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_textBoxFont.Location = new System.Drawing.Point(6, 5);
            this.bt_textBoxFont.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_textBoxFont.Name = "bt_textBoxFont";
            this.bt_textBoxFont.Size = new System.Drawing.Size(119, 34);
            this.bt_textBoxFont.TabIndex = 3;
            this.bt_textBoxFont.Text = "Font";
            this.bt_textBoxFont.UseVisualStyleBackColor = true;
            this.bt_textBoxFont.Click += new System.EventHandler(this.bt_textBoxFont_Click);
            // 
            // bt_textBoxBackColor
            // 
            this.bt_textBoxBackColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_textBoxBackColor.Location = new System.Drawing.Point(268, 5);
            this.bt_textBoxBackColor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_textBoxBackColor.Name = "bt_textBoxBackColor";
            this.bt_textBoxBackColor.Size = new System.Drawing.Size(119, 34);
            this.bt_textBoxBackColor.TabIndex = 2;
            this.bt_textBoxBackColor.Text = "BackColor";
            this.bt_textBoxBackColor.UseVisualStyleBackColor = true;
            this.bt_textBoxBackColor.Click += new System.EventHandler(this.bt_textBoxBackColor_Click);
            // 
            // bt_textBoxForeColor
            // 
            this.bt_textBoxForeColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_textBoxForeColor.Location = new System.Drawing.Point(137, 5);
            this.bt_textBoxForeColor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_textBoxForeColor.Name = "bt_textBoxForeColor";
            this.bt_textBoxForeColor.Size = new System.Drawing.Size(119, 34);
            this.bt_textBoxForeColor.TabIndex = 1;
            this.bt_textBoxForeColor.Text = "ForeColor";
            this.bt_textBoxForeColor.UseVisualStyleBackColor = true;
            this.bt_textBoxForeColor.Click += new System.EventHandler(this.bt_textBoxForeColor_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(684, 201);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "TextBox";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 201);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Properties";
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.Form_Properties_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button bt_FileSave;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_SerialPort_Open;
        private System.Windows.Forms.Button bt_SerialPort_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_PortName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Button bt_textBoxFont;
        private System.Windows.Forms.Button bt_textBoxBackColor;
        private System.Windows.Forms.Button bt_textBoxForeColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
    }
}