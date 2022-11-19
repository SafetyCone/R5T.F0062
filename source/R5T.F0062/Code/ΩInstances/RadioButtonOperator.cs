using System;


namespace R5T.F0062
{
	public class RadioButtonOperator : IRadioButtonOperator
	{
		#region Infrastructure

	    public static IRadioButtonOperator Instance { get; } = new RadioButtonOperator();

	    private RadioButtonOperator()
	    {
        }

	    #endregion
	}
}