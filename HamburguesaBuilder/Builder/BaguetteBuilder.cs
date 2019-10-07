using HamburguesaBuilder.Models;
namespace HamburguesaBuilder.Builder
{
    public class BaguetteBuilder
    {
        protected Baguette _baguette;

        public string Pan { get; set; }

        public Baguette ObtenerBaguette() { return _baguette; }

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
