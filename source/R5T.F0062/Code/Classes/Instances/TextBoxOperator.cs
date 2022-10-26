using System;


namespace R5T.F0062
{
	public class TextBoxOperator : ITextBoxOperator
	{
		#region Infrastructure

	    public static ITextBoxOperator Instance { get; } = new TextBoxOperator();

	    private TextBoxOperator()
	    {
        }

	    #endregion
	}
}