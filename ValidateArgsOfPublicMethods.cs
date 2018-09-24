using System;

namespace DesignLibrary
{
   public class Test
   {
       // This method violates the rule.
       public void DoNotValidate(string input)
       {
           if (input.Length != 0)
           {
               Console.WriteLine(input);
           }
       }

       // This method satisfies the rule.
       public void Validate(string input)
       {
           if (input == null)
           {
               throw new ArgumentNullException("input");
           }
           if (input.Length != 0)
           {
               Console.WriteLine(input);
           }
       }
   }
}
