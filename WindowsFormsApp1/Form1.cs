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
        List<Hamburguesa> lista = new List<Hamburguesa>();
        public Form1()
        {
            InitializeComponent();
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
            dataGridView1.DataSource = typeof(List<Hamburguesa>);
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
                dataGridView1.DataSource = typeof(List<Hamburguesa>);
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
                dataGridView1.DataSource = typeof(List<Hamburguesa>);
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
            dataGridView1.DataSource = typeof(List<Hamburguesa>);
            dataGridView1.DataSource = lista;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new AmericanaBuilder(CarneEnum.Angus, PanEnum.Miel));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Hamburguesa>);
            dataGridView1.DataSource = lista;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new CubanaBuilder(CarneEnum.Arrachera, PanEnum.Ajo));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Hamburguesa>);
            dataGridView1.DataSource = lista;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new HawaianaBuilder(CarneEnum.Pescado, PanEnum.Blanco));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Hamburguesa>);
            dataGridView1.DataSource = lista;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new ItalianaBuilder(CarneEnum.Pollo, PanEnum.Ajonjolí));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Hamburguesa>);
            dataGridView1.DataSource = lista;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new LightBuilder(CarneEnum.Angus, PanEnum.Miel));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Hamburguesa>);
            dataGridView1.DataSource = lista;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hamburguesa aux = cocina.CocinarHamburguesa(new VeganaBuilder(CarneEnum.Soya, PanEnum.GluttenFree));
            total += aux.Precio;
            label1.Text = "$" + total.ToString() + ".00";
            lista.Add(aux);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Hamburguesa>);
            dataGridView1.DataSource = lista;
        }
    }
}
