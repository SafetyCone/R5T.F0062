using System;
using System.Windows.Forms;


namespace R5T.F0062.Extensions
{
    public static class LabelExtensions
    {
        public static Label Reset(this Label label)
        {
            Instances.LabelOperator.Reset(label);

            return label;
        }

        /// <summary>
        /// Fluent.
        /// </summary>
        public static Label SetTrueOrFalse(this Label label,
            bool trueOrFalse)
        {
            Instances.LabelOperator.SetTrueOrFalse(label, trueOrFalse);

            return label;
        }
    }
}
