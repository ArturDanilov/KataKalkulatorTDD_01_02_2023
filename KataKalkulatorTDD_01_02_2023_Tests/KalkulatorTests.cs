using KataKalkulatorTDD_01_02_2023;

namespace KataKalkulatorTDD_01_02_2023_Tests
{
    public class KalkulatorTests
    {
        Kalkulator _kalkulator;

        [SetUp]
        public void Setup()
        {
            _kalkulator = new Kalkulator();
        }
        [TearDown] public void Teardown()
        {
            _kalkulator = null;
        }

        [Test]
        public void Add_Eingabe1Plus2_Return3()
        {
            var actual = _kalkulator.Add("1+2");

            Assert.That(actual, Is.EqualTo("3"));
        }

        [Test]
        public void Add_Eingabe10Plus20_Return30()
        {
            var actual = _kalkulator.Add("10+20");

            Assert.That(actual, Is.EqualTo("30"));
        }

        [Test]
        public void Add_Eingabe100Plus200_Return300()
        {
            var actual = _kalkulator.Add("100+200");

            Assert.That(actual, Is.EqualTo("300"));
        }

        [Test]
        public void Add_Eingabe1000Plus20000_Return21000()
        {
            var actual = _kalkulator.Add("1000+20000");

            Assert.That(actual, Is.EqualTo("21000"));
        }

        [Test]
        public void Add_Eingabe1Plus_Return1()
        {
            var actual = _kalkulator.Add("1+");

            Assert.That(actual, Is.EqualTo("1"));
        }

        [Test]
        public void Add_EingabePlus1_Return1()
        {
            var actual = _kalkulator.Add("+1");

            Assert.That(actual, Is.EqualTo("1"));
        }

        [Test]
        public void Add_Eingabe2Plus_Return1()
        {
            var actual = _kalkulator.Add("2+");

            Assert.That(actual, Is.EqualTo("2"));
        }

        [Test]
        public void Add_Eingabe14Plus_Return14()
        {
            var actual = _kalkulator.Add("14+");

            Assert.That(actual, Is.EqualTo("14"));
        }

        [Test]
        public void Add_Eingabe1PlusA_ReturnExeption()
        {
            var myExeption = Assert.Throws<ArgumentException>(() => _kalkulator.Add("1+A"));

            Assert.That(myExeption.Message, Is.EqualTo("Buchstaben sind nicht erlaubt"));

        }

        [Test]
        public void Add_Eingabe1Plus_a_ReturnExeption()
        {
            var myExeption = Assert.Throws<ArgumentException>(() => _kalkulator.Add("1+a"));

            Assert.That(myExeption.Message, Is.EqualTo("Buchstaben sind nicht erlaubt"));

        }

        [Test]
        public void Add_EingabeAPlus1_ReturnExeption()
        {
            var myExeption = Assert.Throws<ArgumentException>(() => _kalkulator.Add("A+1"));

            Assert.That(myExeption.Message, Is.EqualTo("Buchstaben sind nicht erlaubt"));

        }

        [Test]
        public void Add_Eingabe1_aPlus1_ReturnExeption()
        {
            var myExeption = Assert.Throws<ArgumentException>(() => _kalkulator.Add("a+1"));

            Assert.That(myExeption.Message, Is.EqualTo("Buchstaben sind nicht erlaubt"));

        }

        [Test]
        public void Add_Eingabe5Minus2_Return3()
        {
            var actual = _kalkulator.Add("5-2");

            Assert.That(actual, Is.EqualTo("3"));
        }

        [Test]
        public void Add_Eingabe50Minus20_Return30()
        {
            var actual = _kalkulator.Add("50-20");

            Assert.That(actual, Is.EqualTo("30"));
        }

        [Test]
        public void Add_Eingabe500Minus200_Return300()
        {
            var actual = _kalkulator.Add("500-200");

            Assert.That(actual, Is.EqualTo("300"));
        }

        [Test]
        public void Add_Eingabe20000Minus1000_Return19000()
        {
            var actual = _kalkulator.Add("20000-1000");

            Assert.That(actual, Is.EqualTo("19000"));
        }

        [Test]
        public void Add_Eingabe15Durch3_Return3()
        {
            var actual = _kalkulator.Add("15/3");

            Assert.That(actual, Is.EqualTo("5"));
        }

        [Test]
        public void Add_Eingabe150Durch3_Return30()
        {
            var actual = _kalkulator.Add("150/3");

            Assert.That(actual, Is.EqualTo("50"));
        }

        [Test]
        public void Add_Eingabe1500Durch3_Return300()
        {
            var actual = _kalkulator.Add("1500/3");

            Assert.That(actual, Is.EqualTo("500"));
        }

        [Test]
        public void Add_Eingabe15Durch0_Return21000()
        {

            var myExeption = Assert.Throws<DivideByZeroException>(() => _kalkulator.Add("15/0"));

            Assert.That(myExeption.Message, Is.EqualTo("Dividieren durch Null"));
        }

        [Test]
        public void Add_Eingabe1Minus_a_ReturnExeption()
        {
            var myExeption = Assert.Throws<ArgumentException>(() => _kalkulator.Add("1-a"));

            Assert.That(myExeption.Message, Is.EqualTo("Buchstaben sind nicht erlaubt"));
        }

        [Test]
        public void Add_Eingabe1Minus_b_ReturnExeption()
        {
            var myExeption = Assert.Throws<ArgumentException>(() => _kalkulator.Add("1-b"));

            Assert.That(myExeption.Message, Is.EqualTo("Buchstaben sind nicht erlaubt"));
        }

        [Test]
        public void Add_Eingabe1Minus_c_ReturnExeption()
        {
            var myExeption = Assert.Throws<ArgumentException>(() => _kalkulator.Add("1-c"));

            Assert.That(myExeption.Message, Is.EqualTo("Buchstaben sind nicht erlaubt"));
        }

        [Test]
        public void Add_Eingabe3Mult5_Return15()
        {
            var actual = _kalkulator.Add("3*5");

            Assert.That(actual, Is.EqualTo("15"));
        }

        [Test]
        public void Add_Eingabe30Mult5_Return150()
        {
            var actual = _kalkulator.Add("30*5");

            Assert.That(actual, Is.EqualTo("150"));
        }

        [Test]
        public void Add_Eingabe3Mult500_Return1500()
        {
            var actual = _kalkulator.Add("3*500");

            Assert.That(actual, Is.EqualTo("1500"));
        }

        [Test]
        public void Add_Eingabe30Mult500_Return15000()
        {
            var actual = _kalkulator.Add("30*500");

            Assert.That(actual, Is.EqualTo("15000"));
        }
    }
}