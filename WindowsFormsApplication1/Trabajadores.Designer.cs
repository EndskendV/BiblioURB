
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
            this.Combo_ID = new System.Windows.Forms.ComboBox();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bttn_Consult = new FontAwesome.Sharp.IconButton();
            this.bttn_Delete = new FontAwesome.Sharp.IconButton();
            this.bttn_Modify = new FontAwesome.Sharp.IconButton();
            this.bttn_Save = new FontAwesome.Sharp.IconButton();
            this.TxT_Domicilio = new System.Windows.Forms.TextBox();
            this.TxT_Mail = new System.Windows.Forms.TextBox();
            this.TxT_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Combo_Nac = new System.Windows.Forms.DateTimePicker();
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
            // Combo_ID
            // 
            this.Combo_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_ID.FormattingEnabled = true;
            this.Combo_ID.Location = new System.Drawing.Point(158, 125);
            this.Combo_ID.MaxLength = 10;
            this.Combo_ID.Name = "Combo_ID";
            this.Combo_ID.Size = new System.Drawing.Size(93, 21);
            this.Combo_ID.TabIndex = 1;
            this.Combo_ID.SelectedIndexChanged += new System.EventHandler(this.Combo_IDWk_SelectedIndexChanged);
            // 
            // TXT_Name
            // 
            this.TXT_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_Name.Location = new System.Drawing.Point(257, 125);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(170, 20);
            this.TXT_Name.TabIndex = 2;
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
            this.label3.Location = new System.Drawing.Point(44, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Domicilio";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "E-Mail";
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
            // TxT_Domicilio
            // 
            this.TxT_Domicilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxT_Domicilio.Location = new System.Drawing.Point(158, 190);
            this.TxT_Domicilio.Name = "TxT_Domicilio";
            this.TxT_Domicilio.Size = new System.Drawing.Size(269, 20);
            this.TxT_Domicilio.TabIndex = 4;
            // 
            // TxT_Mail
            // 
            this.TxT_Mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxT_Mail.Location = new System.Drawing.Point(158, 216);
            this.TxT_Mail.Name = "TxT_Mail";
            this.TxT_Mail.Size = new System.Drawing.Size(269, 20);
            this.TxT_Mail.TabIndex = 5;
            // 
            // TxT_Phone
            // 
            this.TxT_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxT_Phone.Location = new System.Drawing.Point(158, 242);
            this.TxT_Phone.MaxLength = 10;
            this.TxT_Phone.Name = "TxT_Phone";
            this.TxT_Phone.Size = new System.Drawing.Size(118, 20);
            this.TxT_Phone.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Telefono";
            // 
            // Combo_Nac
            // 
            this.Combo_Nac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_Nac.Location = new System.Drawing.Point(158, 159);
            this.Combo_Nac.Name = "Combo_Nac";
            this.Combo_Nac.Size = new System.Drawing.Size(200, 20);
            this.Combo_Nac.TabIndex = 3;
            // 
            // Trabajadores
            // 
            this.AcceptButton = this.bttn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 384);
            this.Controls.Add(this.Combo_Nac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxT_Phone);
            this.Controls.Add(this.TxT_Mail);
            this.Controls.Add(this.TxT_Domicilio);
            this.Controls.Add(this.bttn_Consult);
            this.Controls.Add(this.bttn_Delete);
            this.Controls.Add(this.bttn_Modify);
            this.Controls.Add(this.bttn_Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_Name);
            this.Controls.Add(this.Combo_ID);
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
        private System.Windows.Forms.ComboBox Combo_ID;
        private System.Windows.Forms.TextBox TXT_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton bttn_Consult;
        private FontAwesome.Sharp.IconButton bttn_Delete;
        private FontAwesome.Sharp.IconButton bttn_Modify;
        private FontAwesome.Sharp.IconButton bttn_Save;
        private System.Windows.Forms.TextBox TxT_Domicilio;
        private System.Windows.Forms.TextBox TxT_Mail;
        private System.Windows.Forms.TextBox TxT_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Combo_Nac;
    }
}