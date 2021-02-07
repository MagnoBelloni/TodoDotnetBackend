using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class MarkTodoAsUndoneCommandTests
    {
        private readonly MarkTodoAsUndoneCommand _invalidCommand = new MarkTodoAsUndoneCommand(Guid.NewGuid(), "");
        private readonly MarkTodoAsUndoneCommand _validCommand = new MarkTodoAsUndoneCommand(Guid.NewGuid(), "usuario");

        public MarkTodoAsUndoneCommandTests()
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
