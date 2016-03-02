using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colelctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice =Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    {
                        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
                        numbers.Add(6);
                        numbers.AddRange(new int[] { 7, 8, 9 });
                        numbers.Insert(0, 666);
                        numbers.RemoveAt(1);
                        foreach (int i in numbers)
                            Console.WriteLine(i);
                        List<Person> people = new List<Person>(3);
                        people.Add(new Person() { Name = "Tom" });
                        people.Add(new Person() { Name = "Bill" });
                        foreach (Person p in people)
                        {
                            Console.WriteLine(p.Name);
                        }
                        Console.ReadLine();
                        break;
                    }
                case 1:
                    {
                        //етить двусвязнные списки
                        LinkedList<int> numbers = new LinkedList<int>();
                        numbers.AddLast(1);//last in list with value=1
                        numbers.AddFirst(2);//first ith value 2
                        numbers.AddAfter(numbers.Last, 3);//insert after last valu 3
                        foreach (int i in numbers)
                            Console.WriteLine(i);
                        LinkedList<Person> persons = new LinkedList<Person>();
                        LinkedListNode<Person> tom = persons.AddLast(new Person() { Name = "Tom" });
                        persons.AddLast(new Person() { Name = "John" });
                        persons.AddFirst(new Person() { Name = "Bill" });
                        Console.WriteLine(tom.Previous.Value.Name);
                        Console.WriteLine(tom.Next.Value.Name);
                        Console.ReadKey();
                        break;

                    }
                case 2:
                    {
                        Queue<int> numbers = new Queue<int>();

                        numbers.Enqueue(3);
                        numbers.Enqueue(5);
                        numbers.Enqueue(8);//3,5,8

                        int queueElement = numbers.Dequeue();//now 5,8
                        Console.WriteLine(queueElement);
                        Queue<Person> persons = new Queue<Person>();
                        persons.Enqueue(new Person() { Name = "Tom" });
                        persons.Enqueue(new Person() { Name = "Bill" });
                        persons.Enqueue(new Person() { Name = "John" });
                        Person pp = persons.Peek();//получаем первый элемент без извлечения
                        Console.WriteLine(pp.Name);
                        Console.WriteLine("Сейчас в очереди {0} человек ", persons.Count());
                        foreach (Person p in persons)
                        {
                            Console.WriteLine(p.Name);
                        }
                        Person person = persons.Dequeue();//извлекаем первый эл-т
                        Console.WriteLine(person.Name);
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Stack<int> numbers = new Stack<int>();

                        numbers.Push(3);
                        numbers.Push(5);
                        numbers.Push(8);//8,5,3

                        int stackElement = numbers.Pop();//now 5,3
                        Console.WriteLine(stackElement);

                        Stack<Person> persons = new Stack<Person>();
                        persons.Push(new Person() { Name = "Tom" });
                        persons.Push(new Person() { Name = "Bill" });
                        persons.Push(new Person() { Name = "John" });
                        
                        foreach (Person p in persons)
                        {
                            Console.WriteLine(p.Name);
                        }
                        Person person = persons.Pop();//теперь в стеке том, билл
                        Console.WriteLine(person.Name);
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        Dictionary<char, Person > people = new Dictionary<char, Person>();
                        people.Add('b', new Person() { Name = "Bill" });
                        people.Add('t', new Person() { Name = "Tom" });
                        people.Add('j', new Person() { Name = "John" });
                        people['a'] = new Person() { Name = "Alice" };

                        foreach (KeyValuePair<char, Person> keyValue in people)
                        {
                            //
                            Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
                        }

                        //
                        foreach(char c in people.Keys)
                        {
                            Console.WriteLine(c);
                        }
                        
                        //
                        foreach(Person p in people.Values)
                        {
                            Console.WriteLine(p.Name);
                        }
                        Dictionary<string, string> countries = new Dictionary<string, string>
                        {
                            ["Fance"]="Paris",
                            ["German"]="berlin",
                            ["UK"]="London"
                        };
                        break;
                    }
                case 5:
                    {
                        ObservableCollection<Person> people = new ObservableCollection<Person>
                        {
                            new Person {Name = "Bill" },
                            new Person {Name = "Tom" },
                            new Person {Name = "Allice" }
                        };
                        people.CollectionChanged += People_CollectionChanged;
                        people.Add(new Person { Name = "Bob" });
                        people.RemoveAt(1);
                        people[0] = new Person { Name = "Anderson" };

                        foreach(Person p in people)
                        {
                            Console.WriteLine(p.Name);
                        }
                        Console.Read();

                        break;
                    }
                case 6:
                    {
                        Library library = new Library();
                        Console.WriteLine(library[0].Name);
                        library[0] = new Book("Престепление и наказаие");
                        Console.WriteLine(library[0].Name);
                        foreach (Book b in library.GetBooks(5))
                            Console.WriteLine(b.Name);
                        Console.ReadKey();
                        break;
                    }
                        
                default:
                    break;
            }
            

    }
        
    }
}
