namespace FactoryExercise
{
    public class PersonFactory
    {
        private int id = 0;
        public Person CreatPerson(string name)
        {
            var person = new Person();
            person.Name = name;
            person.Id = id;
            id++;
            return person;
        }
    }

}
