using System;
using System.Collections.Generic;
using System.Text;

namespace HiraganaPrac
{
    class Katakana : IJapPronounce1
    {
        public char A { get; set; } = 'ア';
        public char I { get; set; } = 'イ';
        public char U { get; set; } = 'ウ';
        public char E { get; set; } = 'エ';
        public char O { get; set; } = 'オ';

        public char KA { get; set; } = 'カ';
        public char KI { get; set; } = 'キ';
        public char KU { get; set; } = 'ク';
        public char KE { get; set; } = 'ケ';
        public char KO { get; set; } = 'コ';

        public char SA { get; set; } = 'サ';
        public char SHI { get; set; } = 'シ';
        public char SU { get; set; } = 'ス';
        public char SE { get; set; } = 'セ';
        public char SO { get; set; } = 'ソ';

        public char TA { get; set; } = 'タ';
        public char CHI { get; set; } = 'チ';
        public char TSU { get; set; } = 'ツ';
        public char TE { get; set; } = 'テ';
        public char TO { get; set; } = 'ト';

        public char NA { get; set; } = 'ナ';
        public char NI { get; set; } = 'ニ';
        public char NU { get; set; } = 'ヌ';
        public char NE { get; set; } = 'ネ';
        public char NO { get; set; } = 'ノ';

        public char HA { get; set; } = 'ハ';
        public char HI { get; set; } = 'ヒ';
        public char FU { get; set; } = 'フ';
        public char HE { get; set; } = 'ヘ';
        public char HO { get; set; } = 'ホ';

        public char MA { get; set; } = 'マ';
        public char MI { get; set; } = 'ミ';
        public char MU { get; set; } = 'ム';
        public char ME { get; set; } = 'メ';
        public char MO { get; set; } = 'モ';

        public char YA { get; set; } = 'ヤ';
        public char YU { get; set; } = 'ユ';
        public char YO { get; set; } = 'ヨ';

        public char RA { get; set; } = 'ラ';
        public char RI { get; set; } = 'リ';
        public char RU { get; set; } = 'ル';
        public char RE { get; set; } = 'レ';
        public char RO { get; set; } = 'ロ';

        public char WA { get; set; } = 'ワ';
        public char WO { get; set; } = 'ヲ';

        public char N { get; set; } = 'ン';

        //46 total chars

        public static int KataSelect(int min, int max)
        {
            var r = new Random();
            return r.Next(min, max);
        }
    }
}
