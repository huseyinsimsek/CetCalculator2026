namespace MyFirstApp;

public partial class MainPage : ContentPage
{
    private double firstNumber = 0;
    private string currentOperator = "";
    private bool isFirstDigit = true;
    
    public MainPage()
    {
        InitializeComponent();
    }


    private void DigitClicked(object? sender, EventArgs e)
    {
        Button? digit = sender as Button;
        if (isFirstDigit)
        {
            Screen.Text = (string)digit?.CommandParameter;
            isFirstDigit = false;
        }
        else
        {
            Screen.Text += (string)digit?.CommandParameter;
            
        }
    }


    private void EqualOperator_OnClicked(object? sender, EventArgs e)
    {
        Hesapla("=");
    }

    private void SumOperator_OnClicked(object? sender, EventArgs e)
    {
        Hesapla("+");
    }

    private void MinusOperator_OnClicked(object? sender, EventArgs e)
    {
        Hesapla("-");
    }

    private void MultiplyOperator_OnClicked(object? sender, EventArgs e)
    {
        Hesapla("*");
    }

    private void Hesapla(string op)
    {
        isFirstDigit = true;
        if (currentOperator == "" || op == "=")
        {
            firstNumber = double.Parse(Screen.Text);
        }
        else
        {
            double secondNumber = double.Parse(Screen.Text);
            double result = currentOperator switch
            {
                "+" => firstNumber + secondNumber,
                "*" => firstNumber * secondNumber,
                "-" => firstNumber - secondNumber
                
            };
            Screen.Text = result.ToString();
            firstNumber= result;
           
        }
        currentOperator = op;
        
        
    }
}