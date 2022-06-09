
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
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.Grid_Libros = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tematica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combo_Libros = new System.Windows.Forms.ComboBox();
            this.txt_IDBook = new System.Windows.Forms.TextBox();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.bttn_Consult = new FontAwesome.Sharp.IconButton();
            this.bttn_sell = new FontAwesome.Sharp.IconButton();
            this.LBL_CP = new System.Windows.Forms.Label();
            this.Bttn_search = new FontAwesome.Sharp.IconButton();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txt_NameAdq = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.MaskedTextBox();
            this.txt_TelefonoAdq = new System.Windows.Forms.MaskedTextBox();
            this.bttn_Select = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Libros)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Autor
            // 
            this.txt_Autor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Autor.Location = new System.Drawing.Point(294, 9);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.ReadOnly = true;
            this.txt_Autor.Size = new System.Drawing.Size(135, 20);
            this.txt_Autor.TabIndex = 10;
            this.txt_Autor.Text = "Autor";
            // 
            // Grid_Libros
            // 
            this.Grid_Libros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Grid_Libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Libros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameBook,
            this.Autor,
            this.Tematica,
            this.Precio,
            this.Estado,
            this.Autorizacion});
            this.Grid_Libros.Location = new System.Drawing.Point(12, 36);
            this.Grid_Libros.Name = "Grid_Libros";
            this.Grid_Libros.ReadOnly = true;
            this.Grid_Libros.Size = new System.Drawing.Size(574, 336);
            this.Grid_Libros.TabIndex = 24;
            this.Grid_Libros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Libros_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NameBook
            // 
            this.NameBook.HeaderText = "Titulo";
            this.NameBook.Name = "NameBook";
            this.NameBook.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Tematica
            // 
            this.Tematica.HeaderText = "Tematica";
            this.Tematica.Name = "Tematica";
            this.Tematica.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Autorizacion
            // 
            this.Autorizacion.HeaderText = "Autorizó";
            this.Autorizacion.Name = "Autorizacion";
            this.Autorizacion.ReadOnly = true;
            // 
            // Combo_Libros
            // 
            this.Combo_Libros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_Libros.FormattingEnabled = true;
            this.Combo_Libros.Location = new System.Drawing.Point(12, 9);
            this.Combo_Libros.Name = "Combo_Libros";
            this.Combo_Libros.Size = new System.Drawing.Size(121, 21);
            this.Combo_Libros.TabIndex = 8;
            this.Combo_Libros.SelectedIndexChanged += new System.EventHandler(this.Combo_Libro_SelectedIndexChanged);
            // 
            // txt_IDBook
            // 
            this.txt_IDBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_IDBook.Location = new System.Drawing.Point(139, 9);
            this.txt_IDBook.Name = "txt_IDBook";
            this.txt_IDBook.ReadOnly = true;
            this.txt_IDBook.Size = new System.Drawing.Size(149, 20);
            this.txt_IDBook.TabIndex = 9;
            this.txt_IDBook.Text = "Titulo";
            // 
            // txt_Clave
            // 
            this.txt_Clave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Clave.Location = new System.Drawing.Point(435, 9);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(151, 20);
            this.txt_Clave.TabIndex = 0;
            this.txt_Clave.Text = "Clave";
            this.txt_Clave.TextChanged += new System.EventHandler(this.txt_Clave_TextChanged);
            this.txt_Clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Clave_KeyPress);
            this.txt_Clave.Leave += new System.EventHandler(this.Bttn_search_Click);
            // 
            // bttn_Consult
            // 
            this.bttn_Consult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Consult.IconChar = FontAwesome.Sharp.IconChar.HandPointRight;
            this.bttn_Consult.IconColor = System.Drawing.Color.Black;
            this.bttn_Consult.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_Consult.IconSize = 20;
            this.bttn_Consult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Consult.Location = new System.Drawing.Point(722, 328);
            this.bttn_Consult.Name = "bttn_Consult";
            this.bttn_Consult.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Consult.Size = new System.Drawing.Size(85, 44);
            this.bttn_Consult.TabIndex = 0;
            this.bttn_Consult.Text = "Consultar";
            this.bttn_Consult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttn_Consult.UseVisualStyleBackColor = true;
            this.bttn_Consult.Click += new System.EventHandler(this.bttn_Consult_Click_1);
            // 
            // bttn_sell
            // 
            this.bttn_sell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_sell.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.bttn_sell.IconColor = System.Drawing.Color.Black;
            this.bttn_sell.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_sell.IconSize = 20;
            this.bttn_sell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_sell.Location = new System.Drawing.Point(722, 278);
            this.bttn_sell.Name = "bttn_sell";
            this.bttn_sell.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_sell.Size = new System.Drawing.Size(85, 44);
            this.bttn_sell.TabIndex = 4;
            this.bttn_sell.Text = "Vender";
            this.bttn_sell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttn_sell.UseVisualStyleBackColor = true;
            this.bttn_sell.Click += new System.EventHandler(this.Sell_Click);
            // 
            // LBL_CP
            // 
            this.LBL_CP.AutoSize = true;
            this.LBL_CP.Location = new System.Drawing.Point(527, 12);
            this.LBL_CP.Name = "LBL_CP";
            this.LBL_CP.Size = new System.Drawing.Size(0, 13);
            this.LBL_CP.TabIndex = 44;
            // 
            // Bttn_search
            // 
            this.Bttn_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bttn_search.IconChar = FontAwesome.Sharp.IconChar.HandPointRight;
            this.Bttn_search.IconColor = System.Drawing.Color.Black;
            this.Bttn_search.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Bttn_search.IconSize = 20;
            this.Bttn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bttn_search.Location = new System.Drawing.Point(592, 9);
            this.Bttn_search.Name = "Bttn_search";
            this.Bttn_search.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Bttn_search.Size = new System.Drawing.Size(85, 21);
            this.Bttn_search.TabIndex = 45;
            this.Bttn_search.Text = "Buscar";
            this.Bttn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bttn_search.UseVisualStyleBackColor = true;
            this.Bttn_search.Click += new System.EventHandler(this.Bttn_search_Click);
            // 
            // dateTime
            // 
            this.dateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTime.Enabled = false;
            this.dateTime.Location = new System.Drawing.Point(607, 200);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 47;
            // 
            // txt_NameAdq
            // 
            this.txt_NameAdq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NameAdq.Location = new System.Drawing.Point(607, 252);
            this.txt_NameAdq.Name = "txt_NameAdq";
            this.txt_NameAdq.Size = new System.Drawing.Size(200, 20);
            this.txt_NameAdq.TabIndex = 2;
            this.txt_NameAdq.Text = "Nombre";
            // 
            // txt_price
            // 
            this.txt_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_price.Location = new System.Drawing.Point(616, 291);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 3;
            // 
            // txt_TelefonoAdq
            // 
            this.txt_TelefonoAdq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TelefonoAdq.Location = new System.Drawing.Point(607, 226);
            this.txt_TelefonoAdq.Mask = "0000000000";
            this.txt_TelefonoAdq.Name = "txt_TelefonoAdq";
            this.txt_TelefonoAdq.Size = new System.Drawing.Size(200, 20);
            this.txt_TelefonoAdq.TabIndex = 1;
            // 
            // bttn_Select
            // 
            this.bttn_Select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Select.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.bttn_Select.IconColor = System.Drawing.Color.Black;
            this.bttn_Select.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_Select.IconSize = 20;
            this.bttn_Select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Select.Location = new System.Drawing.Point(607, 151);
            this.bttn_Select.Name = "bttn_Select";
            this.bttn_Select.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Select.Size = new System.Drawing.Size(200, 43);
            this.bttn_Select.TabIndex = 10;
            this.bttn_Select.Text = "Seleccionar";
            this.bttn_Select.UseVisualStyleBackColor = true;
            this.bttn_Select.Click += new System.EventHandler(this.bttn_Select_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.HandsHelping;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(607, 328);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(109, 44);
            this.iconButton1.TabIndex = 53;
            this.iconButton1.Text = "Devolucion";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(607, 102);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(200, 43);
            this.iconButton2.TabIndex = 54;
            this.iconButton2.Text = "Limpiar Ventas";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 384);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.bttn_Select);
            this.Controls.Add(this.txt_TelefonoAdq);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_NameAdq);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.Bttn_search);
            this.Controls.Add(this.LBL_CP);
            this.Controls.Add(this.bttn_sell);
            this.Controls.Add(this.bttn_Consult);
            this.Controls.Add(this.txt_Clave);
            this.Controls.Add(this.txt_IDBook);
            this.Controls.Add(this.Combo_Libros);
            this.Controls.Add(this.Grid_Libros);
            this.Controls.Add(this.txt_Autor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(660, 423);
            this.Name = "Ventas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ventas";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Libroo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Libros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       


        #endregion
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.DataGridView Grid_Libros;
        private System.Windows.Forms.ComboBox Combo_Libros;
        private System.Windows.Forms.TextBox txt_IDBook;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tematica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autorizacion;
        private FontAwesome.Sharp.IconButton bttn_Consult;
        private FontAwesome.Sharp.IconButton bttn_sell;
        private System.Windows.Forms.Label LBL_CP;
        private FontAwesome.Sharp.IconButton Bttn_search;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox txt_NameAdq;
        private System.Windows.Forms.MaskedTextBox txt_price;
        private System.Windows.Forms.MaskedTextBox txt_TelefonoAdq;
        private FontAwesome.Sharp.IconButton bttn_Select;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}