using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CalculadoraMinerios
{
    public partial class Form_Calculador : Form
    {
        int coal = 640;
        int coalUnit;
        int quartz = 960;
        int quartzUnit;
        int iron = 1280;
        int ironUnit;
        int redstone = 1920;
        int redstoneUnit;
        int gold = 3840;
        int goldUnit;
        int lapis = 8320;
        int lapisUnit;
        int esmerald = 25600;
        int esmeraldUnit;
        int diamond = 6400;
        int diamondUnit;
        float total = 0;
        

        public Form_Calculador()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void Form_Calculador_Load(object sender, EventArgs e)
        {
            coalUnit = coal / 64;
            quartzUnit = quartz / 64;
            ironUnit = iron / 64;
            redstoneUnit = redstone / 64;
            goldUnit = gold / 64;
            lapisUnit = lapis / 64;
            esmeraldUnit = esmerald / 64;
            diamondUnit = diamond / 64;

      
        }

        private void label_valor_pack_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox_minerio_SelectionChangeCommitted(object sender, EventArgs e)
        {
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPack_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonPack.Checked)
            {
                panel_packs.Visible = true;
                panel_quebrado.Visible = false;
                textBox_quant_packs.Text = "0";
                textBox_quant_minerios.Text = "0";
                label_valorUnit.Text = "0";
                label_calculando.Text = "0";

                label_pack_calc.Visible = true;
                label_calculando.Visible = true;

                label_unitariocalc.Visible = false;
                label_valorUnit.Visible = false;
            }
        }

        private void radioButtonQuebrado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQuebrado.Checked)
            {
                panel_packs.Visible = false;
                panel_quebrado.Visible = true;
                textBox_quant_packs.Text = "0";
                textBox_quant_minerios.Text = "0";
                label_valorUnit.Text = "0";
                label_calculando.Text = "0";

                label_unitariocalc.Visible = true;
                label_valorUnit.Visible = true;

                label_pack_calc.Visible = false;
                label_calculando.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_quant_packs.Text == "0")
                {
                    MessageBox.Show("Não é possivel enviar","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    string moeda = label_calculando.Text;
                    moeda = moeda.Replace("c", "");

                    int quant_packs;
                    quant_packs = int.Parse(textBox_quant_packs.Text);

                    int valor_packs;
                    valor_packs = int.Parse(moeda);

                    int liquido = int.Parse(label_liq.Text);

                    listBox_minerios.Items.Add(quant_packs.ToString() + " " + "Pack(s)" + " de " + comboBox_minerio.Text + " = " + liquido.ToString());

                    total += int.Parse(label_liq.Text);

                    textBox_quant_packs.Text = "0";
                    label_calculando.Text = textBox_quant_packs.Text;
                    label_imp.Text = "0";
                    label_liq.Text = "0";

                    label_total.Text = total.ToString("F0");
                }
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
           }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int add = int.Parse(textBox_quant_packs.Text);
                add++;
                textBox_quant_packs.Text = add.ToString();
                

                string valorPacks = label_valor_pack.Text;
                valorPacks = valorPacks.Replace("c", "");
                label_calculando.Text = valorPacks;

                int pack;
               pack = int.Parse(valorPacks);
                int calculando;
              
               calculando = add * pack;

                float imp = 0.10f;
                float imposto;
                float liquido;
                

                imposto = calculando * imp;
                liquido = calculando - imposto;
              
                label_calculando.Text = calculando.ToString();
                label_imp.Text = imposto.ToString("F0");
                label_liq.Text = liquido.ToString("F0");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int sub = int.Parse(textBox_quant_packs.Text);

            if (sub > 0)
            {
                sub--;
                textBox_quant_packs.Text = sub.ToString();

                string valorPacks = label_valor_pack.Text;
                valorPacks = valorPacks.Replace("c", "");
                label_calculando.Text = valorPacks;

                int pack;
                pack = int.Parse(valorPacks);
                int calculando;

                calculando = sub * pack;

                    float imp = 0.10f;
                    float imposto;
                    float liquido;


                    imposto = calculando * imp;
                    liquido = calculando - imposto;



                    label_calculando.Text = calculando.ToString();
                    label_imp.Text = imposto.ToString("F0");
                    label_liq.Text = liquido.ToString("F0");

                }
            
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int conv;

            if (textBox_quant_minerios.Text == "" || textBox_quant_packs.Text == "")
            {
                

                //minerios
                if (textBox_quant_minerios.Text == "")
                {
                    label_valorUnit.Text = "0";
                    label_imp.Text = "0";
                    label_liq.Text = "0";

                }
                else
                {
                   

                }          

                //Packs
                if (textBox_quant_packs.Text == "")
                {
                    label_calculando.Text = "0";
                    label_imp.Text = "0";
                    label_liq.Text = "0";
                }
                else
                {
                    
                }
            }
            else
            {
                if (radioButtonQuebrado.Checked)
                {
                    conv = int.Parse(textBox_quant_minerios.Text);

                    if (conv > 64)
                    {
                        textBox_quant_minerios.Text = "64";
                        MessageBox.Show("O limite para os minerios em valor unitário é 64", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        int valorUnit;
                        string valor = label_valor_unit.Text;
                        valor = valor.Replace("c", "");

                        valorUnit = int.Parse(valor);


                        float num;
                        num = float.Parse(textBox_quant_minerios.Text);

                        float imp;
                        
                        if(textBox_imposto.Text == "10%")
                        {
                            imp = 0.10f;
                            float imposto;
                            float liquido;

                            float bruto;

                            bruto = num * valorUnit;
                            imposto = bruto * imp;
                            liquido = bruto - imposto;

                            label_valorUnit.Text = bruto.ToString("F0");
                            label_imp.Text = imposto.ToString("F0");
                            label_liq.Text = liquido.ToString("F0");
                        }
                        if(textBox_imposto.Text == "5%")
                        {
                            imp = 0.05f;
                            float imposto;
                            float liquido;

                            float bruto;

                            bruto = num * valorUnit;
                            imposto = bruto * imp;
                            liquido = bruto - imposto;

                            label_valorUnit.Text = bruto.ToString("F0");
                            label_imp.Text = imposto.ToString("F0");
                            label_liq.Text = liquido.ToString("F0");
                        }
                        if (textBox_imposto.Text == "0%")
                        {
                            imp = 0.00f;
                            float imposto;
                            float liquido;

                            float bruto;

                            bruto = num * valorUnit;
                            imposto = bruto * imp;
                            liquido = bruto - imposto;

                            label_valorUnit.Text = bruto.ToString("F0");
                            label_imp.Text = imposto.ToString("F0");
                            label_liq.Text = liquido.ToString("F0");
                        }






                    }
                }
                if(radioButtonPack.Checked)
                {
                    int valorPack;
                    string valor = label_valor_pack.Text;
                    valor = valor.Replace("c", "");

                    valorPack = int.Parse(valor);

                    float num;
                    num = float.Parse(textBox_quant_packs.Text);

                    float imp;
                    if (textBox_imposto.Text == "10%")
                    {
                        imp = 0.10f;
                        float imposto;
                        float liquido;

                        float bruto;

                        bruto = num * valorPack;
                        imposto = bruto * imp;
                        liquido = bruto - imposto;

                        label_calculando.Text = bruto.ToString("F0");
                        label_imp.Text = imposto.ToString("F0");
                        label_liq.Text = liquido.ToString("F0");
                    }
                    if (textBox_imposto.Text == "5%")
                    {
                        imp = 0.05f;
                        float imposto;
                        float liquido;

                        float bruto;

                        bruto = num * valorPack;
                        imposto = bruto * imp;
                        liquido = bruto - imposto;

                        label_calculando.Text = bruto.ToString("F0");
                        label_imp.Text = imposto.ToString("F0");
                        label_liq.Text = liquido.ToString("F0");
                    }
                    if (textBox_imposto.Text == "0%")
                    {
                        imp = 0.00f;
                        float imposto;
                        float liquido;

                        float bruto;

                        bruto = num * valorPack;
                        imposto = bruto * imp;
                        liquido = bruto - imposto;

                        label_calculando.Text = bruto.ToString("F0");
                        label_imp.Text = imposto.ToString("F0");
                        label_liq.Text = liquido.ToString("F0");
                    }

                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int add = int.Parse(textBox_quant_minerios.Text);
                if (add >= 0 && add < 64)
                {
                    add++;
                    textBox_quant_minerios.Text = add.ToString();


                    string valorUnit = label_valor_unit.Text;
                    valorUnit = valorUnit.Replace("c", "");
                    label_valorUnit.Text = valorUnit;

                    int unit;
                    unit = int.Parse(valorUnit);
                    int calculando;

                    calculando = add * unit;

                    float imp = 0.10f;
                    float imposto;
                    float liquido;


                    imposto = calculando * imp;
                    liquido = calculando - imposto;

                    label_valorUnit.Text = calculando.ToString();
                    label_imp.Text = imposto.ToString("F0");
                    label_liq.Text = liquido.ToString("F0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int sub = int.Parse(textBox_quant_minerios.Text);
                if (sub > 0)
                {
                    
                    sub--;
                    textBox_quant_minerios.Text = sub.ToString();


                    string valorUnit = label_valor_unit.Text;
                    valorUnit = valorUnit.Replace("c", "");
                    label_valorUnit.Text = valorUnit;

                    int unit;
                    unit = int.Parse(valorUnit);
                    int calculando;

                    calculando = sub * unit;

                    float imp = 0.10f;
                    float imposto;
                    float liquido;


                    imposto = calculando * imp;
                    liquido = calculando - imposto;

                    label_valorUnit.Text = calculando.ToString();
                    label_imp.Text = imposto.ToString("F0");
                    label_liq.Text = liquido.ToString("F0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int minerio;
                minerio = int.Parse(textBox_quant_minerios.Text);
            

                if (textBox_quant_minerios.Text == "0" || minerio > 64)
                {
                    if (textBox_quant_minerios.Text == "0")
                    {
                        MessageBox.Show("Não é possivel enviar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (minerio > 64)
                    {
                        textBox_quant_minerios.Text = "64";
                        MessageBox.Show("O limite para os minerios em valor unitário é 64", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {

                    string moeda = label_valorUnit.Text;
                    moeda = moeda.Replace("c", "");


                    int quant_minerio = int.Parse(textBox_quant_minerios.Text);
                    int liquido;

                    listBox_minerios.Items.Add(quant_minerio.ToString() + " " + "Minerio(s)" + " de " + comboBox_minerio.Text + " = " + label_liq.Text);

                    liquido = int.Parse(label_liq.Text);
                    total += liquido;

                    textBox_quant_minerios.Text = "0";
                    label_valorUnit.Text = textBox_quant_minerios.Text;
                    label_imp.Text = "0";
                    label_liq.Text = "0";


                   
                    label_total.Text = total.ToString("F0");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creditos cred = new Creditos();
            cred.ShowDialog();
        }

        private void button_reiniciar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja reiniciar os calculos?","Questão",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listBox_minerios.Items.Clear();
                pictureBox_minerio.Image = Properties.Resources.Stone_JE4_BE2;
                comboBox_minerio.Items.Add("");
                comboBox_minerio.Text = "";
                comboBox_minerio.Items.RemoveAt(8);

                groupBox_metodo.Visible = false;
                panel_packs.Visible = false;
                panel_quebrado.Visible = false;
                label_valor_unit.Text = "0";
                label_valor_pack.Text = "0";
                label_valorUnit.Text = "0";
                label_imp.Text = "0";
                label_liq.Text = "0";
                total = 0;
                label_total.Text = "0";

            }
        }

        private void textBox_quant_minerios_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void comboBox_minerio_SelectedValueChanged(object sender, EventArgs e)
        {

            if (comboBox_minerio.Text != "")
            {
                groupBox_metodo.Visible = true;
            }

            label_valorUnit.Text = "0";
            label_calculando.Text = "0";
            textBox_quant_minerios.Text = "0";
            textBox_quant_packs.Text = "0";

            radioButtonPack.Checked = false;
            radioButtonQuebrado.Checked = false;

            label_imp.Text = "0";
            label_liq.Text = "0";

            panel_packs.Visible = false;
            panel_quebrado.Visible = false;

            if (comboBox_minerio.Text == "Carvão")
            {
                pictureBox_minerio.Image = Properties.Resources.Coal_Ore_JE2_BE2;
                label_valor_pack.Text = coal.ToString() + "c";
                label_valor_unit.Text = coalUnit.ToString() + "c";
            }
            if (comboBox_minerio.Text == "Quartzo")
            {
                pictureBox_minerio.Image = Properties.Resources.Nether_Quartz_Ore_JE3_BE2;
                label_valor_pack.Text = quartz.ToString() + "c";
                label_valor_unit.Text = quartzUnit.ToString() + "c";
            }
            if (comboBox_minerio.Text == "Ferro")
            {
                pictureBox_minerio.Image = Properties.Resources.Iron_Ore_JE3_BE2;
                label_valor_pack.Text = iron.ToString() + "c";
                label_valor_unit.Text = ironUnit.ToString() + "c";
            }
            if (comboBox_minerio.Text == "Redstone")
            {
                pictureBox_minerio.Image = Properties.Resources.Redstone_Ore_JE2_BE2;
                label_valor_pack.Text = redstone.ToString() + "c";
                label_valor_unit.Text = redstoneUnit.ToString() + "c";
            }
            if (comboBox_minerio.Text == "Ouro")
            {
                pictureBox_minerio.Image = Properties.Resources.Gold_Ore_JE3_BE2;
                label_valor_pack.Text = gold.ToString() + "c";
                label_valor_unit.Text = goldUnit.ToString() + "c";
            }
            if (comboBox_minerio.Text == "Lapis lazulli")
            {
                pictureBox_minerio.Image = Properties.Resources.Lapis_Lazuli_Ore_JE2_BE2;
                label_valor_pack.Text = lapis.ToString() + "c";
                label_valor_unit.Text = lapisUnit.ToString() + "c";
            }
            if (comboBox_minerio.Text == "Esmeralda")
            {
                pictureBox_minerio.Image = Properties.Resources.Emerald_Ore_JE2_BE2;
                label_valor_pack.Text = esmerald.ToString() + "c";
                label_valor_unit.Text = esmeraldUnit.ToString() + "c";
            }
            if (comboBox_minerio.Text == "Diamante")
            {
                pictureBox_minerio.Image = Properties.Resources.Diamond;
                label_valor_pack.Text = diamond.ToString() + "c";
                label_valor_unit.Text = diamondUnit.ToString() + "c";
            }

        }

        private void textBox_quant_minerios_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void textBox_quant_packs_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_quant_minerios_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button2_Click(null, null);
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }
    }
}
