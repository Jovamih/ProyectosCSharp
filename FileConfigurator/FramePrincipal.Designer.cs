using System.Windows.Forms;

namespace FileConfigurator
{
    partial class FramePrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FramePrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.txtSetNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblPathFile = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.checkEditAcceso = new System.Windows.Forms.CheckBox();
            this.checkEditModification = new System.Windows.Forms.CheckBox();
            this.checkEditCreation = new System.Windows.Forms.CheckBox();
            this.timeAcceso = new System.Windows.Forms.DateTimePicker();
            this.timeModification = new System.Windows.Forms.DateTimePicker();
            this.timeCreation = new System.Windows.Forms.DateTimePicker();
            this.dateAcceso = new System.Windows.Forms.DateTimePicker();
            this.dateModification = new System.Windows.Forms.DateTimePicker();
            this.dateCreation = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.PanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Propiedades";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(265, 28);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Creacion del archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-191, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ultimo acceso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modificacion";
            // 
            // pictureIcon
            // 
            this.pictureIcon.Location = new System.Drawing.Point(35, 24);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(44, 39);
            this.pictureIcon.TabIndex = 5;
            this.pictureIcon.TabStop = false;
            // 
            // txtSetNombre
            // 
            this.txtSetNombre.Location = new System.Drawing.Point(105, 28);
            this.txtSetNombre.Name = "txtSetNombre";
            this.txtSetNombre.Size = new System.Drawing.Size(142, 23);
            this.txtSetNombre.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ubicacion :";
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.lblAutor);
            this.PanelPrincipal.Controls.Add(this.lblPathFile);
            this.PanelPrincipal.Controls.Add(this.btnAplicar);
            this.PanelPrincipal.Controls.Add(this.label6);
            this.PanelPrincipal.Controls.Add(this.btnCancelar);
            this.PanelPrincipal.Controls.Add(this.btnAceptar);
            this.PanelPrincipal.Controls.Add(this.checkEditAcceso);
            this.PanelPrincipal.Controls.Add(this.checkEditModification);
            this.PanelPrincipal.Controls.Add(this.checkEditCreation);
            this.PanelPrincipal.Controls.Add(this.timeAcceso);
            this.PanelPrincipal.Controls.Add(this.timeModification);
            this.PanelPrincipal.Controls.Add(this.timeCreation);
            this.PanelPrincipal.Controls.Add(this.dateAcceso);
            this.PanelPrincipal.Controls.Add(this.dateModification);
            this.PanelPrincipal.Controls.Add(this.dateCreation);
            this.PanelPrincipal.Controls.Add(this.label5);
            this.PanelPrincipal.Controls.Add(this.txtSetNombre);
            this.PanelPrincipal.Controls.Add(this.pictureIcon);
            this.PanelPrincipal.Controls.Add(this.label4);
            this.PanelPrincipal.Controls.Add(this.label3);
            this.PanelPrincipal.Controls.Add(this.label2);
            this.PanelPrincipal.Controls.Add(this.btnOpenFile);
            this.PanelPrincipal.Controls.Add(this.label1);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(407, 294);
            this.PanelPrincipal.TabIndex = 0;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAutor.Location = new System.Drawing.Point(35, 264);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(53, 13);
            this.lblAutor.TabIndex = 29;
            this.lblAutor.Text = "Acerca de";
            this.lblAutor.Click += new System.EventHandler(this.lblAutor_Click);
            // 
            // lblPathFile
            // 
            this.lblPathFile.AutoSize = true;
            this.lblPathFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPathFile.Location = new System.Drawing.Point(105, 66);
            this.lblPathFile.Name = "lblPathFile";
            this.lblPathFile.Size = new System.Drawing.Size(131, 13);
            this.lblPathFile.TabIndex = 28;
            this.lblPathFile.Text = "Ningun archivo cargado";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(307, 259);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 27;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ultimo acceso";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(226, 259);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(145, 259);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // checkEditAcceso
            // 
            this.checkEditAcceso.AutoSize = true;
            this.checkEditAcceso.Location = new System.Drawing.Point(346, 202);
            this.checkEditAcceso.Name = "checkEditAcceso";
            this.checkEditAcceso.Size = new System.Drawing.Size(46, 19);
            this.checkEditAcceso.TabIndex = 23;
            this.checkEditAcceso.Text = "Edit";
            this.checkEditAcceso.UseVisualStyleBackColor = true;
            this.checkEditAcceso.CheckedChanged += new System.EventHandler(this.checkEditAcceso_CheckedChanged);
            // 
            // checkEditModification
            // 
            this.checkEditModification.AutoSize = true;
            this.checkEditModification.Location = new System.Drawing.Point(346, 158);
            this.checkEditModification.Name = "checkEditModification";
            this.checkEditModification.Size = new System.Drawing.Size(46, 19);
            this.checkEditModification.TabIndex = 22;
            this.checkEditModification.Text = "Edit";
            this.checkEditModification.UseVisualStyleBackColor = true;
            this.checkEditModification.CheckedChanged += new System.EventHandler(this.checkEditModification_CheckedChanged);
            // 
            // checkEditCreation
            // 
            this.checkEditCreation.AutoSize = true;
            this.checkEditCreation.Location = new System.Drawing.Point(346, 122);
            this.checkEditCreation.Name = "checkEditCreation";
            this.checkEditCreation.Size = new System.Drawing.Size(46, 19);
            this.checkEditCreation.TabIndex = 21;
            this.checkEditCreation.Text = "Edit";
            this.checkEditCreation.UseVisualStyleBackColor = true;
            this.checkEditCreation.CheckedChanged += new System.EventHandler(this.checkEditCreation_CheckedChanged);
            // 
            // timeAcceso
            // 
            this.timeAcceso.Enabled = false;
            this.timeAcceso.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeAcceso.Location = new System.Drawing.Point(272, 198);
            this.timeAcceso.Name = "timeAcceso";
            this.timeAcceso.ShowUpDown = true;
            this.timeAcceso.Size = new System.Drawing.Size(68, 23);
            this.timeAcceso.TabIndex = 20;
            this.timeAcceso.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // timeModification
            // 
            this.timeModification.Enabled = false;
            this.timeModification.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeModification.Location = new System.Drawing.Point(272, 156);
            this.timeModification.Name = "timeModification";
            this.timeModification.ShowUpDown = true;
            this.timeModification.Size = new System.Drawing.Size(68, 23);
            this.timeModification.TabIndex = 19;
            this.timeModification.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // timeCreation
            // 
            this.timeCreation.Enabled = false;
            this.timeCreation.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeCreation.Location = new System.Drawing.Point(272, 120);
            this.timeCreation.Name = "timeCreation";
            this.timeCreation.ShowUpDown = true;
            this.timeCreation.Size = new System.Drawing.Size(68, 23);
            this.timeCreation.TabIndex = 18;
            this.timeCreation.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // dateAcceso
            // 
            this.dateAcceso.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.dateAcceso.Enabled = false;
            this.dateAcceso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAcceso.Location = new System.Drawing.Point(169, 198);
            this.dateAcceso.Name = "dateAcceso";
            this.dateAcceso.Size = new System.Drawing.Size(96, 23);
            this.dateAcceso.TabIndex = 17;
            this.dateAcceso.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // dateModification
            // 
            this.dateModification.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.dateModification.Enabled = false;
            this.dateModification.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateModification.Location = new System.Drawing.Point(169, 156);
            this.dateModification.Name = "dateModification";
            this.dateModification.Size = new System.Drawing.Size(96, 23);
            this.dateModification.TabIndex = 16;
            this.dateModification.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // dateCreation
            // 
            this.dateCreation.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.dateCreation.Enabled = false;
            this.dateCreation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCreation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateCreation.Location = new System.Drawing.Point(169, 120);
            this.dateCreation.Name = "dateCreation";
            this.dateCreation.Size = new System.Drawing.Size(96, 23);
            this.dateCreation.TabIndex = 15;
            this.dateCreation.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // FramePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 294);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FramePrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Time Changer";
            this.Load += new System.EventHandler(this.FramePrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.TextBox txtSetNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.DateTimePicker dateAcceso;
        private System.Windows.Forms.DateTimePicker dateModification;
        private System.Windows.Forms.DateTimePicker dateCreation;
        private DateTimePicker timeAcceso;
        private DateTimePicker timeModification;
        private DateTimePicker timeCreation;
        private Button btnAplicar;
        private Label label6;
        private Button btnCancelar;
        private Button btnAceptar;
        private CheckBox checkEditAcceso;
        private CheckBox checkEditModification;
        private CheckBox checkEditCreation;
        private Label lblPathFile;
        private Label lblAutor;
    }
}