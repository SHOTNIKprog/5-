using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PractosNumber5
{
    internal class Cake
    {
        public int cost;
        public string forma;
        public string razmerъ;
        public string vkusъ;
        public string Kolvo_Korgey;
        public string glazurъ;
        public string decorъ;
        public Cake(int ParamCost, string ParamForma, string ParamSize, string Paramvkus, string ParamKolvo_Korgey, string Paramglazur, string ParamDecor)
        {
            cost = ParamCost;
            forma = ParamForma;
            razmerъ = ParamSize;
            vkusъ = Paramvkus;
            Kolvo_Korgey = ParamKolvo_Korgey;
            glazurъ = Paramglazur;
            decorъ = ParamDecor;
        }
    }
}
