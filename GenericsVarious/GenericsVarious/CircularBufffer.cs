using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsVarious
{
    public class CircularBufffer<T>
    {
        private int _start;
        private int _end;
        private T[] _circularBuffer;

        public CircularBufffer() : this(capacity: 10)
        {

        }

        public CircularBufffer(int capacity)
        {
            _start = 0;
            _end = 0;
            _circularBuffer = new T[capacity + 1];
        }

        public int BufferSize 
        {
            get
            {
                return _circularBuffer.Length;
            }
         }

        public void write ( T value )
        {
            _circularBuffer[_end] = value;
            _end = (_end + 1) % _circularBuffer.Length;
            if (_start == _end)
            {
                _start = (_start + 1) % _circularBuffer.Length;
            }

        }
        public T read()
        {
            T value = _circularBuffer[_start];
            _start = (_start + 1) % _circularBuffer.Length;
            return value;
        }
            
    }
}
