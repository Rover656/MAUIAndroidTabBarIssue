namespace MAUIAndroidTabBarIssue.Pages {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage {
        public Page5() {
            InitializeComponent();
        }

        private async void OnCounterClicked(object? sender, EventArgs e) {
            await FakeLogin.LogoutAsync();
            await Shell.Current.GoToAsync($"///{nameof(PretendLoginPage)}");
        }
    }
}