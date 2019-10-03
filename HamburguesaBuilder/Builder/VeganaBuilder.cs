using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class VeganaBuilder: HamburguesaBuilder
    {
        public VeganaBuilder(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Carne = carne,
                Pan = pan,
                Nombre = "Vegana",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _hamburguesa.Precio = 49.00;
        }

        public override void PasoAñadirPapas()
        {
            _hamburguesa.Papas = "NO";
        }

        public override void PasoPrepararIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Jitomate");
            _hamburguesa.Ingredientes.Add("Zanahoria");
            _hamburguesa.Ingredientes.Add("Lechuga Italiana");
            _hamburguesa.Ingredientes.Add("Cebolla");
            _hamburguesa.Ingredientes.Add("Tofu");
        }
    }
}
