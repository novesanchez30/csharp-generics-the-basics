using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleGenericsImplementation;

namespace Generics
{
	class Program
	{
		static void Main(string[] args)
		{
			GenericClass<int> gc_int = new GenericClass<int>(10);//<int> is the type argument
			gc_int.GenericMethod(20);

			GenericClass<double> gc_db = new GenericClass<double>(99.11);//<double> is the type argument
			gc_db.GenericMethod(99.10);

			GenericClass<string> gc_str = new GenericClass<string>("I am Prince");//<string> is the type argument
			gc_str.GenericMethod("I am Fritz");
			
			object obj = 1000;
			GenericClass<object> gc_ob = new GenericClass<object>(obj);//<object> is the type argument
			gc_ob.GenericMethod(obj);
			//by using type argument object, this will allow you to put a value any type like string, double, etc

			Console.ReadKey();
		}
	}
}
