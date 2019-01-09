using System;
using Newtonsoft.Json;
namespace InterfaceBuilder
{
    public static class UtilityExtensions
    {
        public static T Clone<T>(this T obj) =>
             JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(obj));
    }
}
