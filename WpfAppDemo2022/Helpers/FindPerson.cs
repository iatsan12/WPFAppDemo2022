using WpfAppDemo2022.Model;

namespace WpfAppDemo2022.Helpers
{
    public class FindPerson
    {
        private int id;

        public FindPerson(int id)
        {
            this.id = id;
        }

        public bool PersonPredicate(Person person)
        {
            return person.Id == id;
        }

    }
}
