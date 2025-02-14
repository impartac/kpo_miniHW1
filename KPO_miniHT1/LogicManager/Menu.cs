using Project.Abstractions.Interfaces;
using Project.Realisation.Buildings;
using Project.Realisation.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.LogicManager
{
    public enum State
    {
        Start,
        ChooseAction,
        ChooseAnimalType,
        ChooseInventoryType,
        WriteCount,
        WriteContactList,
        WriteCountFood,
        Bunny,
        Tiger,
        Monkey,
        Wolf,
        PC,
        Table
    }
    public class Menu
    {
        public State status;
        private Writer writer;
        private Reader reader;
        private IAnimalFactory[] animalFactories =
        {
            new RabbitFactory(),
            new MonkeyFactory(),
            new TigerFactory(),
            new WolfFactory()
        };
        private IThingFactory[] thingFactories = { new ComputerFactory(), new TableFactory() };
        private Zoo zoo;

        private Dictionary<State, string> data = new Dictionary<State, string>()
        {
            {State.Start, "Привет. Теперь ты админ зоопарка. Действуй." },
            {State.ChooseAction,
                "1. Добавить животного.\n"+
                "2. Добавить инвентарь.\n"+
                "3. Вывести кол-во животных.\n" +
                "4. Вывести список контактных животных.\n"+
                "5. Вывести кол-во еды для всех животных."
            },
            {State.ChooseAnimalType,
                "1. Заяц\n"+
                "2. Тигр\n"+
                "3. Обезьян\n"+
                "4. Волк"
            },
            {State.ChooseInventoryType,
                "1. Стол\n"+
                "2. Компьютер"
            },
            { State.WriteCount, "Всего животных :" },
            { State.WriteCountFood, "Всего еды :" },
            { State.WriteContactList, "Список контактного зоопарка :" }
        };
        public Menu(Writer writer, Reader reader, Zoo zoo)
        {
            status = State.Start;
            this.writer = writer;
            this.reader = reader;
            this.zoo = zoo;
        }

        public void SendMessage()
        {
            writer.SendMessage(data[status]);
        }
        public int ReadKey(int min = 0, int max = 9)
        {
            int keyValue = -1;

            do
            {
                try
                {
                    keyValue = reader.ReadKey(min, max);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    writer.IncorrectMenu();
                }
                catch (ArgumentException e)
                {
                    writer.IncorrectKeyNumber();
                }

            } while (keyValue < min || keyValue > max);

            return keyValue;
        }
        public void Start()
        {
            int key = 0;
            while (true)
            {
                switch (status)
                {
                    case State.Start:
                        SendMessage();
                        status = State.ChooseAction;
                        break;
                    case State.ChooseAction:
                        SendMessage();
                        key = ReadKey(1, 5);
                        status += key;
                        break;
                    case State.ChooseAnimalType:
                        SendMessage();
                        key = ReadKey(1, 4);
                        switch (key)
                        {
                            case 1:
                                status = State.Bunny;
                                break;
                            case 2:
                                status = State.Tiger;
                                break;
                            case 3:
                                status = State.Monkey;
                                break;
                            case 4:
                                status = State.Wolf;
                                break;
                        }
                        break;
                    case State.WriteCount:
                        writer.SendMessage(zoo.AnimalStorageCount().ToString());
                        status = State.ChooseAction;
                        break;
                    case State.WriteContactList:
                        writer.SendMessage(zoo.ContactAnimalStorage());
                        status = State.ChooseAction;
                        break;
                    case State.WriteCountFood:
                        writer.SendMessage(zoo.AnimalStorageCountFood().ToString());
                        status = State.ChooseAction;
                        break;
                    case State.Bunny:
                        writer.RequestAnimalFoodProperty();
                        int food = reader.ReadInt((int x) => x >= 0);
                        writer.RequestNameProperty();
                        string name = reader.ReadString((string x) => true);
                        writer.RequestNumberProperty();
                        int number = reader.ReadInt((int x) => true);
                        writer.RequestDescriptionProperty();
                        string description = reader.ReadString((string x) => true);
                        writer.RequestKidnessProperty();
                        int kidness = reader.ReadInt((int x) => 0 <= x && x <= 10);
                        zoo.Add(animalFactories[key - 1].Create(food, name, number, kidness, description));
                        status = State.ChooseAction;
                        break;
                    case State.Monkey:
                    case State.Wolf:
                    case State.Tiger:
                        writer.RequestAnimalFoodProperty();
                        food = reader.ReadInt((int x) => x >= 0);
                        writer.RequestNameProperty();
                        name = reader.ReadString((string x) => true);
                        writer.RequestNumberProperty();
                        number = reader.ReadInt((int x) => true);
                        writer.RequestDescriptionProperty();
                        description = reader.ReadString((string x) => true);
                        zoo.Add(animalFactories[key - 1].Create(food, name, number, description: description));
                        status = State.ChooseAction;
                        break;
                    case State.ChooseInventoryType:
                        SendMessage();
                        key = reader.ReadKey(1,2);
                        status = key == 1 ? State.PC : State.Table;
                        break;
                    case State.PC:
                    case State.Table:
                        writer.RequestNumberProperty();
                        number = reader.ReadInt((int x) => true);
                        writer.RequestDescriptionProperty();
                        description = reader.ReadString((string x) => true);
                        zoo.Add(thingFactories[key-1].Create(number,description));
                        status = State.ChooseAction;
                        break;
                }

            }
        }
    }
}
