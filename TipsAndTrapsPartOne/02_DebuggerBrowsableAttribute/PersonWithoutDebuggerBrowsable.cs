using System.Collections.Generic;
using System.Diagnostics;

namespace TipsAndTrapsPartOne._02_DebuggerBrowsableAttribute
{
    public class PersonWithoutDebuggerBrowsable : IPerson
    {
        public PersonWithoutDebuggerBrowsable()
        {
            FaveColors = new List<string>();
        }

        public int AgeInYears { get; set; }
        public string Name { get; set; }
        public List<string> FaveColors { get; set; }
    }

    
    public class PersonWithDebuggerBrowsable : IPerson
    {
        public PersonWithDebuggerBrowsable()
        {
            FaveColors = new List<string>();
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int AgeInYears { get; set; }

        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public List<string> FaveColors { get; set; }

    }


}
