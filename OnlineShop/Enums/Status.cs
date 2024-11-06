using System.ComponentModel;


namespace OnlineShop.Enums
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