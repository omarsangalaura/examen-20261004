using apiSimple.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace apiSimple.Test
{
    [TestClass]
    public class OperationsControllerTest
    {
        [TestMethod]
        public void GetState_Valid()
        {
            // Instancia controller
            var controller = new OperationsController();
            // Llama al método GetState
            var result = controller.GetState();
            // Verificar
            Assert.IsNotNull(result);
            var okResult = Assert.IsInstanceOfType<OkObjectResult>(result);
            Assert.AreEquivalent("Estado: Activo", okResult.Value);
        }

        [TestMethod]
        public void GetState_Invalid()
        {
            // Instancia controller
            var controller = new OperationsController();
            // Llama al método GetState
            var result = controller.GetState();
            // Verificar
            Assert.IsNotNull(result);
            var okResult = Assert.IsInstanceOfType<OkObjectResult>(result);
            Assert.AreNotEquivalent("Estado: Inactivo", okResult.Value);
        }
    }
}
