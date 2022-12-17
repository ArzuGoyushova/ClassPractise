using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product : IEnumerable 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in this)
            {
                yield return item;
            }
        }
    }
}
