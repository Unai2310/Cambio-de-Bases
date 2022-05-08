
namespace CosasDeAccess
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnTemporada = new System.Windows.Forms.Button();
            this.BtnPelicula = new System.Windows.Forms.Button();
            this.BtnAnime = new System.Windows.Forms.Button();
            this.LblAnime = new System.Windows.Forms.Label();
            this.LblTemporada = new System.Windows.Forms.Label();
            this.LblPelicula = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 652);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnTemporada
            // 
            this.BtnTemporada.Location = new System.Drawing.Point(1316, 270);
            this.BtnTemporada.Name = "BtnTemporada";
            this.BtnTemporada.Size = new System.Drawing.Size(106, 122);
            this.BtnTemporada.TabIndex = 1;
            this.BtnTemporada.Text = "Temporada";
            this.BtnTemporada.UseVisualStyleBackColor = true;
            this.BtnTemporada.Click += new System.EventHandler(this.BtnTemporada_Click);
            // 
            // BtnPelicula
            // 
            this.BtnPelicula.Location = new System.Drawing.Point(1316, 465);
            this.BtnPelicula.Name = "BtnPelicula";
            this.BtnPelicula.Size = new System.Drawing.Size(106, 122);
            this.BtnPelicula.TabIndex = 2;
            this.BtnPelicula.Text = "Pelicula";
            this.BtnPelicula.UseVisualStyleBackColor = true;
            this.BtnPelicula.Click += new System.EventHandler(this.BtnPelicula_Click);
            // 
            // BtnAnime
            // 
            this.BtnAnime.Location = new System.Drawing.Point(1316, 80);
            this.BtnAnime.Name = "BtnAnime";
            this.BtnAnime.Size = new System.Drawing.Size(106, 122);
            this.BtnAnime.TabIndex = 3;
            this.BtnAnime.Text = "Anime";
            this.BtnAnime.UseVisualStyleBackColor = true;
            this.BtnAnime.Click += new System.EventHandler(this.BtnAnime_Click);
            // 
            // LblAnime
            // 
            this.LblAnime.AutoSize = true;
            this.LblAnime.Location = new System.Drawing.Point(1333, 205);
            this.LblAnime.Name = "LblAnime";
            this.LblAnime.Size = new System.Drawing.Size(0, 13);
            this.LblAnime.TabIndex = 4;
            // 
            // LblTemporada
            // 
            this.LblTemporada.AutoSize = true;
            this.LblTemporada.Location = new System.Drawing.Point(1333, 404);
            this.LblTemporada.Name = "LblTemporada";
            this.LblTemporada.Size = new System.Drawing.Size(0, 13);
            this.LblTemporada.TabIndex = 5;
            // 
            // LblPelicula
            // 
            this.LblPelicula.AutoSize = true;
            this.LblPelicula.Location = new System.Drawing.Point(1333, 599);
            this.LblPelicula.Name = "LblPelicula";
            this.LblPelicula.Size = new System.Drawing.Size(0, 13);
            this.LblPelicula.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(665, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(586, 652);
            this.dataGridView2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 203);
            this.button1.TabIndex = 8;
            this.button1.Text = "Rutas Anime";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 199);
            this.button2.TabIndex = 9;
            this.button2.Text = "Rutas Temporada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1257, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "Mirar Errores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(594, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 238);
            this.button4.TabIndex = 11;
            this.button4.Text = "Rutas Pelicula";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 676);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.LblPelicula);
            this.Controls.Add(this.LblTemporada);
            this.Controls.Add(this.LblAnime);
            this.Controls.Add(this.BtnAnime);
            this.Controls.Add(this.BtnPelicula);
            this.Controls.Add(this.BtnTemporada);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnTemporada;
        private System.Windows.Forms.Button BtnPelicula;
        private System.Windows.Forms.Button BtnAnime;
        private System.Windows.Forms.Label LblAnime;
        private System.Windows.Forms.Label LblTemporada;
        private System.Windows.Forms.Label LblPelicula;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

