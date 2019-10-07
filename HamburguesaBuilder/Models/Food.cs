using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;
namespace HamburguesaBuilder.Models
{
    public interface Food
    {
        string Tipo { get; set; }
        string Nombre { get; set; }
        PanEnum Pan { get; set; }
        List<string> Ingredientes { get; set; }
        double Precio { get; set; }
        CarneEnum Carne { get; set; }
        string Papas { get; set; }
        string Descripción();
    }
}
