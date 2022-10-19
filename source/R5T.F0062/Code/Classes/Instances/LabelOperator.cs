using System;


namespace R5T.F0062
{
	public class LabelOperator : ILabelOperator
	{
		#region Infrastructure

	    public static ILabelOperator Instance { get; } = new LabelOperator();

	    private LabelOperator()
	    {
        }

	    #endregion
	}
}