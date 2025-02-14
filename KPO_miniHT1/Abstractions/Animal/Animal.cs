

namespace Project.Abstractions.Interfaces
{
    public abstract class Animal : IAnimal
    {
        private int _food;
        public int Food {
            get => _food;
            set => _food = value >= 0 ? value : throw new ArgumentOutOfRangeException();
        }
        public string Name { get; set; }
        public int Number { get; set; }

        public string Description { get; set; }

        public string Type
        {
            get => GetType().Name;
        }

        public Animal(int food, string name, int number , int kidness = 0,string description = "") {
            _food = food;
            Name = name;
            Number = number;
            Description = description;
        }

        public override string ToString()
        {
            return $"Animal: < Type: {Type}, Name: {Name}, Number: {Number}, Description: {Description}>";
        }
    }
}
