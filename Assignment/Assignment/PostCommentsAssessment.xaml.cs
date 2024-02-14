using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostCommentsAssessment : ContentPage
    {
        public PostCommentsAssessment()
        {
            InitializeComponent();
        }
        private async void OnPostClicked(object sender, EventArgs e)
        {
            string firstName = firstNameEntry.Text;
            string lastName = lastNameEntry.Text;
            string comments = commentsEntry.Text;

            string message = $"{firstName} {lastName}\n{comments}";
            await DisplayAlert("Posted Comments", message, "OK");

            ClearEntries();
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            ClearEntries();
        }

        private void ClearEntries()
        {
            firstNameEntry.Text = string.Empty;
            lastNameEntry.Text = string.Empty;
            commentsEntry.Text = string.Empty;
        }
    }
}