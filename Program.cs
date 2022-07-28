using System;
using System.Linq;

class Module9
{
    static void Main(string[] args)
    {
                
        var exeptions = new Exception[] { new FieldAccessException(), new FileNotFoundException(), new ArgumentNullException(),
            new ArgumentOutOfRangeException(), new MyOwnException("rare")};

        try
        {
            throw new FieldAccessException("Common exc1");
            
        }
        catch (FieldAccessException ex)
        {
            Console.WriteLine($" Исключение типа {ex.Message}");
        }
        try
        {
            throw new FileNotFoundException("Common exc2");
        }

        catch (FileNotFoundException fl)
        {
            Console.WriteLine($" Исключение типа {fl.Message}");
        }
        try
        {
            throw new ArgumentNullException("Common exc3");
        }
        catch(ArgumentNullException arn)
        {
            Console.WriteLine($"Исключение типа {arn.Message}");
        }
        try
        {
            throw new ArgumentOutOfRangeException("Common exc4");
        }
        catch(ArgumentOutOfRangeException arr)
        {
            Console.WriteLine($" Исключение типа {arr.Message}");
        }
        try
        {
            throw new MyOwnException("rare exception");
        }
        
        catch(MyOwnException moe)
        {
            Console.WriteLine($" Исключение типа {moe.Message}");
        } 
    }
        
    public class MyOwnException : Exception
    {
        public MyOwnException(string message) : base(message)
        {

        }
    }
}

  
  

