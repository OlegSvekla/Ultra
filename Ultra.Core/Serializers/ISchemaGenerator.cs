using NJsonSchema;

namespace Ultra.Core.Serializers;

public interface ISchemaGenerator
{
    JsonSchema GenerateSchema<T>();

    JsonSchema GenerateSchema(Type type);
}
