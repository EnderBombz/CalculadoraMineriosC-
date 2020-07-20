namespace CalculadoraMinerios
{
    partial class Form_Calculador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Calculador));
            this.comboBox_minerio = new System.Windows.Forms.ComboBox();
            this.label_minerio = new System.Windows.Forms.Label();
            this.label_pack = new System.Windows.Forms.Label();
            this.label_unitario = new System.Windows.Forms.Label();
            this.label_valor_unit = new System.Windows.Forms.Label();
            this.label_valor_pack = new System.Windows.Forms.Label();
            this.panel_packs = new System.Windows.Forms.Panel();
            this.button_somar_1_pack = new System.Windows.Forms.Button();
            this.button_sub_1_pack = new System.Windows.Forms.Button();
            this.textBox_quant_packs = new System.Windows.Forms.TextBox();
            this.button_adicionar_packs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_quebrado = new System.Windows.Forms.Panel();
            this.button_somar_1_minerio = new System.Windows.Forms.Button();
            this.button_sub_1_minerio = new System.Windows.Forms.Button();
            this.button_adicionar_minerios = new System.Windows.Forms.Button();
            this.textBox_quant_minerios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_metodo = new System.Windows.Forms.GroupBox();
            this.radioButtonQuebrado = new System.Windows.Forms.RadioButton();
            this.radioButtonPack = new System.Windows.Forms.RadioButton();
            this.listBox_minerios = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_total = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_liquido = new System.Windows.Forms.Label();
            this.label_liq = new System.Windows.Forms.Label();
            this.label_imp = new System.Windows.Forms.Label();
            this.label_imposto = new System.Windows.Forms.Label();
            this.label_valorUnit = new System.Windows.Forms.Label();
            this.label_unitariocalc = new System.Windows.Forms.Label();
            this.label_pack_calc = new System.Windows.Forms.Label();
            this.label_calculando = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_minerio = new System.Windows.Forms.PictureBox();
            this.button_reiniciar = new System.Windows.Forms.Button();
            this.button_calculadora = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_imposto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_packs.SuspendLayout();
            this.panel_quebrado.SuspendLayout();
            this.groupBox_metodo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minerio)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_minerio
            // 
            this.comboBox_minerio.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_minerio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_minerio.Font = new System.Drawing.Font("Calibri", 10F);
            this.comboBox_minerio.FormattingEnabled = true;
            this.comboBox_minerio.Items.AddRange(new object[] {
            "Carvão",
            "Quartzo",
            "Ferro",
            "Redstone",
            "Ouro",
            "Lapis lazulli",
            "Esmeralda",
            "Diamante"});
            this.comboBox_minerio.Location = new System.Drawing.Point(9, 45);
            this.comboBox_minerio.Name = "comboBox_minerio";
            this.comboBox_minerio.Size = new System.Drawing.Size(121, 23);
            this.comboBox_minerio.TabIndex = 0;
            this.comboBox_minerio.SelectionChangeCommitted += new System.EventHandler(this.comboBox_minerio_SelectionChangeCommitted);
            this.comboBox_minerio.SelectedValueChanged += new System.EventHandler(this.comboBox_minerio_SelectedValueChanged);
            // 
            // label_minerio
            // 
            this.label_minerio.AutoSize = true;
            this.label_minerio.Font = new System.Drawing.Font("Calibri", 10F);
            this.label_minerio.Location = new System.Drawing.Point(8, 25);
            this.label_minerio.Name = "label_minerio";
            this.label_minerio.Size = new System.Drawing.Size(52, 17);
            this.label_minerio.TabIndex = 1;
            this.label_minerio.Text = "Minério";
            // 
            // label_pack
            // 
            this.label_pack.AutoSize = true;
            this.label_pack.Location = new System.Drawing.Point(6, 45);
            this.label_pack.Name = "label_pack";
            this.label_pack.Size = new System.Drawing.Size(109, 17);
            this.label_pack.TabIndex = 2;
            this.label_pack.Text = "Preço do pack fixo";
            // 
            // label_unitario
            // 
            this.label_unitario.AutoSize = true;
            this.label_unitario.Location = new System.Drawing.Point(6, 23);
            this.label_unitario.Name = "label_unitario";
            this.label_unitario.Size = new System.Drawing.Size(110, 17);
            this.label_unitario.TabIndex = 4;
            this.label_unitario.Text = "Preço unitário fixo";
            // 
            // label_valor_unit
            // 
            this.label_valor_unit.AutoSize = true;
            this.label_valor_unit.Location = new System.Drawing.Point(119, 24);
            this.label_valor_unit.Name = "label_valor_unit";
            this.label_valor_unit.Size = new System.Drawing.Size(15, 17);
            this.label_valor_unit.TabIndex = 7;
            this.label_valor_unit.Text = "0";
            // 
            // label_valor_pack
            // 
            this.label_valor_pack.AutoSize = true;
            this.label_valor_pack.Location = new System.Drawing.Point(119, 45);
            this.label_valor_pack.Name = "label_valor_pack";
            this.label_valor_pack.Size = new System.Drawing.Size(15, 17);
            this.label_valor_pack.TabIndex = 8;
            this.label_valor_pack.Text = "0";
            this.label_valor_pack.Click += new System.EventHandler(this.label_valor_pack_Click);
            // 
            // panel_packs
            // 
            this.panel_packs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_packs.Controls.Add(this.button_somar_1_pack);
            this.panel_packs.Controls.Add(this.button_sub_1_pack);
            this.panel_packs.Controls.Add(this.textBox_quant_packs);
            this.panel_packs.Controls.Add(this.button_adicionar_packs);
            this.panel_packs.Controls.Add(this.label1);
            this.panel_packs.Font = new System.Drawing.Font("Calibri", 10F);
            this.panel_packs.Location = new System.Drawing.Point(12, 273);
            this.panel_packs.Name = "panel_packs";
            this.panel_packs.Size = new System.Drawing.Size(194, 107);
            this.panel_packs.TabIndex = 9;
            this.panel_packs.Visible = false;
            // 
            // button_somar_1_pack
            // 
            this.button_somar_1_pack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_somar_1_pack.Location = new System.Drawing.Point(154, 35);
            this.button_somar_1_pack.Name = "button_somar_1_pack";
            this.button_somar_1_pack.Size = new System.Drawing.Size(25, 25);
            this.button_somar_1_pack.TabIndex = 5;
            this.button_somar_1_pack.Text = "+";
            this.button_somar_1_pack.UseVisualStyleBackColor = true;
            this.button_somar_1_pack.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_sub_1_pack
            // 
            this.button_sub_1_pack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_sub_1_pack.Location = new System.Drawing.Point(123, 35);
            this.button_sub_1_pack.Name = "button_sub_1_pack";
            this.button_sub_1_pack.Size = new System.Drawing.Size(25, 25);
            this.button_sub_1_pack.TabIndex = 4;
            this.button_sub_1_pack.Text = "-";
            this.button_sub_1_pack.UseVisualStyleBackColor = true;
            this.button_sub_1_pack.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_quant_packs
            // 
            this.textBox_quant_packs.Location = new System.Drawing.Point(8, 36);
            this.textBox_quant_packs.Name = "textBox_quant_packs";
            this.textBox_quant_packs.Size = new System.Drawing.Size(105, 24);
            this.textBox_quant_packs.TabIndex = 3;
            this.textBox_quant_packs.Text = "0";
            this.textBox_quant_packs.TextChanged += new System.EventHandler(this.textBox_quant_packs_TextChanged);
            this.textBox_quant_packs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button_adicionar_packs
            // 
            this.button_adicionar_packs.Location = new System.Drawing.Point(7, 62);
            this.button_adicionar_packs.Name = "button_adicionar_packs";
            this.button_adicionar_packs.Size = new System.Drawing.Size(106, 32);
            this.button_adicionar_packs.TabIndex = 2;
            this.button_adicionar_packs.Text = "Adicionar";
            this.button_adicionar_packs.UseVisualStyleBackColor = true;
            this.button_adicionar_packs.Click += new System.EventHandler(this.button1_Click);
            this.button_adicionar_packs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade de packs";
            // 
            // panel_quebrado
            // 
            this.panel_quebrado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_quebrado.Controls.Add(this.button_somar_1_minerio);
            this.panel_quebrado.Controls.Add(this.button_sub_1_minerio);
            this.panel_quebrado.Controls.Add(this.button_adicionar_minerios);
            this.panel_quebrado.Controls.Add(this.textBox_quant_minerios);
            this.panel_quebrado.Controls.Add(this.label2);
            this.panel_quebrado.Font = new System.Drawing.Font("Calibri", 10F);
            this.panel_quebrado.Location = new System.Drawing.Point(12, 273);
            this.panel_quebrado.Name = "panel_quebrado";
            this.panel_quebrado.Size = new System.Drawing.Size(194, 107);
            this.panel_quebrado.TabIndex = 10;
            this.panel_quebrado.Visible = false;
            // 
            // button_somar_1_minerio
            // 
            this.button_somar_1_minerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_somar_1_minerio.Location = new System.Drawing.Point(154, 35);
            this.button_somar_1_minerio.Name = "button_somar_1_minerio";
            this.button_somar_1_minerio.Size = new System.Drawing.Size(25, 25);
            this.button_somar_1_minerio.TabIndex = 6;
            this.button_somar_1_minerio.Text = "+";
            this.button_somar_1_minerio.UseVisualStyleBackColor = true;
            this.button_somar_1_minerio.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_sub_1_minerio
            // 
            this.button_sub_1_minerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_sub_1_minerio.Location = new System.Drawing.Point(123, 35);
            this.button_sub_1_minerio.Name = "button_sub_1_minerio";
            this.button_sub_1_minerio.Size = new System.Drawing.Size(25, 25);
            this.button_sub_1_minerio.TabIndex = 6;
            this.button_sub_1_minerio.Text = "-";
            this.button_sub_1_minerio.UseVisualStyleBackColor = true;
            this.button_sub_1_minerio.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_adicionar_minerios
            // 
            this.button_adicionar_minerios.Location = new System.Drawing.Point(7, 62);
            this.button_adicionar_minerios.Name = "button_adicionar_minerios";
            this.button_adicionar_minerios.Size = new System.Drawing.Size(106, 32);
            this.button_adicionar_minerios.TabIndex = 4;
            this.button_adicionar_minerios.Text = "Adicionar";
            this.button_adicionar_minerios.UseVisualStyleBackColor = true;
            this.button_adicionar_minerios.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_quant_minerios
            // 
            this.textBox_quant_minerios.Location = new System.Drawing.Point(8, 36);
            this.textBox_quant_minerios.Name = "textBox_quant_minerios";
            this.textBox_quant_minerios.Size = new System.Drawing.Size(106, 24);
            this.textBox_quant_minerios.TabIndex = 4;
            this.textBox_quant_minerios.Text = "0";
            this.textBox_quant_minerios.TextChanged += new System.EventHandler(this.textBox_quant_minerios_TextChanged);
            this.textBox_quant_minerios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_quant_minerios_KeyDown);
            this.textBox_quant_minerios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_quant_minerios_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade de minérios";
            // 
            // groupBox_metodo
            // 
            this.groupBox_metodo.Controls.Add(this.radioButtonQuebrado);
            this.groupBox_metodo.Controls.Add(this.radioButtonPack);
            this.groupBox_metodo.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox_metodo.Location = new System.Drawing.Point(12, 175);
            this.groupBox_metodo.Name = "groupBox_metodo";
            this.groupBox_metodo.Size = new System.Drawing.Size(132, 69);
            this.groupBox_metodo.TabIndex = 11;
            this.groupBox_metodo.TabStop = false;
            this.groupBox_metodo.Text = "Método de cálculo";
            this.groupBox_metodo.Visible = false;
            // 
            // radioButtonQuebrado
            // 
            this.radioButtonQuebrado.AutoSize = true;
            this.radioButtonQuebrado.Location = new System.Drawing.Point(8, 42);
            this.radioButtonQuebrado.Name = "radioButtonQuebrado";
            this.radioButtonQuebrado.Size = new System.Drawing.Size(72, 21);
            this.radioButtonQuebrado.TabIndex = 1;
            this.radioButtonQuebrado.TabStop = true;
            this.radioButtonQuebrado.Text = "Unitário";
            this.radioButtonQuebrado.UseVisualStyleBackColor = true;
            this.radioButtonQuebrado.CheckedChanged += new System.EventHandler(this.radioButtonQuebrado_CheckedChanged);
            // 
            // radioButtonPack
            // 
            this.radioButtonPack.AutoSize = true;
            this.radioButtonPack.Checked = true;
            this.radioButtonPack.Location = new System.Drawing.Point(8, 19);
            this.radioButtonPack.Name = "radioButtonPack";
            this.radioButtonPack.Size = new System.Drawing.Size(52, 21);
            this.radioButtonPack.TabIndex = 0;
            this.radioButtonPack.TabStop = true;
            this.radioButtonPack.Text = "Pack";
            this.radioButtonPack.UseVisualStyleBackColor = true;
            this.radioButtonPack.CheckedChanged += new System.EventHandler(this.radioButtonPack_CheckedChanged);
            // 
            // listBox_minerios
            // 
            this.listBox_minerios.Font = new System.Drawing.Font("Calibri", 10F);
            this.listBox_minerios.FormattingEnabled = true;
            this.listBox_minerios.ItemHeight = 15;
            this.listBox_minerios.Location = new System.Drawing.Point(10, 19);
            this.listBox_minerios.Name = "listBox_minerios";
            this.listBox_minerios.Size = new System.Drawing.Size(229, 184);
            this.listBox_minerios.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_unitario);
            this.groupBox2.Controls.Add(this.label_pack);
            this.groupBox2.Controls.Add(this.label_valor_unit);
            this.groupBox2.Controls.Add(this.label_valor_pack);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox2.Location = new System.Drawing.Point(226, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 81);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores do minério";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_total);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox3.Location = new System.Drawing.Point(420, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 110);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rendimento Total";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Calibri", 18F);
            this.label_total.Location = new System.Drawing.Point(6, 44);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(25, 29);
            this.label_total.TabIndex = 0;
            this.label_total.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_liquido);
            this.groupBox4.Controls.Add(this.label_liq);
            this.groupBox4.Controls.Add(this.label_imp);
            this.groupBox4.Controls.Add(this.label_imposto);
            this.groupBox4.Controls.Add(this.label_valorUnit);
            this.groupBox4.Controls.Add(this.label_unitariocalc);
            this.groupBox4.Controls.Add(this.label_pack_calc);
            this.groupBox4.Controls.Add(this.label_calculando);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox4.Location = new System.Drawing.Point(226, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 110);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calculo";
            // 
            // label_liquido
            // 
            this.label_liquido.AutoSize = true;
            this.label_liquido.Location = new System.Drawing.Point(7, 77);
            this.label_liquido.Name = "label_liquido";
            this.label_liquido.Size = new System.Drawing.Size(48, 17);
            this.label_liquido.TabIndex = 14;
            this.label_liquido.Text = "Liquído";
            // 
            // label_liq
            // 
            this.label_liq.AutoSize = true;
            this.label_liq.Location = new System.Drawing.Point(99, 77);
            this.label_liq.Name = "label_liq";
            this.label_liq.Size = new System.Drawing.Size(15, 17);
            this.label_liq.TabIndex = 13;
            this.label_liq.Text = "0";
            // 
            // label_imp
            // 
            this.label_imp.AutoSize = true;
            this.label_imp.Location = new System.Drawing.Point(99, 51);
            this.label_imp.Name = "label_imp";
            this.label_imp.Size = new System.Drawing.Size(15, 17);
            this.label_imp.TabIndex = 12;
            this.label_imp.Text = "0";
            // 
            // label_imposto
            // 
            this.label_imposto.AutoSize = true;
            this.label_imposto.Location = new System.Drawing.Point(7, 51);
            this.label_imposto.Name = "label_imposto";
            this.label_imposto.Size = new System.Drawing.Size(54, 17);
            this.label_imposto.TabIndex = 11;
            this.label_imposto.Text = "Imposto";
            // 
            // label_valorUnit
            // 
            this.label_valorUnit.AutoSize = true;
            this.label_valorUnit.Location = new System.Drawing.Point(99, 24);
            this.label_valorUnit.Name = "label_valorUnit";
            this.label_valorUnit.Size = new System.Drawing.Size(15, 17);
            this.label_valorUnit.TabIndex = 10;
            this.label_valorUnit.Text = "0";
            this.label_valorUnit.Visible = false;
            // 
            // label_unitariocalc
            // 
            this.label_unitariocalc.AutoSize = true;
            this.label_unitariocalc.Location = new System.Drawing.Point(7, 24);
            this.label_unitariocalc.Name = "label_unitariocalc";
            this.label_unitariocalc.Size = new System.Drawing.Size(93, 17);
            this.label_unitariocalc.TabIndex = 9;
            this.label_unitariocalc.Text = "Unitário(bruto)";
            this.label_unitariocalc.Visible = false;
            // 
            // label_pack_calc
            // 
            this.label_pack_calc.AutoSize = true;
            this.label_pack_calc.Location = new System.Drawing.Point(7, 24);
            this.label_pack_calc.Name = "label_pack_calc";
            this.label_pack_calc.Size = new System.Drawing.Size(76, 17);
            this.label_pack_calc.TabIndex = 2;
            this.label_pack_calc.Text = "Pack (bruto)";
            this.label_pack_calc.Visible = false;
            // 
            // label_calculando
            // 
            this.label_calculando.AutoSize = true;
            this.label_calculando.Location = new System.Drawing.Point(99, 24);
            this.label_calculando.Name = "label_calculando";
            this.label_calculando.Size = new System.Drawing.Size(15, 17);
            this.label_calculando.TabIndex = 8;
            this.label_calculando.Text = "0";
            this.label_calculando.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créditosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.créditosToolStripMenuItem.Text = "Créditos";
            this.créditosToolStripMenuItem.Click += new System.EventHandler(this.créditosToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_imposto);
            this.groupBox1.Controls.Add(this.label_minerio);
            this.groupBox1.Controls.Add(this.comboBox_minerio);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 120);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox_minerio
            // 
            this.pictureBox_minerio.Image = global::CalculadoraMinerios.Properties.Resources.Stone_JE4_BE2;
            this.pictureBox_minerio.Location = new System.Drawing.Point(226, 42);
            this.pictureBox_minerio.Name = "pictureBox_minerio";
            this.pictureBox_minerio.Size = new System.Drawing.Size(173, 123);
            this.pictureBox_minerio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_minerio.TabIndex = 3;
            this.pictureBox_minerio.TabStop = false;
            // 
            // button_reiniciar
            // 
            this.button_reiniciar.Font = new System.Drawing.Font("Calibri", 15F);
            this.button_reiniciar.Location = new System.Drawing.Point(555, 386);
            this.button_reiniciar.Name = "button_reiniciar";
            this.button_reiniciar.Size = new System.Drawing.Size(110, 52);
            this.button_reiniciar.TabIndex = 17;
            this.button_reiniciar.Text = "Limpar";
            this.button_reiniciar.UseVisualStyleBackColor = true;
            this.button_reiniciar.Click += new System.EventHandler(this.button_reiniciar_Click);
            // 
            // button_calculadora
            // 
            this.button_calculadora.Font = new System.Drawing.Font("Calibri", 15F);
            this.button_calculadora.Location = new System.Drawing.Point(420, 386);
            this.button_calculadora.Name = "button_calculadora";
            this.button_calculadora.Size = new System.Drawing.Size(129, 52);
            this.button_calculadora.TabIndex = 18;
            this.button_calculadora.Text = "Calculadora";
            this.button_calculadora.UseVisualStyleBackColor = true;
            this.button_calculadora.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox_minerios);
            this.groupBox5.Location = new System.Drawing.Point(420, 40);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 212);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Histórico de calculos";
            // 
            // textBox_imposto
            // 
            this.textBox_imposto.Location = new System.Drawing.Point(86, 74);
            this.textBox_imposto.Name = "textBox_imposto";
            this.textBox_imposto.ReadOnly = true;
            this.textBox_imposto.Size = new System.Drawing.Size(44, 24);
            this.textBox_imposto.TabIndex = 2;
            this.textBox_imposto.Text = "5%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Imposto";
            // 
            // Form_Calculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button_calculadora);
            this.Controls.Add(this.button_reiniciar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel_quebrado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_metodo);
            this.Controls.Add(this.panel_packs);
            this.Controls.Add(this.pictureBox_minerio);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Calculador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Imperial";
            this.Load += new System.EventHandler(this.Form_Calculador_Load);
            this.panel_packs.ResumeLayout(false);
            this.panel_packs.PerformLayout();
            this.panel_quebrado.ResumeLayout(false);
            this.panel_quebrado.PerformLayout();
            this.groupBox_metodo.ResumeLayout(false);
            this.groupBox_metodo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minerio)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_minerio;
        private System.Windows.Forms.Label label_minerio;
        private System.Windows.Forms.Label label_pack;
        private System.Windows.Forms.PictureBox pictureBox_minerio;
        private System.Windows.Forms.Label label_unitario;
        private System.Windows.Forms.Label label_valor_unit;
        private System.Windows.Forms.Label label_valor_pack;
        private System.Windows.Forms.Panel panel_packs;
        private System.Windows.Forms.Button button_adicionar_packs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_quebrado;
        private System.Windows.Forms.GroupBox groupBox_metodo;
        private System.Windows.Forms.TextBox textBox_quant_packs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonQuebrado;
        private System.Windows.Forms.RadioButton radioButtonPack;
        private System.Windows.Forms.TextBox textBox_quant_minerios;
        private System.Windows.Forms.ListBox listBox_minerios;
        private System.Windows.Forms.Button button_adicionar_minerios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button button_somar_1_pack;
        private System.Windows.Forms.Button button_sub_1_pack;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_pack_calc;
        private System.Windows.Forms.Label label_calculando;
        private System.Windows.Forms.Button button_somar_1_minerio;
        private System.Windows.Forms.Button button_sub_1_minerio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_valorUnit;
        private System.Windows.Forms.Label label_unitariocalc;
        private System.Windows.Forms.Label label_imp;
        private System.Windows.Forms.Label label_imposto;
        private System.Windows.Forms.Label label_liquido;
        private System.Windows.Forms.Label label_liq;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_reiniciar;
        private System.Windows.Forms.Button button_calculadora;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_imposto;
    }
}

