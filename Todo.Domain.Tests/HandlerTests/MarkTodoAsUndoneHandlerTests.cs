using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests
{
    [TestClass]
    public class MarkTodoAsUndoneHandlerTests
    {
        private readonly MarkTodoAsUndoneCommand _invalidCommand = new MarkTodoAsUndoneCommand(Guid.NewGuid(), "");
        private readonly MarkTodoAsUndoneCommand _validCommand = new MarkTodoAsUndoneCommand(Guid.NewGuid(), "usuario");
        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());
        private GenericCommandResult _result = new GenericCommandResult();

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            _result = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.AreEqual(_result.Successs, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_a_tarefa()
        {
            _result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.AreEqual(_result.Successs, true);
        }
    }
}
