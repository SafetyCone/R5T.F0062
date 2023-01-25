using System;


namespace R5T.F0062
{
    public class ClipboardOperator : IClipboardOperator
    {
        #region Infrastructure

        public static IClipboardOperator Instance { get; } = new ClipboardOperator();

        private ClipboardOperator()
        {
        }

        #endregion
    }
}