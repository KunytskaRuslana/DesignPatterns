using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Assigned(45);
            Console.WriteLine(human.IdentificationCod.Code);

            human.IdentificationCod = IdentificationCod.getInstance(55);
            Console.WriteLine(human.IdentificationCod.Code);

            Console.ReadLine();
        }

        class Human
        {
            public IdentificationCod IdentificationCod { get; set; }
            public void Assigned(int idCode)
            {
                IdentificationCod = IdentificationCod.getInstance(idCode);
            }
        }

        class IdentificationCod
        {
            private static IdentificationCod instance;

            public int Code { get; private set; }

            protected IdentificationCod(int code)
            {
                this.Code = code;
            }

            public static IdentificationCod getInstance(int code)
            {
                if (instance == null)
                    instance = new IdentificationCod(code);
                return instance;
            }
        }
    }
}
