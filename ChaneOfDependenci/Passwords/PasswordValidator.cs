using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaneOfDependenci.Passwords
{
    class PasswordValidator
    {
        private StringChecker first;
        private StringChecker last;

        public PasswordValidator(StringChecker checker)
        {
            first = checker;
            last = checker;
        }
        public void Add (StringChecker checker)
        {
            last.SetNext(checker);
            last = checker;
        }
        public bool isGoodPassword(string candidate)
        {
            return first.Check(candidate);
        }
    }
}
