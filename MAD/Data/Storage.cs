namespace MAD.Data
{
    public static class Storage
    {
        public static string[] Alternatives = new string[] {
            "Money diff",
            "Middle Age diff",
            "Total Wins Percent diff",
            "Coach Experiance",
            "Funs amount diff",
            "Appsend players amount",
            "Bet koef"
        };

        public static string[] Choices = new string[]
        {
            "Karpaty",
            "Dynamo",
            "Liverpool",
            "Dynamo"
        };

        public static float[][] ComparisonMatrix;


        static Storage()
        {
            ComparisonMatrix = new float[Choices.Length][];
            for (int i = 0; i < Choices.Length; i++)
            {
                ComparisonMatrix[i] = new float[Alternatives.Length];
            }
        }
    }
}
