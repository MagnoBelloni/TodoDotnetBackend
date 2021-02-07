using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult()
        {

        }

        public GenericCommandResult(bool successs, string message, object data)
        {
            Successs = successs;
            Message = message;
            Data = data;
        }

        public bool Successs { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
