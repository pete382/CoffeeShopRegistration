using Microsoft.AspNetCore.Identity;
using System.Text;

namespace CoffeeShopResgistration.Models
{
	public class Person
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string email { get; set; }
		public string password { get; set; }
  // public Person(string _firstName, string _lastName, string _email, string _password)

		//{

  //      firstName = _firstName;
		//lastName = _lastName;
		//email = _email;	
		//password = _password;
  //      }
		//static string PASSWORD(string text ) 
		//{

		//text = Encoding.Unicode.GetString(Convert.FromBase64String(text));
		//	return text;  
		//}
		
	}
}
