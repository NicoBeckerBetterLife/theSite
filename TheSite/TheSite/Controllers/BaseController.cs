using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;

namespace TheSite.Controllers
{
    public abstract class BaseController : Controller
    {
        public virtual void Create()
        {
            //standard implementation
        }
    }
}