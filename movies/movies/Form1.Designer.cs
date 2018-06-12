namespace movies
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoSearch = new System.Windows.Forms.ListBox();
            this.texSearch = new System.Windows.Forms.TextBox();
            this.buttonEstudios = new System.Windows.Forms.Button();
            this.buttonProductores = new System.Windows.Forms.Button();
            this.buttonDirectores = new System.Windows.Forms.Button();
            this.buttonActores = new System.Windows.Forms.Button();
            this.buttonPeliculas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO!";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.InfoSearch);
            this.panel1.Controls.Add(this.texSearch);
            this.panel1.Controls.Add(this.buttonEstudios);
            this.panel1.Controls.Add(this.buttonProductores);
            this.panel1.Controls.Add(this.buttonDirectores);
            this.panel1.Controls.Add(this.buttonActores);
            this.panel1.Controls.Add(this.buttonPeliculas);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 279);
            this.panel1.TabIndex = 1;
            // 
            // InfoSearch
            // 
            this.InfoSearch.FormattingEnabled = true;
            this.InfoSearch.Location = new System.Drawing.Point(50, 142);
            this.InfoSearch.Name = "InfoSearch";
            this.InfoSearch.Size = new System.Drawing.Size(399, 108);
            this.InfoSearch.TabIndex = 5;
            // 
            // texSearch
            // 
            this.texSearch.Location = new System.Drawing.Point(50, 49);
            this.texSearch.Name = "texSearch";
            this.texSearch.Size = new System.Drawing.Size(399, 20);
            this.texSearch.TabIndex = 2;
            this.texSearch.Text = "search...";
            this.texSearch.TextChanged += new System.EventHandler(this.texSearch_TextChanged);
            // 
            // buttonEstudios
            // 
            this.buttonEstudios.Location = new System.Drawing.Point(374, 96);
            this.buttonEstudios.Name = "buttonEstudios";
            this.buttonEstudios.Size = new System.Drawing.Size(75, 23);
            this.buttonEstudios.TabIndex = 4;
            this.buttonEstudios.Text = "Estudios";
            this.buttonEstudios.UseVisualStyleBackColor = true;
            this.buttonEstudios.Click += new System.EventHandler(this.buttonEstudios_Click);
            // 
            // buttonProductores
            // 
            this.buttonProductores.Location = new System.Drawing.Point(293, 96);
            this.buttonProductores.Name = "buttonProductores";
            this.buttonProductores.Size = new System.Drawing.Size(75, 23);
            this.buttonProductores.TabIndex = 3;
            this.buttonProductores.Text = "Productores";
            this.buttonProductores.UseVisualStyleBackColor = true;
            this.buttonProductores.Click += new System.EventHandler(this.buttonProductores_Click);
            // 
            // buttonDirectores
            // 
            this.buttonDirectores.Location = new System.Drawing.Point(212, 96);
            this.buttonDirectores.Name = "buttonDirectores";
            this.buttonDirectores.Size = new System.Drawing.Size(75, 23);
            this.buttonDirectores.TabIndex = 2;
            this.buttonDirectores.Text = "Directores";
            this.buttonDirectores.UseVisualStyleBackColor = true;
            this.buttonDirectores.Click += new System.EventHandler(this.buttonDirectores_Click);
            // 
            // buttonActores
            // 
            this.buttonActores.Location = new System.Drawing.Point(131, 96);
            this.buttonActores.Name = "buttonActores";
            this.buttonActores.Size = new System.Drawing.Size(75, 23);
            this.buttonActores.TabIndex = 1;
            this.buttonActores.Text = "Actores";
            this.buttonActores.UseVisualStyleBackColor = true;
            this.buttonActores.Click += new System.EventHandler(this.buttonActores_Click);
            // 
            // buttonPeliculas
            // 
            this.buttonPeliculas.Location = new System.Drawing.Point(50, 96);
            this.buttonPeliculas.Name = "buttonPeliculas";
            this.buttonPeliculas.Size = new System.Drawing.Size(75, 23);
            this.buttonPeliculas.TabIndex = 0;
            this.buttonPeliculas.Text = "Peliculas";
            this.buttonPeliculas.UseVisualStyleBackColor = true;
            this.buttonPeliculas.Click += new System.EventHandler(this.buttonPeliculas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonActores;
        private System.Windows.Forms.Button buttonPeliculas;
        private System.Windows.Forms.Button buttonEstudios;
        private System.Windows.Forms.Button buttonProductores;
        private System.Windows.Forms.Button buttonDirectores;
        private System.Windows.Forms.TextBox texSearch;
        private System.Windows.Forms.ListBox InfoSearch;
    }
}

