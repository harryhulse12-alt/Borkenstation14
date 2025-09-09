using Content.Shared.EntityEffects;
using Robust.Shared.Prototypes;
using Content.Goobstation.Common.Changeling;
using Content.Shared.Traits.Assorted;

namespace Content.Server.EntityEffects.Effects;

public sealed partial class CureHollowed : EntityEffect
{

    public override void Effect(EntityEffectBaseArgs args)
    {
        var entityManager = args.EntityManager;
        if (entityManager.HasComponent<AbsorbedComponent>(args.TargetEntity))
            return;

        entityManager.RemoveComponent<AbsorbedComponent>(args.TargetEntity);
        entityManager.RemoveComponent<UnrevivableComponent>(args.TargetEntity);
    }

    protected override string? ReagentEffectGuidebookText(IPrototypeManager prototype, IEntitySystemManager entSys)
    {
        return Loc.GetString("reagent-effect-guidebook-cure-hollowed");
    }
}
