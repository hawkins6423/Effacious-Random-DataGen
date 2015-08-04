namespace Random.Tests

type GroupAttribute (label) =
  inherit  Xunit.TraitAttribute ("Category",label)

type SkipAttribute (reason) =
  inherit  Xunit.FactAttribute()
  do base.Skip <- reason
