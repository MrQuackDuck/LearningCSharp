using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    class Enums
    {
        enum Transport : int
        {
            Car = 1,
            Bus,
            Trolleybus,
            Tram,
            Train,
            Plain,
        }


        public void Start()
        {

            Transport transport = Transport.Tram;

            ChooseTransport(transport);

            Console.WriteLine(GetNextTransport((Transport)2));

            Console.WriteLine($"Enum Transport использует тип { Enum.GetUnderlyingType(typeof(Transport)) }");

            /*            Console.WriteLine(transport.ToString());*/

            Array myTransport = Enum.GetValues( typeof(Transport) );
            for (int i = 0; i < myTransport.Length; i++) {
                Console.WriteLine(myTransport.GetValue(i));
            }
        }

        static void ChooseTransport(Transport t)
        {
            switch (t)
            {
                case Transport.Car:
                    Console.WriteLine("Вы выбрали машину, хороший выбор!");
                    break;
                case Transport.Bus:
                    Console.WriteLine("Оу, вы хотите прокатится в тёплом атмосферном автобусе?))");
                    break;
                case Transport.Trolleybus:
                    Console.WriteLine("Ммм, атмосфера зашкаливает...");
                    break;
                case Transport.Tram:
                    Console.WriteLine("Охх, этот звук стука колёс... А задние сидения в Tatra T3 - шик!");
                    break;
                case Transport.Train:
                    Console.WriteLine("Оо да, отлично. Большой трамвай");
                    break;
                case Transport.Plain:
                    Console.WriteLine("Любите почувстовать себя в воздухе?)");
                    break;
                default:
                    Console.WriteLine("Идёте пешком? :D");
                    break;
            }


        }

        static Transport GetNextTransport(Transport t)
        {
            return t + 1;
        }

    }

}
