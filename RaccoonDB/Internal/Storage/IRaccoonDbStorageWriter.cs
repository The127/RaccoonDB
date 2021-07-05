using RaccoonDB.Internal.Querying.Compiler;

namespace RaccoonDB.Internal.Storage
{
    public interface IRaccoonDbStorageWriter : IRacconDbStorageReader
    {
        void CreateTable(CreateTableModel model);
        void AddColumn(AddColumnModel model);
        void DropColumn(DropColumnModel model);
        void AlterColumn(AlterColumnModel model);
        void DropTable(DropTableModel model);
        void TruncateTable(TruncateModel model);
        void CreateIndex(CreateIndexModel model);
        void DropIndex(DropIndexModel model);
    }
}