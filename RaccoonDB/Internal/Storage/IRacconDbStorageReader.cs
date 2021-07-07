using RaccoonDB.Internal.Querying.Compiler;

namespace RaccoonDB.Internal.Storage
{
    public interface IRacconDbStorageReader
    {
        TableInformation ExplainTable(ExplainTableModel model);
        IndexInformation ExplainIndex(ExplainIndexModel model);
    }
}