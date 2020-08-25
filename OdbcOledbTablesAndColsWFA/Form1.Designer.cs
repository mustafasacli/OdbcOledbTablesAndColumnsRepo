namespace OdbcOledbTablesAndColsWFA
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
            this.tblLytMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytColAndTables = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytConnStr = new System.Windows.Forms.TableLayoutPanel();
            this.lblTables = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblConnStr = new System.Windows.Forms.Label();
            this.txtConnStr = new System.Windows.Forms.TextBox();
            this.grdTables = new System.Windows.Forms.DataGridView();
            this.grdColumns = new System.Windows.Forms.DataGridView();
            this.btnGetTablesAndCols = new System.Windows.Forms.Button();
            this.chkIsOdbc = new System.Windows.Forms.CheckBox();
            this.tblLytMain.SuspendLayout();
            this.tblLytColAndTables.SuspendLayout();
            this.tblLytConnStr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.tblLytColAndTables, 0, 0);
            this.tblLytMain.Controls.Add(this.tblLytConnStr, 0, 1);
            this.tblLytMain.Controls.Add(this.btnGetTablesAndCols, 0, 2);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(0, 0);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 3;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLytMain.Size = new System.Drawing.Size(796, 600);
            this.tblLytMain.TabIndex = 0;
            // 
            // tblLytColAndTables
            // 
            this.tblLytColAndTables.ColumnCount = 1;
            this.tblLytColAndTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytColAndTables.Controls.Add(this.lblTables, 0, 0);
            this.tblLytColAndTables.Controls.Add(this.grdTables, 0, 1);
            this.tblLytColAndTables.Controls.Add(this.grdColumns, 0, 3);
            this.tblLytColAndTables.Controls.Add(this.lblColumns, 0, 2);
            this.tblLytColAndTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytColAndTables.Location = new System.Drawing.Point(3, 3);
            this.tblLytColAndTables.Name = "tblLytColAndTables";
            this.tblLytColAndTables.RowCount = 4;
            this.tblLytColAndTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytColAndTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytColAndTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytColAndTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytColAndTables.Size = new System.Drawing.Size(790, 474);
            this.tblLytColAndTables.TabIndex = 0;
            // 
            // tblLytConnStr
            // 
            this.tblLytConnStr.ColumnCount = 3;
            this.tblLytConnStr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblLytConnStr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytConnStr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytConnStr.Controls.Add(this.lblConnStr, 0, 0);
            this.tblLytConnStr.Controls.Add(this.txtConnStr, 1, 0);
            this.tblLytConnStr.Controls.Add(this.chkIsOdbc, 2, 0);
            this.tblLytConnStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytConnStr.Location = new System.Drawing.Point(3, 483);
            this.tblLytConnStr.Name = "tblLytConnStr";
            this.tblLytConnStr.RowCount = 1;
            this.tblLytConnStr.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytConnStr.Size = new System.Drawing.Size(790, 54);
            this.tblLytConnStr.TabIndex = 1;
            // 
            // lblTables
            // 
            this.lblTables.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTables.AutoSize = true;
            this.lblTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTables.Location = new System.Drawing.Point(10, 11);
            this.lblTables.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(59, 17);
            this.lblTables.TabIndex = 0;
            this.lblTables.Text = "Tables :";
            // 
            // lblColumns
            // 
            this.lblColumns.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblColumns.AutoSize = true;
            this.lblColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblColumns.Location = new System.Drawing.Point(10, 248);
            this.lblColumns.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(70, 17);
            this.lblColumns.TabIndex = 1;
            this.lblColumns.Text = "Columns :";
            // 
            // lblConnStr
            // 
            this.lblConnStr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConnStr.AutoSize = true;
            this.lblConnStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblConnStr.Location = new System.Drawing.Point(10, 18);
            this.lblConnStr.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblConnStr.Name = "lblConnStr";
            this.lblConnStr.Size = new System.Drawing.Size(128, 17);
            this.lblConnStr.TabIndex = 0;
            this.lblConnStr.Text = "Connection String :";
            // 
            // txtConnStr
            // 
            this.txtConnStr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConnStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtConnStr.Location = new System.Drawing.Point(160, 15);
            this.txtConnStr.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtConnStr.Name = "txtConnStr";
            this.txtConnStr.Size = new System.Drawing.Size(540, 23);
            this.txtConnStr.TabIndex = 1;
            // 
            // grdTables
            // 
            this.grdTables.AllowUserToAddRows = false;
            this.grdTables.AllowUserToDeleteRows = false;
            this.grdTables.AllowUserToResizeRows = false;
            this.grdTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTables.Location = new System.Drawing.Point(3, 43);
            this.grdTables.Name = "grdTables";
            this.grdTables.Size = new System.Drawing.Size(784, 191);
            this.grdTables.TabIndex = 2;
            // 
            // grdColumns
            // 
            this.grdColumns.AllowUserToAddRows = false;
            this.grdColumns.AllowUserToDeleteRows = false;
            this.grdColumns.AllowUserToResizeRows = false;
            this.grdColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdColumns.Location = new System.Drawing.Point(3, 280);
            this.grdColumns.Name = "grdColumns";
            this.grdColumns.Size = new System.Drawing.Size(784, 191);
            this.grdColumns.TabIndex = 3;
            // 
            // btnGetTablesAndCols
            // 
            this.btnGetTablesAndCols.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetTablesAndCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnGetTablesAndCols.Location = new System.Drawing.Point(311, 547);
            this.btnGetTablesAndCols.Name = "btnGetTablesAndCols";
            this.btnGetTablesAndCols.Size = new System.Drawing.Size(173, 45);
            this.btnGetTablesAndCols.TabIndex = 2;
            this.btnGetTablesAndCols.Text = "Get Tables And Columns";
            this.btnGetTablesAndCols.UseVisualStyleBackColor = true;
            this.btnGetTablesAndCols.Click += new System.EventHandler(this.btnGetTablesAndCols_Click);
            // 
            // chkIsOdbc
            // 
            this.chkIsOdbc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkIsOdbc.AutoSize = true;
            this.chkIsOdbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.chkIsOdbc.Location = new System.Drawing.Point(713, 16);
            this.chkIsOdbc.Name = "chkIsOdbc";
            this.chkIsOdbc.Size = new System.Drawing.Size(61, 21);
            this.chkIsOdbc.TabIndex = 2;
            this.chkIsOdbc.Text = "Odbc";
            this.chkIsOdbc.UseVisualStyleBackColor = true;
            this.chkIsOdbc.CheckedChanged += new System.EventHandler(this.chkIsOdbc_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 600);
            this.Controls.Add(this.tblLytMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tblLytMain.ResumeLayout(false);
            this.tblLytColAndTables.ResumeLayout(false);
            this.tblLytColAndTables.PerformLayout();
            this.tblLytConnStr.ResumeLayout(false);
            this.tblLytConnStr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdColumns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private System.Windows.Forms.TableLayoutPanel tblLytColAndTables;
        private System.Windows.Forms.TableLayoutPanel tblLytConnStr;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblConnStr;
        private System.Windows.Forms.TextBox txtConnStr;
        private System.Windows.Forms.DataGridView grdTables;
        private System.Windows.Forms.DataGridView grdColumns;
        private System.Windows.Forms.Button btnGetTablesAndCols;
        private System.Windows.Forms.CheckBox chkIsOdbc;
    }
}

