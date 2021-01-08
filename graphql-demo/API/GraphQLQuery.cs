using API.Entities;
using API.GraphTypes;
using GraphQL.Types;
using System.Collections.Generic;

namespace API
{
    public sealed class GraphQLQuery : ObjectGraphType
    {
        private readonly List<User> _users = new List<User>();
        private readonly List<Task> _tasks = new List<Task>();

        public GraphQLQuery()
        {
            Field<ListGraphType<UserType>>(
                "users",
                "Returns a collection of users.",
                resolve: context => _users);

            Field<ListGraphType<TaskType>>(
                "tasks",
                "Returns a collection of tasks.",
                resolve: context => _tasks);
        }
    }
}