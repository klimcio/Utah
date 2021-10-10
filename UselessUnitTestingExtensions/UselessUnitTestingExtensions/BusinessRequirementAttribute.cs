using System;

namespace UselessUnitTestingExtensions
{
    public class BusinessRequirementAttribute : Attribute
    {
        private string Reason;

        public BusinessRequirementAttribute() { }

        /// <param name="reason">Might be a ticket number, might be an observation</param>
        public BusinessRequirementAttribute(string reason)
        {
            Reason = reason;
        }
    }
}
