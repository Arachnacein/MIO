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
            Bytes = new Label();
            dataGridView1 = new DataGridView();
            modelNewPersonBindingSource2 = new BindingSource(components);
            mutationPositionsBindingSource = new BindingSource(components);
            modelNewPersonBindingSource1 = new BindingSource(components);
            modelNewPersonBindingSource = new BindingSource(components);
            resultBindingSource = new BindingSource(components);
            modelOutputBindingSource6 = new BindingSource(components);
            modelOutputBindingSource5 = new BindingSource(components);
            modelOutputBindingSource4 = new BindingSource(components);
            modelOutputBindingSource3 = new BindingSource(components);
            modelOutputBindingSource2 = new BindingSource(components);
            modelOutputBindingSource1 = new BindingSource(components);
            modelOutputBindingSource = new BindingSource(components);
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
            crossPropability = new ComboBox();
            mutationPropability = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            Nr = new DataGridViewTextBoxColumn();
            X_REAL = new DataGridViewTextBoxColumn();
            X_BIN = new DataGridViewTextBoxColumn();
            X_Parents = new DataGridViewTextBoxColumn();
            CutPosition = new DataGridViewTextBoxColumn();
            ChildrenPopulation = new DataGridViewTextBoxColumn();
            X_Crossed_Population = new DataGridViewTextBoxColumn();
            MutationPositions = new DataGridViewTextBoxColumn();
            X_Mutated_Population = new DataGridViewTextBoxColumn();
            X_REAL_Mutated_Population = new DataGridViewTextBoxColumn();
            functionFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)A).BeginInit();
            ((System.ComponentModel.ISupportInitialize)B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PopulationSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelNewPersonBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mutationPositionsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelNewPersonBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelNewPersonBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1094, 29);
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
            Precision.Items.AddRange(new object[] { "0,1", "0,01", "0,001", "0,0001" });
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
            label4.Location = new Point(631, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(25, 25);
            label4.TabIndex = 8;
            label4.Text = "N";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nr, X_REAL, X_BIN, X_Parents, CutPosition, ChildrenPopulation, X_Crossed_Population, MutationPositions, X_Mutated_Population, X_REAL_Mutated_Population, functionFDataGridViewTextBoxColumn });
            dataGridView1.DataSource = modelNewPersonBindingSource2;
            dataGridView1.Location = new Point(17, 93);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1650, 637);
            dataGridView1.TabIndex = 12;
            // 
            // modelNewPersonBindingSource2
            // 
            modelNewPersonBindingSource2.DataSource = typeof(ModelNewPerson);
            // 
            // mutationPositionsBindingSource
            // 
            mutationPositionsBindingSource.DataMember = "MutationPositions";
            mutationPositionsBindingSource.DataSource = modelNewPersonBindingSource1;
            // 
            // modelNewPersonBindingSource1
            // 
            modelNewPersonBindingSource1.DataSource = typeof(ModelNewPerson);
            // 
            // modelNewPersonBindingSource
            // 
            modelNewPersonBindingSource.DataSource = typeof(ModelNewPerson);
            // 
            // resultBindingSource
            // 
            resultBindingSource.DataSource = typeof(ModelOutput);
            // 
            // modelOutputBindingSource6
            // 
            modelOutputBindingSource6.DataSource = typeof(ModelOutput);
            // 
            // modelOutputBindingSource5
            // 
            modelOutputBindingSource5.DataSource = typeof(ModelNewPerson);
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
            // crossPropability
            // 
            crossPropability.FormattingEnabled = true;
            crossPropability.Items.AddRange(new object[] { "0", "0,10", "0,20", "0,40", "0,50", "0,60", "0,80", "0,90", "1" });
            crossPropability.Location = new Point(743, 45);
            crossPropability.Margin = new Padding(4, 5, 4, 5);
            crossPropability.Name = "crossPropability";
            crossPropability.Size = new Size(78, 33);
            crossPropability.TabIndex = 13;
            // 
            // mutationPropability
            // 
            mutationPropability.FormattingEnabled = true;
            mutationPropability.Items.AddRange(new object[] { "0,1", "0,5", "0,01", "0,05", "0,001", "0,005" });
            mutationPropability.Location = new Point(843, 44);
            mutationPropability.Margin = new Padding(4, 5, 4, 5);
            mutationPropability.Name = "mutationPropability";
            mutationPropability.Size = new Size(78, 33);
            mutationPropability.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(770, 15);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 25);
            label5.TabIndex = 15;
            label5.Text = "pk";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(861, 15);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 25);
            label6.TabIndex = 16;
            label6.Text = "pm";
            // 
            // Nr
            // 
            Nr.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nr.DataPropertyName = "Number";
            Nr.FillWeight = 59.74279F;
            Nr.HeaderText = "Nr";
            Nr.MinimumWidth = 8;
            Nr.Name = "Nr";
            Nr.Resizable = DataGridViewTriState.False;
            // 
            // X_REAL
            // 
            X_REAL.DataPropertyName = "X_REAL";
            X_REAL.FillWeight = 59.9004631F;
            X_REAL.HeaderText = "X_REAL";
            X_REAL.MinimumWidth = 8;
            X_REAL.Name = "X_REAL";
            // 
            // X_BIN
            // 
            X_BIN.DataPropertyName = "X_BIN";
            X_BIN.FillWeight = 132.744247F;
            X_BIN.HeaderText = "X_BIN";
            X_BIN.MinimumWidth = 8;
            X_BIN.Name = "X_BIN";
            // 
            // X_Parents
            // 
            X_Parents.DataPropertyName = "X_Parents";
            X_Parents.FillWeight = 132.744247F;
            X_Parents.HeaderText = "X_Parents";
            X_Parents.MinimumWidth = 8;
            X_Parents.Name = "X_Parents";
            // 
            // CutPosition
            // 
            CutPosition.DataPropertyName = "CutPosition";
            CutPosition.FillWeight = 56.2665329F;
            CutPosition.HeaderText = "Cut";
            CutPosition.MinimumWidth = 8;
            CutPosition.Name = "CutPosition";
            // 
            // ChildrenPopulation
            // 
            ChildrenPopulation.DataPropertyName = "X_Children_Population";
            ChildrenPopulation.FillWeight = 132.744247F;
            ChildrenPopulation.HeaderText = "Children";
            ChildrenPopulation.MinimumWidth = 8;
            ChildrenPopulation.Name = "ChildrenPopulation";
            // 
            // X_Crossed_Population
            // 
            X_Crossed_Population.DataPropertyName = "X_Crossed_Population";
            X_Crossed_Population.FillWeight = 132.744247F;
            X_Crossed_Population.HeaderText = "Crossed";
            X_Crossed_Population.MinimumWidth = 8;
            X_Crossed_Population.Name = "X_Crossed_Population";
            // 
            // MutationPositions
            // 
            MutationPositions.DataPropertyName = "MutationPositions";
            MutationPositions.FillWeight = 52.6247368F;
            MutationPositions.HeaderText = "Mutation Points";
            MutationPositions.MinimumWidth = 8;
            MutationPositions.Name = "MutationPositions";
            // 
            // X_Mutated_Population
            // 
            X_Mutated_Population.DataPropertyName = "X_Mutated_Population";
            X_Mutated_Population.FillWeight = 132.744247F;
            X_Mutated_Population.HeaderText = "Mutated";
            X_Mutated_Population.MinimumWidth = 8;
            X_Mutated_Population.Name = "X_Mutated_Population";
            // 
            // X_REAL_Mutated_Population
            // 
            X_REAL_Mutated_Population.DataPropertyName = "X_REAL_Mutated_Population";
            X_REAL_Mutated_Population.FillWeight = 75F;
            X_REAL_Mutated_Population.HeaderText = "Mutated X_Real";
            X_REAL_Mutated_Population.MinimumWidth = 8;
            X_REAL_Mutated_Population.Name = "X_REAL_Mutated_Population";
            // 
            // functionFDataGridViewTextBoxColumn
            // 
            functionFDataGridViewTextBoxColumn.DataPropertyName = "Function_F";
            functionFDataGridViewTextBoxColumn.FillWeight = 132.744247F;
            functionFDataGridViewTextBoxColumn.HeaderText = "Function_F";
            functionFDataGridViewTextBoxColumn.MinimumWidth = 8;
            functionFDataGridViewTextBoxColumn.Name = "functionFDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1680, 702);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(mutationPropability);
            Controls.Add(crossPropability);
            Controls.Add(dataGridView1);
            Controls.Add(Bytes);
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
            ((System.ComponentModel.ISupportInitialize)modelNewPersonBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)mutationPositionsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelNewPersonBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelNewPersonBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource6).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelOutputBindingSource).EndInit();
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
        private ComboBox crossPropability;
        private ComboBox mutationPropability;
        private Label label5;
        private Label label6;
        private BindingSource modelOutputBindingSource5;
        private BindingSource modelOutputBindingSource6;
        private BindingSource modelNewPersonBindingSource;
        private BindingSource modelNewPersonBindingSource1;
        private BindingSource mutationPositionsBindingSource;
        private BindingSource modelNewPersonBindingSource2;
        private DataGridViewTextBoxColumn Nr;
        private DataGridViewTextBoxColumn X_REAL;
        private DataGridViewTextBoxColumn X_BIN;
        private DataGridViewTextBoxColumn X_Parents;
        private DataGridViewTextBoxColumn CutPosition;
        private DataGridViewTextBoxColumn ChildrenPopulation;
        private DataGridViewTextBoxColumn X_Crossed_Population;
        private DataGridViewTextBoxColumn MutationPositions;
        private DataGridViewTextBoxColumn X_Mutated_Population;
        private DataGridViewTextBoxColumn X_REAL_Mutated_Population;
        private DataGridViewTextBoxColumn functionFDataGridViewTextBoxColumn;
    }
}