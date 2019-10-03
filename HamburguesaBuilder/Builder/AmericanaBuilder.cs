using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;
namespace HamburguesaBuilder.Builder
{
    public class AmericanaBuilder : HamburguesaBuilder
    {
        public AmericanaBuilder(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Carne = carne,
                Pan = pan,
                Nombre = "Americana",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _hamburguesa.Precio = 79.00;
        }

        public override void PasoAñadirPapas()
        {
            _hamburguesa.Papas = "SI";
        }

        public override void PasoPrepararIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Tocino");
            _hamburguesa.Ingredientes.Add("Aros de Cebolla");
            _hamburguesa.Ingredientes.Add("Jitomate");
            _hamburguesa.Ingredientes.Add("Lechuga");
            _hamburguesa.Ingredientes.Add("Pepinillos");
            _hamburguesa.Ingredientes.Add("Queso Cheddar");
        }
    }
}
