using System;

namespace UselessUnitTestingExtensions
{
    public class NormalBehaviourAttribute : Attribute
    {
        private string Reason;

        public NormalBehaviourAttribute()
        {

        }

        /// <param name="reason">A short explanation or whatever you seem fit to describe why the tested behaviour is normal</param>
        public NormalBehaviourAttribute(string reason)
        {
            Reason = reason;
        }
    }
}
