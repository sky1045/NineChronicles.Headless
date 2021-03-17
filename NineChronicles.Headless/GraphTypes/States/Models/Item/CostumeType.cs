using GraphQL.Types;
using Nekoyume.Model.Item;

namespace NineChronicles.Headless.GraphTypes.States.Models.Item
{
    public class CostumeType : ItemBaseType<Costume>
    {
        public CostumeType()
        {
            Field<NonNullGraphType<GuidGraphType>>(
                nameof(Costume.ItemId),
                description: "Guid of costume."
            );
            Field<NonNullGraphType<BooleanGraphType>>(
                nameof(Costume.Equipped),
                description: "Status of Avatar equipped."
            );
            Field<NonNullGraphType<LongGraphType>>(
                nameof(Costume.RequiredBlockIndex),
                description: "Block index limit that locks the costume item. If the current block index is less than the RequiredBlockIndex, the item cannot be used."
            );
        }
    }
}
