namespace KataKalkulatorTDD_01_02_2023
{
    public class Kalkulator
    {
        public string Add(string str)
        {
            int count = str.Length - 1;
            string[] number = str.Split('+', '-', '/', '*');
            
            CheckNachBuchstebeA(str);

            if (CheckWennEingabeNurEineZahlEnthelt(str, count))
            {
                return number[0];
            }

            return Kalkulieren(str, count, number); 
        }

        private string Kalkulieren(string str, int count, string[] number)
        {
            int a = 0;
            int b = 0;

            if (count > 1)
            {
                if (str.IndexOf('+') != count)
                {
                    a = int.Parse(number[0]);
                    b = int.Parse(number[1]);
                }

                if (str.Contains('+'))
                {
                    return (a + b).ToString();
                }

                if (str.Contains('-'))
                {
                    return (a - b).ToString();
                }

                if (str.Contains('/'))
                {
                    if (!number.Contains("0"))
                    {
                        return (a / b).ToString();
                    }
                    else
                    {
                        throw new DivideByZeroException("Dividieren durch Null");
                    }

                }

                if (str.Contains('*'))
                {
                    return (a * b).ToString();
                }
            }
            return number[1];
        }

        private void CheckNachBuchstebeA(string str)
        {
            if (str.Any(c => char.IsLetter(c)))
            {
                throw new ArgumentException("Buchstaben sind nicht erlaubt");
            }
        }

        private bool CheckWennEingabeNurEineZahlEnthelt(string str, int count)
        {
            return str.IndexOf('+') == count;
        }
    }
}
