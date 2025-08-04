using NJsonSchema;

namespace Ultra.Core.Serializers;

public interface ISchemaClassAttribute
{
    void Apply(JsonSchema schema);
}
