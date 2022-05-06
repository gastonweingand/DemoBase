using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Extensions
{
    public static class ExceptionExtension
    {
        public static void Handle(this Exception ex, object sender)
        {
            BLL.ExceptionBLL.Handle(ex, sender);
        }
    }
}
