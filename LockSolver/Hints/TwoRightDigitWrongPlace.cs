using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSolver.Hints
{
    public class TwoRightDigitWrongPlace : IHint
    {
        private readonly string hint;

        public TwoRightDigitWrongPlace(string hint) 
        { 
            this.hint = hint;
        }

        public bool IsMatch(string lockCandidate)
        {
            int count = 0;
            for(int i = 0; i < lockCandidate.Length; i++)
            {
                if (lockCandidate.Contains(hint[i]) && lockCandidate[i] != hint[i])
                {
                    count++;
                }
            }
            return count == 2;

            //return lockCandidate.Zip(hint, (c, h) => c != h && lockCandidate.Contains(c) ? 1 : 0).Sum() == 2;
        }
    }
}
