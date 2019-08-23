using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Projeto02.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static SelectList ToSelectList<TEnum>(this TEnum obj)
            where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            return new SelectList(Enum.GetValues(typeof(TEnum)).OfType<Enum>()
                .Select(x => new SelectListItem
                {
                    Text = x.GetDisplayName(),
                    Value = (Convert.ToInt32(x)).ToString()
                }),"Value","Text");
        }    

        public static string GetDisplayName(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DisplayAttribute atributo = field.GetCustomAttribute<DisplayAttribute>(inherit: false);
            
            if (atributo != null)
            {
                return atributo.GetName() != string.Empty ? atributo.GetName() : field.Name; 
            }
            return field.Name;

        }
    }   
}