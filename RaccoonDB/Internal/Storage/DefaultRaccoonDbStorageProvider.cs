using System;
using System.IO;
using System.Threading;
using CSharpTest.Net.Collections;
using CSharpTest.Net.Serialization;

namespace RaccoonDB.Internal.Storage
{
    public class DefaultRaccoonDbStorageProvider : IRaccoonDbStorageProvider
    {
        private readonly ReaderWriterLockSlim _readerWriterLock = new();
        private readonly RaccoonDbStorageEngine _storageEngine;

        public DefaultRaccoonDbStorageProvider(string dbDirectory)
        {
            if (!Directory.Exists(dbDirectory))
            {
                Directory.CreateDirectory(dbDirectory);
            }
            _storageEngine = new RaccoonDbStorageEngine(dbDirectory);
        }

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