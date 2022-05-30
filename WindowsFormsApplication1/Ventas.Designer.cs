
namespace WindowsFormsApplication1
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.TXT_instructorName = new System.Windows.Forms.TextBox();
            this.bttn_Regresar = new System.Windows.Forms.Button();
            this.bttn_Consult = new System.Windows.Forms.Button();
            this.Grid_Alumnos = new System.Windows.Forms.DataGridView();
            this.Combo_Grupo = new System.Windows.Forms.ComboBox();
            this.TXT_IDCURSO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_instructorName
            // 
            this.TXT_instructorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_instructorName.Location = new System.Drawing.Point(205, 12);
            this.TXT_instructorName.Name = "TXT_instructorName";
            this.TXT_instructorName.ReadOnly = true;
            this.TXT_instructorName.Size = new System.Drawing.Size(224, 20);
            this.TXT_instructorName.TabIndex = 1;
            this.TXT_instructorName.Text = "Instructor";
            this.TXT_instructorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttn_Regresar
            // 
            this.bttn_Regresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Regresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttn_Regresar.Location = new System.Drawing.Point(602, 324);
            this.bttn_Regresar.Name = "bttn_Regresar";
            this.bttn_Regresar.Size = new System.Drawing.Size(75, 47);
            this.bttn_Regresar.TabIndex = 10;
            this.bttn_Regresar.Text = "Regresar";
            this.bttn_Regresar.UseVisualStyleBackColor = true;
            this.bttn_Regresar.Click += new System.EventHandler(this.bttn_Regresar_Click);
            // 
            // bttn_Consult
            // 
            this.bttn_Consult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Consult.Enabled = false;
            this.bttn_Consult.Location = new System.Drawing.Point(602, 274);
            this.bttn_Consult.Name = "bttn_Consult";
            this.bttn_Consult.Size = new System.Drawing.Size(75, 44);
            this.bttn_Consult.TabIndex = 23;
            this.bttn_Consult.Text = "Consultar";
            this.bttn_Consult.UseVisualStyleBackColor = true;
            this.bttn_Consult.Click += new System.EventHandler(this.bttn_Consult_Click);
            // 
            // Grid_Alumnos
            // 
            this.Grid_Alumnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Grid_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Alumnos.Location = new System.Drawing.Point(12, 39);
            this.Grid_Alumnos.Name = "Grid_Alumnos";
            this.Grid_Alumnos.ReadOnly = true;
            this.Grid_Alumnos.Size = new System.Drawing.Size(574, 336);
            this.Grid_Alumnos.TabIndex = 24;
            this.Grid_Alumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Alumnos_CellContentClick);
            // 
            // Combo_Grupo
            // 
            this.Combo_Grupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_Grupo.FormattingEnabled = true;
            this.Combo_Grupo.Location = new System.Drawing.Point(12, 12);
            this.Combo_Grupo.Name = "Combo_Grupo";
            this.Combo_Grupo.Size = new System.Drawing.Size(121, 21);
            this.Combo_Grupo.TabIndex = 1;
            this.Combo_Grupo.SelectedIndexChanged += new System.EventHandler(this.Combo_Grupo_SelectedIndexChanged);
            // 
            // TXT_IDCURSO
            // 
            this.TXT_IDCURSO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_IDCURSO.Location = new System.Drawing.Point(139, 12);
            this.TXT_IDCURSO.Name = "TXT_IDCURSO";
            this.TXT_IDCURSO.ReadOnly = true;
            this.TXT_IDCURSO.Size = new System.Drawing.Size(60, 20);
            this.TXT_IDCURSO.TabIndex = 26;
            this.TXT_IDCURSO.Text = "ID Curso";
            this.TXT_IDCURSO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttn_Regresar;
            this.ClientSize = new System.Drawing.Size(689, 384);
            this.Controls.Add(this.TXT_IDCURSO);
            this.Controls.Add(this.Combo_Grupo);
            this.Controls.Add(this.Grid_Alumnos);
            this.Controls.Add(this.bttn_Consult);
            this.Controls.Add(this.bttn_Regresar);
            this.Controls.Add(this.TXT_instructorName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(660, 423);
            this.Name = "Ventas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ventas";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Grupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Alumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXT_instructorName;
        private System.Windows.Forms.Button bttn_Regresar;
        private System.Windows.Forms.Button bttn_Consult;
        private System.Windows.Forms.DataGridView Grid_Alumnos;
        private System.Windows.Forms.ComboBox Combo_Grupo;
        private System.Windows.Forms.TextBox TXT_IDCURSO;
    }
}