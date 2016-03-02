using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Colelctions
{
    class PeopleChanged
    {
        private static void People_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Person newPerson = e.NewItems[0] as Person;
                    Console.WriteLine("Added new person");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Person oldPerson = e.OldItems[0] as Person;
                    Console.WriteLine("Person deleted {0}", oldPerson.Name);
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Person replaced = e.OldItems[0] as Person;
                    Person replacing = e.NewItems[0] as Person;
                    Console.WriteLine("Person {0} replaced {0}", replaced.Name, replacing.Name);
                    break;
            }
        }
    }
}
