using System.Collections.Generic;

namespace task_10._1
{
    class Repository
    {
        public List<User> AllUsers { get; private set; }

        public Repository()
        {
            AllUsers = new List<User>
            {
                new User("Иванов", "Иван", "Иванович", "+375445424741", "AA", "1111111"),
                new User("Гаврилов", "Гаврила", "Гаврилович", "+375445424742", "AA", "2222222"),
                new User("Степанова", "Степанида", "Степановна", "+375445424743", "ВВ", "3333333")
            };
        }


    }
}
