using HamburguesaBuilder.Builder;
using HamburguesaBuilder.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Cocina cocina = new Cocina();
        double total = 0;
        List<Food> lista = new List<Food>();
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(AlimentoEnum));
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new MexicanaBuilder(CarneEnum.Pastor, PanEnum.Blanco));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Food>);
            dataGridView1.DataSource = lista;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(lista.Count > 0)
            {
                total -= lista.ElementAt(e.RowIndex).Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.RemoveAt(e.RowIndex);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(lista.Count > 0)
            {
                label1.Text = "$0.00";
                lista.Clear();
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
                MessageBox.Show("¡Gracias, vuelva pronto!");
            }
            else MessageBox.Show("No ha ingresado ningun producto a su cuenta.");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new AlemanaBuilder(CarneEnum.Angus, PanEnum.Ajonjolí));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Food>);
            dataGridView1.DataSource = lista;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new AmericanaBuilder(CarneEnum.Angus, PanEnum.Miel));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Food>);
            dataGridView1.DataSource = lista;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new CubanaBuilder(CarneEnum.Arrachera, PanEnum.Ajo));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Food>);
            dataGridView1.DataSource = lista;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new HawaianaBuilder(CarneEnum.Pescado, PanEnum.Blanco));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Food>);
            dataGridView1.DataSource = lista;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new ItalianaBuilder(CarneEnum.Pollo, PanEnum.Ajonjolí));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Food>);
            dataGridView1.DataSource = lista;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new LightBuilder(CarneEnum.Angus, PanEnum.Miel));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Food>);
            dataGridView1.DataSource = lista;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new VeganaBuilder(CarneEnum.Soya, PanEnum.GluttenFree));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Food>);
            dataGridView1.DataSource = lista;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Hamburguesa")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                if(comboBox1.Text == "Sandwich")
                {
                    Sandwich saleman = cocina.CocinarSandwich(new SandwichAleman(CarneEnum.Angus,PanEnum.Ajonjolí));
                    Sandwich samericano = cocina.CocinarSandwich(new SandwichAmericano(CarneEnum.Angus,PanEnum.Blanco));
                    Sandwich scubano = cocina.CocinarSandwich(new SandwichCubano(CarneEnum.Arrachera,PanEnum.Ajo));
                    Sandwich shawaiano = cocina.CocinarSandwich(new SandwichHawaiano(CarneEnum.Pescado,PanEnum.Miel));
                    Sandwich sitaliano = cocina.CocinarSandwich(new SandwichItaliano(CarneEnum.Pollo,PanEnum.Ajo));
                    Sandwich slight = cocina.CocinarSandwich(new SandwichLight(CarneEnum.Pollo,PanEnum.Ajonjolí));
                    Sandwich smexicano = cocina.CocinarSandwich(new SandwichMexicano(CarneEnum.Pastor,PanEnum.Miel));
                    Sandwich svegano = cocina.CocinarSandwich(new SandwichVegano(CarneEnum.Soya,PanEnum.GluttenFree));
                    label15.Text = "Sandwich " + saleman.Nombre;
                    label16.Text = saleman.Descripción();
                    label17.Text = "Sandwich " + samericano.Nombre;
                    label18.Text = samericano.Descripción();
                    label19.Text = "Sandwich " + scubano.Nombre;
                    label20.Text = scubano.Descripción();
                    label21.Text = "Sandwich " + shawaiano.Nombre;
                    label22.Text = shawaiano.Descripción();
                    label23.Text = "Sandwich " + sitaliano.Nombre;
                    label24.Text = sitaliano.Descripción();
                    label25.Text = "Sandwich " + slight.Nombre;
                    label26.Text = slight.Descripción();
                    label27.Text = "Sandwich " + smexicano.Nombre;
                    label28.Text = smexicano.Descripción();
                    label29.Text = "Sandwich " + svegano.Nombre;
                    label30.Text = svegano.Descripción();
                }
                else
                {
                    Baguette saleman = cocina.CocinarBaguette(new BaguetteAleman(CarneEnum.Angus,PanEnum.Ajonjolí));
                    Baguette samericano = cocina.CocinarBaguette(new BaguetteAmericano(CarneEnum.Angus,PanEnum.Blanco));
                    Baguette scubano = cocina.CocinarBaguette(new BaguetteCubano(CarneEnum.Arrachera,PanEnum.Ajo));
                    Baguette shawaiano = cocina.CocinarBaguette(new BaguetteHawaiano(CarneEnum.Pescado,PanEnum.Miel));
                    Baguette sitaliano = cocina.CocinarBaguette(new BaguetteItaliano(CarneEnum.Pollo,PanEnum.Ajo));
                    Baguette slight = cocina.CocinarBaguette(new BaguetteLight(CarneEnum.Pollo,PanEnum.Ajonjolí));
                    Baguette smexicano = cocina.CocinarBaguette(new BaguetteMexicano(CarneEnum.Pastor,PanEnum.Miel));
                    Baguette svegano = cocina.CocinarBaguette(new BaguetteVegano(CarneEnum.Soya,PanEnum.GluttenFree));
                    label15.Text = "Baguette " + saleman.Nombre;
                    label16.Text = saleman.Descripción();
                    label17.Text = "Baguette " + samericano.Nombre;
                    label18.Text = samericano.Descripción();
                    label19.Text = "Baguette " + scubano.Nombre;
                    label20.Text = scubano.Descripción();
                    label21.Text = "Baguette " + shawaiano.Nombre;
                    label22.Text = shawaiano.Descripción();
                    label23.Text = "Baguette " + sitaliano.Nombre;
                    label24.Text = sitaliano.Descripción();
                    label25.Text = "Baguette " + slight.Nombre;
                    label26.Text = slight.Descripción();
                    label27.Text = "Baguette " + smexicano.Nombre;
                    label28.Text = smexicano.Descripción();
                    label29.Text = "Baguette " + svegano.Nombre;
                    label30.Text = svegano.Descripción();
                }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sandwich")
            {
                Sandwich aux = cocina.CocinarSandwich(new SandwichAleman(CarneEnum.Angus,PanEnum.Ajonjolí));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
            else
            {
                Baguette aux = cocina.CocinarBaguette(new BaguetteAleman(CarneEnum.Angus, PanEnum.Ajonjolí));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sandwich")
            {
                Sandwich aux = cocina.CocinarSandwich(new SandwichAmericano(CarneEnum.Angus, PanEnum.Blanco));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
            else
            {
                Baguette aux = cocina.CocinarBaguette(new BaguetteAmericano(CarneEnum.Angus, PanEnum.Blanco));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sandwich")
            {
                Sandwich aux = cocina.CocinarSandwich(new SandwichCubano(CarneEnum.Arrachera, PanEnum.Ajo));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
            else
            {
                Baguette aux = cocina.CocinarBaguette(new BaguetteCubano(CarneEnum.Arrachera, PanEnum.Ajo));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sandwich")
            {
                Sandwich aux = cocina.CocinarSandwich(new SandwichHawaiano(CarneEnum.Pescado, PanEnum.Miel));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
            else
            {
                Baguette aux = cocina.CocinarBaguette(new BaguetteHawaiano(CarneEnum.Pescado, PanEnum.Miel));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sandwich")
            {
                Sandwich aux = cocina.CocinarSandwich(new SandwichItaliano(CarneEnum.Pescado, PanEnum.Ajo));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
            else
            {
                Baguette aux = cocina.CocinarBaguette(new BaguetteItaliano(CarneEnum.Pescado, PanEnum.Ajo));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sandwich")
            {
                Sandwich aux = cocina.CocinarSandwich(new SandwichLight(CarneEnum.Pollo, PanEnum.Ajonjolí));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
            else
            {
                Baguette aux = cocina.CocinarBaguette(new BaguetteLight(CarneEnum.Pollo, PanEnum.Ajonjolí));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sandwich")
            {
                Sandwich aux = cocina.CocinarSandwich(new SandwichMexicano(CarneEnum.Pastor, PanEnum.Miel));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
            else
            {
                Baguette aux = cocina.CocinarBaguette(new BaguetteMexicano(CarneEnum.Pastor, PanEnum.Miel));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sandwich")
            {
                Sandwich aux = cocina.CocinarSandwich(new SandwichVegano(CarneEnum.Soya, PanEnum.GluttenFree));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
            else
            {
                Baguette aux = cocina.CocinarBaguette(new BaguetteVegano(CarneEnum.Soya, PanEnum.GluttenFree));
                total += aux.Precio;
                label1.Text = "$" + total.ToString() + ".00";
                lista.Add(aux);
                dataGridView1.DataSource = new BindingSource(lista, null);
                dataGridView1.DataSource = typeof(List<Food>);
                dataGridView1.DataSource = lista;
            }
        }
    }
}
