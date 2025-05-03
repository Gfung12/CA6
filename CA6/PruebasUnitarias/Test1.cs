namespace PruebasUnitarias
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void BusquedaLineal_ElementoPresente_RetornaIndiceCorrecto()
        {
            int[] arreglo = { 5, 3, 8, 6, 2, 7, 1, 4, 9 };
            int objetivo = 7;
            int resultado = BusquedaLineal.Buscar(arreglo, objetivo);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void BusquedaLineal_ElementoNoPresente_RetornaMenosUno()
        {
            int[] arreglo = { 1, 2, 3, 4, 5 };
            int objetivo = 10;
            int resultado = BusquedaLineal.Buscar(arreglo, objetivo);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void BusquedaLineal_ArregloVacio_RetornaMenosUno()
        {
            int[] arreglo = { };
            int objetivo = 5;
            int resultado = BusquedaLineal.Buscar(arreglo, objetivo);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void BusquedaLineal_ElementoDuplicado_RetornaPrimeraOcurrencia()
        {
            int[] arreglo = { 5, 2, 7, 2, 9 };
            int objetivo = 2;
            int resultado = BusquedaLineal.Buscar(arreglo, objetivo);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void BusquedaBinaria_ElementoPresente_RetornaIndiceCorrecto()
        {
            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int objetivo = 4;
            int resultado = BusquedaBinaria.Buscar(arreglo, objetivo);
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void BusquedaBinaria_ElementoNoPresente_RetornaMenosUno()
        {
            int[] arreglo = { 10, 20, 30, 40, 50 };
            int objetivo = 25;
            int resultado = BusquedaBinaria.Buscar(arreglo, objetivo);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void BusquedaBinaria_ArregloVacio_RetornaMenosUno()
        {
            int[] arreglo = { };
            int objetivo = 5;
            int resultado = BusquedaBinaria.Buscar(arreglo, objetivo);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void BusquedaBinaria_ElementoPrimero_RetornaCero()
        {
            int[] arreglo = { 5, 10, 15, 20 };
            int objetivo = 5;
            int resultado = BusquedaBinaria.Buscar(arreglo, objetivo);
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void BusquedaBinaria_ElementoUltimo_RetornaUltimoIndice()
        {
            int[] arreglo = { 5, 10, 15, 20, 25 };
            int objetivo = 25;
            int resultado = BusquedaBinaria.Buscar(arreglo, objetivo);
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void BusquedaBinaria_ArregloConElementosDuplicados_RetornaIndiceCorrecto()
        {
            int[] arreglo = { 1, 2, 2, 2, 3, 4, 5 };
            int objetivo = 2;
            int resultado = BusquedaBinaria.Buscar(arreglo, objetivo);
            Assert.IsTrue(resultado >= 1 && resultado <= 3);
        }

    }
}