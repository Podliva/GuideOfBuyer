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
    public partial class MainForm : Form
    {
        private bool flagStartApplication = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void butShowEditor_Click(object sender, EventArgs e)
        {
            pnEditor.Visible = !pnEditor.Visible;
        }

        private void butEditDirectories_Click(object sender, EventArgs e)
        {
            var win = new DirectoriesEditorForm();
            win.ShowDialog();

            InitData();
        }

        /// <summary>
        /// Метод вызывается при первом показе формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            DataManager.LoadTypeOfOwnership();
            DataManager.LoadSpecialization();

            DataManager.LoadFirm();

            InitData();
        }

        private void InitData()
        {
            flagStartApplication = true;

            cbSpect.Items.Clear();
            cbSpect.Items.Add(new Specialization(0, "None")); //Служебная запись показывающая что фильтр не задан
            if (DataManager.Specializations != null)
            {
                for (var i = 0; i < DataManager.Specializations.Count; i++)
                {
                    cbSpect.Items.Add(DataManager.Specializations[i]);
                }
            }
            cbSpect.SelectedIndex = 0;

            cbToo.Items.Clear();
            cbToo.Items.Add(new TypeOfOwnership(0, "None")); //Служебная запись показывающая что фильтр не задан
            if (DataManager.TypeOfOwnerships != null)
            {
                for (var i = 0; i < DataManager.TypeOfOwnerships.Count; i++)
                {
                    cbToo.Items.Add(DataManager.TypeOfOwnerships[i]);
                }
            }
            cbToo.SelectedIndex = 0;

            lvFirms.Items.Clear();
            foreach (Firm data in DataManager.Firms)
            {
                var lvi = CreateListViewItem(data);
                lvFirms.Items.Add(lvi);
            }

            flagStartApplication = false;
        }

        private static ListViewItem CreateListViewItem(Firm data)
        {
            var lvi = new ListViewItem(new string[]
            {
                data.Id.ToString(),
                data.Name,
                data.SpecName,
                data.TooName,
                data.TimeWork
            });
            lvi.Tag = data;
            return lvi;
        }

        private void butAddFirm_Click(object sender, EventArgs e)
        {
            var obj = FirmEditorForm.AddFirm();
            if (obj != null)
            {
                DataManager.Firms.Add(obj);
                DataManager.SaveFirm();

                lvFirms.Items.Add(CreateListViewItem(obj));
            }
        }

        private void butEditFirm_Click(object sender, EventArgs e)
        {
            EditFirm();
        }

        private void lvFirms_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditFirm();
        }

        private void EditFirm()
        {
            if (lvFirms.Items == null || lvFirms.Items.Count == 0)
            {
                return;
            }
            Firm data = null;
            if (lvFirms.SelectedItems == null || lvFirms.SelectedItems.Count == 0)
            {
                lvFirms.Items[0].Selected = true;
                data = (Firm)lvFirms.Items[0].Tag;
            }
            else
            {
                data = (Firm)lvFirms.SelectedItems[0].Tag;
            }

            var obj = FirmEditorForm.EditFirm(data);
            if (obj != null)
            {
                for (var i = 0; i < DataManager.Firms.Count; i++)
                {
                    if (DataManager.Firms[i].Id == obj.Id)
                    {
                        DataManager.Firms[i] = obj;
                        break;
                    }
                }
                DataManager.SaveFirm();

                for (var i = 0; i < lvFirms.Items.Count; i++)
                {
                    if (((Firm) lvFirms.Items[i].Tag).Id == obj.Id)
                    {
                        lvFirms.Items[i] = CreateListViewItem(obj);
                        break;
                    }
                }
            }
        }

        private void butDeleteFirm_Click(object sender, EventArgs e)
        {
            Firm data = null;
            if (lvFirms.SelectedItems == null || lvFirms.SelectedItems.Count == 0)
            {
                lvFirms.Items[0].Selected = true;
                data = (Firm)lvFirms.Items[0].Tag;
            }
            else
            {
                data = (Firm)lvFirms.SelectedItems[0].Tag;
            }

            if (MessageBox.Show(string.Format("Do you delete firm '{0}'", data.Name), "Delete firm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (var i = 0; i < DataManager.Firms.Count; i++)
                {
                    if (DataManager.Firms[i].Id == data.Id)
                    {
                        DataManager.Firms.RemoveAt(i);
                        break;
                    }
                }
                DataManager.SaveFirm();

                for (var i = 0; i < lvFirms.Items.Count; i++)
                {
                    if (((Firm)lvFirms.Items[i].Tag).Id == data.Id)
                    {
                        lvFirms.Items.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void lvFirms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFirms.SelectedItems == null || lvFirms.SelectedItems.Count == 0)
            {
                return;
            }
            var data = (Firm)lvFirms.SelectedItems[0].Tag;
            tbAddress.Text = data.Address;
            tbPhone.Text = data.Phones;
        }

        private void cbFiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoSearch();
            }
        }

        private void DoSearch()
        {
            if (flagStartApplication || cbSpect.SelectedItem == null || cbToo.SelectedItem == null)
            {
                return;
            }

            var specId = ((Specialization) cbSpect.SelectedItem).Id;
            var tooId = ((TypeOfOwnership)cbToo.SelectedItem).Id;
            var searchTxt = tbSearch.Text.ToUpper();

            lvFirms.Items.Clear();
            tbAddress.Text = string.Empty;
            tbPhone.Text = string.Empty;

            for (var i = 0; i < DataManager.Firms.Count; i++)
            {
                var data = DataManager.Firms[i];
                if (specId > 0 && specId != data.SpecId)
                {
                    continue;
                }
                if (tooId > 0 && tooId != data.TooId)
                {
                    continue;
                }
                if (!string.IsNullOrEmpty(searchTxt))
                {
                    var flag = (!string.IsNullOrEmpty(data.Name)     && data.Name.    ToUpper().IndexOf(searchTxt, StringComparison.Ordinal) > -1) ||
                               (!string.IsNullOrEmpty(data.Address)  && data.Address. ToUpper().IndexOf(searchTxt, StringComparison.Ordinal) > -1) ||
                               (!string.IsNullOrEmpty(data.Phones)   && data.Phones.  ToUpper().IndexOf(searchTxt, StringComparison.Ordinal) > -1) ||
                               (!string.IsNullOrEmpty(data.TimeWork) && data.TimeWork.ToUpper().IndexOf(searchTxt, StringComparison.Ordinal) > -1);

                    if (!flag)
                    {
                        continue;
                    }
                }
                
                lvFirms.Items.Add(CreateListViewItem(data));
            }
        }

        private void lbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = string.Empty;
        }
    }
}
