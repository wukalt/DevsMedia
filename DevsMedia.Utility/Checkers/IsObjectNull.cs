namespace DevsMedia.Utility.Checkers
{
    public static class IsObjectNull
    {
        public static bool IsNull(this object obj) => (obj is null) ? true : false;
    }
}
