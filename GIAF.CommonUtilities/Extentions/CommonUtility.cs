using System;
using System.Threading;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIAF.CommonUtilities.Extentions
{
    public static class CommonUtility
    {

        public static T GetValue<T>(this object value)
        {
            Type t = typeof(T);
            if (value == null || value == DBNull.Value)
            {
                if (t.Name == "String")
                {
                    return (T)Convert.ChangeType(string.Empty, typeof(T));
                }
                return default(T);
            }
            if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                Type valueType = t.GetGenericArguments()[0];
                object result = Convert.ChangeType(value, valueType);
                return (T)result;
            }
            return (T)Convert.ChangeType(value, typeof(T));
        }

    }
}
