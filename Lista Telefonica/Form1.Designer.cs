namespace Lista_Telefonica
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.list_cont = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.TextBox();
            this.Busca = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Resetar = new System.Windows.Forms.Button();
            this.Numero2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tipo2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Numero3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tipo3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(12, 44);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(175, 23);
            this.Nome.TabIndex = 0;
            this.Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(12, 115);
            this.Numero.MaxLength = 11;
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(128, 23);
            this.Numero.TabIndex = 1;
            this.Numero.TextChanged += new System.EventHandler(this.Numero_TextChanged);
            this.Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(158, 308);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(101, 38);
            this.Save.TabIndex = 6;
            this.Save.Text = "Salvar";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Tipo
            // 
            this.Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo.FormattingEnabled = true;
            this.Tipo.Items.AddRange(new object[] {
            " ",
            "CEL",
            "COM",
            "RES"});
            this.Tipo.Location = new System.Drawing.Point(158, 115);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(107, 23);
            this.Tipo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(158, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selecione o tipo";
            // 
            // list_cont
            // 
            this.list_cont.ContextMenuStrip = this.contextMenuStrip1;
            this.list_cont.Location = new System.Drawing.Point(292, 83);
            this.list_cont.MultiSelect = false;
            this.list_cont.Name = "list_cont";
            this.list_cont.Size = new System.Drawing.Size(551, 126);
            this.list_cont.TabIndex = 9;
            this.list_cont.UseCompatibleStateImageBehavior = false;
            this.list_cont.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.list_cont_ItemSelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem1.Text = "Excluir Contato";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(292, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Buscar Contato:";
            // 
            // Pesquisa
            // 
            this.Pesquisa.Location = new System.Drawing.Point(292, 44);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(162, 23);
            this.Pesquisa.TabIndex = 11;
            // 
            // Busca
            // 
            this.Busca.Location = new System.Drawing.Point(460, 44);
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(88, 23);
            this.Busca.TabIndex = 12;
            this.Busca.Text = "Buscar";
            this.Busca.UseVisualStyleBackColor = true;
            this.Busca.Click += new System.EventHandler(this.Busca_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(554, 44);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 14;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Visible = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Resetar
            // 
            this.Resetar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Resetar.Location = new System.Drawing.Point(12, 308);
            this.Resetar.Name = "Resetar";
            this.Resetar.Size = new System.Drawing.Size(103, 38);
            this.Resetar.TabIndex = 15;
            this.Resetar.Text = "Novo";
            this.Resetar.UseVisualStyleBackColor = true;
            this.Resetar.Click += new System.EventHandler(this.Resetar_Click);
            // 
            // Numero2
            // 
            this.Numero2.Location = new System.Drawing.Point(12, 186);
            this.Numero2.MaxLength = 11;
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(128, 23);
            this.Numero2.TabIndex = 1;
            this.Numero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone";
            // 
            // Tipo2
            // 
            this.Tipo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo2.FormattingEnabled = true;
            this.Tipo2.Items.AddRange(new object[] {
            " ",
            "CEL",
            "COM",
            "RES"});
            this.Tipo2.Location = new System.Drawing.Point(158, 186);
            this.Tipo2.Name = "Tipo2";
            this.Tipo2.Size = new System.Drawing.Size(107, 23);
            this.Tipo2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(158, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Selecione o tipo";
            // 
            // Numero3
            // 
            this.Numero3.Location = new System.Drawing.Point(12, 256);
            this.Numero3.MaxLength = 11;
            this.Numero3.Name = "Numero3";
            this.Numero3.Size = new System.Drawing.Size(128, 23);
            this.Numero3.TabIndex = 1;
            this.Numero3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Numero3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Telefone";
            // 
            // Tipo3
            // 
            this.Tipo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo3.FormattingEnabled = true;
            this.Tipo3.Items.AddRange(new object[] {
            " ",
            "CEL",
            "COM",
            "RES"});
            this.Tipo3.Location = new System.Drawing.Point(158, 256);
            this.Tipo3.Name = "Tipo3";
            this.Tipo3.Size = new System.Drawing.Size(107, 23);
            this.Tipo3.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(158, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Selecione o tipo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 358);
            this.Controls.Add(this.Resetar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Busca);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.list_cont);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tipo3);
            this.Controls.Add(this.Tipo2);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Numero3);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Nome;
        private TextBox Numero;
        private Label label1;
        private Label label2;
        private Button Save;
        private ComboBox Tipo;
        private Label label3;
        private ListView list_cont;
        private Label label4;
        private TextBox Pesquisa;
        private Button Busca;
        private Button Excluir;
        private Button Resetar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private TextBox Numero2;
        private Label label5;
        private ComboBox Tipo2;
        private Label label6;
        private TextBox Numero3;
        private Label label7;
        private ComboBox Tipo3;
        private Label label8;
    }
}