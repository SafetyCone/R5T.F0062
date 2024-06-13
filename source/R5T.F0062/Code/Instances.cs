using System;


namespace R5T.F0062
{
    public static class Instances
    {
        public static L0066.IBooleanOperator BooleanOperator { get; } = L0066.BooleanOperator.Instance;
        public static IColorOperator ColorOperator { get; } = F0062.ColorOperator.Instance;
        public static IColors Colors { get; } = F0062.Colors.Instance;
        public static ILabelOperator LabelOperator { get; } = F0062.LabelOperator.Instance;
        public static IStrings Strings { get; } = F0062.Strings.Instance;
    }
}