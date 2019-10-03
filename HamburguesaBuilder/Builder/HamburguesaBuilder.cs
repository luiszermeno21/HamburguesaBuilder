using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public abstract class HamburguesaBuilder
    {
        protected Hamburguesa _hamburguesa;

        public string Pan { get; set; }
        public string Carne { get; set; }

        public Hamburguesa ObtenerHamburguesa() { return _hamburguesa; }

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
