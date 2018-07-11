using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

/* Запили приложуньку на консольке  для пропуска. 
 * Вводишь имя и тебе данные о человеке(имя, номер...можно guid, кто он...инженер или еще чет). 
 * Ессно если отсутствуют данные должна быть логика для ввода. 
 * Все написано на Dictionary c использованием строгой типизации и MemoryCache...
 * Данные загружай при загрузке консольки.
    А...залей на гит и дай мне ссылку.
 *
 *  Структура программы:
 *  1. Создание словаря с нужным контентом. Dictionary <string, Person> staff = new Dictionary<string, Person>();
 *  2. Вывод значения по ключу.
 *  3. Добавление / удаление элемента из словаря.
 *  4. Выгрузить результат в репозиторий на GitHub.
 */

namespace ControlPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Developed via Umkachan offer))");            
            Console.ReadLine();

            Person Pers = new Person();
            Pers.ShowDict();
                       
        }
    }
    class Person // Л - логика) 
    {
        public string FirstKey, AddKey, AddValue;
        public string Info { get; private set; }
        Dictionary<string, Person> staff = new Dictionary<string, Person>();

         void Dict() // Метод заполнения словаря начальными значениями.
        {
            

            staff.Add("Thrall", new Person()
            {
                Info = "Post: Shamans guru. " +
                "\nAddress: Orgrimmar, Walley of Glory 1. "
            } );
            staff.Add("Voljin", new Person()
            {
                Info = "Post: Hunters guru. " +
                "\nAddress: Orgrimmar, Walley of Glory 1. "
            });
            staff.Add("Silvanas", new Person()
            {
                Info = "Post: Warchif. " +
                "\nAddress: Undercity, Royal quoter, apartments. "
            });
            staff.Add("Bein Bloodhoof", new Person()
            {
                Info = "Post: Touren's Leader. " +
                "\nAddress: Thunder Bluf, City center. "
            });
            staff.Add("Lortemar", new Person()
            {
                Info = "Post: Blood Elves Leader. " +
                "\nAddress: Silvermoon, somwhere in the city). "
            });
            staff.Add("Gallewigs", new Person()
            {
                Info = "Post: The most greedy goblin. " +
                "\nAddress: Azshara, Gallewigs's palase. "
            });
            staff.Add(" ", new Person()
            {
                Info = null
            });
        
         }

        public void ShowDict()
        {
            Dict();
            Console.ReadLine();
            GetValue();
            AddOrRemove();
            Console.ReadLine();
        }

        public void GetValue() // Метод поиска значения по ключу
        {
            Console.WriteLine("Enter the name.");
            FirstKey = Console.ReadLine();
            foreach (KeyValuePair<string, Person> keyvalue in staff)
            {
                if (keyvalue.Key == FirstKey)
                {
                    Console.WriteLine(keyvalue.Value.Info);
                }

                if (keyvalue.Key != FirstKey && keyvalue.Value.Info == null)
                {
                    Console.WriteLine("Name not found! Press 'Enter'...");
                } 
            }
            Console.WriteLine();
            Console.ReadLine(); 
        }

         void AddElement() // Метод добавления элемента в словарь
        {
            Console.WriteLine("Enter new key name please:");
            AddKey = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine("Enter new element data please:");
            AddValue = Console.ReadLine();
            staff.Add(AddKey, new Person() {Info = AddValue });
            Console.WriteLine("{0} was succefuly added to dictionary! ", AddKey);
            Console.WriteLine();
        }

         void RemoveElement() // Метод удаления элемента из словаря
        {
            Console.WriteLine("Enter new key name please:");
            AddKey = Console.ReadLine();
            staff.Remove(AddKey);
            Console.WriteLine("{0} was succefuly removed from dictionary! ", AddKey);
            Console.WriteLine();
        }

        public void AddOrRemove() // Метод запроса действия.
        {
            bool flag = false;
            do
            {
                string option;
                Console.WriteLine("Press 'm' to start new search, 'a' to add element, \n'r' to remove element, 's' to show all elements " +
                    "\n or 'q' to exit.");
                option = Console.ReadLine();
                if (option == "m")
                    GetValue();
                if (option == "a")
                    AddElement();
                if (option == "r")
                    RemoveElement();
                if (option == "s")
                {
                    foreach (KeyValuePair<string, Person> keyvalue in staff)
                    {
                        Console.WriteLine(keyvalue.Key + " - " + keyvalue.Value.Info);
                    }
                    Console.WriteLine();
                }
                if (option == "q")
                {
                    Console.WriteLine("Have a nice day! ");
                    flag = true;
                }
                    
            }
            while (flag != true);
            Console.WriteLine();
        }
    }

    // Есть во всём этом один косметический косяк, но на основной функционал он не влияет. 
}

        

        
        
        

        


       
        
        
    

