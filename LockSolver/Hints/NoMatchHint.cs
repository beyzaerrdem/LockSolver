using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSolver.Hints
{
    public class NoMatchHint : IHint
    {
        private readonly string hint;
        public NoMatchHint(string hint) 
        {
            this.hint = hint;
        }

        public bool IsMatch(string lockCandidate)
        {
            for (int i = 0; i < lockCandidate.Length; i++)
            {
                if (lockCandidate.Contains(hint[i]))
                {
                    return false;
                }
            }
            return true;

            //return !Lockcandidate.Any(c => hint.Contains(c));
        }
    }
}
