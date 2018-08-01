using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithLegion
{
    class itemSubClass
    {
        Dictionary<string, string> iSubClass = new Dictionary<string, string>();

        public itemSubClass()
        {
            iSubClass.Add("Hache à une main", "0");
            iSubClass.Add("Hache à deux mains", "1");
            iSubClass.Add("Arc", "2");
            iSubClass.Add("Arme à feu", "3");
            iSubClass.Add("Masse à une main", "4");
            iSubClass.Add("Masse à deux mains", "5");
            iSubClass.Add("Arme d'hast", "6");
            iSubClass.Add("Epée à une main", "7");
            iSubClass.Add("Epée à deux mains", "8");
            iSubClass.Add("Bâton", "10");
            iSubClass.Add("Arme de pugilat", "13");
            iSubClass.Add("Dague", "15");
            iSubClass.Add("Arbalète", "18");
            iSubClass.Add("Baguette", "19");
            iSubClass.Add("Canne à pêche", "20");
        }

        public Dictionary<string, string> getSubClass() { return iSubClass; }

    }

    class itemInventoryType
    {
        Dictionary<string, string> iType = new Dictionary<string, string>();

        public itemInventoryType()
        {
            iType.Add("Une main", "13");
            iType.Add("Deux mains", "17");
            iType.Add("Main droite", "21");
            iType.Add("Main gauche", "22");
            iType.Add("Distance", "26");
        }

    }

    class itemQuality
    {
        Dictionary<string, string> iQuality = new Dictionary<string, string>();

        public itemQuality()
        {
            iQuality.Add("Médiocre (Gris)", "0");
            iQuality.Add("Classique (Blanc)", "1");
            iQuality.Add("Bonne (Vert)", "2");
            iQuality.Add("Rare (Bleu)", "3");
            iQuality.Add("Epique (Violet)", "4");
            iQuality.Add("Légendaire (Orange)", "5");
            iQuality.Add("Artéfact (Beige)", "6");
            iQuality.Add("Jeton (Bleu clair)", "7"); // not sure
        }

    }
}
