using System;
using CoreHelper;
using ERGenerator;
using Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces;

namespace Core
{
    public class FactBuilderUtil : IFactBuilderUtil
    {
        public TK GetFact<T, TK>(DataModel ruleDataModel, string parameterName)
        {
            var strValue = ruleDataModel.LoadStringParameters(parameterName);

            //TODO check if this code is not needed 
            //if (string.IsNullOrEmpty(strValue))
            //{
            //    return default(TK);
            //}

            var examRecordValue = ExamRecordConverter.Parse<T>(strValue);
            var obj = Activator.CreateInstance<TK>();
            var field = obj as IField<T>;
            var slot = new ValueSlot<T>();
            slot.Update(examRecordValue, false);
            if (field == null) return obj;
            field.CurrentValue = slot;
            field.NewValue = slot.DeepCopy() as IValueSlot<T>;
            field.PreviousValue = slot.DeepCopy() as IValueSlot<T>;
            return obj;
        }

        public TK GetEmptyFact<T, TK>()
        {
            TK obj = Activator.CreateInstance<TK>();

            if (obj is IField<T> field)
            {
                field.CurrentValue = new ValueSlot<T>();
                field.PreviousValue = new ValueSlot<T>();
                field.NewValue = new ValueSlot<T>();
            }

            return obj;
        }
    }
}