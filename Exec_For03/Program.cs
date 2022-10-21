using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string snum = "123";
			//string pnum=snum.PadLeft(6, '0');
			//string fnum = string.Format("{0:000000}", Convert.ToInt32(snum));
			//Console.WriteLine("原是字串"+snum+"\n透過padleft:"+pnum+"\n透過String.format:"+fnum);

			for (int length = 1; length <= 10; length++)
			{
				Console.WriteLine(new string('*', length).PadLeft(10, ' '));
			}
		}
	}
}
