using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Program
    {
        delegate void Type1(int x);
        delegate void Type2(int x, string y);
        delegate bool Type3(int x, int y);
        delegate bool Type3Float(float x, float y);
        delegate bool Type3String(string x, string y);


        delegate int Type4();
        delegate bool GenericType3<T>(T x, T y);
        delegate void Type5();


        static void Main(string[] args)
        {
            //---------------------------------------------------------------
            Type1 type1 = delegate(int x){
                x = x + 1;
                Console.WriteLine(x);
            };

            Type1 type11 = (a) => Console.WriteLine(a);

            Type1 type1Lambda = (x) => {x = x + 1; Console.WriteLine(x); };

            //---------------------------------------------------------------
            Type2 type2 = delegate(int x, string y) {
                Console.WriteLine(x);
                Console.WriteLine(y.Length);
            };

            Type2 type2Lambda = (p1, p2) =>
            {
                Console.WriteLine(p1);
                Console.WriteLine(p2.Length);               
            };

            //---------------------------------------------------------------

            Type3 type3 = delegate(int x, int y) { return x > y; };
            Type3 type3Lambda1 = (x, y) => x > y;
            Type3 type3Lambda2 = (x, y) => { x = x + y; return  x > y; };


            //----------------------------------------------------------------
            GenericType3<float> gtFloat = delegate(float x, float y) { return x > y; };
            GenericType3<int> gtInt = delegate(int x, int y) { return x > y; };
            GenericType3<string> gtString = delegate(string x, string y) { return x.Length > y.Length; };

            GenericType3<float> gtFloatLambda = (a, b) => a > b;
            GenericType3<int> gtIntLambda = (a,b) => a > b;
            GenericType3<string> gtStringLambda = (a,b) => a.Length > b.Length;

            //------------------------------------------------------------------          

            //GenericType3<Person> personDelegate 
            Person pe1 = new Person { Age = 10 };
            Person pe2 = new Person { Age = 20 };

            bool isPe1GTPe2 = ITakeGenericDelegate<Person>(pe1, pe2, (per1, per2) => per1.Age > per2.Age);


            //-------------------------------------------------------------------
            Person[] people = new Person[3] { new Person { Age = 10 }, new Person { Age = 20 }, new Person { Age = 30 } };

            Human[] humansOldWay = Array.ConvertAll<Person, Human>(people, GetHumanFromPerson);

            Human[] humans = Array.ConvertAll<Person, Human>(people, (person) => new Human { AgeInMonths = person.Age * 12 });
            

            //---------------------------------Variable Capture-------------------
            Type4 cl = inc();

            var res1 = cl();

            var res2 = cl();

            //--------------------------------------------------------------------

            Type5[] t51 = new Type5[10];

            for(int i = 0; i < 10; i++) {
                //int temp = i;
                t51[i] = () => Console.WriteLine(i);
            }
            
            foreach (Type5 t in t51)
            {
                t();
            }
            //--------------------------------------------------------------------
            ExpressionTreeExample();
            Console.ReadLine();
        }

        static Type4 inc()
        {
            int i = 0;
            return () => { i = i + 1; return i; };
        }

       

        static bool ITakeGenericDelegate<T>(T p1, T p2, GenericType3<T> compareDelegate) {

            return compareDelegate(p1, p2);
        }

        static Human GetHumanFromPerson(Person p) {
            return new Human { AgeInMonths = p.Age * 12 };
        }

        static void ExpressionTreeExample() {
            Func<int, bool> isLessThan5 = (num) => num < 5;

            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
            ConstantExpression five = Expression.Constant(5, typeof(int));
            BinaryExpression numLessThanFive = Expression.LessThan(numParam, five);
            Expression<Func<int, bool>> lambda1 = Expression.Lambda<Func<int, bool>>( numLessThanFive, new ParameterExpression[] { numParam });

            Func<int,bool> isLessThan5Compiled = lambda1.Compile();

            
        }
    }

    class Person {
        public int Age { get; set; }
    }

    class Human {
        public int AgeInMonths { get; set; }
    }
}
