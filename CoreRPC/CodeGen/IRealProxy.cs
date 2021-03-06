﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CoreRPC.CodeGen
{
    public interface IRealProxy
    {
        Task<T> Invoke<T>(MethodInfo method, IEnumerable args);
    }
}
