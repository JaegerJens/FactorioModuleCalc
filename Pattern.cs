using Factorio.ModuleCalc.Receipt;

namespace Factorio.ModuleCalc.Pattern {
    public abstract class BuildPattern {
        public ReceiptBase Receipt { get; protected set; }

        public Module[] Modules { get; protected set;}
    }

    public class BeaconLinePattern: BuildPattern {
        public BeaconLinePattern(ReceiptBase receipt) {
            this.Receipt = Receipt;
            this.Modules = new Module[] {
                new ProductivityModule(3, 4),
                new Beacon(new SpeedModule(3), new SpeedModule(3), 8),
            };
        }
    }

    public class MaxBeaconPattern : BuildPattern {
        public MaxBeaconPattern(ReceiptBase receipt) {
            this.Receipt = Receipt;
            this.Modules = new Module[] {
                new ProductivityModule(3, 4),
                new Beacon(new SpeedModule(3), new SpeedModule(3), 12),
            };
        }
    }
} 