namespace BuscaminasFinalGráfico
{
    partial class Menu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Personalizado = new System.Windows.Forms.Button();
            this.Ancho = new System.Windows.Forms.NumericUpDown();
            this.Alto = new System.Windows.Forms.NumericUpDown();
            this.Minas = new System.Windows.Forms.NumericUpDown();
            this.AnchoText = new System.Windows.Forms.Label();
            this.MinasText = new System.Windows.Forms.Label();
            this.AltoText = new System.Windows.Forms.Label();
            this.Facil = new System.Windows.Forms.Button();
            this.Normal = new System.Windows.Forms.Button();
            this.Dificil = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ancho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Facil, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Normal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Dificil, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Personalizado, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Ancho, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Alto, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Minas, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.AnchoText, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MinasText, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.AltoText, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 342);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(798, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Personalizado
            // 
            this.Personalizado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Personalizado.Location = new System.Drawing.Point(600, 3);
            this.Personalizado.Name = "Personalizado";
            this.Personalizado.Size = new System.Drawing.Size(195, 44);
            this.Personalizado.TabIndex = 0;
            this.Personalizado.Text = "Personalizado";
            this.Personalizado.UseVisualStyleBackColor = true;
            this.Personalizado.Click += new System.EventHandler(this.ClickDificultad);
            // 
            // Ancho
            // 
            this.Ancho.Location = new System.Drawing.Point(3, 53);
            this.Ancho.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Ancho.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Ancho.Name = "Ancho";
            this.Ancho.Size = new System.Drawing.Size(120, 20);
            this.Ancho.TabIndex = 4;
            this.Ancho.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Ancho.ValueChanged += new System.EventHandler(this.Ancho_ValueChanged);
            // 
            // Alto
            // 
            this.Alto.Location = new System.Drawing.Point(202, 53);
            this.Alto.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Alto.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Alto.Name = "Alto";
            this.Alto.Size = new System.Drawing.Size(120, 20);
            this.Alto.TabIndex = 5;
            this.Alto.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Alto.ValueChanged += new System.EventHandler(this.Ancho_ValueChanged);
            // 
            // Minas
            // 
            this.Minas.Location = new System.Drawing.Point(401, 53);
            this.Minas.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Minas.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Minas.Name = "Minas";
            this.Minas.Size = new System.Drawing.Size(120, 20);
            this.Minas.TabIndex = 6;
            this.Minas.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // AnchoText
            // 
            this.AnchoText.AutoSize = true;
            this.AnchoText.Location = new System.Drawing.Point(3, 0);
            this.AnchoText.Name = "AnchoText";
            this.AnchoText.Size = new System.Drawing.Size(38, 13);
            this.AnchoText.TabIndex = 2;
            this.AnchoText.Text = "Ancho";
            // 
            // MinasText
            // 
            this.MinasText.AutoSize = true;
            this.MinasText.Location = new System.Drawing.Point(401, 0);
            this.MinasText.Name = "MinasText";
            this.MinasText.Size = new System.Drawing.Size(35, 13);
            this.MinasText.TabIndex = 1;
            this.MinasText.Text = "Minas";
            // 
            // AltoText
            // 
            this.AltoText.AutoSize = true;
            this.AltoText.Location = new System.Drawing.Point(202, 0);
            this.AltoText.Name = "AltoText";
            this.AltoText.Size = new System.Drawing.Size(25, 13);
            this.AltoText.TabIndex = 3;
            this.AltoText.Text = "Alto";
            // 
            // Facil
            // 
            this.Facil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Facil.Location = new System.Drawing.Point(3, 3);
            this.Facil.Name = "Facil";
            this.Facil.Size = new System.Drawing.Size(798, 107);
            this.Facil.TabIndex = 1;
            this.Facil.Text = "Fácil";
            this.Facil.UseVisualStyleBackColor = true;
            this.Facil.Click += new System.EventHandler(this.ClickDificultad);
            // 
            // Normal
            // 
            this.Normal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Normal.Location = new System.Drawing.Point(3, 116);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(798, 107);
            this.Normal.TabIndex = 2;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.Click += new System.EventHandler(this.ClickDificultad);
            // 
            // Dificil
            // 
            this.Dificil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dificil.Location = new System.Drawing.Point(3, 229);
            this.Dificil.Name = "Dificil";
            this.Dificil.Size = new System.Drawing.Size(798, 107);
            this.Dificil.TabIndex = 3;
            this.Dificil.Text = "Difícil";
            this.Dificil.UseVisualStyleBackColor = true;
            this.Dificil.Click += new System.EventHandler(this.ClickDificultad);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ancho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Personalizado;
        private System.Windows.Forms.Button Facil;
        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.Button Dificil;
        private System.Windows.Forms.Label MinasText;
        private System.Windows.Forms.Label AnchoText;
        private System.Windows.Forms.Label AltoText;
        private System.Windows.Forms.NumericUpDown Ancho;
        private System.Windows.Forms.NumericUpDown Alto;
        private System.Windows.Forms.NumericUpDown Minas;
    }
}

