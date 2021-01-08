using Factorio.ModuleCalc.Resources;

namespace Factorio.ModuleCalc.Receipt {
    public abstract class ReceiptBase {
        public FactorioResource[] Input { get; protected set; }

        public FactorioResource Output { get; protected set; }

        public decimal CraftTime { get; protected set; }
    }

    public class ElectronicCircuitReceipt: ReceiptBase {
        public ElectronicCircuitReceipt() {
            this.Output = new Item(ItemType.ElectronicCircuit, 1);
            this.Input = new [] {
                new Item(ItemType.CopperCable, 3),
                new Item(ItemType.IronPlate, 1),
            };
            this.CraftTime = 0.5M;
        }
    }

    public class AdvanceCircuitReceipt: ReceiptBase {
        public AdvanceCircuitReceipt() {
            this.Output = new Item(ItemType.AdvancedCircuit, 1);
            this.Input = new [] {
                new Item(ItemType.PlasticBar, 2),
                new Item(ItemType.CopperCable, 4),
                new Item(ItemType.ElectronicCircuit, 2),
            };
            this.CraftTime = 6;
        }
    }

    public class ProcessingUnitReceipt: ReceiptBase {
        public ProcessingUnitReceipt() {
            this.Output = new Item(ItemType.ProcessingUnit, 1);
            this.Input = new FactorioResource[] {
                new Item(ItemType.ElectronicCircuit, 20),
                new Item(ItemType.AdvancedCircuit, 2),
                new Fluid(FluidType.SulfuricAcid, 5),
            };
            this.CraftTime = 10;
        }
    }
}