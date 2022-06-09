
namespace WindowsFormsApplication1
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.txt_IDBook = new System.Windows.Forms.TextBox();
            this.Combo_Libros = new System.Windows.Forms.ComboBox();
            this.Grid_Libros = new System.Windows.Forms.DataGridView();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.bttn_sell = new FontAwesome.Sharp.IconButton();
            this.bttn_Consult = new FontAwesome.Sharp.IconButton();
            this.txt_TelefonoAdq = new System.Windows.Forms.MaskedTextBox();
            this.txt_NameAdq = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.bttn_Select = new FontAwesome.Sharp.IconButton();
            this.Bttn_search = new FontAwesome.Sharp.IconButton();
            this.LBL_CP = new System.Windows.Forms.Label();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.bttn_ClrPrestamo = new FontAwesome.Sharp.IconButton();
            this.Bttn_clrDisponible = new FontAwesome.Sharp.IconButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Libros)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_IDBook
            // 
            this.txt_IDBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_IDBook.Location = new System.Drawing.Point(139, 11);
            this.txt_IDBook.Name = "txt_IDBook";
            this.txt_IDBook.ReadOnly = true;
            this.txt_IDBook.Size = new System.Drawing.Size(60, 20);
            this.txt_IDBook.TabIndex = 33;
            this.txt_IDBook.Text = "ID Libro";
            this.txt_IDBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Combo_Libros
            // 
            this.Combo_Libros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_Libros.FormattingEnabled = true;
            this.Combo_Libros.Location = new System.Drawing.Point(12, 11);
            this.Combo_Libros.Name = "Combo_Libros";
            this.Combo_Libros.Size = new System.Drawing.Size(121, 21);
            this.Combo_Libros.TabIndex = 28;
            // 
            // Grid_Libros
            // 
            this.Grid_Libros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Grid_Libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Libros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.Grid_Libros.Location = new System.Drawing.Point(12, 38);
            this.Grid_Libros.Name = "Grid_Libros";
            this.Grid_Libros.ReadOnly = true;
            this.Grid_Libros.Size = new System.Drawing.Size(589, 336);
            this.Grid_Libros.TabIndex = 32;
            // 
            // txt_Autor
            // 
            this.txt_Autor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Autor.Location = new System.Drawing.Point(205, 11);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.ReadOnly = true;
            this.txt_Autor.Size = new System.Drawing.Size(224, 20);
            this.txt_Autor.TabIndex = 29;
            this.txt_Autor.Text = "Autor";
            // 
            // bttn_sell
            // 
            this.bttn_sell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_sell.IconChar = FontAwesome.Sharp.IconChar.GrinBeam;
            this.bttn_sell.IconColor = System.Drawing.Color.Black;
            this.bttn_sell.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_sell.IconSize = 20;
            this.bttn_sell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_sell.Location = new System.Drawing.Point(722, 280);
            this.bttn_sell.Name = "bttn_sell";
            this.bttn_sell.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_sell.Size = new System.Drawing.Size(85, 44);
            this.bttn_sell.TabIndex = 45;
            this.bttn_sell.Text = "Prestamo";
            this.bttn_sell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttn_sell.UseVisualStyleBackColor = true;
            this.bttn_sell.Click += new System.EventHandler(this.Sell_Click);
            // 
            // bttn_Consult
            // 
            this.bttn_Consult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Consult.IconChar = FontAwesome.Sharp.IconChar.HandPointRight;
            this.bttn_Consult.IconColor = System.Drawing.Color.Black;
            this.bttn_Consult.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_Consult.IconSize = 20;
            this.bttn_Consult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Consult.Location = new System.Drawing.Point(722, 330);
            this.bttn_Consult.Name = "bttn_Consult";
            this.bttn_Consult.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Consult.Size = new System.Drawing.Size(85, 44);
            this.bttn_Consult.TabIndex = 44;
            this.bttn_Consult.Text = "Consultar";
            this.bttn_Consult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttn_Consult.UseVisualStyleBackColor = true;
            this.bttn_Consult.Click += new System.EventHandler(this.bttn_Consult_Click);
            // 
            // txt_TelefonoAdq
            // 
            this.txt_TelefonoAdq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TelefonoAdq.Location = new System.Drawing.Point(607, 228);
            this.txt_TelefonoAdq.Mask = "000-000-0000";
            this.txt_TelefonoAdq.Name = "txt_TelefonoAdq";
            this.txt_TelefonoAdq.Size = new System.Drawing.Size(200, 20);
            this.txt_TelefonoAdq.TabIndex = 55;
            // 
            // txt_NameAdq
            // 
            this.txt_NameAdq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NameAdq.Location = new System.Drawing.Point(607, 254);
            this.txt_NameAdq.Name = "txt_NameAdq";
            this.txt_NameAdq.Size = new System.Drawing.Size(200, 20);
            this.txt_NameAdq.TabIndex = 53;
            this.txt_NameAdq.Text = "Nombre";
            // 
            // dateTime
            // 
            this.dateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTime.Enabled = false;
            this.dateTime.Location = new System.Drawing.Point(607, 202);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 52;
            // 
            // bttn_Select
            // 
            this.bttn_Select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Select.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.bttn_Select.IconColor = System.Drawing.Color.Black;
            this.bttn_Select.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_Select.IconSize = 20;
            this.bttn_Select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Select.Location = new System.Drawing.Point(607, 153);
            this.bttn_Select.Name = "bttn_Select";
            this.bttn_Select.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Select.Size = new System.Drawing.Size(200, 43);
            this.bttn_Select.TabIndex = 56;
            this.bttn_Select.Text = "Seleccionar";
            this.bttn_Select.UseVisualStyleBackColor = true;
            this.bttn_Select.Click += new System.EventHandler(this.bttn_Select_Click);
            // 
            // Bttn_search
            // 
            this.Bttn_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bttn_search.IconChar = FontAwesome.Sharp.IconChar.HandPointRight;
            this.Bttn_search.IconColor = System.Drawing.Color.Black;
            this.Bttn_search.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Bttn_search.IconSize = 20;
            this.Bttn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bttn_search.Location = new System.Drawing.Point(592, 12);
            this.Bttn_search.Name = "Bttn_search";
            this.Bttn_search.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Bttn_search.Size = new System.Drawing.Size(85, 21);
            this.Bttn_search.TabIndex = 57;
            this.Bttn_search.Text = "Buscar";
            this.Bttn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bttn_search.UseVisualStyleBackColor = true;
            this.Bttn_search.Click += new System.EventHandler(this.Bttn_search_Click);
            // 
            // LBL_CP
            // 
            this.LBL_CP.AutoSize = true;
            this.LBL_CP.Location = new System.Drawing.Point(527, 16);
            this.LBL_CP.Name = "LBL_CP";
            this.LBL_CP.Size = new System.Drawing.Size(0, 13);
            this.LBL_CP.TabIndex = 59;
            // 
            // txt_Clave
            // 
            this.txt_Clave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Clave.Location = new System.Drawing.Point(435, 13);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(151, 20);
            this.txt_Clave.TabIndex = 58;
            this.txt_Clave.Text = "Clave";
            this.txt_Clave.TextChanged += new System.EventHandler(this.txt_Clave_TextChanged);
            this.txt_Clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Clave_KeyPress);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.HandsHelping;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(607, 280);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(109, 92);
            this.iconButton1.TabIndex = 60;
            this.iconButton1.Text = "Devolucion";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // bttn_ClrPrestamo
            // 
            this.bttn_ClrPrestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_ClrPrestamo.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.bttn_ClrPrestamo.IconColor = System.Drawing.Color.Black;
            this.bttn_ClrPrestamo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_ClrPrestamo.IconSize = 20;
            this.bttn_ClrPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_ClrPrestamo.Location = new System.Drawing.Point(607, 104);
            this.bttn_ClrPrestamo.Name = "bttn_ClrPrestamo";
            this.bttn_ClrPrestamo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_ClrPrestamo.Size = new System.Drawing.Size(200, 43);
            this.bttn_ClrPrestamo.TabIndex = 61;
            this.bttn_ClrPrestamo.Text = "Limpiar Prestamos";
            this.bttn_ClrPrestamo.UseVisualStyleBackColor = true;
            this.bttn_ClrPrestamo.Click += new System.EventHandler(this.bttn_ClrPrestamo_Click);
            // 
            // Bttn_clrDisponible
            // 
            this.Bttn_clrDisponible.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bttn_clrDisponible.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.Bttn_clrDisponible.IconColor = System.Drawing.Color.Black;
            this.Bttn_clrDisponible.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Bttn_clrDisponible.IconSize = 20;
            this.Bttn_clrDisponible.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bttn_clrDisponible.Location = new System.Drawing.Point(607, 55);
            this.Bttn_clrDisponible.Name = "Bttn_clrDisponible";
            this.Bttn_clrDisponible.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Bttn_clrDisponible.Size = new System.Drawing.Size(200, 43);
            this.Bttn_clrDisponible.TabIndex = 62;
            this.Bttn_clrDisponible.Text = "Limpiar Disponibles";
            this.Bttn_clrDisponible.UseVisualStyleBackColor = true;
            this.Bttn_clrDisponible.Click += new System.EventHandler(this.Bttn_clrDisponible_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Titulo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Autor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tematica";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha de Prestamo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Dia de Devolucion";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Usuario Adq";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Telefono";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Estado";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 85;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Autorizo";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 60;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 384);
            this.Controls.Add(this.Grid_Libros);
            this.Controls.Add(this.Bttn_clrDisponible);
            this.Controls.Add(this.bttn_ClrPrestamo);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.LBL_CP);
            this.Controls.Add(this.Bttn_search);
            this.Controls.Add(this.bttn_Select);
            this.Controls.Add(this.txt_TelefonoAdq);
            this.Controls.Add(this.txt_NameAdq);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.bttn_sell);
            this.Controls.Add(this.bttn_Consult);
            this.Controls.Add(this.txt_IDBook);
            this.Controls.Add(this.Combo_Libros);
            this.Controls.Add(this.txt_Autor);
            this.Controls.Add(this.txt_Clave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Libros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_IDBook;
        private System.Windows.Forms.ComboBox Combo_Libros;
        private System.Windows.Forms.DataGridView Grid_Libros;
        private System.Windows.Forms.TextBox txt_Autor;
        private FontAwesome.Sharp.IconButton bttn_sell;
        private FontAwesome.Sharp.IconButton bttn_Consult;
        private System.Windows.Forms.MaskedTextBox txt_TelefonoAdq;
        private System.Windows.Forms.TextBox txt_NameAdq;
        private System.Windows.Forms.DateTimePicker dateTime;
        private FontAwesome.Sharp.IconButton bttn_Select;
        private FontAwesome.Sharp.IconButton Bttn_search;
        private System.Windows.Forms.Label LBL_CP;
        private System.Windows.Forms.TextBox txt_Clave;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton bttn_ClrPrestamo;
        private FontAwesome.Sharp.IconButton Bttn_clrDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}