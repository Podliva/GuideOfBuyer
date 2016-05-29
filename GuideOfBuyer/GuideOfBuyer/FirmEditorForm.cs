using System;
using System.Windows.Forms;

using GuideOfBuyer.Bll.Data;

namespace GuideOfBuyer
{
    public partial class FirmEditorForm : Form
    {
        public FirmEditorForm()
        {
            InitializeComponent();
            InitData();
        }

        private void tbTimeWork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void InitData()
        {
            foreach (Specialization data in DataManager.Specializations)
            {
                cbSpec.Items.Add(data);
            }

            foreach (TypeOfOwnership data in DataManager.TypeOfOwnerships)
            {
                cbToo.Items.Add(data);
            }
        }

        private Firm GetData()
        {
            var obj = new Firm();
            obj.Id = Convert.ToInt32(lbId.Text);
            obj.Name = tbName.Text;
            obj.Address = tbAddress.Text;
            obj.Phones = tbPhone.Text;
            obj.SpecId = ((Specialization) cbSpec.SelectedItem).Id;
            obj.SpecName = ((Specialization)cbSpec.SelectedItem).Name;
            obj.TooId = ((TypeOfOwnership)cbToo.SelectedItem).Id;
            obj.TooName = ((TypeOfOwnership)cbToo.SelectedItem).Name;
            obj.TimeWork = tbTimeWork.Text;
            return obj;
        }

        private Firm SetData(Firm obj)
        {
            lbId.Text = obj.Id.ToString();
            tbName.Text = obj.Name;
            tbAddress.Text = obj.Address;
            tbPhone.Text = obj.Phones;
            tbTimeWork.Text = obj.TimeWork;
            for (var i = 0; i < cbSpec.Items.Count; i++)
            {
                if (((Specialization) cbSpec.Items[i]).Id == obj.SpecId)
                {
                    cbSpec.SelectedIndex = i;
                    break;
                }
            }
            for (var i = 0; i < cbToo.Items.Count; i++)
            {
                if (((TypeOfOwnership)cbToo.Items[i]).Id == obj.TooId)
                {
                    cbToo.SelectedIndex = i;
                    break;
                }
            }
            return obj;
        }

        public static Firm AddFirm()
        {
            var win = new FirmEditorForm();
            var id = DataManager.FirmGetNewId();
            win.lbId.Text = id.ToString();
            win.cbSpec.SelectedIndex = 0;
            win.cbToo.SelectedIndex = 0;
            if (win.ShowDialog() == DialogResult.OK)
            {
                return win.GetData();
            }
            return null;
        }

        public static Firm EditFirm(Firm data)
        {
            var win = new FirmEditorForm();
            win.SetData(data);
            if (win.ShowDialog() == DialogResult.OK)
            {
                return win.GetData();
            }
            return null;
        }
    }
}
