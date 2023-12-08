namespace ProgressTest.View;
using CommunityToolkit.Maui.Views;


public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
    }

    public bool IsExpanded = false;

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (IsExpanded == false)
        {
            FuckingSpan.Text = "Was a Dutch Post-Impressionist painter who is among the most famous and influential artist in the world.";
            IsExpanded = true;
        }
        else if (IsExpanded == true)
        {
            FuckingSpan.Text = "Was a Dutch Post-Impressionist...";
            IsExpanded = false;
        }
    }
}