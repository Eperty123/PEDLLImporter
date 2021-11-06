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

using DelegateContainerNet.Models;
using PeNet;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PEDLLImporter
{
    public partial class Form1 : Form
    {
        DelegateContainer _DelegateContainer;
        PeFile _LoadedDll;
        PeFile _ExeToPatch;

        string _InputDll;
        string _InputExe;
        BindingList<string> _AvailableFunctionNamesSource;
        BindingList<string> _ImportedFunctionNamesSource;

        string selectedAvailableFunctinoName;
        string selectedToImportFunctinoName;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            _DelegateContainer = new DelegateContainer();
            _DelegateContainer.SetFormTitle(this, Application.ProductName);
            _AvailableFunctionNamesSource = new BindingList<string>();
            _ImportedFunctionNamesSource = new BindingList<string>();

            availableFunctionListView.DataSource = _AvailableFunctionNamesSource;
            importedFunctionsListView.DataSource = _ImportedFunctionNamesSource;
        }

        void LoadDll()
        {
            var opf = new OpenFileDialog();
            opf.Title = "Browse for a dll to load";
            opf.Filter = "Dll (*.dll)|*.dll";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                _LoadedDll = new PeFile(opf.FileName);
                _InputDll = opf.FileName;
                _DelegateContainer.SetTextBoxValue(dllPathTextBox, opf.FileName);
                ShowDllFunctions();
            }
        }

        void LoadExe()
        {
            var opf = new OpenFileDialog();
            opf.Title = "Browse for an executable to load";
            opf.Filter = "Executable (*.exe,*.bin)|*.bin;*.exe|All|*.*";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                _ExeToPatch = new PeFile(opf.FileName);
                _InputExe = opf.FileName;
                _DelegateContainer.SetTextBoxValue(exePathTextBox, opf.FileName);
            }
        }

        void ShowDllFunctions()
        {
            if (_LoadedDll != null)
            {
                _AvailableFunctionNamesSource.Clear();
                var functions = _LoadedDll.ExportedFunctions.Select(x => x.Name).ToList();
                if (functions.Count > 0)
                {
                    functions.ForEach(x => _AvailableFunctionNamesSource.Add(x));
                    selectedAvailableFunctinoName = functions[0];
                }
            }
        }

        void ImportFunction(string functionName)
        {
            if (_ExeToPatch != null) _ExeToPatch.AddImport(Path.GetFileName(_InputDll), functionName);
        }

        void ImportFunctions()
        {
            if (importedFunctionsListView.Items.Count > 0)
            {
                var functions = _ImportedFunctionNamesSource.ToList();
                for (int i = 0; i < functions.Count; i++)
                    ImportFunction(functions[i]);
            }
        }

        void PatchExe()
        {
            if (_ExeToPatch != null)
            {
                var sfd = new SaveFileDialog();
                sfd.Title = "Save modified executable";
                sfd.Filter = "Executable (*.exe,*.bin)|*.bin;*.exe|All|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ImportFunctions();
                    File.WriteAllBytes(sfd.FileName, _ExeToPatch.RawFile.ToArray());
                }
            }
        }

        private void loadDllBtn_Click(object sender, EventArgs e)
        {
            LoadDll();
        }

        private void loadExeBtn_Click(object sender, EventArgs e)
        {
            LoadExe();
        }

        private void patchBtn_Click(object sender, EventArgs e)
        {
            PatchExe();
        }

        private void availableFunctionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (availableFunctionListView.SelectedItem != null)
                selectedAvailableFunctinoName = availableFunctionListView.SelectedItem.ToString();
        }

        private void importedFunctionsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (importedFunctionsListView.SelectedItem != null)
                selectedToImportFunctinoName = importedFunctionsListView.SelectedItem.ToString();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            if (selectedAvailableFunctinoName != null && !_ImportedFunctionNamesSource.Contains(selectedAvailableFunctinoName))
                _ImportedFunctionNamesSource.Add(selectedAvailableFunctinoName);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (selectedAvailableFunctinoName != null && _ImportedFunctionNamesSource.Contains(selectedAvailableFunctinoName))
                _ImportedFunctionNamesSource.Remove(selectedAvailableFunctinoName);
        }
    }
}
