namespace DBOracleGenerate
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CreateTable = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cnKeyName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbBulidArray = new System.Windows.Forms.CheckBox();
            this.tbCreateTable = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ckBulibPartition = new System.Windows.Forms.CheckBox();
            this.cbPartitionField = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbParitionCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbBulidIndex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIsBuildIndex = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BTAddRow = new System.Windows.Forms.Button();
            this.TBAddCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnDataSet = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btConfirmField = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LbMsg = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.CreateTable.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnDataSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CreateTable);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // CreateTable
            // 
            this.CreateTable.Controls.Add(this.panel3);
            this.CreateTable.Controls.Add(this.label3);
            this.CreateTable.Controls.Add(this.label2);
            this.CreateTable.Controls.Add(this.pnDataSet);
            this.CreateTable.Location = new System.Drawing.Point(4, 22);
            this.CreateTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateTable.Name = "CreateTable";
            this.CreateTable.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateTable.Size = new System.Drawing.Size(602, 404);
            this.CreateTable.TabIndex = 0;
            this.CreateTable.Text = "数据库创建";
            this.CreateTable.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.tbCreateTable);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(453, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 384);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cnKeyName);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbBulidArray);
            this.panel2.Location = new System.Drawing.Point(2, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 64);
            this.panel2.TabIndex = 7;
            // 
            // cnKeyName
            // 
            this.cnKeyName.Enabled = false;
            this.cnKeyName.FormattingEnabled = true;
            this.cnKeyName.Location = new System.Drawing.Point(3, 36);
            this.cnKeyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cnKeyName.Name = "cnKeyName";
            this.cnKeyName.Size = new System.Drawing.Size(136, 20);
            this.cnKeyName.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "主键名：";
            // 
            // cbBulidArray
            // 
            this.cbBulidArray.AutoSize = true;
            this.cbBulidArray.Location = new System.Drawing.Point(4, 3);
            this.cbBulidArray.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBulidArray.Name = "cbBulidArray";
            this.cbBulidArray.Size = new System.Drawing.Size(72, 16);
            this.cbBulidArray.TabIndex = 0;
            this.cbBulidArray.Text = "建立序列";
            this.cbBulidArray.UseVisualStyleBackColor = true;
            this.cbBulidArray.CheckedChanged += new System.EventHandler(this.cbBulidArray_CheckedChanged);
            // 
            // tbCreateTable
            // 
            this.tbCreateTable.Location = new System.Drawing.Point(76, 341);
            this.tbCreateTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCreateTable.Name = "tbCreateTable";
            this.tbCreateTable.Size = new System.Drawing.Size(65, 30);
            this.tbCreateTable.TabIndex = 1;
            this.tbCreateTable.Text = "创建表";
            this.tbCreateTable.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.ckBulibPartition);
            this.panel5.Controls.Add(this.cbPartitionField);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.tbParitionCount);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(2, 198);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(142, 104);
            this.panel5.TabIndex = 6;
            // 
            // ckBulibPartition
            // 
            this.ckBulibPartition.AutoSize = true;
            this.ckBulibPartition.Location = new System.Drawing.Point(4, 3);
            this.ckBulibPartition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckBulibPartition.Name = "ckBulibPartition";
            this.ckBulibPartition.Size = new System.Drawing.Size(72, 16);
            this.ckBulibPartition.TabIndex = 4;
            this.ckBulibPartition.Text = "建立分区";
            this.ckBulibPartition.UseVisualStyleBackColor = true;
            this.ckBulibPartition.CheckedChanged += new System.EventHandler(this.ckBulibPartition_CheckedChanged);
            // 
            // cbPartitionField
            // 
            this.cbPartitionField.Enabled = false;
            this.cbPartitionField.FormattingEnabled = true;
            this.cbPartitionField.Location = new System.Drawing.Point(5, 77);
            this.cbPartitionField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPartitionField.Name = "cbPartitionField";
            this.cbPartitionField.Size = new System.Drawing.Size(133, 20);
            this.cbPartitionField.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "分区字段：";
            // 
            // tbParitionCount
            // 
            this.tbParitionCount.Enabled = false;
            this.tbParitionCount.Location = new System.Drawing.Point(5, 36);
            this.tbParitionCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbParitionCount.Name = "tbParitionCount";
            this.tbParitionCount.Size = new System.Drawing.Size(133, 21);
            this.tbParitionCount.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "分区数量：";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbBulidIndex);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cbIsBuildIndex);
            this.panel4.Location = new System.Drawing.Point(2, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(143, 64);
            this.panel4.TabIndex = 5;
            // 
            // cbBulidIndex
            // 
            this.cbBulidIndex.Enabled = false;
            this.cbBulidIndex.FormattingEnabled = true;
            this.cbBulidIndex.Location = new System.Drawing.Point(2, 38);
            this.cbBulidIndex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBulidIndex.Name = "cbBulidIndex";
            this.cbBulidIndex.Size = new System.Drawing.Size(135, 20);
            this.cbBulidIndex.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "索引列：";
            // 
            // cbIsBuildIndex
            // 
            this.cbIsBuildIndex.AutoSize = true;
            this.cbIsBuildIndex.Location = new System.Drawing.Point(4, 2);
            this.cbIsBuildIndex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbIsBuildIndex.Name = "cbIsBuildIndex";
            this.cbIsBuildIndex.Size = new System.Drawing.Size(72, 16);
            this.cbIsBuildIndex.TabIndex = 0;
            this.cbIsBuildIndex.Text = "建立索引";
            this.cbIsBuildIndex.UseVisualStyleBackColor = true;
            this.cbIsBuildIndex.CheckedChanged += new System.EventHandler(this.cbIsBuildIndex_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTAddRow);
            this.panel1.Controls.Add(this.TBAddCount);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 54);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "数据列数量：";
            // 
            // BTAddRow
            // 
            this.BTAddRow.Location = new System.Drawing.Point(84, 22);
            this.BTAddRow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTAddRow.Name = "BTAddRow";
            this.BTAddRow.Size = new System.Drawing.Size(55, 25);
            this.BTAddRow.TabIndex = 0;
            this.BTAddRow.Text = "新增列";
            this.BTAddRow.UseVisualStyleBackColor = true;
            this.BTAddRow.Click += new System.EventHandler(this.BTAddRow_Click);
            // 
            // TBAddCount
            // 
            this.TBAddCount.Location = new System.Drawing.Point(4, 22);
            this.TBAddCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBAddCount.Name = "TBAddCount";
            this.TBAddCount.Size = new System.Drawing.Size(76, 21);
            this.TBAddCount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "数据选择项：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "数据配置项：";
            // 
            // pnDataSet
            // 
            this.pnDataSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDataSet.Controls.Add(this.label8);
            this.pnDataSet.Controls.Add(this.label7);
            this.pnDataSet.Controls.Add(this.btConfirmField);
            this.pnDataSet.Location = new System.Drawing.Point(4, 17);
            this.pnDataSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnDataSet.Name = "pnDataSet";
            this.pnDataSet.Size = new System.Drawing.Size(444, 385);
            this.pnDataSet.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "类型名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "属性名：";
            // 
            // btConfirmField
            // 
            this.btConfirmField.Location = new System.Drawing.Point(365, 342);
            this.btConfirmField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btConfirmField.Name = "btConfirmField";
            this.btConfirmField.Size = new System.Drawing.Size(65, 30);
            this.btConfirmField.TabIndex = 0;
            this.btConfirmField.Text = "确认字段";
            this.btConfirmField.UseVisualStyleBackColor = true;
            this.btConfirmField.Click += new System.EventHandler(this.btConfirmField_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(602, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据操作";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(602, 404);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "存储过程";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LbMsg
            // 
            this.LbMsg.AutoSize = true;
            this.LbMsg.Location = new System.Drawing.Point(7, 451);
            this.LbMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbMsg.Name = "LbMsg";
            this.LbMsg.Size = new System.Drawing.Size(53, 12);
            this.LbMsg.TabIndex = 1;
            this.LbMsg.Text = "提示消息";
            this.LbMsg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 478);
            this.Controls.Add(this.LbMsg);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "数据库创建";
            this.tabControl1.ResumeLayout(false);
            this.CreateTable.ResumeLayout(false);
            this.CreateTable.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnDataSet.ResumeLayout(false);
            this.pnDataSet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CreateTable;
        private System.Windows.Forms.Button BTAddRow;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button tbCreateTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBAddCount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbPartitionField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbParitionCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbBulidIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbIsBuildIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnDataSet;
        private System.Windows.Forms.Button btConfirmField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LbMsg;
        private System.Windows.Forms.CheckBox ckBulibPartition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cnKeyName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbBulidArray;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

