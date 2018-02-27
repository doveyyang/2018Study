namespace EnumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallResultConst.RegisterDescription();
            //var t = CallResult.Success;
            //var str = CallResult.Success.GetDescription();
            //var t1 = CallResultConst.RFIDTAGUSED;
            //var t2 = CallResultConst.ILlegeTag;
            //if (t1 == t2)
            //{
            //    Console.WriteLine(t1==t2);
            //}
            //var str1 = CallResultConst.ILlegeTag.GetDescription();
            //var str2 = CallResultConst.RFIDTAGUSED.GetDescription();
            try
            {
                MemcachedHelper.SetCache("a", "b");
                System.Console.WriteLine(MemcachedHelper.GetCache("a"));
                System.Console.ReadKey();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            
        }
    }
}
