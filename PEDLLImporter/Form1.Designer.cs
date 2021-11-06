namespace PEDLLImporter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.patchBtn = new System.Windows.Forms.Button();
            this.loadDllBtn = new System.Windows.Forms.Button();
            this.dllPathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exePathTextBox = new System.Windows.Forms.TextBox();
            this.loadExeBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.importBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.importedFunctionsListView = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.availableFunctionListView = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // patchBtn
            // 
            this.patchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patchBtn.Location = new System.Drawing.Point(12, 622);
            this.patchBtn.Name = "patchBtn";
            this.patchBtn.Size = new System.Drawing.Size(696, 46);
            this.patchBtn.TabIndex = 13;
            this.patchBtn.Text = "Patch";
            this.patchBtn.UseVisualStyleBackColor = true;
            this.patchBtn.Click += new System.EventHandler(this.patchBtn_Click);
            // 
            // loadDllBtn
            // 
            this.loadDllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadDllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDllBtn.Location = new System.Drawing.Point(580, 28);
            this.loadDllBtn.Name = "loadDllBtn";
            this.loadDllBtn.Size = new System.Drawing.Size(105, 32);
            this.loadDllBtn.TabIndex = 6;
            this.loadDllBtn.Text = "Load";
            this.loadDllBtn.UseVisualStyleBackColor = true;
            this.loadDllBtn.Click += new System.EventHandler(this.loadDllBtn_Click);
            // 
            // dllPathTextBox
            // 
            this.dllPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dllPathTextBox.Location = new System.Drawing.Point(6, 28);
            this.dllPathTextBox.Multiline = true;
            this.dllPathTextBox.Name = "dllPathTextBox";
            this.dllPathTextBox.Size = new System.Drawing.Size(568, 32);
            this.dllPathTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Available Functions";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.exePathTextBox);
            this.groupBox1.Controls.Add(this.loadExeBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Executeable";
            // 
            // exePathTextBox
            // 
            this.exePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exePathTextBox.Location = new System.Drawing.Point(6, 33);
            this.exePathTextBox.Multiline = true;
            this.exePathTextBox.Name = "exePathTextBox";
            this.exePathTextBox.Size = new System.Drawing.Size(568, 32);
            this.exePathTextBox.TabIndex = 2;
            // 
            // loadExeBtn
            // 
            this.loadExeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadExeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExeBtn.Location = new System.Drawing.Point(580, 33);
            this.loadExeBtn.Name = "loadExeBtn";
            this.loadExeBtn.Size = new System.Drawing.Size(105, 32);
            this.loadExeBtn.TabIndex = 3;
            this.loadExeBtn.Text = "Load";
            this.loadExeBtn.UseVisualStyleBackColor = true;
            this.loadExeBtn.Click += new System.EventHandler(this.loadExeBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.importBtn);
            this.groupBox2.Controls.Add(this.removeBtn);
            this.groupBox2.Controls.Add(this.importedFunctionsListView);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.availableFunctionListView);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.loadDllBtn);
            this.groupBox2.Controls.Add(this.dllPathTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 513);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input DLL";
            // 
            // importBtn
            // 
            this.importBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBtn.Location = new System.Drawing.Point(533, 281);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(73, 32);
            this.importBtn.TabIndex = 9;
            this.importBtn.Text = "Import";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(612, 281);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(73, 32);
            this.removeBtn.TabIndex = 10;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // importedFunctionsListView
            // 
            this.importedFunctionsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importedFunctionsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.importedFunctionsListView.FormattingEnabled = true;
            this.importedFunctionsListView.ItemHeight = 24;
            this.importedFunctionsListView.Location = new System.Drawing.Point(10, 335);
            this.importedFunctionsListView.Name = "importedFunctionsListView";
            this.importedFunctionsListView.Size = new System.Drawing.Size(675, 172);
            this.importedFunctionsListView.TabIndex = 23;
            this.importedFunctionsListView.SelectedIndexChanged += new System.EventHandler(this.importedFunctionsListView_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Import Functions";
            // 
            // availableFunctionListView
            // 
            this.availableFunctionListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availableFunctionListView.FormattingEnabled = true;
            this.availableFunctionListView.ItemHeight = 24;
            this.availableFunctionListView.Location = new System.Drawing.Point(10, 103);
            this.availableFunctionListView.Name = "availableFunctionListView";
            this.availableFunctionListView.Size = new System.Drawing.Size(675, 172);
            this.availableFunctionListView.TabIndex = 8;
            this.availableFunctionListView.SelectedIndexChanged += new System.EventHandler(this.availableFunctionListView_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 680);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.patchBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button patchBtn;
        private System.Windows.Forms.Button loadDllBtn;
        private System.Windows.Forms.TextBox dllPathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox exePathTextBox;
        private System.Windows.Forms.Button loadExeBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox availableFunctionListView;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ListBox importedFunctionsListView;
        private System.Windows.Forms.Label label3;
    }
}

