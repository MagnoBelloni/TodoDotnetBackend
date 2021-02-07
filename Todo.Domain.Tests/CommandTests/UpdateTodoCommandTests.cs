using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class UpdateTodoCommandTests
    {
        private readonly UpdateTodoCommand _invalidCommand = new UpdateTodoCommand(Guid.NewGuid(), "", "");
        private readonly UpdateTodoCommand _validCommand = new UpdateTodoCommand(Guid.NewGuid(), "titulo da task", "usuario");

        public UpdateTodoCommandTests()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }

        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            Assert.AreEqual(_validCommand.Valid, true);
        }

    }
}
