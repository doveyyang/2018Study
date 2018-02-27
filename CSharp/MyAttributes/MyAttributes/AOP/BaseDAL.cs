using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttributes.AOP
{
    public class BaseDAL
    {
        public static void Insert<T>(T t)
        {
            

            Console.WriteLine("Insert Success!");
        }
    }

    public class ValideExtend
    {
        public static bool Validate<T>(this T t)
        {
            bool value = true;
            Type type = t.GetType();
            foreach (var item in type.GetProperties())
            {
                //                LengthAttribute attribute = item
                //if (item.IsDefined(typeof(LengthAttribute), true))
                foreach (var attribute in item.GetCustomAttributes())
                {

                }
                {
                    LengthAttribute attribute = item.GetCustomAttributes(typeof(LengthAttribute), true)[0] as LengthAttribute;
                    if (!attribute.Vaildate(item.GetValue(t)))
                    {
                        throw new Exception("LengthAttribute");
                    };
                }
            }
            return value;
        }

    }
}
