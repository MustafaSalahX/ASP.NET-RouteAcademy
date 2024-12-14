using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopTwoOOP3.Interfaces
{
	public interface IRectangle : IShape
	{
		double Length {  get; set; }
		double Width { get; set; }
	}
}
