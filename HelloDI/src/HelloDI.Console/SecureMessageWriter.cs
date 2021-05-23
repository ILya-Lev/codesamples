using System;
using System.Security.Principal;

namespace Ploeh.Samples.HelloDI.Console
{
    // ---- Code Listing 1.3 ----
    public class SecureMessageWriter : IMessageWriter
    {
        private readonly IMessageWriter writer;
        private readonly IIdentity identity;

        public SecureMessageWriter(
            IMessageWriter writer,
            IIdentity identity)
        {
            this.writer = writer ?? throw new ArgumentNullException(nameof(writer));
            this.identity = identity ?? throw new ArgumentNullException(nameof(identity));
        }

        public void Write(string message)
        {
            if (this.identity.IsAuthenticated)
            {
                this.writer.Write(message);
            }
        }
    }
}