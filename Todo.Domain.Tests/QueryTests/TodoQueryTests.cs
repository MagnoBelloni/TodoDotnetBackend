﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>
            {
                new TodoItem("tarefa 1", DateTime.Now, "usuarioA"),
                new TodoItem("tarefa 2", DateTime.Now, "usuarioB"),
                new TodoItem("tarefa 3", DateTime.Now, "usuarioB"),
                new TodoItem("tarefa 4", DateTime.Now, "usuarioA"),
                new TodoItem("tarefa 5", DateTime.Now, "usuarioB")
            };
        }

        [TestMethod]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuarioB()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("usuarioB"));
            Assert.AreEqual(3, result.Count());
        }
    }
}
