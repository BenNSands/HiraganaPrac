using System;
using System.Collections.Generic;
using System.Text;

namespace HiraganaPrac
{
    class Hiragana : IJapPronounce1
    {
        public char A { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char I { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char U { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char E { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char O { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char KA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char KI { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char KU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char KE { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char KO { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char SA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char SHI { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char SU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char SE { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char SO { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char TA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char CHI { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char TSU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char TE { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char TO { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char NA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char NI { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char NU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char NE { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char NO { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char HA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char HI { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char FU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char HE { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char HO { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char MA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char MI { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char MU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char ME { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char MO { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char YA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char YU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char YO { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char RA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char RI { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char RU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char RE { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char RO { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char WA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char WO { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char N { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



        //Hiragana constructor
        //initiallize them with the proper chars later
        public Hiragana() { }


        public static int HiraSelect(int min, int max)
        {
            var r = new Random();
            return r.Next(min, max);
        }

    }
}
