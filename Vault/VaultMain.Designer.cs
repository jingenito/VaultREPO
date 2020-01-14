namespace Vault
{
    partial class VaultMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaultMain));
            this.tblLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButts = new System.Windows.Forms.Panel();
            this.tblButts = new System.Windows.Forms.TableLayoutPanel();
            this.buttAdd = new System.Windows.Forms.Button();
            this.buttSave = new System.Windows.Forms.Button();
            this.buttLoad = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.buttSignOut = new System.Windows.Forms.Button();
            this.tblLayoutMain.SuspendLayout();
            this.pnlButts.SuspendLayout();
            this.tblButts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutMain
            // 
            this.tblLayoutMain.ColumnCount = 2;
            this.tblLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutMain.Controls.Add(this.buttSignOut, 0, 2);
            this.tblLayoutMain.Controls.Add(this.pnlButts, 0, 0);
            this.tblLayoutMain.Controls.Add(this.dgv, 0, 1);
            this.tblLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutMain.Name = "tblLayoutMain";
            this.tblLayoutMain.RowCount = 3;
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutMain.Size = new System.Drawing.Size(1190, 783);
            this.tblLayoutMain.TabIndex = 0;
            // 
            // pnlButts
            // 
            this.pnlButts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblLayoutMain.SetColumnSpan(this.pnlButts, 2);
            this.pnlButts.Controls.Add(this.tblButts);
            this.pnlButts.Location = new System.Drawing.Point(290, 35);
            this.pnlButts.Name = "pnlButts";
            this.pnlButts.Size = new System.Drawing.Size(609, 125);
            this.pnlButts.TabIndex = 0;
            // 
            // tblButts
            // 
            this.tblButts.ColumnCount = 3;
            this.tblButts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButts.Controls.Add(this.buttAdd, 2, 0);
            this.tblButts.Controls.Add(this.buttSave, 1, 0);
            this.tblButts.Controls.Add(this.buttLoad, 0, 0);
            this.tblButts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButts.Location = new System.Drawing.Point(0, 0);
            this.tblButts.Name = "tblButts";
            this.tblButts.RowCount = 1;
            this.tblButts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButts.Size = new System.Drawing.Size(609, 125);
            this.tblButts.TabIndex = 0;
            // 
            // buttAdd
            // 
            this.buttAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttAdd.Location = new System.Drawing.Point(425, 13);
            this.buttAdd.Name = "buttAdd";
            this.buttAdd.Size = new System.Drawing.Size(164, 98);
            this.buttAdd.TabIndex = 2;
            this.buttAdd.Text = "Add";
            this.buttAdd.UseVisualStyleBackColor = true;
            // 
            // buttSave
            // 
            this.buttSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttSave.Location = new System.Drawing.Point(222, 13);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(164, 98);
            this.buttSave.TabIndex = 1;
            this.buttSave.Text = "Save";
            this.buttSave.UseVisualStyleBackColor = true;
            // 
            // buttLoad
            // 
            this.buttLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttLoad.Location = new System.Drawing.Point(19, 13);
            this.buttLoad.Name = "buttLoad";
            this.buttLoad.Size = new System.Drawing.Size(164, 98);
            this.buttLoad.TabIndex = 0;
            this.buttLoad.Text = "Load";
            this.buttLoad.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLayoutMain.SetColumnSpan(this.dgv, 2);
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 198);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1184, 385);
            this.dgv.TabIndex = 1;
            // 
            // buttSignOut
            // 
            this.buttSignOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblLayoutMain.SetColumnSpan(this.buttSignOut, 2);
            this.buttSignOut.Location = new System.Drawing.Point(445, 625);
            this.buttSignOut.Name = "buttSignOut";
            this.buttSignOut.Size = new System.Drawing.Size(300, 119);
            this.buttSignOut.TabIndex = 3;
            this.buttSignOut.Text = "Sign Out";
            this.buttSignOut.UseVisualStyleBackColor = true;
            this.buttSignOut.Click += new System.EventHandler(this.buttSignOut_Click);
            // 
            // VaultMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 783);
            this.Controls.Add(this.tblLayoutMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VaultMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vault";
            this.Load += new System.EventHandler(this.VaultMain_Load);
            this.tblLayoutMain.ResumeLayout(false);
            this.pnlButts.ResumeLayout(false);
            this.tblButts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutMain;
        private System.Windows.Forms.Panel pnlButts;
        private System.Windows.Forms.TableLayoutPanel tblButts;
        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.Button buttLoad;
        private System.Windows.Forms.Button buttAdd;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttSignOut;
    }
}