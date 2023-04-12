namespace EstatisticasBuscaEmprego
{
    partial class formConfiguracaoPainel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConfiguracaoPainel));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDelItem = new System.Windows.Forms.TextBox();
            this.txtDelTecnologia = new System.Windows.Forms.TextBox();
            this.dgvPesquisar = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAtualizarItem = new System.Windows.Forms.TextBox();
            this.txtAtualizarTecnologia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddItem = new System.Windows.Forms.TextBox();
            this.txtAddTecnologia = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnDeletar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtIDelItem);
            this.groupBox3.Controls.Add(this.txtDelTecnologia);
            this.groupBox3.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(815, 484);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 170);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deletar Registro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Item Stack:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(198, 129);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(91, 29);
            this.btnDeletar.TabIndex = 0;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tecnologia:";
            // 
            // txtIDelItem
            // 
            this.txtIDelItem.Enabled = false;
            this.txtIDelItem.Location = new System.Drawing.Point(103, 82);
            this.txtIDelItem.Name = "txtIDelItem";
            this.txtIDelItem.Size = new System.Drawing.Size(186, 27);
            this.txtIDelItem.TabIndex = 1;
            // 
            // txtDelTecnologia
            // 
            this.txtDelTecnologia.Enabled = false;
            this.txtDelTecnologia.Location = new System.Drawing.Point(103, 49);
            this.txtDelTecnologia.Name = "txtDelTecnologia";
            this.txtDelTecnologia.Size = new System.Drawing.Size(125, 27);
            this.txtDelTecnologia.TabIndex = 0;
            // 
            // dgvPesquisar
            // 
            this.dgvPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisar.Location = new System.Drawing.Point(15, 29);
            this.dgvPesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPesquisar.Name = "dgvPesquisar";
            this.dgvPesquisar.ReadOnly = true;
            this.dgvPesquisar.RowHeadersWidth = 40;
            this.dgvPesquisar.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPesquisar.RowTemplate.Height = 29;
            this.dgvPesquisar.RowTemplate.ReadOnly = true;
            this.dgvPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPesquisar.Size = new System.Drawing.Size(747, 359);
            this.dgvPesquisar.TabIndex = 7;
            this.dgvPesquisar.SelectionChanged += new System.EventHandler(this.dgvPesquisar_SelectionChanged);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(113, 397);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(125, 27);
            this.txtPesquisar.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(462, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPesquisar);
            this.groupBox4.Controls.Add(this.dgvPesquisar);
            this.groupBox4.Controls.Add(this.txtPesquisar);
            this.groupBox4.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(12, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(779, 437);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pesquisar Registro";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(13, 396);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 29);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAtualizar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAtualizarItem);
            this.groupBox2.Controls.Add(this.txtAtualizarTecnologia);
            this.groupBox2.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(784, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 170);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atualizar Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Stack:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(198, 129);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(91, 29);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tecnologia:";
            // 
            // txtAtualizarItem
            // 
            this.txtAtualizarItem.Location = new System.Drawing.Point(103, 82);
            this.txtAtualizarItem.Name = "txtAtualizarItem";
            this.txtAtualizarItem.Size = new System.Drawing.Size(186, 27);
            this.txtAtualizarItem.TabIndex = 1;
            // 
            // txtAtualizarTecnologia
            // 
            this.txtAtualizarTecnologia.Location = new System.Drawing.Point(103, 49);
            this.txtAtualizarTecnologia.Name = "txtAtualizarTecnologia";
            this.txtAtualizarTecnologia.Size = new System.Drawing.Size(125, 27);
            this.txtAtualizarTecnologia.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAddItem);
            this.groupBox1.Controls.Add(this.txtAddTecnologia);
            this.groupBox1.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 170);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Stack:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(198, 129);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tecnologia:";
            // 
            // txtAddItem
            // 
            this.txtAddItem.Location = new System.Drawing.Point(103, 82);
            this.txtAddItem.Name = "txtAddItem";
            this.txtAddItem.Size = new System.Drawing.Size(186, 27);
            this.txtAddItem.TabIndex = 1;
            // 
            // txtAddTecnologia
            // 
            this.txtAddTecnologia.Location = new System.Drawing.Point(103, 49);
            this.txtAddTecnologia.Name = "txtAddTecnologia";
            this.txtAddTecnologia.Size = new System.Drawing.Size(125, 27);
            this.txtAddTecnologia.TabIndex = 0;
            // 
            // formConfiguracaoPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 678);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formConfiguracaoPainel";
            this.Text = "Painel de Configuração";
            this.Load += new System.EventHandler(this.formConfiguracaoPainel_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox3;
        private Button btnDeletar;
        private DataGridView dgvPesquisar;
        private TextBox txtPesquisar;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private TextBox txtIDelItem;
        private TextBox txtDelTecnologia;
        private GroupBox groupBox4;
        private Button btnPesquisar;
        private GroupBox groupBox2;
        private Label label3;
        private Button btnAtualizar;
        private Label label4;
        private TextBox txtAtualizarItem;
        private TextBox txtAtualizarTecnologia;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnAdd;
        private Label label2;
        private TextBox txtAddItem;
        private TextBox txtAddTecnologia;
    }
}