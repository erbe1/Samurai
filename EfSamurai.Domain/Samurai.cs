using System;
using System.Collections.Generic;

namespace EfSamurai.Domain
{

    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Clan { get; set; }
        public int Age { get; set; }

        public Haircut Haircut { get; set; }
        public QuoteVariation QuoteVariation { get; set; }


        public List<Quote> Quote { get; set; }

        public SecretIdentity SecretIdentity { get; set; }
    }
}
