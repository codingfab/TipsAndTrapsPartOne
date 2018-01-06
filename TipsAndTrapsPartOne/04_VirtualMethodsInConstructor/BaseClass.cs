namespace TipsAndTrapsPartOne._04_VirtualMethodsInConstructor
{
    public class BaseClass
    {
        private int _length;
        protected string Name;

        public BaseClass()
        {
            InitName();

            _length = Name.Length;
        }

        protected virtual void InitName()
        {
            Name = "Sarah";
        }

    }
}