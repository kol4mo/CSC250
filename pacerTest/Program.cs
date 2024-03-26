using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace pacerTest {
    internal class Program {
        static void performPacerTest() {
        }

        static void run() {
        }

        static void changeDirection() {
        }

        static int addOne(int addedNumber) {
            return ++addedNumber;
        }

        static void Main(string[] args) {
            int addedNumber = addOne(1);
            Console.WriteLine(addedNumber);
        }
    }
}
