using Microsoft.Maui.Controls;

namespace Project_Final_Pruthvi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnViewStudentsClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StudentPage());
        }

        private void OnViewCoursesClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CoursePage());
        }
    }
}