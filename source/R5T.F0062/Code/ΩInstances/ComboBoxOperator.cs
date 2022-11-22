using System;


namespace R5T.F0062
{
	public class ComboBoxOperator : IComboBoxOperator
	{
		#region Infrastructure

	    public static IComboBoxOperator Instance { get; } = new ComboBoxOperator();

	    private ComboBoxOperator()
	    {
        }

	    #endregion
	}
}