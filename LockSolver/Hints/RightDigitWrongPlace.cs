using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSolver.Hints
{
    public class RightDigitWrongPlace : IHint
    {
        private readonly string hint;

        public RightDigitWrongPlace(string hint)
        {
            this.hint = hint;
        }

        public bool IsMatch(string lockCandidate)
        {
            for (int i = 0; i < lockCandidate.Length; i++)
            {
                if (lockCandidate.Contains(hint[i]) && lockCandidate[i] != hint[i])
                {
                    return true;
                }
            }
            return false;

            //return lockCandidate.Zip(hint, (c, h) => c != h && hint.Contains(c) ? 1 : 0 ).Sum() == 1;
        }
    }
}
