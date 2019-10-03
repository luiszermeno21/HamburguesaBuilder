using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class HawaianaBuilder: HamburguesaBuilder
    {
        public HawaianaBuilder(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Carne = carne,
                Pan = pan,
                Nombre = "Hawaiana",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _hamburguesa.Precio = 59.00;
        }

        public override void PasoAñadirPapas()
        {
            _hamburguesa.Papas = "NO";
        }

        public override void PasoPrepararIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Jamón");
            _hamburguesa.Ingredientes.Add("Piña");
            _hamburguesa.Ingredientes.Add("Lechuga");
            _hamburguesa.Ingredientes.Add("Cebolla");
            _hamburguesa.Ingredientes.Add("Queso Amarillo");
        }
    }
}
