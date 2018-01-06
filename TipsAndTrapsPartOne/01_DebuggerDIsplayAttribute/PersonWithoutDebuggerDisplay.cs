using System.Diagnostics;

namespace TipsAndTrapsPartOne._01_DebuggerDIsplayAttribute
{
    public interface IPerson
    {
        int AgeInYears { get; set; }
        string Name { get; set; }
    }

    public class PersonWithoutDebuggerDisplay : IPerson
    {
        public int AgeInYears { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "This is overriden ToString()";
        }
    }

    [DebuggerDisplay("This person is called {Name} and is {AgeInYears} years old")]
    public class PersonWithDebuggerDisplay : IPerson
    {
        [DebuggerDisplay("{AgeInYears} years old")]
        public int AgeInYears { get; set; }
        public string Name { get; set; }
    }

}