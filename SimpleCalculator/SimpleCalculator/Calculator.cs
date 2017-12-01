namespace SimpleCalculator
{
    public class Calculator
    {
        public double Calculate(string userString)
        {
            userString = userString.Trim();
            var resultString = "";

            var parser = new Parser(userString);
            var firstNumber = parser.getFirstNumber();
            var operation = parser.getOperation();
            var secondNumber = parser.getSecondNumber();

            var result = CalculateResult(firstNumber, secondNumber, operation, ref resultString);
            return result;
        }

        private double CalculateResult(double firstNumber, double secondNumber, char operation, ref string resultString)
        {
            if (double.IsNaN(firstNumber) || double.IsNaN(secondNumber))
            {
                resultString = "Неверно введенные числа";
                return double.NaN;
            }


            var result = 0d;
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '/':
                    if (secondNumber == 0)
                    {
                        resultString = "Делить на 0 нельзя";
                        return double.NaN;
                    }
                    result = firstNumber / secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                default:
                    resultString = "Ошибка. Доступные операции +,-,/,*";
                    break;
            }
            return result;
        }
    }
}
