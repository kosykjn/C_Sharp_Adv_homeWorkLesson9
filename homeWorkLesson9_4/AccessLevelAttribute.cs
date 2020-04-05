using System;

namespace homeWorkLesson9_4
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class AccessLevelAttribute : Attribute
    {
        public int Level { get; set; }

        public AccessLevelAttribute(int level)
        {
            Level = level;
        }
    }
   
}
