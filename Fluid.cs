namespace Factorio.ModuleCalc.Resources {
    public enum FluidType {
        Water,
        CrudeOil,
        PetroleumGas,
        LightOil,
        HeavyOil,
        Lubricant,
        SulfuricAcid,
    }

    public class Fluid: FactorioResource {
        public Fluid(FluidType type, int amount) {
            this.Type = type;
            this.Amount = amount;
        }

        public FluidType Type { get; private set; }

        public int Amount { get; set; }
    }
}