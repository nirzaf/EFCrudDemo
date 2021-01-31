using EFCrudDEMO.DAL;
using EFCrudDEMO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCrudDEMO
{
    public partial class Form1 : Form
    {
        CallRepo cr = new CallRepo();
        Call calls = new Call();
        private int CallId;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calls.MobileNumber = TxtMobile.Text.Trim();
            cr.Create(calls);
            LoadDGV();
        }

        private void LoadDGV()
        {
            DGVCalls.DataSource = cr.View();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void DGVCalls_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            calls.CallID = Convert.ToInt32(DGVCalls.SelectedRows[0].Cells[1].Value.ToString());
            calls.MobileNumber = DGVCalls.SelectedRows[0].Cells[1].Value.ToString();
            CallId = calls.CallID;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            cr.Update(CallId);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            cr.Delete(CallId);
            LoadDGV();
        }
    }
}
