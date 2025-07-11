namespace MAUIAndroidTabBarIssue.Pages {
    public partial class PretendLoginPage : ContentPage {
        int count = 0;

        public PretendLoginPage() {
            InitializeComponent();
        }

        private async void LoginClicked(object? sender, EventArgs e) {
            await FakeLogin.LoginAsync();
        }
    }
}
