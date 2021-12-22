namespace Auroterm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bt_Properties = new System.Windows.Forms.ToolStripLabel();
            this.bt_SerialPort = new System.Windows.Forms.ToolStripLabel();
            this.bt_MCT8132PTable = new System.Windows.Forms.ToolStripLabel();
            this.bt_ToolBox = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_Properties,
            this.bt_SerialPort,
            this.bt_MCT8132PTable,
            this.bt_ToolBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(695, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bt_Properties
            // 
            this.bt_Properties.Name = "bt_Properties";
            this.bt_Properties.Size = new System.Drawing.Size(64, 22);
            this.bt_Properties.Text = "Properties";
            this.bt_Properties.Click += new System.EventHandler(this.bt_Properties_Click);
            // 
            // bt_SerialPort
            // 
            this.bt_SerialPort.Name = "bt_SerialPort";
            this.bt_SerialPort.Size = new System.Drawing.Size(61, 22);
            this.bt_SerialPort.Text = "SerialPort";
            this.bt_SerialPort.Click += new System.EventHandler(this.bt_SerialPort_Click);
            // 
            // bt_MCT8132PTable
            // 
            this.bt_MCT8132PTable.Name = "bt_MCT8132PTable";
            this.bt_MCT8132PTable.Size = new System.Drawing.Size(45, 22);
            this.bt_MCT8132PTable.Text = " Table ";
            this.bt_MCT8132PTable.Click += new System.EventHandler(this.bt_MCT8132PTable_Click);
            // 
            // bt_ToolBox
            // 
            this.bt_ToolBox.Name = "bt_ToolBox";
            this.bt_ToolBox.Size = new System.Drawing.Size(54, 22);
            this.bt_ToolBox.Text = "ToolBox";
            this.bt_ToolBox.Click += new System.EventHandler(this.bt_ToolBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 561);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Auroterm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel bt_Properties;
        private System.Windows.Forms.ToolStripLabel bt_SerialPort;
        private System.Windows.Forms.ToolStripLabel bt_MCT8132PTable;
        private System.Windows.Forms.ToolStripLabel bt_ToolBox;
    }
}

