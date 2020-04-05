namespace homeWorkLesson9_4
{
    [AccessLevel(3)]
    class Director : IPersonal
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Director(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
