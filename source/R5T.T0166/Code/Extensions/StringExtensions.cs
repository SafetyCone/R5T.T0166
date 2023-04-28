using System;


namespace R5T.T0166.Extensions
{
    public static class StringExtensions
    {
        [Obsolete("Use R5T.T0188 instead.")]
        public static CommitMessage ToCommitMessage(this string value)
        {
            var output = StringOperator.Instance.ToCommitMessage(value);
            return output;
        }
    }
}
