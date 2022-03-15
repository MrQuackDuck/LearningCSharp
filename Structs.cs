using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    class Structs
    {
        struct MyFirstStruct
        {
            public int xAxis;
            public int yAxis;

            public int AddCoordinates()
            {
                return xAxis + yAxis;
            }
        }


        public void Start()
        {
            MyFirstStruct mystruct = new MyFirstStruct();
            mystruct.xAxis = 4;
            mystruct.yAxis = 4;
            Console.WriteLine( mystruct.AddCoordinates() );
        }
    }
}
