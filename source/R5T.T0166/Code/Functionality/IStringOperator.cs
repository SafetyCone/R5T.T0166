using System;

using R5T.T0132;


namespace R5T.T0166
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public CommitMessage ToCommitMessage(string value)
        {
            var output = new CommitMessage(value);
            return output;
        }
    }
}
