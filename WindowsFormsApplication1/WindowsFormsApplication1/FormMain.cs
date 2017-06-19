using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        DBDataContext db = new DBDataContext();

        public Form1()
        {
            InitializeComponent();
            Closed += new EventHandler(Form1_Closed);
            Load += new EventHandler(Form1_Load);
        }

        void Form1_Load(object sender, EventArgs e)
        {
            BoundTpye();
            BoundItems();
        }

        private void BoundItems()
        {
            dgvitems.DataSource = db.TimeTables
                .Where(item=>item.Title.Contains(txtTitle.Text))
                .Where(item=>cboType.SelectedIndex==0?true : item.TypeId==Convert.ToInt32(cboType.SelectedValue))//如果下拉列表==0，直接true；不为0，则将选择的值传给typeid
                .Where(item=>rbAll.Checked?true : item.IsFinished==Convert.ToBoolean(cboIsFinished.Checked))
                .Select(item=>new
                {
                    编号 = item.Id,
                    标题 = item.Title,
                    分类 = item.Type.Name,
                    开始时间 = item.BeginTime,
                    结束时间 = item.EndTime,
                    状态 = Convert.ToBoolean(item.IsFinished)?"已完成" : "未完成",
                }).ToList();
        }

        private void BoundTpye()
        {
            var types = db.Types.ToList();
            types.Insert(0, new Type { Id = 0, Name = "全部" });
            cboType.DataSource=types;
            cboType.DisplayMember="Name";
            cboType.ValueMember="Id";
        }


        void Form1_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoundItems();                                
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 新建项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new System.Threading.Thread(() =>
                {
                    FormEdit frm = new FormEdit { TimeTable = null };
                    frm.ShowDialog();
                }).Start();
            
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(() =>
                {
                    if (dgvitems.SelectedRows.Count > 0)
                    {
                        var id = Convert.ToInt32(dgvitems.SelectedRows[0].Cells[0].Value);
                        var item = db.TimeTables.FirstOrDefault(t => t.Id == id);
                        FormEdit frm = new FormEdit { TimeTable = item };
                        frm.ShowDialog();
                    }
                }).Start();
            this.Close();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvitems.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(dgvitems.SelectedRows[0].Cells[0].Value);
                var item = db.TimeTables.FirstOrDefault(t => t.Id == id);
                db.TimeTables.DeleteOnSubmit(item);
                db.SubmitChanges();
                BoundItems();
            }
        }
    }
}
