using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePickerStart.Value = DateTime.Now;
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value;
            dateTimePickerEnd.Value = dateTimePickerStart.Value.AddHours(2);
        }
        iCalendar calendar = new iCalendar("C Sharp Demo");

        private void buttonUPD_Click(object sender, EventArgs ea)
        {
            var e = new iCalendar.vEvent();
            e.Cancel = checkBoxCancel.Checked;
            e.DESCRIPTION = textBoxDES.Text;
            e.DTEND = dateTimePickerEnd.Value.ToUniversalTime();
            e.DTSTART = dateTimePickerStart.Value.ToUniversalTime();
            e.LOCATION = textBoxLOC.Text;
            e.ORGANIZER = textBoxORG.Text;
            e.SUMMARY = textBoxSUM.Text;
            e.UID = textBoxID.Text;
            foreach (var item in textBoxATT.Text.Split(';'))
            {
                var s = item.Split(':');
                e.ATTENDEE[(s.Length > 1 ? s[1] : s[0])] = s[0];
            }
            calendar.Add(e);
            UpdateList();
        }

        void UpdateList()
        {
            var list = calendar.Select(x => $"{x.UID}　{x.SUMMARY}　UTC-{x.DTSTART.ToString("yyyy/MM/dd-HH:mm")}");
            listBox1.Items.Clear();
            listBox1.Items.AddRange(list.ToArray());
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void buttonOUT_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                System.IO.File.WriteAllText(saveFileDialog1.FileName, calendar.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs ea)
        {
            if (listBox1.SelectedIndex == -1) return;
            var e = calendar[listBox1.SelectedIndex];
            checkBoxCancel.Checked = e.Cancel;
            textBoxDES.Text = e.DESCRIPTION;
            dateTimePickerStart.Value = e.DTSTART.ToLocalTime();
            dateTimePickerEnd.Value = e.DTEND.ToLocalTime();
            textBoxLOC.Text = e.LOCATION;
            textBoxORG.Text = e.ORGANIZER;
            textBoxSUM.Text = e.SUMMARY;
            textBoxID.Text = e.UID;
            textBoxATT.Text = string.Join(";", e.ATTENDEE.Select(x => x.Value + ":" + x.Key));
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            var x = calendar[listBox1.SelectedIndex];
            if (MessageBox.Show($"你確定要移除以下設定？\r\n『{x.UID}　{x.SUMMARY}　UTC-{x.DTSTART.ToString("yyyy/MM/dd-HH:mm")}』", "移除", MessageBoxButtons.YesNo) == DialogResult.Yes)
                calendar.Remove(x);
            UpdateList();
        }
    }
}
