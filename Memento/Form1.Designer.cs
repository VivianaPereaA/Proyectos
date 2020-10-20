namespace Memento
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp = new System.Windows.Forms.GroupBox();
            this.radRojo = new System.Windows.Forms.RadioButton();
            this.radAzul = new System.Windows.Forms.RadioButton();
            this.radVerde = new System.Windows.Forms.RadioButton();
            this.btnAntes = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lstlhis = new System.Windows.Forms.ListBox();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp
            // 
            this.grp.Controls.Add(this.radVerde);
            this.grp.Controls.Add(this.radAzul);
            this.grp.Controls.Add(this.radRojo);
            this.grp.Location = new System.Drawing.Point(158, 91);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(235, 157);
            this.grp.TabIndex = 0;
            this.grp.TabStop = false;
            this.grp.Text = "groupBox1";
            // 
            // radRojo
            // 
            this.radRojo.AutoSize = true;
            this.radRojo.Location = new System.Drawing.Point(42, 29);
            this.radRojo.Name = "radRojo";
            this.radRojo.Size = new System.Drawing.Size(47, 17);
            this.radRojo.TabIndex = 0;
            this.radRojo.Text = "Rojo";
            this.radRojo.UseVisualStyleBackColor = true;
            this.radRojo.CheckedChanged += new System.EventHandler(this.radRojo_CheckedChanged);
            // 
            // radAzul
            // 
            this.radAzul.AutoSize = true;
            this.radAzul.Location = new System.Drawing.Point(42, 53);
            this.radAzul.Name = "radAzul";
            this.radAzul.Size = new System.Drawing.Size(45, 17);
            this.radAzul.TabIndex = 1;
            this.radAzul.Text = "Azul";
            this.radAzul.UseVisualStyleBackColor = true;
            this.radAzul.CheckedChanged += new System.EventHandler(this.radAzul_CheckedChanged);
            // 
            // radVerde
            // 
            this.radVerde.AutoSize = true;
            this.radVerde.Location = new System.Drawing.Point(42, 76);
            this.radVerde.Name = "radVerde";
            this.radVerde.Size = new System.Drawing.Size(53, 17);
            this.radVerde.TabIndex = 2;
            this.radVerde.Text = "Verde";
            this.radVerde.UseVisualStyleBackColor = true;
            this.radVerde.CheckedChanged += new System.EventHandler(this.radVerde_CheckedChanged);
            // 
            // btnAntes
            // 
            this.btnAntes.Location = new System.Drawing.Point(184, 301);
            this.btnAntes.Name = "btnAntes";
            this.btnAntes.Size = new System.Drawing.Size(75, 23);
            this.btnAntes.TabIndex = 1;
            this.btnAntes.Text = "Undo";
            this.btnAntes.UseVisualStyleBackColor = true;
            this.btnAntes.Click += new System.EventHandler(this.btnAntes_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(415, 219);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 2;
            // 
            // lstlhis
            // 
            this.lstlhis.FormattingEnabled = true;
            this.lstlhis.Location = new System.Drawing.Point(40, 118);
            this.lstlhis.Name = "lstlhis";
            this.lstlhis.Size = new System.Drawing.Size(95, 121);
            this.lstlhis.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 387);
            this.Controls.Add(this.lstlhis);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnAntes);
            this.Controls.Add(this.grp);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.RadioButton radVerde;
        private System.Windows.Forms.RadioButton radAzul;
        private System.Windows.Forms.RadioButton radRojo;
        private System.Windows.Forms.Button btnAntes;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.ListBox lstlhis;
    }
}

