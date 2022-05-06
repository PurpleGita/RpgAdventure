namespace RpgAdventure
{
    internal class Classes

     {
            public int Id { get; set; }

            internal string Name { get; set; }

            public string NameOfClass { get; set; }

            internal string Backround { get; set; }

            internal List<string> Talents { get; set; }

            internal List<string> StartAttacks { get; set; }

            internal int Strength { get; set; }

            internal int Magic { get; set; }

            internal int MaxHP { get; set; }

            internal int MaxMp { get; set; }

            internal int Charisma { get; set; }

            internal int Faith { get; set; }

            internal int Perception { get; set; }

            internal int Luck { get; set; }

            internal int Intellegence { get; set; }

            //bare til mig selv for at huske en constroctur.
            public Classes()
            {

            }
    }

    internal class Charchter 
    {
        internal List<string> Talents { get; set; }

        internal List<string> Attacks { get; set; }

        internal int Strength { get; set; }

        internal int Magic { get; set; }

        internal int MaxHP { get; set; }

        internal int HP { get; set; }

        internal int MaxMP { get; set; }

        internal int MP { get; set; }

        internal int Charisma { get; set; }

        internal int Faith { get; set; }

        internal int Perception { get; set; }

        internal int Luck { get; set; }

        internal int Intellegence { get; set; }


    }

}
