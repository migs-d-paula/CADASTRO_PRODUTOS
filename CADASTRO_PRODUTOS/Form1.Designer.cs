namespace CADASTRO_PRODUTOS
{
    partial class FormLISTA
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDESCRICAO = new System.Windows.Forms.TextBox();
            this.textBoxCATEGORIA = new System.Windows.Forms.TextBox();
            this.textBoxPRECO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEXCLUIR = new System.Windows.Forms.TextBox();
            this.labelEXCLUIR = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewPRODUTOS = new System.Windows.Forms.DataGridView();
            this.buttonALTERAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDESCRICAO
            // 
            this.textBoxDESCRICAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDESCRICAO.Location = new System.Drawing.Point(202, 70);
            this.textBoxDESCRICAO.Name = "textBoxDESCRICAO";
            this.textBoxDESCRICAO.Size = new System.Drawing.Size(486, 26);
            this.textBoxDESCRICAO.TabIndex = 0;
            // 
            // textBoxCATEGORIA
            // 
            this.textBoxCATEGORIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCATEGORIA.Location = new System.Drawing.Point(202, 117);
            this.textBoxCATEGORIA.Name = "textBoxCATEGORIA";
            this.textBoxCATEGORIA.Size = new System.Drawing.Size(486, 26);
            this.textBoxCATEGORIA.TabIndex = 1;
            // 
            // textBoxPRECO
            // 
            this.textBoxPRECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPRECO.Location = new System.Drawing.Point(202, 168);
            this.textBoxPRECO.Name = "textBoxPRECO";
            this.textBoxPRECO.Size = new System.Drawing.Size(486, 26);
            this.textBoxPRECO.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "preco";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(241, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "cadastrar produto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista de produtos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "id";
            // 
            // textBoxEXCLUIR
            // 
            this.textBoxEXCLUIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEXCLUIR.Location = new System.Drawing.Point(26, 399);
            this.textBoxEXCLUIR.Name = "textBoxEXCLUIR";
            this.textBoxEXCLUIR.Size = new System.Drawing.Size(20, 26);
            this.textBoxEXCLUIR.TabIndex = 9;
            // 
            // labelEXCLUIR
            // 
            this.labelEXCLUIR.AutoSize = true;
            this.labelEXCLUIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEXCLUIR.Image = global::CADASTRO_PRODUTOS.Properties.Resources.excluir__1_;
            this.labelEXCLUIR.Location = new System.Drawing.Point(52, 400);
            this.labelEXCLUIR.Name = "labelEXCLUIR";
            this.labelEXCLUIR.Size = new System.Drawing.Size(32, 25);
            this.labelEXCLUIR.TabIndex = 10;
            this.labelEXCLUIR.Text = "    ";
            this.labelEXCLUIR.Click += new System.EventHandler(this.labelEXCLUIR_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(814, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // dataGridViewPRODUTOS
            // 
            this.dataGridViewPRODUTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPRODUTOS.Location = new System.Drawing.Point(795, 25);
            this.dataGridViewPRODUTOS.Name = "dataGridViewPRODUTOS";
            this.dataGridViewPRODUTOS.Size = new System.Drawing.Size(331, 371);
            this.dataGridViewPRODUTOS.TabIndex = 12;
            this.dataGridViewPRODUTOS.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPRODUTOS_CellMouseClick);
            // 
            // buttonALTERAR
            // 
            this.buttonALTERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonALTERAR.Location = new System.Drawing.Point(492, 252);
            this.buttonALTERAR.Name = "buttonALTERAR";
            this.buttonALTERAR.Size = new System.Drawing.Size(150, 36);
            this.buttonALTERAR.TabIndex = 13;
            this.buttonALTERAR.Text = "alterar";
            this.buttonALTERAR.UseVisualStyleBackColor = true;
            this.buttonALTERAR.Click += new System.EventHandler(this.buttonALTERAR_Click);
            // 
            // FormLISTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CADASTRO_PRODUTOS.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1165, 450);
            this.Controls.Add(this.buttonALTERAR);
            this.Controls.Add(this.dataGridViewPRODUTOS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelEXCLUIR);
            this.Controls.Add(this.textBoxEXCLUIR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPRECO);
            this.Controls.Add(this.textBoxCATEGORIA);
            this.Controls.Add(this.textBoxDESCRICAO);
            this.Name = "FormLISTA";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDESCRICAO;
        private System.Windows.Forms.TextBox textBoxCATEGORIA;
        private System.Windows.Forms.TextBox textBoxPRECO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEXCLUIR;
        private System.Windows.Forms.Label labelEXCLUIR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewPRODUTOS;
        private System.Windows.Forms.Button buttonALTERAR;
    }
}

