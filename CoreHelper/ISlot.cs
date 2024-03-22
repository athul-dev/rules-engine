using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces;

namespace CoreHelper
{
    public interface ISlot : INotifyPropertyChanged
    {
        bool IsReactive { get; }

        ISlot DeepCopy();
    }

    public interface IValueSlot<T> : ISlot
    {
        T Value { get; }
    }

    public interface IOptionSlot<T> : ISlot
    {
        IEnumerable<T> Options { get; }
    }

    public interface IRangeSlot<T> : ISlot
    {
        MinMaxLimit<T> Range { get; }
    }

    public interface ISlotUpdate<T>
    {
        void Update(T value, bool triggerValueChanged);
    }



    public class ValueSlot<T> : IValueSlot<T>, ISlotUpdate<T>
    {
        private T val;
        public void Update(T newValue, bool triggerValueChanged)
        {
            if (val != null && val.Equals(newValue) && IsReactive)
            {
                return;
            }
            val = newValue;
            IsReactive = true;
            if (triggerValueChanged)
            {
                OnValueChanged();
            }
        }

        private void OnValueChanged()
        {
            OnPropertyChanged(nameof(Value));
        }

        public bool IsReactive { get; private set; }

        public T Value => val;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ISlot DeepCopy()
        {
            ValueSlot<T> deepCopy = new ValueSlot<T>();
            deepCopy.Update(this.Value, false);
            return deepCopy;
        }
    }



    public class OptionSlot<T> : IOptionSlot<T>, ISlotUpdate<IEnumerable<T>>
    {
        private IEnumerable<T> options;

        public OptionSlot()
        {
            options = new List<T>();
        }

        public void Update(IEnumerable<T> newOptions, bool triggerValueChanged)
        {
            IsReactive = true;
            options = newOptions;
            if (triggerValueChanged)
            {
                OnOptionsChanged();
            }
        }

        private void OnOptionsChanged()
        {
            OnPropertyChanged(nameof(Options));
        }

        public bool IsReactive { get; set; }
        public ISlot DeepCopy()
        {
            OptionSlot<T> deepCopy = new OptionSlot<T>();
            deepCopy.Update(this.Options, false);
            return deepCopy;
        }

        public IEnumerable<T> Options => options;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }



    public class RangeSlot<T> : IRangeSlot<T>, ISlotUpdate<MinMaxLimit<T>>
    {
        public RangeSlot()
        {
            Range = new MinMaxLimit<T>();
        }

        public void Update(MinMaxLimit<T> range, bool triggerValueChanged)
        {
            IsReactive = true;
            Range = range;
            if (triggerValueChanged)
            {
                OnPropertyChanged(nameof(Range));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public bool IsReactive { get; private set; }
        public ISlot DeepCopy()
        {
            RangeSlot<T> deepCopy = new RangeSlot<T>();
            deepCopy.Update(this.Range, false);
            return deepCopy;
        }

        public MinMaxLimit<T> Range { get; private set; }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}