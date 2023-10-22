namespace Presentacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.identificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.salario_base = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.ComboBox();
            this.visualizador_de_consulta = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.tipo_de_consulta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDENTIFICACION";
            // 
            // identificacion
            // 
            this.identificacion.Location = new System.Drawing.Point(260, 114);
            this.identificacion.Name = "identificacion";
            this.identificacion.Size = new System.Drawing.Size(223, 26);
            this.identificacion.TabIndex = 2;
            this.identificacion.TextChanged += new System.EventHandler(this.identificacion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "SALARIO BASE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "ESTADO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(260, 158);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(223, 26);
            this.nombre.TabIndex = 6;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // salario_base
            // 
            this.salario_base.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salario_base.Location = new System.Drawing.Point(260, 203);
            this.salario_base.Name = "salario_base";
            this.salario_base.Size = new System.Drawing.Size(223, 26);
            this.salario_base.TabIndex = 7;
            this.salario_base.TextChanged += new System.EventHandler(this.salario_base_TextChanged);
            // 
            // estado
            // 
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.estado.Location = new System.Drawing.Point(259, 245);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(223, 28);
            this.estado.TabIndex = 8;
            this.estado.SelectedIndexChanged += new System.EventHandler(this.estado_SelectedIndexChanged);
            // 
            // visualizador_de_consulta
            // 
            this.visualizador_de_consulta.HideSelection = false;
            this.visualizador_de_consulta.Location = new System.Drawing.Point(577, 99);
            this.visualizador_de_consulta.Name = "visualizador_de_consulta";
            this.visualizador_de_consulta.Size = new System.Drawing.Size(529, 270);
            this.visualizador_de_consulta.TabIndex = 10;
            this.visualizador_de_consulta.UseCompatibleStateImageBehavior = false;
            this.visualizador_de_consulta.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(-1, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 89);
            this.label6.TabIndex = 11;
            this.label6.Text = "CONSULTAR POR:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipo_de_consulta
            // 
            this.tipo_de_consulta.FormattingEnabled = true;
            this.tipo_de_consulta.Items.AddRange(new object[] {
            "NOMBRE: ",
            "ESTADO:"});
            this.tipo_de_consulta.Location = new System.Drawing.Point(260, 395);
            this.tipo_de_consulta.Name = "tipo_de_consulta";
            this.tipo_de_consulta.Size = new System.Drawing.Size(223, 28);
            this.tipo_de_consulta.TabIndex = 12;
            this.tipo_de_consulta.SelectedIndexChanged += new System.EventHandler(this.tipo_de_consulta_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "REGISTRAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tipo_de_consulta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.visualizador_de_consulta);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.salario_base);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.identificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox identificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox salario_base;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.ListView visualizador_de_consulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipo_de_consulta;
        private System.Windows.Forms.Button button1;
    }
}

