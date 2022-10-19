using System;

using R5T.F0000;


namespace R5T.F0062
{
    public static class Instances
    {
        public static IBooleanOperator BooleanOperator { get; } = F0000.BooleanOperator.Instance;
        public static IColorOperator ColorOperator { get; } = F0062.ColorOperator.Instance;
        public static IColors Colors { get; } = F0062.Colors.Instance;
        public static ILabelOperator LabelOperator { get; } = F0062.LabelOperator.Instance;
        public static IStrings Strings { get; } = F0062.Strings.Instance;
    }
}