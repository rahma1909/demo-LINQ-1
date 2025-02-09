namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region implicitly typed local variable

            #region var
            //var: is a c# keyword  

            var name = "rahma";
            //must be intilized
            //compiler can detect the variable datatype based on intilial value in the compliation time
            //can't be intilized with null
            //after intilization u can not change the datatype


            //name = 9;//invalid 

            #endregion

            #region dynamic
            //dynamic :is a c# keyword c# 4.0feature

            dynamic data;
            //compiler will skip the type checking at compilation time
            //clr will resolve type at the run time
            //you don't need to intilize it
            // after intilization you can change the var dt
            //


            #endregion


            #endregion

            #region anonymous type

            //var emp = new { id = 10, name = "ahmed", salary = 1002 };
            //Console.WriteLine(emp.GetType().Name);//<>f__AnonymousType0`3


            ////var emp01 = new { id = 20, name = "eyad", salary = 1002 };
            ////the same anonymous type as long as 
            ////1. the same signature sam properties {names}
            ////2. properties ordering
            ////Console.WriteLine(emp.GetType().Name);//<>f__AnonymousType0`3

            //emp.id = 20;//invalid
            ////emp =new { id=20,emp.name,emp.salary};
            ////synatx suger
            //emp = emp with { id = 30 };//c#10.0 
            //Console.WriteLine(emp); 

            #endregion

            #region extention method
            //int x = 12345;
            ////int y = intextensions.reverse(x);

            //int z = x.reverse();
            //Console.WriteLine(z);


            #endregion


            #region what is LINQ??
            //LINQ:stands for language-integrated quary  c#3.0
            //LINQ:40+ extension methods for the built in interface Ienumrable
            //use linq aganist data stored in sequence
            //sequence: is an object from calss implementing the interface "Ienumrable"
            //local seq:
            //remote seq:

            //List<int> nums = [1, 2, 3, 56, 4, 8, 9];//local seq:obj from list ==>
            //List<int> oddnums = nums.Where((n) => n % 2 == 1).ToList();


            //nums.AddRange([11, 12, 13, 14]);

            //foreach (var item in oddnums)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion


            #region LINQ syntax

            #region 1. Fluent syntax

            List<int> nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            ////call LINQ operators as => static method through enumerab;e calss
            ////var odds = Enumerable.Where(nums, (n) => n % 2 == 1);

            ////call LINQ operators as => extention method [recommended]
            //var odds = nums.Where((n) => n % 2 == 1);

            //foreach (var item in odds)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion


            #region 2.query syntax like => sql style

            //var odds = from N in nums
            //           where N % 2 == 1
            //           select N;


            //foreach (var item in odds)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion




            #endregion

            #region LINQ Excuation ways


            #region 1. differed excuation
            //var res = nums.Where((n) => n % 2 == 1);

            //nums.AddRange([11, 12, 13, 45]);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion




            #region 2. Immediate excuation
            //var res = nums.Where((n) => n % 2 == 1).ToList();

            //nums.AddRange([11, 12, 13, 45]);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #endregion




        }
    }
}
