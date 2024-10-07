namespace Delt.Utility.Generators
{
    public static class GenerateShortDescription
    {
        public static string Create(string fullDescription) => $"{fullDescription.Substring(0, 150)}...";
    }
}
