using Factorio.ModuleCalc.Resources;

namespace Factorio.ModuleCalc {
    public abstract class Module: Item {
        public Module(ItemType type, int count = 1): base(type, count) {}

        public int Level { get; protected set; }

        public int EnergyConsumption { get; protected set; }

        public int Speed { get; protected set; }

        public int Productivity { get; protected set; }
    }

    public class SpeedModule: Module {
        public SpeedModule(int level, int count = 1): base(ItemType.SpeedModule, count) {
            this.Level = level;
            this.Productivity = 0;
            switch (level) {
                case 3:
                    this.EnergyConsumption = 70;
                    this.Speed = 50;
                    break;
                case 2:
                    this.EnergyConsumption = 60;
                    this.Speed = 30;
                    break;
                default:
                    this.Level = 1;
                    this.EnergyConsumption = 50;
                    this.Speed = 20;
                    break;
            }
        }
    }

    public class ProductivityModule: Module {
        public ProductivityModule(int level, int count = 1): base(ItemType.ProductivityModule, count) {
            this.Level = level;
            switch (level) {
                case 3:
                    this.EnergyConsumption = 80;
                    this.Speed = -15;
                    this.Productivity = 10;
                    break;
                case 2:
                    this.EnergyConsumption = 60;
                    this.Speed = -10;
                    this.Productivity = 6;
                    break;
                default:
                    this.Level = 1;
                    this.EnergyConsumption = 40;
                    this.Speed = -5;
                    this.Productivity = 4;
                    break;
            }
        }
    }
}