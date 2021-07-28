using System;

namespace JsonApiSerializer
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ResourceTypeAttribute : Attribute
    {
        public string Name { get; internal set; }

        public ResourceTypeAttribute(string typeName)
        {
            Name = typeName;
        }
    }
}