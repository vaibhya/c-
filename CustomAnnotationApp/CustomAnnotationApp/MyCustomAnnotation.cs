﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAnnotationApp
{
    [AttributeUsage(AttributeTargets.Method)]
    class MyCustomAnnotation:Attribute
    {
    }
}
