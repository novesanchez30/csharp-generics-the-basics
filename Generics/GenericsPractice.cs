using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGenericsImplementation
{
	/**
	* @author: Nove Sanchez Nov. 23, 2017
	* @description:
	* this is just a basic implementation of Generics for beginners
	* instead of hardcoding the specific type
	* with generics we can implement code reuse with type safety
	* this is to avoid type casting and unboxing/boxing
	* 
	* T is an arbitrary that most dev follow
	* T is a placeholder whenever we provide a type
	* 
	* @reference: wwww.pluralsight.com
	* 
	* feel free to download and modify the code for testing purposes. :)
	*/
	class GenericClass<T>//T is a type parameter
	{
		private T _localGenericVariable;//local variable with T type
		
		public GenericClass(T value)//class constructor with T type
		{
			Console.WriteLine("constructor value: {0}", value);
			_localGenericVariable = value;
		}
		
		public T GenericMethod(T genericParameter)//method with T return type and T as type parameter
		{
			Console.WriteLine("return type of genericParameter {0}, value: {1}", typeof(T).ToString(), genericParameter);
			Console.WriteLine("return type of _localVariable {0}, value: {1}", typeof(T).ToString(), _localGenericVariable);

			return _localGenericVariable;
		}
	}
}
