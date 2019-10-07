using HamburguesaBuilder.Models;
namespace HamburguesaBuilder.Builder
{
    public class Cocina
    {
        public Hamburguesa CocinarHamburguesa(HamburguesaBuilder hamburguesaBuilder)
        {
            hamburguesaBuilder.PasoPrepararPrecio();
            hamburguesaBuilder.PasoAñadirPapas();
            hamburguesaBuilder.PasoPrepararIngredientes();
            return hamburguesaBuilder.ObtenerHamburguesa();
        }

        public Sandwich CocinarSandwich(SandwichBuilder sandwichBuilder)
        {
            sandwichBuilder.PasoPrepararPrecio();
            sandwichBuilder.PasoAñadirPapas();
            sandwichBuilder.PasoPrepararIngredientes();
            return sandwichBuilder.ObtenerSandwich();
        }

        public Baguette CocinarBaguette(BaguetteBuilder baguetteBuilder)
        {
            baguetteBuilder.PasoPrepararPrecio();
            baguetteBuilder.PasoAñadirPapas();
            baguetteBuilder.PasoPrepararIngredientes();
            return baguetteBuilder.ObtenerBaguette();
        }
    }
}
