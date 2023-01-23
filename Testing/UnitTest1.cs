using esercizio1_pausadidattica;
namespace Testing
{
    public class UnitTest1
    {
        Telefono cell;

        [Fact]
        public void Test1()
        {
            cell = new Telefono("12345678", "Xiaomi", "Redmi", 10, -10);
            cell.Ricaricare(10);
            Assert.True(cell.Credito == 20);
        }

        [Fact]
        public void Test2()
        {
            cell = new Telefono("12345678", "Xiaomi", "Redmi", 10, -10);
            Assert.Throws<Exception>(() => cell.Ricaricare(0));
        }

        [Fact]
        public void Test3()
        {
            cell = new Telefono("12345678", "Xiaomi", "Redmi", 10, -10);
            Assert.Throws<Exception>(() => cell.Ricaricare(-10));
        }

        [Fact]
        public void Test4()
        {
            cell = new Telefono("12345678", "Xiaomi", "Redmi", 10, -10);
            Assert.Throws<Exception>(() => cell.Avviare("3331122444"));
        }

        [Fact]
        public void Test5()
        {
            cell = new Telefono("12345678", "Xiaomi", "Redmi", 10, -10);
            cell.Credito = -20;
            Assert.Throws<Exception>(() => cell.Avviare("3331122444")); //da ERRORE perchè il Credito < CreditoMin
        }

        [Fact]
        public void Test6()
        {
            cell = new Telefono("12345678", "Xiaomi", "Redmi", 10, -10);
            Assert.Throws<Exception>(() => cell.AggiungereNero("3331122444"));
        }

        [Fact]
        public void Test7()
        {
            cell = new Telefono("12345678", "Xiaomi", "Redmi", 10, -10);
            cell.AggiungereNero("3331122444");
            Assert.Throws<Exception>(() => cell.EliminareNero("3331122444"));
        }

        [Fact]
        public void Test8()
        {
            cell = new Telefono("12345678", "Xiaomi", "Redmi", 10, -10);
            Assert.Throws<Exception>(() => cell.EliminareNero("3331122444"));
        }
    }
}