using System;
using System.Collections.Generic;

namespace Partie4_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation du nouveau dictionnaire
            Dictionary<string, string> fujita = new Dictionary<string, string>();

            string ask;

            //ajouter des éléments dans le dictionnaire

            fujita.Add("FO", $"Dégâts légers : certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres.");
            fujita.Add("F1", $"Dégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés.");
            fujita.Add("F2", $"Dégâts importants : les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées.");
            fujita.Add("F3", $"Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts| importants, les forêts et les récoltes sont abattues.");
            fujita.Add("F4", $"Dégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent ; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances.");
            fujita.Add("F5", $"Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits (parfois surnommé « le doigt de Dieu ».");

            Console.WriteLine(" renseigner le type d’une tornade FO/F1/F2/F3/F4/F5:  ");
            ask = (Console.ReadLine()).ToUpper();

            //demander de vérifier si la clés existe
            if (fujita.ContainsKey(ask)) { 

            //on appelle la clés ask renseigner par l'utilisateur pour afficher les dégats
            Console.WriteLine(fujita[ask]); }
            else
            {
                Console.WriteLine("entrer une valeur correct");
            }
        }
        }
    }



