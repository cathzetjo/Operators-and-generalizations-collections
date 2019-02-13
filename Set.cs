using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Set<T>
    {
        public List<T> setList;

        public int Count { get; set; }                                  //Properties: Count
        public string Name { get; set; }                                //Properties: Name

        public Set()                                                    //Default Constructor
        {
            Count = 0;
            setList = new List<T>(capacity: 0);
            Name = "Set";
        }

        public Set(T[] newSetElement)                                    //Syntax Constructor
        {
            setList = new List<T>(newSetElement);
            Count = newSetElement.Length;
            Name = "Set";
        }

        public void Add(T newElement)                                 //Method Add (without repeatings)

        {
            if (setList.Contains(newElement) == false)
            {
                setList.Add(newElement);
                ++Count;
            }
        }

        public void Remove(T oldElement)                              //Method Remove (with calling method Contains)

        {
            if (setList.Contains(oldElement) == true)
            {
                setList.Remove(oldElement);
                --Count;
            }
        }

        public bool Contains(T element)                               //Method Contains (return True)
        {

            for (int i = 0; i < Count; ++i)
            {
                if (setList[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public void GetInfo()
        {
            Console.Write($"\n\t\t {Name}: ");

            for (int i = 0; i < Count; ++i)
            {
                Console.Write($"{setList[i]} ");
            }
            Console.Write("\n\t\t_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n");
        }

        //Union of two SET objects without repeatings
        public Set<T> Union(Set<T> param)
        {
            Set<T> resultSet = new Set<T>();

            for (int i = 0; i < this.Count; ++i)
            {
                resultSet.Add(this.setList[i]);                       //call Method Add - add elements from set1 to set3
            }

            for (int i = 0; i < param.Count; ++i)
            {
                resultSet.Add(param.setList[i]);                     //call Method Add - add elements from set2 to set3
            }

            return resultSet;
        }

        //Same elements from two SET objects
        public Set<T> Intersect(Set<T> param)
        {
            Set<T> resultSet = new Set<T>();


            for (int j = 0; j < param.Count; ++j)
            {
                if (this.Contains(param.setList[j]))                    // if element from set1 = element from set2
                {
                    resultSet.Add(param.setList[j]);                    //call Method Add - add elements from set1 to set4
                }
            }

            return resultSet;
        }

        //1 SET object minus 2 SET objects (only unique from 1 SET)
        public Set<T> Difference(Set<T> param)
        {
            Set<T> resultSet = new Set<T>();

            for (int i = 0; i < this.Count; ++i)
            {
                resultSet.Add(this.setList[i]);                      //call Method Add - add elements from set1 to set5
            }

            for (int i = 0; i < param.Count; ++i)
            {
                resultSet.Remove(param.setList[i]);                 //call Method Remove - remove elements from set5 which contains in set2
            }
            return resultSet;
        }

        //1 SET object plus 2 SET objects minus same elements (only unique from both objects)
        public Set<T> SymmetricDifference(Set<T> param)
        {

            Set<T> resultSet1 = this.Difference(param);                 // call Method Difference - add elements from set1 which not contains in set2 to set6_temp  

            Set<T> resultSet2 = param.Difference(this);                 // call Method Difference - add elements from set2 which not contains in set1 to set6_temp

            Set<T> resultSet = resultSet1.Union(resultSet2);            // call Method Union - add elements from 2 sets whithout repeating

            return resultSet;
        }

        //Elements from 1 SET included in 2 SET
        public bool IsSubsetOf(Set<T> param)
        {
            Console.Write($"\n\t\t{this.Name} is subset of {param.Name}:\t");

            foreach (T element in this.setList)
            {

                if (!param.Contains(element))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    return false;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            return true;
        }

        public static Set<T> operator +(Set<T> first, Set<T> second)
        {
            Set<T> temp = first.Union(second);
            return temp;
        }

        public static Set<T> operator *(Set<T> first, Set<T> second)
        {
            Set<T> temp = first.Intersect(second);
            return temp;
        }

        public static Set<T> operator -(Set<T> first, Set<T> second)
        {
            Set<T> temp = first.Difference(second);
            return temp;
        }

        public static Set<T> operator %(Set<T> first, Set<T> second)
        {
            Set<T> temp = first.SymmetricDifference(second);
            return temp;
        }

        public static bool operator ==(Set<T> first, Set<T> second)

        {
            Set<T> temp = first.SymmetricDifference(second);

            if (temp.Count == 0)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Set<T> first, Set<T> second)

        {
            Set<T> temp = first.SymmetricDifference(second);

            if (temp.Count != 0)
            {
                return true;
            }

            return false;
        }

        public static bool operator >(Set<T> first, Set<T> second)

        {
            if (first.IsSubsetOf(second))
            {

                return true;
            }

            return false;
        }

        public static bool operator <(Set<T> first, Set<T> second)

        {
            if (!first.IsSubsetOf(second))
            {

                return true;
            }

            return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj is Set<T> set)
            {
                return (this == set);
            }

            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        // Метод для вывода на консоль информации о типе-параметре
        public void ShowParamType()
        {
            Console.WriteLine("Type parameter: " + typeof(T));
        }

        // Метод для вывода на консоль информации о типе класса
        public void ShowClassType()
        {
            Console.WriteLine("Generic class type: " + this.GetType() + "\n");
        }



    }
}
