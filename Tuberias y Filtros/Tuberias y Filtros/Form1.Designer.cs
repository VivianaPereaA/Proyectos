namespace Tuberias_y_Filtros
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minus = new System.Windows.Forms.CheckBox();
            this.mayus = new System.Windows.Forms.CheckBox();
            this.macro = new System.Windows.Forms.CheckBox();
            this.chkreverse = new System.Windows.Forms.CheckBox();
            this.chkeliBlancos = new System.Windows.Forms.CheckBox();
            this.txtentrada = new System.Windows.Forms.TextBox();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.txtsalida = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minus);
            this.groupBox1.Controls.Add(this.mayus);
            this.groupBox1.Controls.Add(this.macro);
            this.groupBox1.Controls.Add(this.chkreverse);
            this.groupBox1.Controls.Add(this.chkeliBlancos);
            this.groupBox1.Location = new System.Drawing.Point(58, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Location = new System.Drawing.Point(26, 111);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(74, 17);
            this.minus.TabIndex = 4;
            this.minus.Text = "Minuscula";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.CheckedChanged += new System.EventHandler(this.minus_CheckedChanged);
            // 
            // mayus
            // 
            this.mayus.AutoSize = true;
            this.mayus.Location = new System.Drawing.Point(26, 88);
            this.mayus.Name = "mayus";
            this.mayus.Size = new System.Drawing.Size(77, 17);
            this.mayus.TabIndex = 3;
            this.mayus.Text = "Mayuscula";
            this.mayus.UseVisualStyleBackColor = true;
            this.mayus.CheckedChanged += new System.EventHandler(this.mayus_CheckedChanged);
            // 
            // macro
            // 
            this.macro.AutoSize = true;
            this.macro.Location = new System.Drawing.Point(26, 65);
            this.macro.Name = "macro";
            this.macro.Size = new System.Drawing.Size(92, 17);
            this.macro.TabIndex = 2;
            this.macro.Text = "macroNombre";
            this.macro.UseVisualStyleBackColor = true;
            this.macro.CheckedChanged += new System.EventHandler(this.macro_CheckedChanged);
            // 
            // chkreverse
            // 
            this.chkreverse.AutoSize = true;
            this.chkreverse.Location = new System.Drawing.Point(26, 42);
            this.chkreverse.Name = "chkreverse";
            this.chkreverse.Size = new System.Drawing.Size(66, 17);
            this.chkreverse.TabIndex = 1;
            this.chkreverse.Text = "Reverse";
            this.chkreverse.UseVisualStyleBackColor = true;
            this.chkreverse.CheckedChanged += new System.EventHandler(this.chkreverse_CheckedChanged);
            // 
            // chkeliBlancos
            // 
            this.chkeliBlancos.AutoSize = true;
            this.chkeliBlancos.Location = new System.Drawing.Point(26, 19);
            this.chkeliBlancos.Name = "chkeliBlancos";
            this.chkeliBlancos.Size = new System.Drawing.Size(103, 17);
            this.chkeliBlancos.TabIndex = 0;
            this.chkeliBlancos.Text = "Eliminar Blancos";
            this.chkeliBlancos.UseVisualStyleBackColor = true;
            this.chkeliBlancos.CheckedChanged += new System.EventHandler(this.chkeliBlancos_CheckedChanged);
            // 
            // txtentrada
            // 
            this.txtentrada.Location = new System.Drawing.Point(211, 51);
            this.txtentrada.Multiline = true;
            this.txtentrada.Name = "txtentrada";
            this.txtentrada.Size = new System.Drawing.Size(191, 141);
            this.txtentrada.TabIndex = 1;
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(408, 51);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnfiltrar.TabIndex = 2;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // txtsalida
            // 
            this.txtsalida.Location = new System.Drawing.Point(490, 51);
            this.txtsalida.Multiline = true;
            this.txtsalida.Name = "txtsalida";
            this.txtsalida.Size = new System.Drawing.Size(176, 141);
            this.txtsalida.TabIndex = 3;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(409, 81);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(74, 23);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtsalida);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.txtentrada);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkeliBlancos;
        private System.Windows.Forms.TextBox txtentrada;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.TextBox txtsalida;
        private System.Windows.Forms.CheckBox chkreverse;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.CheckBox minus;
        private System.Windows.Forms.CheckBox mayus;
        private System.Windows.Forms.CheckBox macro;
    }
}

