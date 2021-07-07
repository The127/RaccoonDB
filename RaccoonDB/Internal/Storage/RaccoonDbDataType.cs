using System;
using System.Collections.Generic;

namespace RaccoonDB.Internal.Storage
{
    public enum RaccoonDbDataType
    {
        Unitialized,
        String,
        Int,
        Bool,
        Uuid,
    }

    public class StringTableFieldComparer : IComparer<TableField>
    {
        public int Compare(TableField x, TableField y) => 
            string.Compare(((string)x.Value), (string)y.Value, StringComparison.Ordinal);
    }

    public class IntTableFieldComparer : IComparer<TableField>
    {
        public int Compare(TableField x, TableField y) => 
            ((int) x.Value).CompareTo((int) y.Value);
    }

    public class BoolTableFieldComparer : IComparer<TableField>
    {
        public int Compare(TableField x, TableField y) =>
            ((bool) x.Value).CompareTo((bool) y.Value);
    }

    public class UuidTableFieldComparer : IComparer<TableField>
    {
        public int Compare(TableField x, TableField y) => 
            ((Guid) x.Value).CompareTo((Guid) y.Value);
    }

    public static class RaccoonDbDataTypeExtensions
    {
        public static RaccoonDbDataType ConvertToDbDataType(this string s) =>
            s switch
            {
                "string" => RaccoonDbDataType.String,
                "int" => RaccoonDbDataType.Int,
                "bool" => RaccoonDbDataType.Bool,
                "uuid" => RaccoonDbDataType.Uuid,
                _ => throw new RacconDbSchemaException($"unknown database type '{s}'")
            };

        public static IComparer<TableField> GetComparer(this RaccoonDbDataType dataType) =>
            dataType switch
            {
                RaccoonDbDataType.String => new StringTableFieldComparer(),
                RaccoonDbDataType.Int => new IntTableFieldComparer(),
                RaccoonDbDataType.Bool => new BoolTableFieldComparer(),
                RaccoonDbDataType.Uuid => new UuidTableFieldComparer(),
                _ => throw new ArgumentOutOfRangeException(nameof(dataType), dataType, null)
            };
    } 
}