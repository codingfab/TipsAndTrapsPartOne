using System.Diagnostics;

namespace TipsAndTrapsPartOne._01_DebuggerDIsplayAttribute
{
    [DebuggerDisplay("This person is called {Name} and is {AgeInYears} years old")]
    public class PersonWithDebuggerDisplay : IPerson
    {
        [DebuggerDisplay("{AgeInYears} years old")]
        public int AgeInYears { get; set; }
        public string Name { get; set; }
    }
}