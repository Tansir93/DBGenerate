﻿using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBOracleGenerate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            cbIsBuildIndex.Checked = false;
        }
        List<CreatTableRow> ls = new List<CreatTableRow>();
        List<CreateRowNameAndType> lstype=new List<CreateRowNameAndType>();
        List<string> lis=new List<string>() { "vachar2","number","int", "date" };
        private void BTAddRow_Click(object sender, EventArgs e)
        {
            
            if (ls.Count > 0)
            {
                foreach (CreatTableRow item in ls)
                {
                    this.pnDataSet.Controls.Remove(item.RowType);
                    this.pnDataSet.Controls.Remove(item.RowName);
                    this.pnDataSet.Controls.Remove(item.Num);
                }
            }
            ls.Clear();
            int AddRowCount = int.Parse(TBAddCount.Text);
          
            for (int i = 0; i < AddRowCount; i++)
            {
                TextBox tb=new TextBox();
                
                tb.Top = 20 + 30 * i;
                tb.Left = 0;

                Label lb = new Label();
                lb.Top = 20 + 30 * i;
                lb.Left = tb.Width+50 ;
                lb.Text ="第 "+ i+" 列";


                ComboBox cb=new ComboBox();
                cb.Top = 20 + 30 * i;
                cb.Left =  tb.Width+ lb.Left + 10;
                cb.DataSource =new List<string>(lis);


                this.pnDataSet.Controls.Add(tb);
                this.pnDataSet.Controls.Add(cb);
                this.pnDataSet.Controls.Add(lb);
                this.pnDataSet.Controls.Add(cb);
                CreatTableRow ctr = new CreatTableRow() { RowName = tb, RowType = cb, Num = lb};
                ls.Add(ctr);
            }
        }


        private void cbIsBuildIndex_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsBuildIndex.Checked)
            {
                cbBulidIndex.Enabled = true;
            }
            else
            {
                cbBulidIndex.Enabled = false;
            }
        }


        private void btConfirmField_Click(object sender, EventArgs e)
        {
            lstype.Clear();
            foreach (CreatTableRow item in ls)
            {
                if (item.RowName.Text == null || item.RowName.Text == string.Empty || item.RowType.Text == null || item.RowType.Text == string.Empty)
                {
                    LbMsg.Visible = true;   
                    LbMsg.Text = item.Num.Text + "不能为空.";
                    LbMsg.ForeColor=Color.Red;
                    return;
                }
                CreateRowNameAndType cnt = new CreateRowNameAndType();
                cnt.RowName = item.RowName.Text;
                cnt.RowType = item.RowType.SelectedValue.ToString();
                lstype.Add(cnt);
            }
            DataSourceBind<ComboBox>(cbBulidIndex, lstype);

            DataSourceBind<ComboBox>(cbPartitionField, lstype);

            DataSourceBind<ComboBox>(cnKeyName, lstype);

            LbMsg.Visible = false;
        }

        private void ckBulibPartition_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBulibPartition.Checked)
            {
                tbParitionCount.Enabled = true;
                cbPartitionField.Enabled = true;

            }
            else
            {
                tbParitionCount.Enabled = false;
                cbPartitionField.Enabled = false;
            }
        }

        private void cbBulidArray_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBulidArray.Checked)
            {
                cnKeyName.Enabled = true;
            }
            else
            {
                cnKeyName.Enabled = false;
            }
        }





    }

}
