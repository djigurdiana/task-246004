


using System.Runtime.ExceptionServices;

{
     internal class program
{
    static void Main(string[] args)
    {
       int [] a = new int [10];
       var rnd = new Random();
       for (int i = 0; i < a.Length; i++)
       {
           a[i] = rnd.Next(1, 100);
           
       }
       PrintArray(a);
       Array.Sort(a);
         PrintArray(a);
         Array.Sort(a, 0, a.length);
         
    }
}
static void 



}
