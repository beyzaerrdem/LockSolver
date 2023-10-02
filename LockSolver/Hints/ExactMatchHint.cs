using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSolver.Hints
{
    public class ExactMatchHint : IHint
    {
        private readonly string hint;

        public ExactMatchHint(string hint) 
        { 
            this.hint = hint;
        }
            
        public bool IsMatch(string lockCandidate)
        {
            for(int i = 0; i < lockCandidate.Length; i++)
            {
                if (lockCandidate[i] == hint[i])
                {
                    return true;
                }
            }
            return false;

            //return Lockcandidate.Zip(hint, (c, h) => c == h ? 1 : 0).Sum() == 1;
        }
    }
}
