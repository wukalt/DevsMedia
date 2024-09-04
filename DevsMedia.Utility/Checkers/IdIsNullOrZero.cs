namespace DevsMedia.Utility.Checkers
{
    public static class IdIsNullOrZero
    {
        public static bool IsNullOrZero(this int? id) => (id is null || id is 0) ? true : false;
    }
}
