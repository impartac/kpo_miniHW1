
using Project.Abstractions.Interfaces;


namespace Project.Realisation.Buildings
{
    internal class Clinic : IClinic
    {
        public Clinic()
        {

        }
        public bool CheckHealth(IAnimal animal)
        {
            return animal.Food > 0;
        }
    }
}
