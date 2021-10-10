using System;

namespace UselessUnitTestingExtensions
{
    public class BugfixAttribute : Attribute
    {
        private string Reason;

        public BugfixAttribute() { }

        /// <param name="reason">Might be a ticket number, might be an observation</param>
        public BugfixAttribute(string reason)
        {
            Reason = reason;
        }
    }
}
