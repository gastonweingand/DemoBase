using Services.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public static class ExceptionService
    {
        public static void Handle(Exception ex)
        {
            BLL.ExceptionBLL.Handle(ex);
        }
    }
}
