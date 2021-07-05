using System;
using System.Threading;
using CSharpTest.Net.Collections;
using CSharpTest.Net.Serialization;

namespace RaccoonDB.Internal.Storage
{
    public class DefaultRaccoonDbStorageProvider : IRaccoonDbStorageProvider
    {
        private ReaderWriterLockSlim _readerWriterLock = new();
        private RacconDbStorageEngine _storageEngine = new();

        public void Read(Action<IRacconDbStorageReader> readAction)
        {
            _readerWriterLock.EnterReadLock();
            try
            {
                readAction.Invoke(_storageEngine);
            }
            finally
            {
                _readerWriterLock.ExitReadLock();
            }
        }

        public void Write(Action<IRaccoonDbStorageWriter> writeAction)
        {
            _readerWriterLock.EnterWriteLock();
            try
            {
                writeAction.Invoke(_storageEngine);
            }
            finally
            {
                _readerWriterLock.ExitWriteLock();
            }
        }
    }
}