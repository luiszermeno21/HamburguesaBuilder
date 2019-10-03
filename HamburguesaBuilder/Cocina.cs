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
    }
}
