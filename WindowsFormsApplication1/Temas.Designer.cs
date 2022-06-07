
namespace WindowsFormsApplication1
{
    partial class Temas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temas));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bttn_Asistencia = new FontAwesome.Sharp.IconButton();
            this.bttn_Grupo = new FontAwesome.Sharp.IconButton();
            this.bttn_Instructor = new FontAwesome.Sharp.IconButton();
            this.bttn_Docente = new FontAwesome.Sharp.IconButton();
            this.bttn_Depa = new FontAwesome.Sharp.IconButton();
            this.bttn_Curso = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.bttn_Home = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.labTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelSombra = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttn_Home)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.bttn_Asistencia);
            this.panelMenu.Controls.Add(this.bttn_Grupo);
            this.panelMenu.Controls.Add(this.bttn_Instructor);
            this.panelMenu.Controls.Add(this.bttn_Docente);
            this.panelMenu.Controls.Add(this.bttn_Depa);
            this.panelMenu.Controls.Add(this.bttn_Curso);
            this.panelMenu.Controls.Add(this.panelLogo);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // bttn_Asistencia
            // 
            resources.ApplyResources(this.bttn_Asistencia, "bttn_Asistencia");
            this.bttn_Asistencia.FlatAppearance.BorderSize = 0;
            this.bttn_Asistencia.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttn_Asistencia.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart;
            this.bttn_Asistencia.IconColor = System.Drawing.Color.Black;
            this.bttn_Asistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttn_Asistencia.Name = "bttn_Asistencia";
            this.bttn_Asistencia.UseVisualStyleBackColor = true;
            this.bttn_Asistencia.Click += new System.EventHandler(this.bttn_Asistencia_Click);
            // 
            // bttn_Grupo
            // 
            resources.ApplyResources(this.bttn_Grupo, "bttn_Grupo");
            this.bttn_Grupo.FlatAppearance.BorderSize = 0;
            this.bttn_Grupo.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttn_Grupo.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.bttn_Grupo.IconColor = System.Drawing.Color.Black;
            this.bttn_Grupo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttn_Grupo.Name = "bttn_Grupo";
            this.bttn_Grupo.UseVisualStyleBackColor = true;
            this.bttn_Grupo.Click += new System.EventHandler(this.bttn_Ventas_Click);
            // 
            // bttn_Instructor
            // 
            resources.ApplyResources(this.bttn_Instructor, "bttn_Instructor");
            this.bttn_Instructor.FlatAppearance.BorderSize = 0;
            this.bttn_Instructor.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttn_Instructor.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.bttn_Instructor.IconColor = System.Drawing.Color.Black;
            this.bttn_Instructor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttn_Instructor.Name = "bttn_Instructor";
            this.bttn_Instructor.UseVisualStyleBackColor = true;
            this.bttn_Instructor.Click += new System.EventHandler(this.bttn_IVirtual_Click);
            // 
            // bttn_Docente
            // 
            resources.ApplyResources(this.bttn_Docente, "bttn_Docente");
            this.bttn_Docente.FlatAppearance.BorderSize = 0;
            this.bttn_Docente.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttn_Docente.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.bttn_Docente.IconColor = System.Drawing.Color.Black;
            this.bttn_Docente.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bttn_Docente.Name = "bttn_Docente";
            this.bttn_Docente.UseVisualStyleBackColor = true;
            this.bttn_Docente.Click += new System.EventHandler(this.bttn_Trabajador_Click);
            // 
            // bttn_Depa
            // 
            resources.ApplyResources(this.bttn_Depa, "bttn_Depa");
            this.bttn_Depa.FlatAppearance.BorderSize = 0;
            this.bttn_Depa.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttn_Depa.IconChar = FontAwesome.Sharp.IconChar.LaptopCode;
            this.bttn_Depa.IconColor = System.Drawing.Color.Black;
            this.bttn_Depa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttn_Depa.Name = "bttn_Depa";
            this.bttn_Depa.UseVisualStyleBackColor = true;
            this.bttn_Depa.Click += new System.EventHandler(this.bttn_Depa_Click);
            // 
            // bttn_Curso
            // 
            resources.ApplyResources(this.bttn_Curso, "bttn_Curso");
            this.bttn_Curso.FlatAppearance.BorderSize = 0;
            this.bttn_Curso.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttn_Curso.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.bttn_Curso.IconColor = System.Drawing.Color.Black;
            this.bttn_Curso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttn_Curso.Name = "bttn_Curso";
            this.bttn_Curso.UseVisualStyleBackColor = true;
            this.bttn_Curso.Click += new System.EventHandler(this.bttn_Libros_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.bttn_Home);
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            // 
            // bttn_Home
            // 
            resources.ApplyResources(this.bttn_Home, "bttn_Home");
            this.bttn_Home.Name = "bttn_Home";
            this.bttn_Home.TabStop = false;
            this.bttn_Home.Click += new System.EventHandler(this.bttn_Home_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.panelBarraTitulo.Controls.Add(this.labTitleChildForm);
            this.panelBarraTitulo.Controls.Add(this.iconCurrentChildForm);
            resources.ApplyResources(this.panelBarraTitulo, "panelBarraTitulo");
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            // 
            // labTitleChildForm
            // 
            resources.ApplyResources(this.labTitleChildForm, "labTitleChildForm");
            this.labTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labTitleChildForm.Name = "labTitleChildForm";
            this.labTitleChildForm.Click += new System.EventHandler(this.labTitleChildForm_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.LightSteelBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resources.ApplyResources(this.iconCurrentChildForm, "iconCurrentChildForm");
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelSombra
            // 
            this.panelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            resources.ApplyResources(this.panelSombra, "panelSombra");
            this.panelSombra.Name = "panelSombra";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.panelDesktop, "panelDesktop");
            this.panelDesktop.Name = "panelDesktop";
            // 
            // Temas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelSombra);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "Temas";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bttn_Home)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton bttn_Asistencia;
        private FontAwesome.Sharp.IconButton bttn_Grupo;
        private FontAwesome.Sharp.IconButton bttn_Instructor;
        private FontAwesome.Sharp.IconButton bttn_Docente;
        private FontAwesome.Sharp.IconButton bttn_Depa;
        private FontAwesome.Sharp.IconButton bttn_Curso;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox bttn_Home;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label labTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelSombra;
        private System.Windows.Forms.Panel panelDesktop;
    }
}