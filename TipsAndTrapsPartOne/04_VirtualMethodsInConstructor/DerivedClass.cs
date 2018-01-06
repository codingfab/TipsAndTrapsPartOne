namespace TipsAndTrapsPartOne._04_VirtualMethodsInConstructor
{
    public class DerivedClass : BaseClass
    {
        protected override void InitName()
        {
            Name = null;
        }
    }
}