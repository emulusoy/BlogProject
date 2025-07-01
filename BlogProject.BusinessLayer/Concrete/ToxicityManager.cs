using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProject.BusinessLayer.Abstract;

namespace BlogProject.BusinessLayer.Concrete
{
    public class ToxicityManager : IToxicityService
    {
        private readonly HashSet<string> _toxicKeywords = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "hate", "idiot", "stupid", "kill", "die", "ugly", "fat",
            "moron", "retard", "crap", "suck", "worthless", "loser",
            "dumb", "shut up", "nobody cares", "trash", "useless",
            "salak","mal","aptal",
        };

        public bool IsToxic(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            return _toxicKeywords.Any(keyword => text.Contains(keyword));
        }
    }
}
