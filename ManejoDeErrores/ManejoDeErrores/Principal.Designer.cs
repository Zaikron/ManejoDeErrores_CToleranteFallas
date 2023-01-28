
namespace ManejoDeErrores
{
    partial class Principal
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
            this.imagen_PBox = new System.Windows.Forms.PictureBox();
            this.txtImg = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_PBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imagen_PBox
            // 
            this.imagen_PBox.Location = new System.Drawing.Point(12, 43);
            this.imagen_PBox.Name = "imagen_PBox";
            this.imagen_PBox.Size = new System.Drawing.Size(330, 256);
            this.imagen_PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen_PBox.TabIndex = 0;
            this.imagen_PBox.TabStop = false;
            // 
            // txtImg
            // 
            this.txtImg.AutoSize = true;
            this.txtImg.Location = new System.Drawing.Point(12, 316);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(10, 13);
            this.txtImg.TabIndex = 1;
            this.txtImg.Text = "-";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 347);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtImg);
            this.Controls.Add(this.imagen_PBox);
            this.Name = "Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagen_PBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagen_PBox;
        private System.Windows.Forms.Label txtImg;
        private System.Windows.Forms.Button btnSelect;
    }
}

