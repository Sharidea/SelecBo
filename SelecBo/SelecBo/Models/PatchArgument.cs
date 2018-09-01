using System;

namespace SelecBo.Models
{
    public abstract class PatchArgument
    {
        public string Name { get; set; }
        public Type Type { get; set; }
    }

    public class PatchArgument<T> : PatchArgument
    {
        public PatchArgument()
        {
            Type = typeof(T);
        }
        public T Value { get; set; }
    }
}
