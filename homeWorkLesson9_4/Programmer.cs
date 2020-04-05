namespace homeWorkLesson9_4
{
    [AccessLevel(2)]
    class Programmer : IPersonal
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Programmer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
