namespace AsianStoreInventory.Data
{
    public static class UserSession
    {
        public static string Role { get; set; } = "";

        public static bool IsLoggedIn { get; set; } = false;
    }
}