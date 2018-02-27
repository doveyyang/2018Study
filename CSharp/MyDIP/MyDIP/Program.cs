using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiloway.Factory;
//using Kiloway.Bll;
//using Kiloway.DAL;
using Kiloway.IBLL;
using Kiloway.IDAL;

namespace MyDIP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //{
                //    Apple apple = new Apple();
                //    Vivo vivo = new Vivo();
                //    IPersonService service = new PersonService();//new IPersonService();

                //    service.Study();
                //    service.PlayApple(apple);
                //    service.Play(apple);
                //    service.Play(vivo);
                //}
                {
                    AbstractPhone apple = Factory.GetAbstractPhone(PhoneType.Apple);//new Apple();
                    AbstractPhone vivo = Factory.GetAbstractPhone(PhoneType.Vivo);// new Vivo();
                    AbstractPhone luima = Factory.GetAbstractPhone(PhoneType.Luima);// new Vivo();
                    IPersonService service = Factory.GetPersonService("IPersonService");//new PersonService();//new IPersonService();

                    service.Study();                    
                    service.Play(apple);
                    service.Play(vivo);
                    service.Play(luima);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            Console.ReadKey();
        }
    }
}
