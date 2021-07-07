using RaccoonDB.Internal.Querying.Compiler;

namespace RaccoonDB.Internal.Storage
{
    public interface IRacconDbStorageReader
    {
        Table.TableInformation ExplainTable(ExplainTableModel model);
    }
}