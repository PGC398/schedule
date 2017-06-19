using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormEdit : Form
    {
        public TimeTable TimeTable { get; set; }
        DBDataContext db = new DBDataContext();

        public FormEdit()
        {
            InitializeComponent();
            Load += FormEdit_load;     
        }

        void FormEdit_load(object sender, EventArgs e)
        {
            BoundType();
            BoundTimeTable();
        }

        private void BoundTimeTable()
        {
            if (TimeTable == null) return;
            try
            {
                txtTitle.Text = TimeTable.Title;
                txtAdress.Text = TimeTable.Address;
                cboType.SelectedValue = TimeTable.TypeId;
                dtBeginTime.Value = Convert.ToDateTime(TimeTable.BeginTime);
                dtEndTime.Value = Convert.ToDateTime(TimeTable.EndTime);
                txtContent.Rtf = TimeTable.MainContent;
                cbStatus.Checked = Convert.ToBoolean(TimeTable.IsFinished);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }            
        }

        private void BoundType()
        {
            cboType.DataSource = db.Types.ToList();
            cboType.DisplayMember = "Name";
            cboType.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TimeTable == null) 
            {
                if (txtTitle.Text.Trim() == string.Empty || txtAdress.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("请输入完整信息","警告");
                    return;
                }
                db.TimeTables.InsertOnSubmit(new TimeTable
                    {
                        Title=txtTitle.Text,
                        Address=txtAdress.Text,
                        TypeId=Convert.ToInt32(cboType.SelectedValue),
                        BeginTime=dtBeginTime.Value,
                        EndTime=dtEndTime.Value,
                        MainContent=txtContent.Rtf,
                        IsFinished=cbStatus.Checked
                    });               
            }
            else
            {
                if (txtTitle.Text.Trim() == string.Empty || txtAdress.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("请输入完整信息", "警告");
                    return;
                }
                var item = db.TimeTables.FirstOrDefault(t => t.Id == TimeTable.Id);
                item.Title=txtTitle.Text;
                item.Address=txtAdress.Text;
                item.TypeId=Convert.ToInt32(cboType.SelectedValue);
                item.BeginTime=dtBeginTime.Value;
                item.EndTime=dtEndTime.Value;
                item.MainContent=txtContent.Rtf;
                item.IsFinished=cbStatus.Checked;
            }
            db.SubmitChanges();
            this.Close();

            new System.Threading.Thread(() =>
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
            }).Start();

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new System.Threading.Thread(() =>
            { 
                Form1 frm = new Form1();
                frm.ShowDialog();
            }).Start();

        }      
    }
}
