
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
            this.bttn_Regresar = new System.Windows.Forms.Button();
            this.bttn_Consult = new System.Windows.Forms.Button();
            this.Grid_Libros = new System.Windows.Forms.DataGridView();
            this.Combo_Libros = new System.Windows.Forms.ComboBox();
            this.txt_IDBook = new System.Windows.Forms.TextBox();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Libros)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Autor
            // 
            this.txt_Autor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Autor.Location = new System.Drawing.Point(205, 12);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.ReadOnly = true;
            this.txt_Autor.Size = new System.Drawing.Size(224, 20);
            this.txt_Autor.TabIndex = 1;
            this.txt_Autor.Text = "Autor";
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
            // Grid_Libros
            // 
            this.Grid_Libros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Grid_Libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Libros.Location = new System.Drawing.Point(12, 39);
            this.Grid_Libros.Name = "Grid_Libros";
            this.Grid_Libros.ReadOnly = true;
            this.Grid_Libros.Size = new System.Drawing.Size(574, 336);
            this.Grid_Libros.TabIndex = 24;
            this.Grid_Libros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Libros_CellContentClick);
            // 
            // Combo_Libros
            // 
            this.Combo_Libros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_Libros.FormattingEnabled = true;
            this.Combo_Libros.Location = new System.Drawing.Point(12, 12);
            this.Combo_Libros.Name = "Combo_Libros";
            this.Combo_Libros.Size = new System.Drawing.Size(121, 21);
            this.Combo_Libros.TabIndex = 1;
            this.Combo_Libros.SelectedIndexChanged += new System.EventHandler(this.Combo_Libro_SelectedIndexChanged);
            // 
            // txt_IDBook
            // 
            this.txt_IDBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_IDBook.Location = new System.Drawing.Point(139, 12);
            this.txt_IDBook.Name = "txt_IDBook";
            this.txt_IDBook.ReadOnly = true;
            this.txt_IDBook.Size = new System.Drawing.Size(60, 20);
            this.txt_IDBook.TabIndex = 26;
            this.txt_IDBook.Text = "ID Libro";
            this.txt_IDBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Clave
            // 
            this.txt_Clave.Location = new System.Drawing.Point(436, 11);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(100, 20);
            this.txt_Clave.TabIndex = 27;
            this.txt_Clave.Text = "Clave";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttn_Regresar;
            this.ClientSize = new System.Drawing.Size(689, 384);
            this.Controls.Add(this.txt_Clave);
            this.Controls.Add(this.txt_IDBook);
            this.Controls.Add(this.Combo_Libros);
            this.Controls.Add(this.Grid_Libros);
            this.Controls.Add(this.bttn_Consult);
            this.Controls.Add(this.bttn_Regresar);
            this.Controls.Add(this.txt_Autor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(660, 423);
            this.Name = "Ventas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ventas";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Grupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Libros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       


        #endregion
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.Button bttn_Regresar;
        private System.Windows.Forms.Button bttn_Consult;
        private System.Windows.Forms.DataGridView Grid_Libros;
        private System.Windows.Forms.ComboBox Combo_Libros;
        private System.Windows.Forms.TextBox txt_IDBook;
        private System.Windows.Forms.TextBox txt_Clave;
    }
}