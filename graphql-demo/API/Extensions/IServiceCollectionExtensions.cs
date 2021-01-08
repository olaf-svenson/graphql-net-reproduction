using GraphQL;
using GraphQL.SystemTextJson;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection serviceCollection)
            => serviceCollection
                .AddSingleton<IDocumentExecuter, DocumentExecuter>()
                .AddSingleton<IDocumentWriter, DocumentWriter>()
                .AddSingleton<ISchema, GraphQLSchema>()
                .AddSingleton<GraphQLQuery>();
    }
}