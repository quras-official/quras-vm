﻿using System;

namespace Pure.VM.Types
{
    internal class InteropInterface : StackItem
    {
        private IInteropInterface _object;

        public InteropInterface(IInteropInterface value)
        {
            this._object = value;
        }

        public override bool Equals(StackItem other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (ReferenceEquals(null, other)) return false;
            InteropInterface i = other as InteropInterface;
            if (i == null) return false;
            return _object.Equals(i._object);
        }

        public override bool GetBoolean()
        {
            return _object != null;
        }

        public override byte[] GetByteArray()
        {
            throw new NotSupportedException();
        }

        public override T GetInterface<T>()
        {
            return _object as T;
        }
    }
}
