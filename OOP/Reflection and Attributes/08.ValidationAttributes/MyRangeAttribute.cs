namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int minAge;
        private readonly int maxAge;
        public MyRangeAttribute(int minAge, int maxAge)
        {
            this.minAge = minAge;
            this.maxAge = maxAge;
        }

        public override bool IsValid(object obj)
        {
            int age = (int)obj;

            return age >= minAge && age <= maxAge;
        }
    }
}
