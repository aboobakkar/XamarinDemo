using System;
using Xamarin.Forms;

namespace CustomRenderer
{
	public partial class DetailPage : ContentPage
	{
		public DetailPage (object detail)
		{
			InitializeComponent ();

			if (detail is string) {
                detailName.Text = detail as string;
			} else if (detail is DataSource) {
                detailName.Text = (detail as DataSource).Name;
                categorylabel.Text = (detail as DataSource).Category;
                ImageSource Image = (detail as DataSource).ImageFilename;
                passportLabel.Text = (detail as DataSource).Passport;
                genderLabel.Text = (detail as DataSource).Gender;
                JoiningdateLabel.Text = (detail as DataSource).Joining;
                designationLabel.Text = (detail as DataSource).Designation;
                departmentLabel.Text = (detail as DataSource).Department;
                religionLabel.Text = (detail as DataSource).Religion;
                dobLabel.Text = (detail as DataSource).Dob;
                nationalityLabel.Text = (detail as DataSource).Nationality;

            }
		}

		void OnButtonClicked (object sender, EventArgs e)
		{
			Navigation.PopModalAsync ();
		}
	}
}
