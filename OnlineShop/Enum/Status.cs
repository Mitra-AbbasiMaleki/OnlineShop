using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OnlineShop.Enum
{
   internal enum Status
    {
        [Description("انتخاب کنید")]
        NOT_SET,

        [Description ("موجود")]
        AVAILABLE,

        [Description("ناموجود")]
        UNAVAILABLE,
    }
}