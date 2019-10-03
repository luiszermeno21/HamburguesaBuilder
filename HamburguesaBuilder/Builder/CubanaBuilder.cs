using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class CubanaBuilder: HamburguesaBuilder
    {
        public CubanaBuilder(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Carne = carne,
                Pan = pan,
                Nombre = "Cuabana",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _hamburguesa.Precio = 119.00;
        }

        public override void PasoAñadirPapas()
        {
            _hamburguesa.Papas = "SI";
        }

        public override void PasoPrepararIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Milanesa");
            _hamburguesa.Ingredientes.Add("Jamón");
            _hamburguesa.Ingredientes.Add("Chicharrón");
            _hamburguesa.Ingredientes.Add("Salchicha");
            _hamburguesa.Ingredientes.Add("Chorizo");
            _hamburguesa.Ingredientes.Add("Jitomate");
            _hamburguesa.Ingredientes.Add("Lechuga");
            _hamburguesa.Ingredientes.Add("Aguacate");
            _hamburguesa.Ingredientes.Add("Queso Cheddar");
            _hamburguesa.Ingredientes.Add("Queso Asadero");
        }
    }
}
