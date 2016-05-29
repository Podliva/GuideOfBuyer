using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GuideOfBuyer.Bll.Data;

namespace GuideOfBuyer
{
    public partial class DirectoryItemEditorForm : Form
    {
        public DirectoryItemEditorForm()
        {
            InitializeComponent();
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
            }
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        public static TypeOfOwnership AddToo()
        {
            var win  = new DirectoryItemEditorForm();
            var id = DataManager.TooGetNewId();
            win.lbId.Text = id.ToString();
            if (win.ShowDialog() == DialogResult.OK)
            {
                var obj = new TypeOfOwnership(Convert.ToInt32(win.lbId.Text), win.tbName.Text);
                return obj;
            }
            return null;
        }

        public static TypeOfOwnership EditToo(TypeOfOwnership data)
        {
            var win = new DirectoryItemEditorForm
            {
                lbId = {Text = data.Id.ToString()},
                tbName = {Text = data.Name}
            };
            if (win.ShowDialog() == DialogResult.OK)
            {
                var obj = new TypeOfOwnership(Convert.ToInt32(win.lbId.Text), win.tbName.Text);
                return obj;
            }
            return data;
        }

        public static Specialization AddSpec()
        {
            var win  = new DirectoryItemEditorForm();
            var id = DataManager.SpecGetNewId();
            win.lbId.Text = id.ToString();
            if (win.ShowDialog() == DialogResult.OK)
            {
                var obj = new Specialization(Convert.ToInt32(win.lbId.Text), win.tbName.Text);
                return obj;
            }
            return null;
        }

        public static Specialization EditSpec(Specialization data)
        {
            var win = new DirectoryItemEditorForm
            {
                lbId = {Text = data.Id.ToString()},
                tbName = {Text = data.Name}
            };
            if (win.ShowDialog() == DialogResult.OK)
            {
                var obj = new Specialization(Convert.ToInt32(win.lbId.Text), win.tbName.Text);
                return obj;
            }

            return data;
        }
    }
}
