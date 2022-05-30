
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
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.TXT_TipoPlaza = new System.Windows.Forms.TextBox();
            this.schoolDataSet = new WindowsFormsApplication1.SchoolDataSet();
            this.schoolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_TipoPlaza = new System.Windows.Forms.Label();
            this.CheckDelete = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.plazaTableAdapter = new WindowsFormsApplication1.SchoolDataSetTableAdapters.PlazaTableAdapter();
            this.schoolDataSet1 = new WindowsFormsApplication1.SchoolDataSet();
            this.schoolDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bttn_Consult = new FontAwesome.Sharp.IconButton();
            this.bttn_Delete = new FontAwesome.Sharp.IconButton();
            this.bttn_Modify = new FontAwesome.Sharp.IconButton();
            this.bttn_Save = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_ID
            // 
            this.TXT_ID.AcceptsReturn = true;
            this.TXT_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_ID.Location = new System.Drawing.Point(83, 116);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Size = new System.Drawing.Size(258, 20);
            this.TXT_ID.TabIndex = 1;
            this.TXT_ID.Text = "123...";
            this.TXT_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.AcceptsReturn = true;
            this.TXT_NAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_NAME.Location = new System.Drawing.Point(83, 177);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(258, 20);
            this.TXT_NAME.TabIndex = 3;
            this.TXT_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_TipoPlaza
            // 
            this.TXT_TipoPlaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_TipoPlaza.Location = new System.Drawing.Point(83, 235);
            this.TXT_TipoPlaza.Name = "TXT_TipoPlaza";
            this.TXT_TipoPlaza.Size = new System.Drawing.Size(258, 20);
            this.TXT_TipoPlaza.TabIndex = 5;
            this.TXT_TipoPlaza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_TipoPlaza.Visible = false;
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolDataSetBindingSource
            // 
            this.schoolDataSetBindingSource.DataSource = this.schoolDataSet;
            this.schoolDataSetBindingSource.Position = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(12, 119);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 13);
            this.lbl_ID.TabIndex = 12;
            this.lbl_ID.Text = "ID:";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(12, 180);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(47, 13);
            this.lbl_Name.TabIndex = 13;
            this.lbl_Name.Text = "Nombre:";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_TipoPlaza
            // 
            this.lbl_TipoPlaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TipoPlaza.AutoSize = true;
            this.lbl_TipoPlaza.Location = new System.Drawing.Point(13, 235);
            this.lbl_TipoPlaza.Name = "lbl_TipoPlaza";
            this.lbl_TipoPlaza.Size = new System.Drawing.Size(31, 13);
            this.lbl_TipoPlaza.TabIndex = 14;
            this.lbl_TipoPlaza.Text = "Tipo:";
            this.lbl_TipoPlaza.UseMnemonic = false;
            this.lbl_TipoPlaza.Visible = false;
            // 
            // CheckDelete
            // 
            this.CheckDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckDelete.AutoSize = true;
            this.CheckDelete.Location = new System.Drawing.Point(500, 219);
            this.CheckDelete.Name = "CheckDelete";
            this.CheckDelete.Size = new System.Drawing.Size(68, 17);
            this.CheckDelete.TabIndex = 19;
            this.CheckDelete.Text = "Cancelar";
            this.CheckDelete.UseVisualStyleBackColor = true;
            this.CheckDelete.Visible = false;
            this.CheckDelete.CheckedChanged += new System.EventHandler(this.CheckDelete_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "ID\'s Disponibles";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // plazaTableAdapter
            // 
            this.plazaTableAdapter.ClearBeforeFill = true;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "SchoolDataSet";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolDataSet1BindingSource
            // 
            this.schoolDataSet1BindingSource.DataSource = this.schoolDataSet1;
            this.schoolDataSet1BindingSource.Position = 0;
            // 
            // bttn_Consult
            // 
            this.bttn_Consult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Consult.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bttn_Consult.IconColor = System.Drawing.Color.Black;
            this.bttn_Consult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttn_Consult.IconSize = 20;
            this.bttn_Consult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Consult.Location = new System.Drawing.Point(589, 260);
            this.bttn_Consult.Name = "bttn_Consult";
            this.bttn_Consult.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.bttn_Consult.Size = new System.Drawing.Size(88, 43);
            this.bttn_Consult.TabIndex = 44;
            this.bttn_Consult.Text = "Consultar";
            this.bttn_Consult.UseVisualStyleBackColor = true;
            this.bttn_Consult.Visible = false;
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
            this.bttn_Delete.Location = new System.Drawing.Point(589, 211);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Delete.Size = new System.Drawing.Size(88, 43);
            this.bttn_Delete.TabIndex = 43;
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
            this.bttn_Modify.Location = new System.Drawing.Point(589, 165);
            this.bttn_Modify.Name = "bttn_Modify";
            this.bttn_Modify.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Modify.Size = new System.Drawing.Size(88, 43);
            this.bttn_Modify.TabIndex = 42;
            this.bttn_Modify.Text = "Modificar";
            this.bttn_Modify.UseVisualStyleBackColor = true;
            this.bttn_Modify.Visible = false;
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
            this.bttn_Save.Location = new System.Drawing.Point(589, 116);
            this.bttn_Save.Name = "bttn_Save";
            this.bttn_Save.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bttn_Save.Size = new System.Drawing.Size(88, 43);
            this.bttn_Save.TabIndex = 41;
            this.bttn_Save.Text = "Guardar";
            this.bttn_Save.UseVisualStyleBackColor = true;
            this.bttn_Save.Visible = false;
            this.bttn_Save.Click += new System.EventHandler(this.bttn_Save_Click);
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 384);
            this.Controls.Add(this.bttn_Consult);
            this.Controls.Add(this.bttn_Delete);
            this.Controls.Add(this.bttn_Modify);
            this.Controls.Add(this.bttn_Save);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CheckDelete);
            this.Controls.Add(this.lbl_TipoPlaza);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.TXT_TipoPlaza);
            this.Controls.Add(this.TXT_NAME);
            this.Controls.Add(this.TXT_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Equipos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.Departamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.TextBox TXT_NAME;
        private System.Windows.Forms.TextBox TXT_TipoPlaza;
        private System.Windows.Forms.BindingSource schoolDataSetBindingSource;
        private SchoolDataSet schoolDataSet;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_TipoPlaza;
        private System.Windows.Forms.CheckBox CheckDelete;
        private System.Windows.Forms.ComboBox comboBox1;
        private SchoolDataSetTableAdapters.PlazaTableAdapter plazaTableAdapter;
        private System.Windows.Forms.BindingSource schoolDataSet1BindingSource;
        private SchoolDataSet schoolDataSet1;
        private FontAwesome.Sharp.IconButton bttn_Consult;
        private FontAwesome.Sharp.IconButton bttn_Delete;
        private FontAwesome.Sharp.IconButton bttn_Modify;
        private FontAwesome.Sharp.IconButton bttn_Save;
    }
}