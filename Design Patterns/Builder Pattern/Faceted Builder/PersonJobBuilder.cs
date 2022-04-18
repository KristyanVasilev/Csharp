namespace BuilderFacets
{
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }

        public PersonJobBuilder CompanyName(string name)
        {
            person.CompanyName = name;

            return this;
        }

        public PersonJobBuilder Position(string position)
        {
            person.Position = position;

            return this;
        }

        public PersonJobBuilder AnnualIncome(int annualIncome)
        {
            person.AnnualIncome = annualIncome;

            return this;
        }
    }
}