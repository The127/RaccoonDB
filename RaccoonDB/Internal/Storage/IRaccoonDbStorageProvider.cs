using System;

namespace RaccoonDB.Internal.Storage
{
    public interface IRaccoonDbStorageProvider
    {
        void Read(Action<IRacconDbStorageReader> readAction);
        void Write(Action<IRaccoonDbStorageWriter> writeAction);
    }
}