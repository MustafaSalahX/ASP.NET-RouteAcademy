using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWorkShop
{
	/*5.	implement a custom list called FixedSizeList<T> with a predetermined capacity. 
	 *      This list should not allow more elements than its capacity and 
	 */
	public class FixedSizeList<T> : IEnumerable<T>
	{
        public int Capicty { get; set; }
        public List<T> List { get; set; }
        public FixedSizeList(int capcity)
        {
            Capicty = capcity;
            List = new List<T>(capcity);
        }
        public void Add(T item)
        {
            if(List.Count >= Capicty)
            {
                throw new Exception("List has reached the max capcity");
            }
            List.Add(item);
        }
        public T Get(int index)
        {
            if (index < 0 || index >= List.Count)
                throw new Exception("Index out of the range");
            return List[index];
        }

		public IEnumerator<T> GetEnumerator()
		{
            return List.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
            return GetEnumerator();
		}
	}
}
