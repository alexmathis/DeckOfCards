using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardsApp.Models
{
	public class ReturnResults<T>
	{
		public string ErrorMessage { get; set; }

		public T Data { get; set; }

		public bool Success { get; set; } = false;


		/// <summary>
		/// 
		/// </summary>
		/// <param name="defaultValue"></param>
		public ReturnResults()
		{
			// Return a default object of the defined type.
			// Return an empty string if T is string.
			// String will throw MissingMethodException in CreateInstance<T>().
			if (typeof(T) == typeof(string))
			{
				// Have to fake out compiler with casts for this to work.
				Data = (T)(object)"";
			}
			else if (typeof(T).IsValueType)
			{
				Data = default(T);
			}
			else
			{
				Data = Activator.CreateInstance<T>();
			}

		}
	}
}
