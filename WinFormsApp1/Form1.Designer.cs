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
            numberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            xREAL1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            xINT1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            xBINDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            xINT2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            xREAL2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelOutputBindingSource = new BindingSource(components);
            resultBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)A).BeginInit();
            ((System.ComponentModel.ISupportInitialize)B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PopulationSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(970, 42);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(21, 25);
            label1.TabIndex = 2;
            label1.Text = "a";
            // 
            // A
            // 
            A.Location = new Point(17, 45);
            A.Margin = new Padding(4, 5, 4, 5);
            A.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            A.Name = "A";
            A.Size = new Size(171, 31);
            A.TabIndex = 3;
            A.Value = new decimal(new int[] { 4, 0, 0, int.MinValue });
            // 
            // B
            // 
            B.Location = new Point(197, 45);
            B.Margin = new Padding(4, 5, 4, 5);
            B.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            B.Name = "B";
            B.Size = new Size(171, 31);
            B.TabIndex = 5;
            B.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 4;
            label2.Text = "b";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 15);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 6;
            label3.Text = "d";
            // 
            // Precision
            // 
            Precision.FormattingEnabled = true;
            Precision.Items.AddRange(new object[] { "0,1", "0,01", "0,001", "0,0001", "0,00001", "0,000001" });
            Precision.Location = new Point(377, 45);
            Precision.Margin = new Padding(4, 5, 4, 5);
            Precision.Name = "Precision";
            Precision.Size = new Size(171, 33);
            Precision.TabIndex = 7;
            // 
            // PopulationSize
            // 
            PopulationSize.Location = new Point(559, 45);
            PopulationSize.Margin = new Padding(4, 5, 4, 5);
            PopulationSize.Name = "PopulationSize";
            PopulationSize.Size = new Size(171, 31);
            PopulationSize.TabIndex = 9;
            PopulationSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(632, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(25, 25);
            label4.TabIndex = 8;
            label4.Text = "N";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(821, 42);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(16, 25);
            label5.TabIndex = 10;
            label5.Text = "l";
            // 
            // Bytes
            // 
            Bytes.AutoSize = true;
            Bytes.Location = new Point(743, 50);
            Bytes.Margin = new Padding(4, 0, 4, 0);
            Bytes.Name = "Bytes";
            Bytes.Size = new Size(0, 25);
            Bytes.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numberDataGridViewTextBoxColumn, xREAL1DataGridViewTextBoxColumn, xINT1DataGridViewTextBoxColumn, xBINDataGridViewTextBoxColumn, xINT2DataGridViewTextBoxColumn, xREAL2DataGridViewTextBoxColumn });
            dataGridView1.DataSource = modelOutputBindingSource;
            dataGridView1.Location = new Point(17, 93);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1109, 637);
            dataGridView1.TabIndex = 12;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn.HeaderText = "Number";
            numberDataGridViewTextBoxColumn.MinimumWidth = 8;
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // xREAL1DataGridViewTextBoxColumn
            // 
            xREAL1DataGridViewTextBoxColumn.DataPropertyName = "X_REAL1";
            xREAL1DataGridViewTextBoxColumn.HeaderText = "X_REAL1";
            xREAL1DataGridViewTextBoxColumn.MinimumWidth = 8;
            xREAL1DataGridViewTextBoxColumn.Name = "xREAL1DataGridViewTextBoxColumn";
            // 
            // xINT1DataGridViewTextBoxColumn
            // 
            xINT1DataGridViewTextBoxColumn.DataPropertyName = "X_INT1";
            xINT1DataGridViewTextBoxColumn.HeaderText = "X_INT1";
            xINT1DataGridViewTextBoxColumn.MinimumWidth = 8;
            xINT1DataGridViewTextBoxColumn.Name = "xINT1DataGridViewTextBoxColumn";
            // 
            // xBINDataGridViewTextBoxColumn
            // 
            xBINDataGridViewTextBoxColumn.DataPropertyName = "X_BIN";
            xBINDataGridViewTextBoxColumn.HeaderText = "X_BIN";
            xBINDataGridViewTextBoxColumn.MinimumWidth = 8;
            xBINDataGridViewTextBoxColumn.Name = "xBINDataGridViewTextBoxColumn";
            // 
            // xINT2DataGridViewTextBoxColumn
            // 
            xINT2DataGridViewTextBoxColumn.DataPropertyName = "X_INT2";
            xINT2DataGridViewTextBoxColumn.HeaderText = "X_INT2";
            xINT2DataGridViewTextBoxColumn.MinimumWidth = 8;
            xINT2DataGridViewTextBoxColumn.Name = "xINT2DataGridViewTextBoxColumn";
            // 
            // xREAL2DataGridViewTextBoxColumn
            // 
            xREAL2DataGridViewTextBoxColumn.DataPropertyName = "X_REAL2";
            xREAL2DataGridViewTextBoxColumn.HeaderText = "X_REAL2";
            xREAL2DataGridViewTextBoxColumn.MinimumWidth = 8;
            xREAL2DataGridViewTextBoxColumn.Name = "xREAL2DataGridViewTextBoxColumn";
            // 
            // modelOutputBindingSource
            // 
            modelOutputBindingSource.DataSource = typeof(ModelOutput);
            // 
            // resultBindingSource
            // 
            resultBindingSource.DataSource = typeof(ModelOutput);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)A).EndInit();
            ((System.ComponentModel.ISupportInitialize)B).EndInit();
            ((System.ComponentModel.ISupportInitialize)PopulationSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xREAL1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xINT1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xBINDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xINT2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xREAL2DataGridViewTextBoxColumn;
        private BindingSource modelOutputBindingSource;
    }
}