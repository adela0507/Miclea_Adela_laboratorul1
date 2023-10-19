using Microsoft.AspNetCore.Mvc;

namespace Miclea_Adela_laboratorul1.Controllers
{
    public class Haine : Controller
    {
        public string Index()
        {
            return "Bun venit! Vă rugăm să introduceți numele dvs.";
        }

        public string Salut(string numeUtilizator)
        {
            return $"Salut, {numeUtilizator}!";
        }

        public void AfiseazaMesaj(string mesaj, int numar)
        {
            Console.WriteLine($"{mesaj}: {numar}");
        }
    }
}
