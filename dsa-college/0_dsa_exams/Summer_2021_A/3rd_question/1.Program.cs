using System;
using System.Text;



namespace dsa_college._0_dsa_exams.Summer_2021_A._3rd_question
{
	public class Program {

		public static void Main(string[] args)
		{
			object[] arr = new object[3];
			Clothes a = new Shirt();
			a.price = 10;
			arr[0] = a;
			Clothes b = new Dress();
			b.price = 5;
			arr[1] = b;
			Book c = new Book();
			c.price = 5;
			arr[2] = c;

			Shipping s = new Shipping();
			s.arr = arr;

			Console.WriteLine(s.sum());


			Console.Read();
		}
	}
}