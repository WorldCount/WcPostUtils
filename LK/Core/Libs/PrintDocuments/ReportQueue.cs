using System;
using System.Collections.Generic;

namespace LK.Core.Libs.PrintDocuments
{
    public class ReportQueue<T>
    {
        private readonly Queue<T> _queue = new Queue<T>();

        public event EventHandler Changed;
        public event EventHandler AddedObject;
        public event EventHandler RemoveObject;

        protected virtual void OnChanged()
        {
            if (Changed != null) Changed(this, EventArgs.Empty);
        }

        protected virtual void OnAdded()
        {
            if (AddedObject != null) AddedObject(this, EventArgs.Empty);
        }

        protected virtual void OnRemoved()
        {
            if (RemoveObject != null) RemoveObject(this, EventArgs.Empty);
        }

        public int Count => _queue.Count;

        public virtual void Enqueue(T item)
        {
            _queue.Enqueue(item);
            OnChanged();
            OnAdded();
        }

        public virtual T Dequeue()
        {
            T item = _queue.Dequeue();
            OnChanged();
            OnRemoved();
            return item;
        }
    }
}
