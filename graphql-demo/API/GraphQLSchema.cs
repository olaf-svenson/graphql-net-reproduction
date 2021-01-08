using System;

namespace API
{
    public sealed class GraphQLSchema : GraphQL.Types.Schema
    {
        public GraphQLSchema(GraphQLQuery graphQLQuery, IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = graphQLQuery;
        }
    }
}