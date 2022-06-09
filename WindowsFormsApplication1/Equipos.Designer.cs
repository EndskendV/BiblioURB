
namespace WindowsFormsApplication1
{
    partial class Equipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipos));
            this.lbl_ID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.schoolDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bttn_Unlock = new FontAwesome.Sharp.IconButton();
            this.bttn_Lock = new FontAwesome.Sharp.IconButton();
            this.bttn_Select = new FontAwesome.Sharp.IconButton();
            this.DatosR = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_add = new System.Windows.Forms.Button();
            this.PC_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosR)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(33, 131);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 13);
            this.lbl_ID.TabIndex = 12;
            this.lbl_ID.Text = "ID:";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "ID\'s Disponibles";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // plazaTableAdapter
            // 
            // 
            // bttn_Unlock
            // 
            this.bttn_Unlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Unlock.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt;
            this.bttn_Unlock.IconColor = System.Drawing.Color.Black;
            this.bttn_Unlock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttn_Unlock.IconSize = 22;
            this.bttn_Unlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Unlock.Location = new System.Drawing.Point(342, 260);
            this.bttn_Unlock.Name = "bttn_Unlock";
            this.bttn_Unlock.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Unlock.Size = new System.Drawing.Size(144, 43);
            this.bttn_Unlock.TabIndex = 43;
            this.bttn_Unlock.Text = "Desbloquear";
            this.bttn_Unlock.UseVisualStyleBackColor = true;
            this.bttn_Unlock.Visible = false;
            this.bttn_Unlock.Click += new System.EventHandler(this.bttn_Unlock_Click);
            // 
            // bttn_Lock
            // 
            this.bttn_Lock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Lock.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.bttn_Lock.IconColor = System.Drawing.Color.Black;
            this.bttn_Lock.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_Lock.IconSize = 20;
            this.bttn_Lock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Lock.Location = new System.Drawing.Point(342, 214);
            this.bttn_Lock.Name = "bttn_Lock";
            this.bttn_Lock.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Lock.Size = new System.Drawing.Size(144, 43);
            this.bttn_Lock.TabIndex = 42;
            this.bttn_Lock.Text = "Bloquear";
            this.bttn_Lock.UseVisualStyleBackColor = true;
            this.bttn_Lock.Visible = false;
            this.bttn_Lock.Click += new System.EventHandler(this.bttn_Locky_Click);
            // 
            // bttn_Select
            // 
            this.bttn_Select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Select.IconChar = FontAwesome.Sharp.IconChar.HandPointRight;
            this.bttn_Select.IconColor = System.Drawing.Color.Black;
            this.bttn_Select.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_Select.IconSize = 20;
            this.bttn_Select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Select.Location = new System.Drawing.Point(342, 165);
            this.bttn_Select.Name = "bttn_Select";
            this.bttn_Select.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Select.Size = new System.Drawing.Size(144, 43);
            this.bttn_Select.TabIndex = 41;
            this.bttn_Select.Text = "Seleccionar";
            this.bttn_Select.UseVisualStyleBackColor = true;
            this.bttn_Select.Click += new System.EventHandler(this.bttn_Select_Click);
            // 
            // DatosR
            // 
            this.DatosR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DatosR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DatosR.Location = new System.Drawing.Point(12, 165);
            this.DatosR.Name = "DatosR";
            this.DatosR.ReadOnly = true;
            this.DatosR.Size = new System.Drawing.Size(267, 207);
            this.DatosR.TabIndex = 45;
            this.DatosR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Equipo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Disponible";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PC_add
            // 
            this.PC_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PC_add.Location = new System.Drawing.Point(12, 12);
            this.PC_add.Name = "PC_add";
            this.PC_add.Size = new System.Drawing.Size(75, 23);
            this.PC_add.TabIndex = 46;
            this.PC_add.Text = "Añadir PC";
            this.PC_add.UseVisualStyleBackColor = true;
            this.PC_add.Click += new System.EventHandler(this.AñadirPc_Click);
            // 
            // PC_Remove
            // 
            this.PC_Remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PC_Remove.Location = new System.Drawing.Point(104, 12);
            this.PC_Remove.Name = "PC_Remove";
            this.PC_Remove.Size = new System.Drawing.Size(75, 23);
            this.PC_Remove.TabIndex = 47;
            this.PC_Remove.Text = "Remover PC";
            this.PC_Remove.UseVisualStyleBackColor = true;
            this.PC_Remove.Click += new System.EventHandler(this.PC_Remove_Click);
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 384);
            this.Controls.Add(this.PC_Remove);
            this.Controls.Add(this.PC_add);
            this.Controls.Add(this.DatosR);
            this.Controls.Add(this.bttn_Unlock);
            this.Controls.Add(this.bttn_Lock);
            this.Controls.Add(this.bttn_Select);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Equipos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.Equipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource schoolDataSet1BindingSource;
        private FontAwesome.Sharp.IconButton bttn_Unlock;
        private FontAwesome.Sharp.IconButton bttn_Lock;
        private FontAwesome.Sharp.IconButton bttn_Select;
        private System.Windows.Forms.DataGridView DatosR;
        private System.Windows.Forms.Button PC_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button PC_Remove;
    }
}