using DotnetExamples.Model.Util;
using Newtonsoft.Json;

namespace DotnetExamples.Model.NsJson
{
    public class ParentObj
    {
        [JsonProperty("name")]
        public readonly string Name;
        
        [JsonConverter(typeof(WrapperObjJsonConvert<Age, int>))]
        [JsonProperty("age")]
        public readonly Age Age;


        public ParentObj(
            string name,
            Age age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}