
namespace WindowsFormsApplication1
{
    partial class Libros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libros));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckDelete = new System.Windows.Forms.CheckBox();
            this.TXT_Lugar = new System.Windows.Forms.TextBox();
            this.Combo_InstructorID = new System.Windows.Forms.ComboBox();
            this.TXT_InstructorName = new System.Windows.Forms.TextBox();
            this.TXT_IDCurso = new System.Windows.Forms.TextBox();
            this.Combo_Curso = new System.Windows.Forms.ComboBox();
            this.TXT_Horario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Combo_TipoCurso = new System.Windows.Forms.ComboBox();
            this.bttn_Save = new FontAwesome.Sharp.IconButton();
            this.bttn_Modify = new FontAwesome.Sharp.IconButton();
            this.bttn_Delete = new FontAwesome.Sharp.IconButton();
            this.bttn_Consult = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Horario:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lugar:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de curso:";
            // 
            // CheckDelete
            // 
            this.CheckDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckDelete.AutoSize = true;
            this.CheckDelete.Location = new System.Drawing.Point(470, 198);
            this.CheckDelete.Name = "CheckDelete";
            this.CheckDelete.Size = new System.Drawing.Size(68, 17);
            this.CheckDelete.TabIndex = 24;
            this.CheckDelete.Text = "Cancelar";
            this.CheckDelete.UseVisualStyleBackColor = true;
            this.CheckDelete.Visible = false;
            this.CheckDelete.CheckedChanged += new System.EventHandler(this.CheckDelete_CheckedChanged);
            // 
            // TXT_Lugar
            // 
            this.TXT_Lugar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_Lugar.Location = new System.Drawing.Point(197, 162);
            this.TXT_Lugar.MaxLength = 100;
            this.TXT_Lugar.Name = "TXT_Lugar";
            this.TXT_Lugar.Size = new System.Drawing.Size(186, 20);
            this.TXT_Lugar.TabIndex = 27;
            this.TXT_Lugar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Combo_InstructorID
            // 
            this.Combo_InstructorID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_InstructorID.FormattingEnabled = true;
            this.Combo_InstructorID.Location = new System.Drawing.Point(197, 109);
            this.Combo_InstructorID.Name = "Combo_InstructorID";
            this.Combo_InstructorID.Size = new System.Drawing.Size(87, 21);
            this.Combo_InstructorID.TabIndex = 28;
            this.Combo_InstructorID.SelectedIndexChanged += new System.EventHandler(this.Combo_InstructorID_SelectedIndexChanged);
            // 
            // TXT_InstructorName
            // 
            this.TXT_InstructorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_InstructorName.Enabled = false;
            this.TXT_InstructorName.Location = new System.Drawing.Point(291, 109);
            this.TXT_InstructorName.MaxLength = 100;
            this.TXT_InstructorName.Name = "TXT_InstructorName";
            this.TXT_InstructorName.Size = new System.Drawing.Size(163, 20);
            this.TXT_InstructorName.TabIndex = 29;
            // 
            // TXT_IDCurso
            // 
            this.TXT_IDCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_IDCurso.Location = new System.Drawing.Point(197, 82);
            this.TXT_IDCurso.MaxLength = 10;
            this.TXT_IDCurso.Name = "TXT_IDCurso";
            this.TXT_IDCurso.Size = new System.Drawing.Size(87, 20);
            this.TXT_IDCurso.TabIndex = 30;
            // 
            // Combo_Curso
            // 
            this.Combo_Curso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_Curso.FormattingEnabled = true;
            this.Combo_Curso.Location = new System.Drawing.Point(291, 82);
            this.Combo_Curso.Name = "Combo_Curso";
            this.Combo_Curso.Size = new System.Drawing.Size(163, 21);
            this.Combo_Curso.TabIndex = 32;
            this.Combo_Curso.SelectedIndexChanged += new System.EventHandler(this.Combo_Curso_SelectedIndexChanged);
            // 
            // TXT_Horario
            // 
            this.TXT_Horario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_Horario.Location = new System.Drawing.Point(197, 136);
            this.TXT_Horario.Name = "TXT_Horario";
            this.TXT_Horario.Size = new System.Drawing.Size(186, 20);
            this.TXT_Horario.TabIndex = 33;
            this.TXT_Horario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Instructor:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Curso:";
            // 
            // Combo_TipoCurso
            // 
            this.Combo_TipoCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_TipoCurso.FormattingEnabled = true;
            this.Combo_TipoCurso.Items.AddRange(new object[] {
            "Clase en linea",
            "Clase presencial"});
            this.Combo_TipoCurso.Location = new System.Drawing.Point(197, 188);
            this.Combo_TipoCurso.Name = "Combo_TipoCurso";
            this.Combo_TipoCurso.Size = new System.Drawing.Size(186, 21);
            this.Combo_TipoCurso.TabIndex = 36;
            // 
            // bttn_Save
            // 
            this.bttn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Save.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.bttn_Save.IconColor = System.Drawing.Color.Black;
            this.bttn_Save.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_Save.IconSize = 20;
            this.bttn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Save.Location = new System.Drawing.Point(551, 86);
            this.bttn_Save.Name = "bttn_Save";
            this.bttn_Save.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Save.Size = new System.Drawing.Size(88, 43);
            this.bttn_Save.TabIndex = 37;
            this.bttn_Save.Text = "Guardar";
            this.bttn_Save.UseVisualStyleBackColor = true;
            this.bttn_Save.Click += new System.EventHandler(this.bttn_Save_Click);
            // 
            // bttn_Modify
            // 
            this.bttn_Modify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Modify.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.bttn_Modify.IconColor = System.Drawing.Color.Black;
            this.bttn_Modify.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_Modify.IconSize = 20;
            this.bttn_Modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Modify.Location = new System.Drawing.Point(551, 135);
            this.bttn_Modify.Name = "bttn_Modify";
            this.bttn_Modify.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Modify.Size = new System.Drawing.Size(88, 43);
            this.bttn_Modify.TabIndex = 38;
            this.bttn_Modify.Text = "Modificar";
            this.bttn_Modify.UseVisualStyleBackColor = true;
            this.bttn_Modify.Click += new System.EventHandler(this.bttn_Modify_Click);
            // 
            // bttn_Delete
            // 
            this.bttn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.bttn_Delete.IconColor = System.Drawing.Color.Black;
            this.bttn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttn_Delete.IconSize = 22;
            this.bttn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Delete.Location = new System.Drawing.Point(551, 181);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Delete.Size = new System.Drawing.Size(88, 43);
            this.bttn_Delete.TabIndex = 39;
            this.bttn_Delete.Text = "Eliminar";
            this.bttn_Delete.UseVisualStyleBackColor = true;
            this.bttn_Delete.Visible = false;
            this.bttn_Delete.Click += new System.EventHandler(this.bttn_Delete_Click);
            // 
            // bttn_Consult
            // 
            this.bttn_Consult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Consult.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bttn_Consult.IconColor = System.Drawing.Color.Black;
            this.bttn_Consult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttn_Consult.IconSize = 20;
            this.bttn_Consult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Consult.Location = new System.Drawing.Point(551, 230);
            this.bttn_Consult.Name = "bttn_Consult";
            this.bttn_Consult.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.bttn_Consult.Size = new System.Drawing.Size(88, 43);
            this.bttn_Consult.TabIndex = 40;
            this.bttn_Consult.Text = "Consultar";
            this.bttn_Consult.UseVisualStyleBackColor = true;
            this.bttn_Consult.Click += new System.EventHandler(this.bttn_Consult_Click);
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 384);
            this.Controls.Add(this.bttn_Consult);
            this.Controls.Add(this.bttn_Delete);
            this.Controls.Add(this.bttn_Modify);
            this.Controls.Add(this.bttn_Save);
            this.Controls.Add(this.Combo_TipoCurso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_Horario);
            this.Controls.Add(this.Combo_Curso);
            this.Controls.Add(this.TXT_IDCurso);
            this.Controls.Add(this.TXT_InstructorName);
            this.Controls.Add(this.Combo_InstructorID);
            this.Controls.Add(this.TXT_Lugar);
            this.Controls.Add(this.CheckDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Libros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Curso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckDelete;
        private System.Windows.Forms.TextBox TXT_Lugar;
        private System.Windows.Forms.ComboBox Combo_InstructorID;
        private System.Windows.Forms.TextBox TXT_InstructorName;
        private System.Windows.Forms.TextBox TXT_IDCurso;
        private System.Windows.Forms.ComboBox Combo_Curso;
        private System.Windows.Forms.TextBox TXT_Horario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Combo_TipoCurso;
        private FontAwesome.Sharp.IconButton bttn_Save;
        private FontAwesome.Sharp.IconButton bttn_Modify;
        private FontAwesome.Sharp.IconButton bttn_Delete;
        private FontAwesome.Sharp.IconButton bttn_Consult;
    }
}