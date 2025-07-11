namespace MAUIAndroidTabBarIssue {
    public partial class AppShell : Shell {
        public AppShell() {
            InitializeComponent();

            FakeLogin.LoggedIn += (_, _) => UpdateTabVisibility();
            FakeLogin.LoggedOut += (_, _) => UpdateTabVisibility();

            UpdateTabVisibility();
        }

        public bool IsLoggedIn => FakeLogin.IsLoggedIn;

        private void UpdateTabVisibility() {
            OnPropertyChanged(nameof(IsLoggedIn));

            SetFlyoutItemIsVisible(HomeTab, IsLoggedIn);
            SetFlyoutItemIsVisible(Tab2, IsLoggedIn);
            SetFlyoutItemIsVisible(Tab3, IsLoggedIn);
            SetFlyoutItemIsVisible(Tab4, IsLoggedIn);
            SetFlyoutItemIsVisible(Tab5, IsLoggedIn);
            SetFlyoutItemIsVisible(LoginTab, !IsLoggedIn);
        }
    }
}
