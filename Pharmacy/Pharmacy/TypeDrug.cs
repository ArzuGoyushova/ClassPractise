using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy
{
    public class TypeDrug
    {
        private static int _Id;
        public int Id { get; set; }
        public string TypeName { get; set; }
        public TypeDrug(string typeName)
        {
            _Id++;
            Id = _Id;
            TypeName = typeName;
        }
    }
}
