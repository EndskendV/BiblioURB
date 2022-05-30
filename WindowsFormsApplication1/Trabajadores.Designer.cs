
namespace WindowsFormsApplication1
{
    partial class Trabajadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trabajadores));
            this.CheckDelete = new System.Windows.Forms.CheckBox();
            this.Combo_IDDocente = new System.Windows.Forms.ComboBox();
            this.TXT_DocenteName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_IDPlaza = new System.Windows.Forms.TextBox();
            this.Combo_PlazaName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxT_IDDepartamento = new System.Windows.Forms.TextBox();
            this.Combo_DepartamentoName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_IDCurso = new System.Windows.Forms.TextBox();
            this.Combo_CursoName = new System.Windows.Forms.ComboBox();
            this.bttn_Consult = new FontAwesome.Sharp.IconButton();
            this.bttn_Delete = new FontAwesome.Sharp.IconButton();
            this.bttn_Modify = new FontAwesome.Sharp.IconButton();
            this.bttn_Save = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // CheckDelete
            // 
            this.CheckDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckDelete.AutoSize = true;
            this.CheckDelete.Location = new System.Drawing.Point(498, 192);
            this.CheckDelete.Name = "CheckDelete";
            this.CheckDelete.Size = new System.Drawing.Size(68, 17);
            this.CheckDelete.TabIndex = 24;
            this.CheckDelete.Text = "Cancelar";
            this.CheckDelete.UseVisualStyleBackColor = true;
            this.CheckDelete.Visible = false;
            this.CheckDelete.CheckedChanged += new System.EventHandler(this.CheckDelete_CheckedChanged);
            // 
            // Combo_IDDocente
            // 
            this.Combo_IDDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_IDDocente.FormattingEnabled = true;
            this.Combo_IDDocente.Location = new System.Drawing.Point(158, 125);
            this.Combo_IDDocente.MaxLength = 10;
            this.Combo_IDDocente.Name = "Combo_IDDocente";
            this.Combo_IDDocente.Size = new System.Drawing.Size(93, 21);
            this.Combo_IDDocente.TabIndex = 25;
            this.Combo_IDDocente.SelectedIndexChanged += new System.EventHandler(this.Combo_IDDocente_SelectedIndexChanged);
            // 
            // TXT_DocenteName
            // 
            this.TXT_DocenteName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_DocenteName.Location = new System.Drawing.Point(257, 125);
            this.TXT_DocenteName.Name = "TXT_DocenteName";
            this.TXT_DocenteName.Size = new System.Drawing.Size(170, 20);
            this.TXT_DocenteName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID/ Nombre";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Seleccion de Plaza";
            // 
            // TXT_IDPlaza
            // 
            this.TXT_IDPlaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_IDPlaza.Location = new System.Drawing.Point(342, 151);
            this.TXT_IDPlaza.Name = "TXT_IDPlaza";
            this.TXT_IDPlaza.ReadOnly = true;
            this.TXT_IDPlaza.Size = new System.Drawing.Size(85, 20);
            this.TXT_IDPlaza.TabIndex = 29;
            // 
            // Combo_PlazaName
            // 
            this.Combo_PlazaName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_PlazaName.FormattingEnabled = true;
            this.Combo_PlazaName.Location = new System.Drawing.Point(158, 152);
            this.Combo_PlazaName.MaxLength = 10;
            this.Combo_PlazaName.Name = "Combo_PlazaName";
            this.Combo_PlazaName.Size = new System.Drawing.Size(178, 21);
            this.Combo_PlazaName.TabIndex = 28;
            this.Combo_PlazaName.SelectedIndexChanged += new System.EventHandler(this.Combo_PlazaName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Departamento";
            // 
            // TxT_IDDepartamento
            // 
            this.TxT_IDDepartamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxT_IDDepartamento.Location = new System.Drawing.Point(342, 178);
            this.TxT_IDDepartamento.Name = "TxT_IDDepartamento";
            this.TxT_IDDepartamento.ReadOnly = true;
            this.TxT_IDDepartamento.Size = new System.Drawing.Size(85, 20);
            this.TxT_IDDepartamento.TabIndex = 32;
            // 
            // Combo_DepartamentoName
            // 
            this.Combo_DepartamentoName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_DepartamentoName.FormattingEnabled = true;
            this.Combo_DepartamentoName.Location = new System.Drawing.Point(158, 179);
            this.Combo_DepartamentoName.MaxLength = 10;
            this.Combo_DepartamentoName.Name = "Combo_DepartamentoName";
            this.Combo_DepartamentoName.Size = new System.Drawing.Size(178, 21);
            this.Combo_DepartamentoName.TabIndex = 31;
            this.Combo_DepartamentoName.SelectedIndexChanged += new System.EventHandler(this.Combo_DepartamentoName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Curso";
            // 
            // TXT_IDCurso
            // 
            this.TXT_IDCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_IDCurso.Location = new System.Drawing.Point(342, 205);
            this.TXT_IDCurso.Name = "TXT_IDCurso";
            this.TXT_IDCurso.ReadOnly = true;
            this.TXT_IDCurso.Size = new System.Drawing.Size(85, 20);
            this.TXT_IDCurso.TabIndex = 35;
            // 
            // Combo_CursoName
            // 
            this.Combo_CursoName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_CursoName.FormattingEnabled = true;
            this.Combo_CursoName.Location = new System.Drawing.Point(158, 206);
            this.Combo_CursoName.MaxLength = 10;
            this.Combo_CursoName.Name = "Combo_CursoName";
            this.Combo_CursoName.Size = new System.Drawing.Size(178, 21);
            this.Combo_CursoName.TabIndex = 34;
            this.Combo_CursoName.SelectedIndexChanged += new System.EventHandler(this.Combo_CursoName_SelectedIndexChanged);
            // 
            // bttn_Consult
            // 
            this.bttn_Consult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Consult.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bttn_Consult.IconColor = System.Drawing.Color.Black;
            this.bttn_Consult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttn_Consult.IconSize = 20;
            this.bttn_Consult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Consult.Location = new System.Drawing.Point(576, 242);
            this.bttn_Consult.Name = "bttn_Consult";
            this.bttn_Consult.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.bttn_Consult.Size = new System.Drawing.Size(88, 43);
            this.bttn_Consult.TabIndex = 48;
            this.bttn_Consult.Text = "Consultar";
            this.bttn_Consult.UseVisualStyleBackColor = true;
            this.bttn_Consult.Click += new System.EventHandler(this.bttn_Consult_Click);
            // 
            // bttn_Delete
            // 
            this.bttn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.bttn_Delete.IconColor = System.Drawing.Color.Black;
            this.bttn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttn_Delete.IconSize = 22;
            this.bttn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Delete.Location = new System.Drawing.Point(576, 193);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Delete.Size = new System.Drawing.Size(88, 43);
            this.bttn_Delete.TabIndex = 47;
            this.bttn_Delete.Text = "Eliminar";
            this.bttn_Delete.UseVisualStyleBackColor = true;
            this.bttn_Delete.Visible = false;
            this.bttn_Delete.Click += new System.EventHandler(this.bttn_Delete_Click);
            // 
            // bttn_Modify
            // 
            this.bttn_Modify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Modify.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.bttn_Modify.IconColor = System.Drawing.Color.Black;
            this.bttn_Modify.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_Modify.IconSize = 20;
            this.bttn_Modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Modify.Location = new System.Drawing.Point(576, 147);
            this.bttn_Modify.Name = "bttn_Modify";
            this.bttn_Modify.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Modify.Size = new System.Drawing.Size(88, 43);
            this.bttn_Modify.TabIndex = 46;
            this.bttn_Modify.Text = "Modificar";
            this.bttn_Modify.UseVisualStyleBackColor = true;
            this.bttn_Modify.Click += new System.EventHandler(this.bttn_Modify_Click);
            // 
            // bttn_Save
            // 
            this.bttn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Save.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.bttn_Save.IconColor = System.Drawing.Color.Black;
            this.bttn_Save.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_Save.IconSize = 20;
            this.bttn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Save.Location = new System.Drawing.Point(576, 98);
            this.bttn_Save.Name = "bttn_Save";
            this.bttn_Save.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Save.Size = new System.Drawing.Size(88, 43);
            this.bttn_Save.TabIndex = 45;
            this.bttn_Save.Text = "Guardar";
            this.bttn_Save.UseVisualStyleBackColor = true;
            this.bttn_Save.Click += new System.EventHandler(this.bttn_Save_Click);
            // 
            // Trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 384);
            this.Controls.Add(this.bttn_Consult);
            this.Controls.Add(this.bttn_Delete);
            this.Controls.Add(this.bttn_Modify);
            this.Controls.Add(this.bttn_Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_IDCurso);
            this.Controls.Add(this.Combo_CursoName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxT_IDDepartamento);
            this.Controls.Add(this.Combo_DepartamentoName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_IDPlaza);
            this.Controls.Add(this.Combo_PlazaName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_DocenteName);
            this.Controls.Add(this.Combo_IDDocente);
            this.Controls.Add(this.CheckDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Trabajadores";
            this.Text = "Trabajadores";
            this.Load += new System.EventHandler(this.Docente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CheckDelete;
        private System.Windows.Forms.ComboBox Combo_IDDocente;
        private System.Windows.Forms.TextBox TXT_DocenteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_IDPlaza;
        private System.Windows.Forms.ComboBox Combo_PlazaName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxT_IDDepartamento;
        private System.Windows.Forms.ComboBox Combo_DepartamentoName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_IDCurso;
        private System.Windows.Forms.ComboBox Combo_CursoName;
        private FontAwesome.Sharp.IconButton bttn_Consult;
        private FontAwesome.Sharp.IconButton bttn_Delete;
        private FontAwesome.Sharp.IconButton bttn_Modify;
        private FontAwesome.Sharp.IconButton bttn_Save;
    }
}