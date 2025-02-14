using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.LogicManager
{
    public class Writer
    {
        public Writer() { }

        public void SendMessage(string? text) 
        {
            Console.WriteLine(text);
        }

        public void IncorrectMenu()
        {
            Console.WriteLine("Вы выбрали неправильный пункт меню");
        }

        public void IncorrectKeyNumber()
        {
            Console.WriteLine("Нажмите на цифру, а не на другую клавишу.");
        }
        public void RequestAnimalFoodProperty() 
        {
            Console.WriteLine("Введите занчени для еды");
        }
        public void RequestNameProperty() 
        {
            Console.WriteLine("Введите имя");
        }
        public void RequestNumberProperty()
        {
            Console.WriteLine("Введите номер");
        }
        public void RequestKidnessProperty()
        {
            Console.WriteLine("Введите доброту");
        }

        public void RequestDescriptionProperty() 
        {
            Console.WriteLine("Введите описание на одной строке");
        }
        
    }
}
