//
//  Program.cs
//
//  Author:
//       student <>
//
//  Copyright (c) 2014 student
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace Krakazyabra
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
			Console.WriteLine ("Поочередно введите значения, перед (1)x^2, перед (2)x, свободный коээфициент (3)");
			double a = Convert.ToDouble(Console.ReadLine());
			double b = Convert.ToDouble(Console.ReadLine());
			double c = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ваше уравнение {0}x^2+{1}x+{2}=0",a,b,c);
			double d = b * b - 4 * a * c;
			double o = 0;
			if (d < o) {
				Console.WriteLine ("d={0} Натуральных корней нет", d);
				Console.ReadKey(); }
			if (d > o) {
				double kd = Math.Sqrt(d);
				double x1 = -b + kd / 2 * a;
				double x2 = -b - kd / 2 * a;
				Console.WriteLine ("Уравнение имеет два корня");
				Console.WriteLine ("x1 = {0} + {1} / {2}", -b, kd, 2*a);
				Console.WriteLine ("x1 = {0}",x1);
				Console.WriteLine ("x2 = {0} - {1} / {2}", -b, kd, 2*a);
				Console.WriteLine ("x2 = {0}",x2);
				Console.ReadKey(); }
			else {
				double x = -b / 2 * a;
				Console.WriteLine ("Уравнение имеет единственный корень");
				Console.WriteLine("x = {0} / {1}",-b,2*a);
				Console.WriteLine ("x = {0}", x);
				Console.ReadKey(); }
		}
	}
}
