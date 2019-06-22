using System;
using DotnetExamples.Model.NsJson;
using Newtonsoft.Json;

namespace DotnetExamples.Model.Util
{
    public class WrapperObjJsonConvert<T1, T2> : JsonConverter<T1> where T1 : WrapperObj<T2>
    {
        public override T1 ReadJson(
            JsonReader reader,
            Type objectType,
            T1 existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(
            JsonWriter writer,
            T1 value,
            JsonSerializer serializer)
        {
            writer.WriteValue(value.Value);
        }
    }
}