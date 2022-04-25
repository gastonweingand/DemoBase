using Services.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessExceptions
{
    public class ClienteMayorEdadException : Exception
    {
        public ClienteMayorEdadException():base("El cliente es menor de edad!".Translate())
        {
            base.HelpLink = "https://wiki.com";
        }
    }
}
