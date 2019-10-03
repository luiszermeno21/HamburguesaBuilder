using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Builder;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class MexicanaBuilder: HamburguesaBuilder
    {
        public MexicanaBuilder(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Carne = carne,
                Pan = pan,
                Nombre = "Mexicana",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _hamburguesa.Precio = 89.00;
        }

        public override void PasoAñadirPapas()
        {
            _hamburguesa.Papas = "SI";
        }

        public override void PasoPrepararIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Chorizo");
            _hamburguesa.Ingredientes.Add("Jalapeño");
            _hamburguesa.Ingredientes.Add("Frijoles");
            _hamburguesa.Ingredientes.Add("Chicharron");
            _hamburguesa.Ingredientes.Add("Jitomate");
            _hamburguesa.Ingredientes.Add("Lechuga");
            _hamburguesa.Ingredientes.Add("Aguacate");
            _hamburguesa.Ingredientes.Add("Queso Asadero");
    }
    }
}
