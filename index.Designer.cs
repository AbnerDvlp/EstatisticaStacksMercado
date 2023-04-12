namespace EstatisticasBuscaEmprego
{
    partial class index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.dgvPainel = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRmv = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPainel
            // 
            this.dgvPainel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPainel.Location = new System.Drawing.Point(24, 33);
            this.dgvPainel.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.dgvPainel.MultiSelect = false;
            this.dgvPainel.Name = "dgvPainel";
            this.dgvPainel.ReadOnly = true;
            this.dgvPainel.RowHeadersWidth = 51;
            this.dgvPainel.RowTemplate.Height = 29;
            this.dgvPainel.RowTemplate.ReadOnly = true;
            this.dgvPainel.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPainel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPainel.Size = new System.Drawing.Size(780, 465);
            this.dgvPainel.TabIndex = 0;
            this.dgvPainel.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(821, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 79);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRmv
            // 
            this.btnRmv.BackColor = System.Drawing.Color.Tomato;
            this.btnRmv.FlatAppearance.BorderSize = 3;
            this.btnRmv.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRmv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRmv.Location = new System.Drawing.Point(821, 116);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(128, 79);
            this.btnRmv.TabIndex = 3;
            this.btnRmv.Text = "Rmv";
            this.btnRmv.UseVisualStyleBackColor = false;
            this.btnRmv.Click += new System.EventHandler(this.btnRmv_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfigurar.Location = new System.Drawing.Point(821, 315);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(128, 29);
            this.btnConfigurar.TabIndex = 4;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(836, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 101);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.btnRmv);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPainel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "index";
            this.Text = "EstatisticasStacks";
            this.Activated += new System.EventHandler(this.index_Activated);
            this.Load += new System.EventHandler(this.index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgvPainel;
        private Button btnAdd;
        private Button btnRmv;
        private Button btnConfigurar;
        private PictureBox pictureBox1;
    }
}