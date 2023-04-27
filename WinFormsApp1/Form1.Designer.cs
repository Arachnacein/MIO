using WinFormsApp1.Models;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            A = new NumericUpDown();
            B = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            Precision = new ComboBox();
            PopulationSize = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            Bytes = new Label();
            dataGridView1 = new DataGridView();
            modelOutputBindingSource4 = new BindingSource(components);
            modelOutputBindingSource3 = new BindingSource(components);
            modelOutputBindingSource2 = new BindingSource(components);
            modelOutputBindingSource1 = new BindingSource(components);
            modelOutputBindingSource = new BindingSource(components);
            resultBindingSource = new BindingSource(components);
            xREAL1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            xINT1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            xREAL1DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            xINT1DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            numberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            xREAL1DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            xINT1DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            numberDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            xREAL1DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            xINT1DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            X_REAL1 = new DataGridViewTextBoxColumn();
            functionXDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Function_G = new DataGridViewTextBoxColumn();
            Function_P = new DataGridViewTextBoxColumn();
            Q = new DataGridViewTextBoxColumn();
            R = new DataGridViewTextBoxColumn();
            Selection = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)A).BeginInit();
            ((System.ComponentModel.ISupportInitialize)B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PopulationSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(679, 25);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 2;
            label1.Text = "a";
            // 
            // A
            // 
            A.Location = new Point(12, 27);
            A.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            A.Name = "A";
            A.Size = new Size(120, 23);
            A.TabIndex = 3;
            A.Value = new decimal(new int[] { 4, 0, 0, int.MinValue });
            // 
            // B
            // 
            B.Location = new Point(138, 27);
            B.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            B.Name = "B";
            B.Size = new Size(120, 23);
            B.TabIndex = 5;
            B.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 9);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 4;
            label2.Text = "b";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 9);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 6;
            label3.Text = "d";
            // 
            // Precision
            // 
            Precision.FormattingEnabled = true;
            Precision.Items.AddRange(new object[] { "0,1", "0,01", "0,001", "0,0001", "0,00001", "0,000001" });
            Precision.Location = new Point(264, 27);
            Precision.Name = "Precision";
            Precision.Size = new Size(121, 23);
            Precision.TabIndex = 7;
            // 
            // PopulationSize
            // 
            PopulationSize.Location = new Point(391, 27);
            PopulationSize.Name = "PopulationSize";
            PopulationSize.Size = new Size(120, 23);
            PopulationSize.TabIndex = 9;
            PopulationSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 9);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 8;
            label4.Text = "N";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(575, 25);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 10;
            label5.Text = "l";
            // 
            // Bytes
            // 
            Bytes.AutoSize = true;
            Bytes.Location = new Point(520, 30);
            Bytes.Name = "Bytes";
            Bytes.Size = new Size(0, 15);
            Bytes.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Number, X_REAL1, functionXDataGridViewTextBoxColumn, Function_G, Function_P, Q, R, Selection });
            dataGridView1.DataSource = modelOutputBindingSource4;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1059, 382);
            dataGridView1.TabIndex = 12;
            // 
            // modelOutputBindingSource4
            // 
            modelOutputBindingSource4.DataSource = typeof(ModelOutput);
            // 
            // modelOutputBindingSource3
            // 
            modelOutputBindingSource3.DataSource = typeof(ModelOutput);
            // 
            // modelOutputBindingSource2
            // 
            modelOutputBindingSource2.DataSource = typeof(ModelOutput);
            // 
            // modelOutputBindingSource1
            // 
            modelOutputBindingSource1.DataSource = typeof(ModelOutput);
            // 
            // modelOutputBindingSource
            // 
            modelOutputBindingSource.DataSource = typeof(ModelOutput);
            // 
            // resultBindingSource
            // 
            resultBindingSource.DataSource = typeof(ModelOutput);
            // 
            // xREAL1DataGridViewTextBoxColumn
            // 
            xREAL1DataGridViewTextBoxColumn.DataPropertyName = "X_REAL1";
            xREAL1DataGridViewTextBoxColumn.HeaderText = "X_REAL1";
            xREAL1DataGridViewTextBoxColumn.MinimumWidth = 8;
            xREAL1DataGridViewTextBoxColumn.Name = "xREAL1DataGridViewTextBoxColumn";
            xREAL1DataGridViewTextBoxColumn.Width = 174;
            // 
            // xINT1DataGridViewTextBoxColumn
            // 
            xINT1DataGridViewTextBoxColumn.DataPropertyName = "X_INT1";
            xINT1DataGridViewTextBoxColumn.HeaderText = "X_INT1";
            xINT1DataGridViewTextBoxColumn.MinimumWidth = 8;
            xINT1DataGridViewTextBoxColumn.Name = "xINT1DataGridViewTextBoxColumn";
            xINT1DataGridViewTextBoxColumn.Width = 175;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn.HeaderText = "Number";
            numberDataGridViewTextBoxColumn.MinimumWidth = 8;
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            numberDataGridViewTextBoxColumn.Width = 149;
            // 
            // xREAL1DataGridViewTextBoxColumn1
            // 
            xREAL1DataGridViewTextBoxColumn1.DataPropertyName = "X_REAL1";
            xREAL1DataGridViewTextBoxColumn1.HeaderText = "X_REAL1";
            xREAL1DataGridViewTextBoxColumn1.MinimumWidth = 8;
            xREAL1DataGridViewTextBoxColumn1.Name = "xREAL1DataGridViewTextBoxColumn1";
            xREAL1DataGridViewTextBoxColumn1.Width = 150;
            // 
            // xINT1DataGridViewTextBoxColumn1
            // 
            xINT1DataGridViewTextBoxColumn1.DataPropertyName = "X_INT1";
            xINT1DataGridViewTextBoxColumn1.HeaderText = "X_INT1";
            xINT1DataGridViewTextBoxColumn1.MinimumWidth = 8;
            xINT1DataGridViewTextBoxColumn1.Name = "xINT1DataGridViewTextBoxColumn1";
            xINT1DataGridViewTextBoxColumn1.Width = 149;
            // 
            // numberDataGridViewTextBoxColumn1
            // 
            numberDataGridViewTextBoxColumn1.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn1.HeaderText = "Number";
            numberDataGridViewTextBoxColumn1.MinimumWidth = 8;
            numberDataGridViewTextBoxColumn1.Name = "numberDataGridViewTextBoxColumn1";
            numberDataGridViewTextBoxColumn1.Width = 173;
            // 
            // xREAL1DataGridViewTextBoxColumn2
            // 
            xREAL1DataGridViewTextBoxColumn2.DataPropertyName = "X_REAL1";
            xREAL1DataGridViewTextBoxColumn2.HeaderText = "X_REAL1";
            xREAL1DataGridViewTextBoxColumn2.MinimumWidth = 8;
            xREAL1DataGridViewTextBoxColumn2.Name = "xREAL1DataGridViewTextBoxColumn2";
            xREAL1DataGridViewTextBoxColumn2.Width = 174;
            // 
            // xINT1DataGridViewTextBoxColumn2
            // 
            xINT1DataGridViewTextBoxColumn2.DataPropertyName = "X_INT1";
            xINT1DataGridViewTextBoxColumn2.HeaderText = "X_INT1";
            xINT1DataGridViewTextBoxColumn2.MinimumWidth = 8;
            xINT1DataGridViewTextBoxColumn2.Name = "xINT1DataGridViewTextBoxColumn2";
            xINT1DataGridViewTextBoxColumn2.Width = 173;
            // 
            // numberDataGridViewTextBoxColumn2
            // 
            numberDataGridViewTextBoxColumn2.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn2.HeaderText = "Number";
            numberDataGridViewTextBoxColumn2.MinimumWidth = 8;
            numberDataGridViewTextBoxColumn2.Name = "numberDataGridViewTextBoxColumn2";
            numberDataGridViewTextBoxColumn2.Width = 173;
            // 
            // xREAL1DataGridViewTextBoxColumn3
            // 
            xREAL1DataGridViewTextBoxColumn3.DataPropertyName = "X_REAL1";
            xREAL1DataGridViewTextBoxColumn3.HeaderText = "X_REAL1";
            xREAL1DataGridViewTextBoxColumn3.MinimumWidth = 8;
            xREAL1DataGridViewTextBoxColumn3.Name = "xREAL1DataGridViewTextBoxColumn3";
            xREAL1DataGridViewTextBoxColumn3.Width = 174;
            // 
            // xINT1DataGridViewTextBoxColumn3
            // 
            xINT1DataGridViewTextBoxColumn3.DataPropertyName = "X_INT1";
            xINT1DataGridViewTextBoxColumn3.HeaderText = "X_INT1";
            xINT1DataGridViewTextBoxColumn3.MinimumWidth = 8;
            xINT1DataGridViewTextBoxColumn3.Name = "xINT1DataGridViewTextBoxColumn3";
            xINT1DataGridViewTextBoxColumn3.Width = 173;
            // 
            // Number
            // 
            Number.DataPropertyName = "Number";
            Number.HeaderText = "Number";
            Number.Name = "Number";
            // 
            // X_REAL1
            // 
            X_REAL1.DataPropertyName = "X_REAL1";
            X_REAL1.FillWeight = 81.21826F;
            X_REAL1.HeaderText = "X_REAL1";
            X_REAL1.MinimumWidth = 8;
            X_REAL1.Name = "X_REAL1";
            // 
            // functionXDataGridViewTextBoxColumn
            // 
            functionXDataGridViewTextBoxColumn.DataPropertyName = "Function_X";
            functionXDataGridViewTextBoxColumn.FillWeight = 112.761887F;
            functionXDataGridViewTextBoxColumn.HeaderText = "Function_X";
            functionXDataGridViewTextBoxColumn.MinimumWidth = 8;
            functionXDataGridViewTextBoxColumn.Name = "functionXDataGridViewTextBoxColumn";
            // 
            // Function_G
            // 
            Function_G.DataPropertyName = "Function_G";
            Function_G.FillWeight = 112.761887F;
            Function_G.HeaderText = "Function_G";
            Function_G.MinimumWidth = 8;
            Function_G.Name = "Function_G";
            // 
            // Function_P
            // 
            Function_P.DataPropertyName = "Function_P";
            Function_P.FillWeight = 112.761887F;
            Function_P.HeaderText = "Function_P";
            Function_P.MinimumWidth = 8;
            Function_P.Name = "Function_P";
            // 
            // Q
            // 
            Q.DataPropertyName = "Q";
            Q.FillWeight = 112.761887F;
            Q.HeaderText = "Q";
            Q.MinimumWidth = 8;
            Q.Name = "Q";
            // 
            // R
            // 
            R.DataPropertyName = "R";
            R.FillWeight = 112.761887F;
            R.HeaderText = "R";
            R.MinimumWidth = 8;
            R.Name = "R";
            // 
            // Selection
            // 
            Selection.DataPropertyName = "Selection";
            Selection.FillWeight = 112.761887F;
            Selection.HeaderText = "Selection";
            Selection.MinimumWidth = 8;
            Selection.Name = "Selection";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 421);
            Controls.Add(dataGridView1);
            Controls.Add(Bytes);
            Controls.Add(label5);
            Controls.Add(PopulationSize);
            Controls.Add(label4);
            Controls.Add(Precision);
            Controls.Add(label3);
            Controls.Add(B);
            Controls.Add(label2);
            Controls.Add(A);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)A).EndInit();
            ((System.ComponentModel.ISupportInitialize)B).EndInit();
            ((System.ComponentModel.ISupportInitialize)PopulationSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private NumericUpDown B;
        private Label label2;
        private Label label3;
        private ComboBox Precision;
        private NumericUpDown PopulationSize;
        private Label label4;
        private Label label5;
        private Label Bytes;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn xRealDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xIntDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xBinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calcIntDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calcRealDataGridViewTextBoxColumn;
        private BindingSource resultBindingSource;
        public NumericUpDown A;
        private BindingSource modelOutputBindingSource;
        private DataGridViewTextBoxColumn xREAL1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xINT1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xREAL1DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn xINT1DataGridViewTextBoxColumn1;
        private BindingSource modelOutputBindingSource1;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn xREAL1DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn xINT1DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn xREAL1DataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn xINT1DataGridViewTextBoxColumn3;
        private BindingSource modelOutputBindingSource2;
        private BindingSource modelOutputBindingSource3;
        private BindingSource modelOutputBindingSource4;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn X_REAL1;
        private DataGridViewTextBoxColumn functionXDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Function_G;
        private DataGridViewTextBoxColumn Function_P;
        private DataGridViewTextBoxColumn Q;
        private DataGridViewTextBoxColumn R;
        private DataGridViewTextBoxColumn Selection;
    }
}