# SOLID why?
В данном проекте, реализуются все принципы SOLID.
Приведем некоторые примеры.
Например Single Responsibility Principle реализуется в AnimalStorage, ItemStorage, Writer, Reader. Они могут изменяться только в случае дополнения функциональности экземпляров.
OCP также можно наблюдать в AnimalStorage, ItemStorage
LSP Нетрудно заметить, что Storages хранят именно классы, реализующие соответсвующие интерфейсы, таким образом Wolf, Tiger также хранятся в этих контейнерах, т.к. они реализуют интерфейс IAnimal.
ISP Примером тут является интерфейс IAnimal, который является совокупностью интерфейсов IItem, IAlive, INamed. Это позволяет реализовать интерфейс IItem, например для IThing.
DIP Реализуется для абстрактных классов, и интерфейсов, которые соответсвенно реализуются, например Herbo : Animal  - абстрактный класс
