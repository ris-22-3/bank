﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class HistoryTransfers : Form
    {
        public HistoryTransfers()
        {
            InitializeComponent();
        }
        byte isRubUsdOrTng = 0;

        public void FillTable()
        {
            dataGridView_all.Rows.Clear();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            if (isRubUsdOrTng == 1)
            {
                Objects.current = Objects.user.rub;
                for (int i = 0; i < Objects.current.history.Count; i++)
                {
                    DataGridViewRow row = AddRow(Objects.current.history[i]);
                    rows.Add(row);
                }
            }
            if (isRubUsdOrTng == 2)
            {
                Objects.current = Objects.user.usd;
                for (int i = 0; i < Objects.current.history.Count; i++)
                {
                    DataGridViewRow row = AddRow(Objects.current.history[i]);
                    rows.Add(row);
                }
            }
            if (isRubUsdOrTng == 3)
            {
                Objects.current = Objects.user.tenge;
                for (int i = 0; i < Objects.current.history.Count; i++)
                {
                    DataGridViewRow row = AddRow(Objects.current.history[i]);
                    rows.Add(row);
                }
            }
            rows.Reverse();
            dataGridView_all.Rows.AddRange(rows.ToArray());
            dataGridView_all.Refresh();
        }
        public DataGridViewRow AddRow(Operation op)
        {
            DataGridViewRow row = new DataGridViewRow();
                string day = "";
                if (op.date.Day < 10)
                    day = "0";
                day += op.date.Day.ToString();
                string month = "";
                if (op.date.Month < 10)
                    month = "0";
                month += op.date.Month.ToString();
                string dateStr = day + "." + month + "." + op.date.Year.ToString();
                DataGridViewCell date = new DataGridViewTextBoxCell();
                date.Value = dateStr;

                DataGridViewCell billeType = new DataGridViewTextBoxCell();
                billeType.Value = op.billetype;

                DataGridViewCell sum = new DataGridViewTextBoxCell();
                sum.Value = op.sum.ToString();
                DataGridViewCell type = new DataGridViewTextBoxCell();
                type.Value = op.type;
                row.Cells.AddRange(date, billeType, sum, type);
            return row;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WelcomeForm().ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WelcomeForm().ShowDialog();
            this.Close();
        }

        private void rubButton_Click(object sender, EventArgs e)
        {
            rubButton.FlatStyle = FlatStyle.Standard;
            usdButton.FlatStyle = FlatStyle.Flat;
            tngButton.FlatStyle = FlatStyle.Flat;
            isRubUsdOrTng = 1;
            FillTable();
        }

        private void usdButton_Click(object sender, EventArgs e)
        {
            rubButton.FlatStyle = FlatStyle.Flat;
            usdButton.FlatStyle = FlatStyle.Standard;
            tngButton.FlatStyle = FlatStyle.Flat;
            isRubUsdOrTng = 2;
            FillTable();
        }

        private void tngButton_Click(object sender, EventArgs e)
        {
            rubButton.FlatStyle = FlatStyle.Flat;
            usdButton.FlatStyle = FlatStyle.Flat;
            tngButton.FlatStyle = FlatStyle.Standard;
            isRubUsdOrTng = 3;
            FillTable();
        }

        private void HistoryTransfers_Shown(object sender, EventArgs e)
        {
            if (CurrencyAccountForm.historyRubUsdOrTng == 1)
            {
                rubButton.PerformClick();
            }
            if (CurrencyAccountForm.historyRubUsdOrTng == 2)
            {
                usdButton.PerformClick();
            }
            if (CurrencyAccountForm.historyRubUsdOrTng == 3)
            {
                tngButton.PerformClick();
            }
        }
    }
}
