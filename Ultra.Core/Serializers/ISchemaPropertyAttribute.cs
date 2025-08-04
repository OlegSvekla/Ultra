using NJsonSchema;

namespace Ultra.Core.Serializers;

public interface ISchemaPropertyAttribute
{
    void Apply(JsonSchema schema);
}
