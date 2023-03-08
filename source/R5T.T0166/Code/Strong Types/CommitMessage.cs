using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0166
{
    /// <summary>
    /// A strongly-typed source control system commit message.
    /// </summary>
    [StrongTypeMarker]
    public class CommitMessage : TypedString, IStrongTypeMarker
    {
        public CommitMessage(string value)
            : base(value)
        {
        }
    }
}
