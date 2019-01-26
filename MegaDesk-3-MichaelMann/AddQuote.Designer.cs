namespace MegaDesk_3_MichaelMann
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbBuildOption = new System.Windows.Forms.ComboBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudCountDrawer = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudDepth = new System.Windows.Forms.NumericUpDown();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblCountDrawer = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblBuildOption = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountDrawer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(71, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // cmbBuildOption
            // 
            this.cmbBuildOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuildOption.FormattingEnabled = true;
            this.cmbBuildOption.Location = new System.Drawing.Point(151, 266);
            this.cmbBuildOption.Name = "cmbBuildOption";
            this.cmbBuildOption.Size = new System.Drawing.Size(181, 28);
            this.cmbBuildOption.TabIndex = 6;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(151, 216);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(181, 28);
            this.cmbMaterial.TabIndex = 5;
            // 
            // nudWidth
            // 
            this.nudWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWidth.Location = new System.Drawing.Point(151, 72);
            this.nudWidth.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(181, 26);
            this.nudWidth.TabIndex = 2;
            this.nudWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudWidth.Validating += new System.ComponentModel.CancelEventHandler(this.nudWidth_Validating);
            this.nudWidth.Validated += new System.EventHandler(this.nudWidth_Validated);
            // 
            // nudCountDrawer
            // 
            this.nudCountDrawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCountDrawer.Location = new System.Drawing.Point(151, 168);
            this.nudCountDrawer.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudCountDrawer.Name = "nudCountDrawer";
            this.nudCountDrawer.Size = new System.Drawing.Size(181, 26);
            this.nudCountDrawer.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(151, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 26);
            this.txtName.TabIndex = 1;
            // 
            // nudDepth
            // 
            this.nudDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDepth.Location = new System.Drawing.Point(151, 120);
            this.nudDepth.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudDepth.Name = "nudDepth";
            this.nudDepth.Size = new System.Drawing.Size(181, 26);
            this.nudDepth.TabIndex = 3;
            this.nudDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudDepth_KeyPress);
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepth.Location = new System.Drawing.Point(43, 120);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(83, 20);
            this.lblDepth.TabIndex = 7;
            this.lblDepth.Text = "Depth (in):";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(46, 72);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(80, 20);
            this.lblWidth.TabIndex = 8;
            this.lblWidth.Text = "Width (in):";
            // 
            // lblCountDrawer
            // 
            this.lblCountDrawer.AutoSize = true;
            this.lblCountDrawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDrawer.Location = new System.Drawing.Point(23, 168);
            this.lblCountDrawer.Name = "lblCountDrawer";
            this.lblCountDrawer.Size = new System.Drawing.Size(103, 20);
            this.lblCountDrawer.TabIndex = 9;
            this.lblCountDrawer.Text = "# of Drawers:";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(57, 216);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(69, 20);
            this.lblMaterial.TabIndex = 10;
            this.lblMaterial.Text = "Material:";
            // 
            // lblBuildOption
            // 
            this.lblBuildOption.AutoSize = true;
            this.lblBuildOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildOption.Location = new System.Drawing.Point(40, 264);
            this.lblBuildOption.Name = "lblBuildOption";
            this.lblBuildOption.Size = new System.Drawing.Size(86, 20);
            this.lblBuildOption.TabIndex = 11;
            this.lblBuildOption.Text = "Build Time:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 75);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(187, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 75);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(359, 411);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblBuildOption);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblCountDrawer);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.nudDepth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.nudCountDrawer);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.cmbBuildOption);
            this.Controls.Add(this.lblName);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountDrawer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbBuildOption;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudCountDrawer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudDepth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblCountDrawer;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblBuildOption;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}