using System;


namespace R5T.F0062
{
    public class CheckboxOperator : ICheckboxOperator
    {
        #region Infrastructure

        public static ICheckboxOperator Instance { get; } = new CheckboxOperator();

        private CheckboxOperator()
        {
        }

        #endregion
    }
}