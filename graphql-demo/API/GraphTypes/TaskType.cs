using API.Entities;
using GraphQL.Types;

namespace API.GraphTypes
{
    public sealed class TaskType : ObjectGraphType<Task>
    {
        public TaskType()
        {
            Name = nameof(Task);

            Field(task => task.Id)
                .Description("The task id.");

            Field(task => task.IsDone)
                .Description("Represents the task state.");

            Field(task => task.Title)
                .Description("The task title.");

            Field(task => task.Description)
                .Description("The task description.");

            Field(task => task.CreatedAt)
                .Description("The date the task was created.");
        }
    }
}