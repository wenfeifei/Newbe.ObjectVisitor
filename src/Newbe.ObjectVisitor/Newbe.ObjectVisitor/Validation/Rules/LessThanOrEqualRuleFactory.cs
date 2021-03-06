﻿using System;
using System.Collections.Generic;

namespace Newbe.ObjectVisitor.Validation
{
    internal static class LessThanOrEqualRuleFactory
    {
        public static LessThanOrEqualRule<T, TValue> Create<T, TValue>(TValue max)
            where TValue : IComparable<TValue>
        {
            return new LessThanOrEqualRule<T, TValue>(max, RuleExpressionHelper.Less(max, false));
        }
        
        public static LessThanOrEqualRule<T, TValue?> CreateNullable<T, TValue>(TValue max)
            where TValue : struct, IComparable<TValue>
        {
            return new LessThanOrEqualRule<T, TValue?>(max, RuleExpressionHelper.LessNullable(max, false));
        }

        public static LessThanOrEqualRule<T, TValue> Create<T, TValue>(TValue max, IComparer<TValue> comparer)
        {
            return new LessThanOrEqualRule<T, TValue>(max, RuleExpressionHelper.Less(max, false, comparer));
        }
    }
}