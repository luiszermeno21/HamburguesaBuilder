using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class SandwichBuilder
    {
        protected Sandwich _sandwich;

        public string Pan { get; set; }

        public Sandwich ObtenerSandwich() { return _sandwich; }

        // Un paso para cada una de las propiedades
        public virtual void PasoPrepararPrecio()
        {

        }

        public virtual void PasoAñadirPapas()
        {

        }

        public virtual void PasoPrepararIngredientes()
        {

        }
    }
}
