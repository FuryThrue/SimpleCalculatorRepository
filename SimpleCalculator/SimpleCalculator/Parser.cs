namespace SimpleCalculator
{
    public class Parser
    {
        char _operation;
        string _userString;

        public Parser(string userString)
        {
            var trimmedOne = userString.Replace(" ", "");
            var trimmedTwo = trimmedOne.Replace(")", "");
            var trimmedThree = trimmedTwo.Replace("(", "");
            _userString = trimmedThree;
        }

        public char getOperation()
        {
            for (int i = 0; i < _userString.Length; i++)
            {
                var c = _userString[i];
                if (!char.IsDigit(c) && (c == '+' || (c == '-' && _userString.IndexOf('-') > 0) || c == '*' || c == '/'))
                {
                    _operation = _userString[i];
                    break;
                }
            }
            return _operation;
        }

        public double getSecondNumber()
        {
            var indexOfOperation = _userString.IndexOf(getOperation());
            return indexOfOperation > 0 ? getFirstNumber(_userString.Substring(indexOfOperation + 1)) : double.NaN;
        }

        public double getFirstNumber()
        {
            return getFirstNumber(_userString);
        }

        double getFirstNumber(string parOfString)
        {
            var numberString = "";
            foreach (var c in parOfString)
            {
                if (char.IsDigit(c) || c == '.' || c == ',' || (c == '-' && _userString.IndexOf('-') == 0))
                {
                    var mark = c;
                    if (mark == '.')
                        mark = ',';

                    numberString += mark;
                }

                else
                    break;
            }
            var resultParse = 0d;
            var result = double.TryParse(numberString, out resultParse);
            return result ? resultParse : double.NaN;
        }
    }
}
