using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICRUDABLE_App.Model
{
    interface ICrud
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }
}
