using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class BaseEntity
    {
        private int _id;
        public int Id { get; set; }
        //static BaseEntity()
        //{
        //    _id = 0;
        //}
        public BaseEntity()
        {
            _id++;
            Id = _id;
        }
    }
}
