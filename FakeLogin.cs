namespace MAUIAndroidTabBarIssue {
    internal static class FakeLogin {
        public static bool IsLoggedIn { get; private set; }

        public static event EventHandler LoggedIn;
        public static event EventHandler LoggedOut;

        public static async Task LoginAsync() {
            await Task.Delay(500);
            IsLoggedIn = true;
            LoggedIn?.Invoke(null, EventArgs.Empty);
        }

        public static async Task LogoutAsync() {
            await Task.Delay(500);
            IsLoggedIn = false;
            LoggedOut?.Invoke(null, EventArgs.Empty);
        }
    }
}
