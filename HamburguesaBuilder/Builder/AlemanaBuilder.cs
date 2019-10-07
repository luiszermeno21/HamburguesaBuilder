using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;
namespace HamburguesaBuilder.Builder
{
    public class AlemanaBuilder: HamburguesaBuilder
    {
        public AlemanaBuilder(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Tipo = "Hamburguesa",
                Carne = carne,
                Pan = pan,
                Nombre = "Alemana",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _hamburguesa.Precio = 95.00;
        }

        public override void PasoAñadirPapas()
        {
            _hamburguesa.Papas = "SI";
        }

        public override void PasoPrepararIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Salchicha Alemana");
            _hamburguesa.Ingredientes.Add("Cebolla");
            _hamburguesa.Ingredientes.Add("Jitomate");
            _hamburguesa.Ingredientes.Add("Lechuga");
            _hamburguesa.Ingredientes.Add("Pimiento");
            _hamburguesa.Ingredientes.Add("Queso Gorgonzola");
        }
    }
}
