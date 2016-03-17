﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoWorkload
{
    public partial class ConfigForm : Form
    {

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            this.tbConnectionString.Text = Program.CONN_STR;
            this.TransactionCount.Value = Program.TRANSACTION_COUNT;
            this.ThreadCount.Value = Program.THREAD_COUNT;
            this.ReadsPerWrite.Value = Program.READS_PER_WRITE;
            this.RequestCount.Value = Program.REQUEST_COUNT;
            this.RowCount.Value = Program.ROW_COUNT;
            this.txtMaxLatch.Text = Program.MAX_LATCH_WAIT.ToString();
            this.txtMaxTPS.Text = Program.MAX_TPS.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.THREAD_COUNT = (int)this.ThreadCount.Value;
            Program.READS_PER_WRITE = (int)this.ReadsPerWrite.Value;
            Program.REQUEST_COUNT = (int)this.RequestCount.Value;
            Program.ROW_COUNT = (int)this.RowCount.Value;
            Program.TRANSACTION_COUNT = (int)this.TransactionCount.Value;
            Program.CONN_STR = this.tbConnectionString.Text;
            Program.MAX_TPS = Convert.ToInt32(this.txtMaxTPS.Text);
            Program.MAX_LATCH_WAIT = Convert.ToInt32(this.txtMaxLatch.Text);
            // Program.CONN_STR = string.Format("Server={0};Initial Catalog={1};Integrated Security=True", ".\\" + Program.INSTANCE_NAME, Program.DB_NAME);
        }

        private void tbInstance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}