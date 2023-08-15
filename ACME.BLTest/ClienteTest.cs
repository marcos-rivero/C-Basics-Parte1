using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.BL;

namespace ACME.BLTest
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void NombreCompleto_NombreYApellido_RetornaNombreCompleto()
        {
            // Arrange
            Cliente Cliente = new Cliente
            {
                Nombre = "PrimerNombre",
                Apellido = "Apellido"
            };
            string expected = "Apellido, PrimerNombre";
            // Act
            string actual = Cliente.NombreCompleto;

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void NombreCompleto_Nombre_RetornaApellidoVacio()
        {
            // Arrange
            Cliente Cliente = new Cliente
            {
                Nombre = "PrimerNombre"
            };
            string expected = "PrimerNombre";
            // Act
            string actual = Cliente.NombreCompleto;

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void NombreCompleto_Apellido_RetornaNombreVacio()
        {
            // Arrange
            Cliente Cliente = new Cliente
            {
                Apellido = "PrimerNombre"
            };
            string expected = "PrimerNombre";
            // Act
            string actual = Cliente.NombreCompleto;

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void InstanceCount_Cliente_ReturnCountOfInstance()
        {
            // Arrange
            var c1 = new Cliente();
            c1.Nombre = "Frodo";
            Cliente.InstanceCount += 1;

            var c2 = new Cliente();
            c1.Nombre = "Bilbo";
            Cliente.InstanceCount += 1;

            var c3 = new Cliente();
            c1.Nombre = "Rosie";
            Cliente.InstanceCount += 1;

            // Act

            // Assert
            Assert.AreEqual(3, Cliente.InstanceCount);
        }

        [TestMethod]
        public void Validate_Cliente_ReturnTrue()
        {
            // Arrange
            var Cliente = new Cliente
            {
                Apellido = "Voldemort",
                DireccionDeMail = "test@email.com"
            };
            var expected = true;

            // Act
            var actual = Cliente.Validate();

            // Assert
            Assert.IsTrue(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_Cliente_ReturnFalse()
        {
            // Arrange
            var Cliente = new Cliente
            {
                DireccionDeMail = "test@email.com"
            };
            var expected = false;

            // Act
            var actual = Cliente.Validate();

            // Assert
            Assert.IsFalse(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
