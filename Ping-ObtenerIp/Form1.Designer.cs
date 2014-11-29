namespace Ping_ObtenerIp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ping_button = new System.Windows.Forms.Button();
            this.ping_textBox = new System.Windows.Forms.TextBox();
            this.obtener_ip_textBox = new System.Windows.Forms.TextBox();
            this.obtener_ip_button = new System.Windows.Forms.Button();
            this.Obtener_nombre_button = new System.Windows.Forms.Button();
            this.obtener_nombre_textBox = new System.Windows.Forms.TextBox();
            this.obtener_equipo_por_ip_textBox = new System.Windows.Forms.TextBox();
            this.obtener_por_equipo_ip_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ping_button
            // 
            this.ping_button.Location = new System.Drawing.Point(84, 146);
            this.ping_button.Name = "ping_button";
            this.ping_button.Size = new System.Drawing.Size(75, 23);
            this.ping_button.TabIndex = 0;
            this.ping_button.Text = "Ping";
            this.ping_button.UseVisualStyleBackColor = true;
            this.ping_button.Click += new System.EventHandler(this.ping_button_Click);
            // 
            // ping_textBox
            // 
            this.ping_textBox.Location = new System.Drawing.Point(75, 120);
            this.ping_textBox.Name = "ping_textBox";
            this.ping_textBox.Size = new System.Drawing.Size(100, 20);
            this.ping_textBox.TabIndex = 1;
            // 
            // obtener_ip_textBox
            // 
            this.obtener_ip_textBox.Location = new System.Drawing.Point(245, 120);
            this.obtener_ip_textBox.Name = "obtener_ip_textBox";
            this.obtener_ip_textBox.Size = new System.Drawing.Size(100, 20);
            this.obtener_ip_textBox.TabIndex = 2;
            // 
            // obtener_ip_button
            // 
            this.obtener_ip_button.Location = new System.Drawing.Point(260, 146);
            this.obtener_ip_button.Name = "obtener_ip_button";
            this.obtener_ip_button.Size = new System.Drawing.Size(75, 23);
            this.obtener_ip_button.TabIndex = 3;
            this.obtener_ip_button.Text = "Obtener IP";
            this.obtener_ip_button.UseVisualStyleBackColor = true;
            this.obtener_ip_button.Click += new System.EventHandler(this.obtener_ip_button_Click);
            // 
            // Obtener_nombre_button
            // 
            this.Obtener_nombre_button.Location = new System.Drawing.Point(415, 146);
            this.Obtener_nombre_button.Name = "Obtener_nombre_button";
            this.Obtener_nombre_button.Size = new System.Drawing.Size(98, 36);
            this.Obtener_nombre_button.TabIndex = 4;
            this.Obtener_nombre_button.Text = "Obtener Nombre Equipo";
            this.Obtener_nombre_button.UseVisualStyleBackColor = true;
            this.Obtener_nombre_button.Click += new System.EventHandler(this.Obtener_nombre_button_Click);
            // 
            // obtener_nombre_textBox
            // 
            this.obtener_nombre_textBox.Location = new System.Drawing.Point(397, 120);
            this.obtener_nombre_textBox.Name = "obtener_nombre_textBox";
            this.obtener_nombre_textBox.Size = new System.Drawing.Size(144, 20);
            this.obtener_nombre_textBox.TabIndex = 5;
            // 
            // obtener_equipo_por_ip_textBox
            // 
            this.obtener_equipo_por_ip_textBox.Location = new System.Drawing.Point(245, 214);
            this.obtener_equipo_por_ip_textBox.Name = "obtener_equipo_por_ip_textBox";
            this.obtener_equipo_por_ip_textBox.Size = new System.Drawing.Size(100, 20);
            this.obtener_equipo_por_ip_textBox.TabIndex = 6;
            // 
            // obtener_por_equipo_ip_button
            // 
            this.obtener_por_equipo_ip_button.Location = new System.Drawing.Point(260, 240);
            this.obtener_por_equipo_ip_button.Name = "obtener_por_equipo_ip_button";
            this.obtener_por_equipo_ip_button.Size = new System.Drawing.Size(75, 51);
            this.obtener_por_equipo_ip_button.TabIndex = 7;
            this.obtener_por_equipo_ip_button.Text = "Obtener Ip de un equipo";
            this.obtener_por_equipo_ip_button.UseVisualStyleBackColor = true;
            this.obtener_por_equipo_ip_button.Click += new System.EventHandler(this.obtener_por_equipo_ip_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 323);
            this.Controls.Add(this.obtener_por_equipo_ip_button);
            this.Controls.Add(this.obtener_equipo_por_ip_textBox);
            this.Controls.Add(this.obtener_nombre_textBox);
            this.Controls.Add(this.Obtener_nombre_button);
            this.Controls.Add(this.obtener_ip_button);
            this.Controls.Add(this.obtener_ip_textBox);
            this.Controls.Add(this.ping_textBox);
            this.Controls.Add(this.ping_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ping_button;
        private System.Windows.Forms.TextBox ping_textBox;
        private System.Windows.Forms.TextBox obtener_ip_textBox;
        private System.Windows.Forms.Button obtener_ip_button;
        private System.Windows.Forms.Button Obtener_nombre_button;
        private System.Windows.Forms.TextBox obtener_nombre_textBox;
        private System.Windows.Forms.TextBox obtener_equipo_por_ip_textBox;
        private System.Windows.Forms.Button obtener_por_equipo_ip_button;
    }
}

