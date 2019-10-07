using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class ItalianaBuilder : HamburguesaBuilder
    {
        public ItalianaBuilder(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Tipo = "Hamburguesa",
                Carne = carne,
                Pan = pan,
                Nombre = "Italiana",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _hamburguesa.Precio = 69.00;
        }

        public override void PasoAñadirPapas()
        {
            _hamburguesa.Papas = "NO";
        }

        public override void PasoPrepararIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Prosciuto");
            _hamburguesa.Ingredientes.Add("Salame");
            _hamburguesa.Ingredientes.Add("Jitomate");
            _hamburguesa.Ingredientes.Add("Lechuga Italiana");
            _hamburguesa.Ingredientes.Add("Pimiento");
            _hamburguesa.Ingredientes.Add("Queso Provolone");
        }
    }
}
