namespace DotnetExamples.Model.NsJson
{
    public abstract class WrapperObj<T>
    {
        public readonly T Value;


        public WrapperObj(T value)
        {
            this.Value = value;
        }
    }
}