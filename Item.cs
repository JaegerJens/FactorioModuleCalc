namespace Factorio.ModuleCalc.Resources {
     public interface FactorioResource { }

    public enum ItemType {
        IronOre,
        IronPlate,
        SteelPlate,
        CopperOre,
        CopperPlate,
        CopperCable,
        PlasticBar,
        ElectronicCircuit,
        AdvancedCircuit,
        ProcessingUnit,
        SpeedModule,
        ProductivityModule,
    }

    public class Item: FactorioResource {
        public Item(ItemType type, int count = 1) {
            this.Type = type;
            this.Count = 1;
        }

        public ItemType Type { get; private set; }

        public int Count { get; set; }
    }
}