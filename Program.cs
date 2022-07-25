using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
             Phone x1 = new Phone("Moho","AfterMath",2019,251);
             x1.changeTitle("AfterMath Moho");
             x1.ShowInfo();

             x1.switchs(true);
          
             x1.play(true);
         
            x1.setVolume(5);
            Phone x2 = new Phone("Shorolotar Protima", "Khalid", 2010, 311);
            Phone x3 = new Phone("Closing Time", "Leonard Cohen", 1992, 371);
            
            Phone list = new Phone();
            list.AddMusicFile(x2, x1, x3);
            
            list.ShowAllMusicFile();
            Console.ReadLine();
               }
    }
}
