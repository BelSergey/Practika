namespace Practika
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
            this.GridInput = new System.Windows.Forms.DataGridView();
            this.GridOut = new System.Windows.Forms.DataGridView();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GridInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridInput
            // 
            this.GridInput.AllowUserToAddRows = false;
            this.GridInput.AllowUserToDeleteRows = false;
            this.GridInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInput.Location = new System.Drawing.Point(12, 108);
            this.GridInput.Name = "GridInput";
            this.GridInput.RowTemplate.Height = 25;
            this.GridInput.Size = new System.Drawing.Size(452, 322);
            this.GridInput.TabIndex = 0;
            // 
            // GridOut
            // 
            this.GridOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GridOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOut.Location = new System.Drawing.Point(602, 108);
            this.GridOut.Name = "GridOut";
            this.GridOut.RowTemplate.Height = 25;
            this.GridOut.Size = new System.Drawing.Size(452, 322);
            this.GridOut.TabIndex = 1;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(502, 222);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(502, 108);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 23);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1095, 476);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.GridOut);
            this.Controls.Add(this.GridInput);
            this.Name = "Form1";
            this.Text = "Сортировка матрицы";
            ((System.ComponentModel.ISupportInitialize)(this.GridInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private DataGridView GridInput;
        private DataGridView GridOut;
        private Button buttonConvert;
        private NumericUpDown numericUpDown1;
    }
}