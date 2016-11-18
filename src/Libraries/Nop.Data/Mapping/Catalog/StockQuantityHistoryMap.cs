using Nop.Core.Domain.Catalog;

namespace Nop.Data.Mapping.Catalog
{
    public partial class StockQuantityHistoryMap : NopEntityTypeConfiguration<StockQuantityHistory>
    {
        public StockQuantityHistoryMap()
        {
            this.ToTable("StockQuantityHistory");
            this.HasKey(historyEntry => historyEntry.Id);

            this.HasRequired(historyEntry => historyEntry.Product)
                .WithMany()
                .HasForeignKey(historyEntry => historyEntry.ProductId);

            this.HasOptional(historyEntry => historyEntry.Combination)
                .WithMany()
                .HasForeignKey(historyEntry => historyEntry.CombinationId);

            this.HasOptional(historyEntry => historyEntry.Warehouse)
                .WithMany()
                .HasForeignKey(historyEntry => historyEntry.WarehouseId);
        }
    }
}