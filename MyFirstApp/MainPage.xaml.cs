namespace MyFirstApp;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }


    private void DigitClicked(object? sender, EventArgs e)
    {
        Button? digit = sender as Button;
        
        Screen.Text += (string)digit?.CommandParameter;
    }


    private void EqualOperator_OnClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void SumOperator_OnClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void MinusOperator_OnClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void MultiplyOperator_OnClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}