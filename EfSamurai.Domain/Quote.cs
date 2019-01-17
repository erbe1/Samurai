using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSamurai.Domain
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public string QuoteScream { get; set; }
        public string QuoteType { get; set; }

        public Samurai Samurai { get; set; }
    }
}
