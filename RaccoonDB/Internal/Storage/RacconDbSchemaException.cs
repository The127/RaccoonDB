using System;

namespace RaccoonDB.Internal.Storage
{
    public class RacconDbSchemaException : Exception
    {
        public RacconDbSchemaException(string msg)
            : base(msg)
        {
            
        }
    }
}