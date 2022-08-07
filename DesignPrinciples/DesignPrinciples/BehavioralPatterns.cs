using DesignPrinciples.Classes;
using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            List<IShoppingItems> shoppingItems = new List<IShoppingItems>();
            shoppingItems.Add(new Table("desk",20));
            shoppingItems.Add(new Table("desk", 40));
            shoppingItems.Add(new Chair("chair", 20));
            double sum = 0;
            IShoppingCartVisitor shoppingCartVisitor = new ShoppingCart();
            foreach(var item in shoppingItems)
            {
                sum = sum + item.Accept(shoppingCartVisitor); 
            }
            Console.WriteLine("Price "+sum);
            /////////
            ///Null Pattern
            ///
            /// 
            //CustomerFactory customerFactory = new CustomerFactory();
            //Console.WriteLine(customerFactory.GetCustomer("zolaikha").GetCustomer());
            /////////
            ///Template Pattern
            ///
            //int[] numbers = { 4, 5, 1, 3, 6, 87, 6,-4 };
            //Algorithm bubbleSort = new BubbleSort(numbers);
            //bubbleSort.Sort();
            //Algorithm insertionSort = new InsertionSort1(numbers);
            //insertionSort.Sort();
            /////////
            ///Iterator Pattern
            ///
            /////////
            ///Iterator Pattern
            ///

            //NamesRepository namesRepository = new NamesRepository();
            //for (IIterator iterator = namesRepository.GetIterator(); iterator.HasNext();)
            //{
            //    string name = (string)iterator.Next();
            //    Console.WriteLine(name);
            //}

            /////////
            ///Iterator Pattern
            ///


            /////////
            ///Command Pattern
            ///

            //Algorithm algorithm = new Algorithm();
            //System.Threading.Tasks.Task.Factory.StartNew(() => algorithm.Produce());
            //System.Threading.Tasks.Task.Factory.StartNew(() => algorithm.Consume());
            //Switcher switcher = new Switcher(); //invoker
            //Light light = new Light(); //receiver
            //TurnOnCommand turnOnCommand = new TurnOnCommand(light); //command
            //TurnOffCommand turnOffCommand = new TurnOffCommand(light); //command
            //switcher.AddCommand(turnOnCommand);
            //switcher.AddCommand(turnOffCommand);
            //switcher.ExecuteCommand();

            /////////
            ///Command Pattern
            ///

            /////////
            ///Observer Pattern
            //CricketStation cricketStation = new CricketStation();
            //CricketObserver cricketObserver = new CricketObserver(cricketStation);
            //cricketStation.SetOvers(3);
            //cricketStation.SetRuns(5);

            //WeatherStation weatherStation = new WeatherStation();
            //WeatherObserver weatherObserver = new WeatherObserver(weatherStation);
            //weatherStation.SetHumidity(1000);
            //weatherStation.SetHumidity(4000);
            /////////
            ///Observer Pattern
            ///

            /////////
            ///Strategy Pattern
            //Manager manager = new Manager();
            //manager.SetStrategy(new Add());
            //manager.Operation(3,4);
            //manager.SetStrategy(new Multiple());
            //manager.Operation(2,3);
            /////////
            ///Strategy 

            Console.ReadLine();
        }
    }
}
