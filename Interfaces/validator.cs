namespace StoreSystem.Helpers
{
    public static class Validator
    {
        public static bool IsValidName(string name)
        {
            return !string.IsNullOrEmpty(name);
        }
    }
}