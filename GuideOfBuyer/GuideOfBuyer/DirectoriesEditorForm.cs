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
    public partial class DirectoriesEditorForm : Form
    {
        public DirectoriesEditorForm()
        {
            InitializeComponent();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            DataManager.SaveTypeOfOwnership();
            DataManager.SaveSpecialization();
        }

        private void butReload_Click(object sender, EventArgs e)
        {
            lvToo.Items.Clear();
            lvSpec.Items.Clear();

            DataManager.LoadTypeOfOwnership();
            DataManager.LoadSpecialization();

            InitData();
        }

        private void DirectoriesEditorForm_Shown(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            foreach (var data in DataManager.TypeOfOwnerships)
            {
                lvToo.Items.Add(new ListViewItem(new string[] {data.Id.ToString(), data.Name}));
            }

            foreach (var data in DataManager.Specializations)
            {
                lvSpec.Items.Add(new ListViewItem(new string[] { data.Id.ToString(), data.Name }));
            }
        }

        #region Specialization

        private void butSpecAdd_Click(object sender, EventArgs e)
        {
            var data = DirectoryItemEditorForm.AddSpec();
            if (data != null)
            {
                DataManager.Specializations.Add(data);
                lvSpec.Items.Add(new ListViewItem(new string[] { data.Id.ToString(), data.Name }));
            }
        }

        private void butSpecEdit_Click(object sender, EventArgs e)
        {
            EditSpec();
        }

        private void butSpecDelete_Click(object sender, EventArgs e)
        {
            if (lvSpec.Items == null || lvSpec.Items.Count == 0)
            {
                return;
            }
            string txtId;
            string txt;
            if (lvSpec.SelectedItems == null || lvSpec.SelectedItems.Count == 0)
            {
                lvSpec.Items[0].Selected = true;
                txtId = lvSpec.Items[0].Text;
                txt = string.Format("Are you delete record '{0}. {1}'", txtId, lvSpec.Items[0].SubItems[1].Text);
            }
            else
            {
                txtId = lvSpec.SelectedItems[0].Text;
                txt = string.Format("Are you delete record '{0}. {1}'", txtId, lvSpec.SelectedItems[0].SubItems[1].Text);
            }
            if (MessageBox.Show(txt, "Delete specialization", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < lvSpec.Items.Count; i++)
                {
                    if (lvSpec.Items[i].Text == txtId)
                    {
                        DataManager.SpecDelete(Convert.ToInt32(txtId));
                        lvSpec.Items.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void lvSpec_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditSpec();
        }

        private void EditSpec()
        {
            if (lvSpec.Items == null || lvSpec.Items.Count == 0)
            {
                return;
            }
            string txtId;
            string txt;
            if (lvSpec.SelectedItems == null || lvSpec.SelectedItems.Count == 0)
            {
                lvSpec.Items[0].Selected = true;
                txtId = lvSpec.Items[0].Text;
                txt = lvSpec.Items[0].SubItems[1].Text;
            }
            else
            {
                txtId = lvSpec.SelectedItems[0].Text;
                txt = lvSpec.SelectedItems[0].SubItems[1].Text;
            }

            for (var i = 0; i < lvSpec.Items.Count; i++)
            {
                if (lvSpec.Items[i].Text == lvSpec.SelectedItems[0].Text)
                {
                    var obj = new Specialization(Convert.ToInt32(txtId), txt);
                    var data = DirectoryItemEditorForm.EditSpec(obj);
                    DataManager.SpecEdit(data);
                    lvSpec.SelectedItems[0].SubItems[1].Text = data.Name;
                    break;
                }
            }
        }

        #endregion

        #region Type of ownership

        private void butTooAdd_Click(object sender, EventArgs e)
        {
            var data = DirectoryItemEditorForm.AddToo();
            if (data != null)
            {
                DataManager.TypeOfOwnerships.Add(data);
                lvToo.Items.Add(new ListViewItem(new string[] { data.Id.ToString(), data.Name }));
            }
        }

        private void butTooEdit_Click(object sender, EventArgs e)
        {
            EditToo();
        }

        private void butTooDelete_Click(object sender, EventArgs e)
        {
            if (lvToo.Items == null || lvToo.Items.Count == 0)
            {
                return;
            }
            string txtId;
            string txt;
            if (lvToo.SelectedItems == null || lvToo.SelectedItems.Count == 0)
            {
                lvSpec.Items[0].Selected = true;
                txtId = lvToo.Items[0].Text;
                txt = string.Format("Are you delete record '{0}. {1}'", txtId, lvToo.Items[0].SubItems[1].Text);
            }
            else
            {
                txtId = lvToo.SelectedItems[0].Text;
                txt = string.Format("Are you delete record '{0}. {1}'", txtId, lvToo.SelectedItems[0].SubItems[1].Text);
            }
            if (MessageBox.Show(txt, "Delete type of ownership", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < lvToo.Items.Count; i++)
                {
                    if (lvToo.Items[i].Text == txtId)
                    {
                        DataManager.TooDelete(Convert.ToInt32(txtId));
                        lvToo.Items.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void lvToo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditToo();
        }

        private void EditToo()
        {
            if (lvToo.Items == null || lvToo.Items.Count == 0)
            {
                return;
            }
            string txtId;
            string txt;
            if (lvToo.SelectedItems == null || lvToo.SelectedItems.Count == 0)
            {
                lvSpec.Items[0].Selected = true;
                txtId = lvToo.Items[0].Text;
                txt = lvToo.Items[0].SubItems[1].Text;
            }
            else
            {
                txtId = lvToo.SelectedItems[0].Text;
                txt = lvToo.SelectedItems[0].SubItems[1].Text;
            }

            for (var i = 0; i < lvToo.Items.Count; i++)
            {
                if (lvToo.Items[i].Text == txtId)
                {
                    var obj = new TypeOfOwnership(Convert.ToInt32(txtId), txt);
                    var data = DirectoryItemEditorForm.EditToo(obj);
                    DataManager.TooEdit(data);
                    lvToo.SelectedItems[0].SubItems[1].Text = data.Name;
                    break;
                }
            }
        }

        #endregion
    }
}
