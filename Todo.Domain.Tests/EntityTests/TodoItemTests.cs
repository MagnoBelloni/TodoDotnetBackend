using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoItemTests
    {
        private readonly TodoItem _validTodo = new TodoItem("Titulo aqui", DateTime.Now, "usuario");

        [TestMethod]
        public void Dado_um_novo_todo_o_mesmo_nao_pode_ser_concluido()
        {
            Assert.AreEqual(_validTodo.Done, false);
        }

        [TestMethod]
        public void Deve_marcar_um_todo_como_concluido()
        {
            _validTodo.MarkAsDone();
            Assert.AreEqual(_validTodo.Done, true);
        }

        [TestMethod]
        public void Deve_marcar_um_todo_como_nao_concluido()
        {
            _validTodo.MarkAsUndone();
            Assert.AreEqual(_validTodo.Done, false);
        }

        [TestMethod]
        public void Deve_atualizar_o_titulo_de_um_todo()
        {
            _validTodo.UpdateTitle("novo titulo");
            Assert.AreEqual(_validTodo.Title, "novo titulo");
        }
    }
}
