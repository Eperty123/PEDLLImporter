/*
Copyright (c) 2021 Eperty123

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE
OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Threading;
using System.Windows.Forms;

namespace DelegateContainerNet.Models
{
    public class DelegateContainer
    {
        #region Delegates
        // Controls
        public delegate void AddComboBoxListItemDelegate(ComboBox list, object value);
        public delegate void ClearComboBoxListDelegate(ComboBox list, bool clearValue = false);
        public delegate string GetSelectedComboBoxItemValueDelegate(ComboBox list);
        public delegate string GetTextBoxValueDelegate(TextBox textBox);
        public delegate string GetRichTextBoxValueDelegate(RichTextBox textBox);
        public delegate void SetTextBoxValueDelegate(TextBox textBox, object value);
        public delegate void SetRichTextBoxValueDelegate(RichTextBox textBox, object value);
        public delegate void SetLabelTextValueDelegate(Label label, string value);
        public delegate void SetSelectedComboBoxItemDelegate(ComboBox list, object value);
        public delegate void SetControlStateDelegate(Control control, bool value);
        public delegate void SetCheckBoxCheckStateDelegate(CheckBox checkBox, bool enabled);
        public delegate void SetDataGridViewTableDelegate(DataGridView dgv, object dataSource);
        public delegate void SetFormTitleDelegate(Form form, object value);

        // Form
        public delegate void FormTitleChangeDelegate(Form form, string title);
        #endregion

        #region Public Methods
        public void AddComboBoxListItem(ComboBox list, object value)
        {
            try
            {
                if (list.InvokeRequired)
                {
                    var d = new AddComboBoxListItemDelegate(AddComboBoxListItem);
                    list.Invoke(d, new object[] { list, value });
                }
                list.Items.Add(value);
            }
            catch (Exception) { }
        }

        public void ClearComboBoxList(ComboBox list, bool clearValue = false)
        {
            try
            {
                if (list.InvokeRequired)
                {
                    var d = new ClearComboBoxListDelegate(ClearComboBoxList);
                    list.Invoke(d, new object[] { list, clearValue });
                }
                list.Items.Clear();
                if (clearValue) list.Text = "";
            }
            catch (Exception) { }
        }

        public string GetSelectedComboBoxItem(ComboBox list)
        {
            string value = null;
            try
            {
                if (list.InvokeRequired)
                {
                    var d = new GetSelectedComboBoxItemValueDelegate(GetSelectedComboBoxItem);
                    list.Invoke(d, new object[] { list });
                }
                if (list.SelectedItem != null)
                    value = list.SelectedItem.ToString();
            }
            catch (Exception) { }
            return value;
        }

        public string GetTextBoxValue(TextBox textBox)
        {
            string value = "";
            try
            {
                if (textBox.InvokeRequired)
                {
                    var d = new GetTextBoxValueDelegate(GetTextBoxValue);
                    textBox.Invoke(d, new object[] { textBox });
                }
                value = textBox.Text;
            }
            catch (Exception) { }
            return value;
        }

        public string GetRichTextBoxValue(RichTextBox richTextBox)
        {
            string value = "";
            try
            {
                if (richTextBox.InvokeRequired)
                {
                    var d = new GetRichTextBoxValueDelegate(GetRichTextBoxValue);
                    richTextBox.Invoke(d, new object[] { richTextBox });
                }
                value = richTextBox.Text;
            }
            catch (Exception) { }
            return value;
        }

        public void SetSelectedComboBoxItem(ComboBox list, object value)
        {
            try
            {
                if (list.InvokeRequired)
                {
                    var d = new SetSelectedComboBoxItemDelegate(SetSelectedComboBoxItem);
                    list.Invoke(d, new object[] { list, value });
                }
                list.SelectedItem = value;
            }
            catch (Exception) { }
        }

        public void SetTextBoxValue(TextBox textBox, object value)
        {
            try
            {
                if (textBox.InvokeRequired)
                {
                    var d = new SetTextBoxValueDelegate(SetTextBoxValue);
                    textBox.Invoke(d, new object[] { textBox, value });
                }
                textBox.Text = value.ToString();
            }
            catch (Exception) { }
        }

        public void SetTextBoxValue(TextBox textBox, string value)
        {
            SetTextBoxValue(textBox, (object)value);
        }

        public void SetRichTextBoxValue(RichTextBox richTextBox, object value)
        {
            try
            {
                if (richTextBox.InvokeRequired)
                {
                    var d = new SetRichTextBoxValueDelegate(SetRichTextBoxValue);
                    richTextBox.Invoke(d, new object[] { richTextBox, value });
                }
                richTextBox.Text = value.ToString();
            }
            catch (Exception) { }
        }

        public void SetRichTextBoxValue(RichTextBox richTextBox, string value)
        {
            SetRichTextBoxValue(richTextBox, (object)value);
        }

        public void AppendRichTextBoxValue(RichTextBox richTextBox, object value)
        {
            try
            {
                if (richTextBox.InvokeRequired)
                {
                    var d = new SetRichTextBoxValueDelegate(AppendRichTextBoxValue);
                    richTextBox.Invoke(d, new object[] { richTextBox, value });
                }
                richTextBox.AppendText(value + "\n");
            }
            catch (Exception) { }
        }

        public void SetLabelTextValue(Label label, string value)
        {
            try
            {
                if (label.InvokeRequired)
                {
                    var d = new SetLabelTextValueDelegate(SetLabelTextValue);
                    label.Invoke(d, new object[] { label, value });
                }
                label.Text = value;
            }
            catch (Exception) { }
        }

        public void ChangeFormTitle(Form form, string title)
        {
            try
            {
                if (form.InvokeRequired)
                {
                    var d = new FormTitleChangeDelegate(ChangeFormTitle);
                    form.Invoke(d, new object[] { form, title });
                }
                form.Text = title;

            }
            catch (Exception) { }
        }

        public void SetControlState(Control control, bool value)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    var d = new SetControlStateDelegate(SetControlState);
                    control.Invoke(d, new object[] { control, value });
                }
                control.Enabled = value;
            }
            catch (Exception) { }
        }

        public void SetCheckboxCheckState(CheckBox control, bool value)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    var d = new SetCheckBoxCheckStateDelegate(SetControlState);
                    control.Invoke(d, new object[] { control, value });
                }
                control.Checked = value;
            }
            catch (Exception) { }
        }

        public void SetDataGridViewDataSource(DataGridView dgv, object dataSource)
        {
            try
            {
                if (dgv.InvokeRequired)
                {
                    var d = new SetDataGridViewTableDelegate(SetDataGridViewDataSource);
                    dgv.Invoke(d, new object[] { dgv, dataSource });
                }
                dgv.DataSource = dataSource;
            }
            catch (Exception) { }
        }

        public void SetFormTitle(Form form, object value)
        {
            try
            {
                if (form.InvokeRequired)
                {
                    var d = new SetFormTitleDelegate(SetFormTitle);
                    form.Invoke(d, new object[] { form, value });
                }
                form.Text = value.ToString();
            }
            catch (Exception) { }
        }

        public static Thread StartThread(Thread thread, params Action[] methods)
        {
            if (thread != null && thread.IsAlive)
                thread.Abort();

            thread = new Thread(() =>
            {
                foreach (var method in methods)
                    method();
            });
            thread.IsBackground = true;
            thread.Start();
            return thread;
        }
        #endregion
    }
}
