using GraphQL.Server.Transports.AspNetCore;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ApolloServer
{
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// Add the GraphQL middleware to the request pipeline with Apollo Tracing
        /// </summary>
        /// <typeparam name="TSchema">The implementation of <see cref="ISchema"/> to use</typeparam>
        /// <param name="builder">The application builder.</param>
        /// <param name="path"></param>
        /// <returns>The <see cref="IApplicationBuilder"/> received as parameter</returns>
        public static IApplicationBuilder UseGraphQLWithApolloTracing<TSchema>(this IApplicationBuilder builder, PathString path)
            where TSchema : ISchema
        {
            return builder.UseMiddleware<ApolloGraphQLHttpMiddleware<TSchema>>(path);
        }
    }
}
