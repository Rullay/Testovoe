using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace hashtable
{
    public class HashTableUser
    {
        private _Array<User>[] _array;

        public HashTableUser(int size)
        {
            _array = new _Array<User>[size];

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = new _Array<User>(i);
            }
        }

        public void Add(User key)
        {
            var k = GetHash(key.Name);
            _array[k].list.Add(key);

        }

        public void Search(string name, DataHashing data)
        {
            var k = GetHash(name);
            if (_array[k] != null)
            {
                for (int i = 0; i < _array[k].list.Count; i++)
                {
                    if (_array[k].list[i].Name == name)
                    {
                        data.Search(_array[k].list[i]);
                    }
                }
            }
            
        }


        private int GetHash(string key)
        {
            int hashing = 0;
            foreach (char c in key)
            {
                hashing += ((int)c);
            }

            return hashing % _array.Length;

        }


        public void DeleteUser(string name)
        {
            var k = GetHash(name);
            if (_array[k] != null)
            {
                for (int i = 0; i < _array[k].list.Count; i++)
                {
                    if (_array[k].list[i].Name == name)
                    {
                        _array[k].list.RemoveAt(i);
                        _array[k].list.RemoveAll(x => x == null);
                    }
                }
            }
        }

        public void EditUser(string name, int number)
        {
            var k = GetHash(name);
            if (_array[k] != null)
            {
                for (int i = 0; i < _array[k].list.Count; i++)
                {
                    if (_array[k].list[i].Name == name)
                    {
                        _array[k].list[i].Number = number;
                    }
                }
            }
        }


    }



}