
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
            this.TXT_EditorialLibro = new System.Windows.Forms.TextBox();
            this.TXT_LibroName = new System.Windows.Forms.TextBox();
            this.Combo_Libro = new System.Windows.Forms.ComboBox();
            this.TXT_AutorLibro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Combo_TemasLibros = new System.Windows.Forms.ComboBox();
            this.bttn_Save = new FontAwesome.Sharp.IconButton();
            this.bttn_Modify = new FontAwesome.Sharp.IconButton();
            this.bttn_Delete = new FontAwesome.Sharp.IconButton();
            this.bttn_Consult = new FontAwesome.Sharp.IconButton();
            this.txt_PrecioLibro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Combo_fechaPublic = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Editorial:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Temas:";
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
            // TXT_EditorialLibro
            // 
            this.TXT_EditorialLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_EditorialLibro.Location = new System.Drawing.Point(197, 162);
            this.TXT_EditorialLibro.MaxLength = 100;
            this.TXT_EditorialLibro.Name = "TXT_EditorialLibro";
            this.TXT_EditorialLibro.Size = new System.Drawing.Size(186, 20);
            this.TXT_EditorialLibro.TabIndex = 4;
            // 
            // TXT_LibroName
            // 
            this.TXT_LibroName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_LibroName.Enabled = false;
            this.TXT_LibroName.Location = new System.Drawing.Point(197, 109);
            this.TXT_LibroName.MaxLength = 100;
            this.TXT_LibroName.Name = "TXT_LibroName";
            this.TXT_LibroName.Size = new System.Drawing.Size(186, 20);
            this.TXT_LibroName.TabIndex = 2;
            // 
            // Combo_Libro
            // 
            this.Combo_Libro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_Libro.FormattingEnabled = true;
            this.Combo_Libro.Location = new System.Drawing.Point(197, 82);
            this.Combo_Libro.Name = "Combo_Libro";
            this.Combo_Libro.Size = new System.Drawing.Size(186, 21);
            this.Combo_Libro.TabIndex = 1;
            this.Combo_Libro.SelectedIndexChanged += new System.EventHandler(this.Combo_Curso_SelectedIndexChanged);
            // 
            // TXT_AutorLibro
            // 
            this.TXT_AutorLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_AutorLibro.Location = new System.Drawing.Point(197, 136);
            this.TXT_AutorLibro.Name = "TXT_AutorLibro";
            this.TXT_AutorLibro.Size = new System.Drawing.Size(186, 20);
            this.TXT_AutorLibro.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Libro:";
            // 
            // Combo_TemasLibros
            // 
            this.Combo_TemasLibros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_TemasLibros.FormattingEnabled = true;
            this.Combo_TemasLibros.Items.AddRange(new object[] {
            "Literatura",
            "Comic y fantasia",
            "Infantil",
            "Juvenil",
            "Conocimiento y Ciencia",
            "Actualidad y Empresa",
            "Bienestar y salud",
            "Cocina y Gastronomia",
            "Viajes y ocio",
            "Agendas y Calendarios"});
            this.Combo_TemasLibros.Location = new System.Drawing.Point(197, 188);
            this.Combo_TemasLibros.Name = "Combo_TemasLibros";
            this.Combo_TemasLibros.Size = new System.Drawing.Size(186, 21);
            this.Combo_TemasLibros.TabIndex = 5;
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
            // txt_PrecioLibro
            // 
            this.txt_PrecioLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_PrecioLibro.Location = new System.Drawing.Point(197, 241);
            this.txt_PrecioLibro.MaxLength = 100;
            this.txt_PrecioLibro.Name = "txt_PrecioLibro";
            this.txt_PrecioLibro.Size = new System.Drawing.Size(186, 20);
            this.txt_PrecioLibro.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Precio: ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Fecha de Publicacion: ";
            // 
            // Combo_fechaPublic
            // 
            this.Combo_fechaPublic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_fechaPublic.Location = new System.Drawing.Point(197, 214);
            this.Combo_fechaPublic.Name = "Combo_fechaPublic";
            this.Combo_fechaPublic.Size = new System.Drawing.Size(202, 20);
            this.Combo_fechaPublic.TabIndex = 6;
            // 
            // Libros
            // 
            this.AcceptButton = this.bttn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 384);
            this.Controls.Add(this.Combo_fechaPublic);
            this.Controls.Add(this.txt_PrecioLibro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttn_Consult);
            this.Controls.Add(this.bttn_Delete);
            this.Controls.Add(this.bttn_Modify);
            this.Controls.Add(this.bttn_Save);
            this.Controls.Add(this.Combo_TemasLibros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_AutorLibro);
            this.Controls.Add(this.Combo_Libro);
            this.Controls.Add(this.TXT_LibroName);
            this.Controls.Add(this.TXT_EditorialLibro);
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
        private System.Windows.Forms.TextBox TXT_EditorialLibro;
        private System.Windows.Forms.TextBox TXT_LibroName;
        private System.Windows.Forms.ComboBox Combo_Libro;
        private System.Windows.Forms.TextBox TXT_AutorLibro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Combo_TemasLibros;
        private FontAwesome.Sharp.IconButton bttn_Save;
        private FontAwesome.Sharp.IconButton bttn_Modify;
        private FontAwesome.Sharp.IconButton bttn_Delete;
        private FontAwesome.Sharp.IconButton bttn_Consult;
        private System.Windows.Forms.TextBox txt_PrecioLibro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Combo_fechaPublic;
    }
}