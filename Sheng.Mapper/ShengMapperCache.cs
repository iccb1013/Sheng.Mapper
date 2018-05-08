﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Sheng.Mapper
{
    static class ShengMapperCache
    {
        private static Dictionary<Type, ShengMapperTypeDescription> _cacheList = new Dictionary<Type, ShengMapperTypeDescription>();

        static ShengMapperCache()
        {

        }

        public static ShengMapperTypeDescription Get(Type type)
        {
            if (type == null)
                return null;

            if (_cacheList.Keys.Contains(type))
                return _cacheList[type];
            else
            {
                ShengMapperTypeDescription cacheCodon = new ShengMapperTypeDescription(type);

                Monitor.Enter(_cacheList);

                if (_cacheList.Keys.Contains(type) == false)
                    _cacheList.Add(type, cacheCodon);

                Monitor.Exit(_cacheList);

                return cacheCodon;

            }
        }

    }
}
