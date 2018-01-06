namespace TipsAndTrapsPartOne._01_DebuggerDIsplayAttribute
{
    public class PersonWithoutDebuggerDisplay : IPerson
    {
        public int AgeInYears { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "This is overriden ToString()";
        }
    }
}