using Program;

namespace Library.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void SetUp() {}

        [Test]
        public void CompuertaAnd()
        {
            CLogAND and = new CLogAND("AND");
            and.AgregarEntrada("A", 1);
            and.AgregarEntrada("B", 1);

            Assert.That(and.Calcular(), Is.EqualTo(1));
        }
        
        [Test]
        public void CompuertaOr()
        {
            CLogOR or = new CLogOR("or");
            or.AgregarEntrada("A", 0);
            or.AgregarEntrada("B", 1);

            Assert.That(or.Calcular(), Is.EqualTo(1));
        }
        
        [Test]
        public void CompuertaNot()
        {
            CLogNOT not = new CLogNOT("not");
            not.AgregarEntrada("A", 1);
            
            Assert.That(not.Calcular(), Is.EqualTo(0));
        }

        [Test]
        public void GarageGateAbrir()
        {
            GarageGate puerta = new GarageGate(0, 1, 1);
            var puertaAbre = puerta.AbrirGarage();
            
            Assert.AreEqual(1, puertaAbre);
        }
    }
}