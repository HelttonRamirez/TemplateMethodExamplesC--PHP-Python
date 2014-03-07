//using System;
//class MainApp
//{
//  static void Main()
//  {
//        AbstractClass a;
//        a = new ConcreteClassA();
//        a.TemplateMethod();
//        
//        a = new ConcreteClassB();
//        a.TemplateMethod();
//        // Wait for user 
//        Console.Read();
//  }
//}
//
//// "AbstractClass"
//abstract class AbstractClass
//{
//        public abstract void PrimitiveOperation1();
//        public abstract void PrimitiveOperation2();
//        // The "Template method" 
//        public void TemplateMethod()
//        {
//            PrimitiveOperation1();
//            PrimitiveOperation2();
//            Console.WriteLine("");
//        }
//}
//
//// "ConcreteClass" 
//class ConcreteClassA : AbstractClass
//{
//        public override void PrimitiveOperation1()
//        {
//            Console.WriteLine("A-> ConcreteClassA.PrimitiveOperation1()");
//        }
//        public override void PrimitiveOperation2()
//        {
//            Console.WriteLine("A-> ConcreteClassA.PrimitiveOperation2()");
//        }
//}
//class ConcreteClassB : AbstractClass
//{
//        public override void PrimitiveOperation1()
//        {
//            Console.WriteLine("B-> ConcreteClassB.PrimitiveOperation1()");
//        }
//        public override void PrimitiveOperation2()
//        {
//            Console.WriteLine("B-> ConcreteClassB.PrimitiveOperation2()");
//        }
//}

////////////////////////////////////////////////////



using System;
class MainApp
{
  static void Main()
  {
        int[] arr = new int[15]{-2,2,1,44,2,1,0,0,-4,6,-7,9,33,1,-89};
        AbstractClass a;
        a = new SortUp(arr);
        a.TemplateMethod();
        a = new SortDown(arr);
        a.TemplateMethod();
        // Wait for user 
        Console.Read();
  }
}

// "AbstractClass"
abstract class AbstractClass
{
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
        // The "Template method" 
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
}

// "ConcreteClass" 
class SortUp : AbstractClass
{
        public int[] arra;
        public SortUp(int[] arr)
        {
            arra=new int[15];
            arra=arr;
        }
        public override void PrimitiveOperation1()
        {
            Array.Sort(arra);
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("El Ordenamiento Ascendiente es: ");
            foreach(var i in arra)
            {
                
                Console.Write(i+", ");
            }
        }
}
class SortDown : AbstractClass
{
        public int[] arra;
        public SortDown(int[] arr)
        {
            arra=new int[15];
            arra=arr;
        }
        public override void PrimitiveOperation1()
        {
            Array.Reverse(arra);
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("El Ordenamiento Descendiente es: ");
            foreach(var i in arra)
            {
                
                Console.Write(i+", ");
            }
        }
}
