using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace csv_parser
{
	class Program
	{
		static void Main(string[] args)
		{
			var path = "file.csv";
			var file = File.OpenRead(path);
			using(var parser = new TextFieldParser(path))
			{
				parser.TextFieldType = FieldType.Delimited;
				parser.SetDelimiters(",");
				while (!parser.EndOfData)
				{
					var line = parser.ReadFields();
					foreach (var item in line)
					{
						Console.WriteLine(item);
					}
				}
			}
			Console.Read();
		}
	}
}
