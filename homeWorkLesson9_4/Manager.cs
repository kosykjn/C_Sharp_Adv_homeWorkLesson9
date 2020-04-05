namespace homeWorkLesson9_4
{
    [AccessLevel(1)]
    class Manager : IPersonal
    {
        public string Name { get ; set ; }
        public string Surname { get; set; }

        public Manager(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
