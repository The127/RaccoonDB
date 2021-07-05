using RaccoonDB.Internal.Querying.Compiler;

namespace RaccoonDB.Internal.Storage
{
    public class RacconDbStorageEngine : IRaccoonDbStorageWriter
    {
        public void CreateTable(CreateTableModel model)
        {
            throw new System.NotImplementedException();
        }

        public void AddColumn(AddColumnModel model)
        {
            throw new System.NotImplementedException();
        }

        public void DropColumn(DropColumnModel model)
        {
            throw new System.NotImplementedException();
        }

        public void AlterColumn(AlterColumnModel model)
        {
            throw new System.NotImplementedException();
        }

        public void DropTable(DropTableModel model)
        {
            throw new System.NotImplementedException();
        }

        public void TruncateTable(TruncateModel model)
        {
            throw new System.NotImplementedException();
        }

        public void CreateIndex(CreateIndexModel model)
        {
            throw new System.NotImplementedException();
        }

        public void DropIndex(DropIndexModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}