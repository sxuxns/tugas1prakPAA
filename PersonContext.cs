namespace TUGAS1PRAKTIKUM.Models
{
    public class PersonContext
    {
        public List<Person> ListPerson()
        {
            List<Person> list1 = new List<Person>();
            Object[,] arrayPerson = new Object[,]
            {
                { 1, "Adinda", "Banyuwangi", "adin@gmail.com"},
                { 2, "Ayunda", "Banyuwangi", "ayunda@gmail.com" },
                { 3, "Ubay", "Banyuwangi", "ubay@gmail.com" }
            };
            for (int i = 0; i < arrayPerson.GetLength(0); i++)
            {
                list1.Add(new Person()
                {
                    id_person = int.Parse(arrayPerson[i, 0].ToString()),
                    nama = arrayPerson[i, 1].ToString(),
                    alamat = arrayPerson[i, 2].ToString(),
                    email = arrayPerson[i, 3].ToString()
                });
            }
            return list1;
        }

        public Person GetPersonById(int id)
        {
            var listPerson = ListPerson();
            return listPerson.Find(x => x.id_person == id);
        }
    }
}
