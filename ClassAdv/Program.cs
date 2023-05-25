using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //소멸자 > 역순 호출
            Product product1 = new Product("과자", 1000);
            Product product2 = new Product("아이스크림", 800);
            Product product3 = new Product("케이크", 10000);
        
            //속성(Property)
            Box box = new Box(3, 5);
            box.Width = 100;
            box.Height = 200;
            box.GetArea();
            try
            {
                box.Width = -10;    // 잘못된 값이 들어간 경우
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
