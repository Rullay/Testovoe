using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace hashtable
{
    public class _Array<T>
    {
        public int Key { get; set; }

        public List<T> list { get; set; }

        public _Array(int key)
        {
            Key = key;
            list = new List<T>();
        }
    }
}



