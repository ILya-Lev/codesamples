using System;

namespace Ploeh.Samples.HelloDI.Console
{
    // ---- Code Listing 1.1 ----
    public class Salutation
    {
        private readonly IMessageWriter writer;

        public Salutation(IMessageWriter writer)
        {
            this.writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        public void Exclaim()
        {
            this.writer.Write("Hello DI!");
        }
    }
}