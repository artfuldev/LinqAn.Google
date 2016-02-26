using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace LinqAn.Google.Linq.Core
{
    internal static class ReflectionExtensions
    {
        private static readonly HashSet<Type> IntegralTypes = new HashSet<Type>
        {
            typeof (sbyte),
            typeof (short),
            typeof (int),
            typeof (long),
            typeof (byte),
            typeof (ushort),
            typeof (uint),
            typeof (ulong)
        };

        public static bool IsAssignableFrom(this Type type, Type other)
        {
            return type.GetTypeInfo().IsAssignableFrom(other.GetTypeInfo());
        }

        public static Type FindIEnumerable(this Type seqType)
        {
            if (seqType == null || seqType == typeof (string))
                return null;
            if (seqType.IsArray)
                return typeof (IEnumerable<>).MakeGenericType(seqType.GetElementType());
            if (seqType.GetTypeInfo().IsGenericType)
            {
                foreach (var arg in seqType.GetGenericArguments())
                {
                    var ienum = typeof (IEnumerable<>).MakeGenericType(arg);
                    if (ienum.IsAssignableFrom(seqType))
                    {
                        return ienum;
                    }
                }
            }
            var ifaces = seqType.GetInterfaces().ToArray();
            if (ifaces != null && ifaces.Length > 0)
            {
                foreach (var ienum in ifaces.Select(FindIEnumerable).Where(ienum => ienum != null))
                {
                    return ienum;
                }
            }
            if (seqType.GetTypeInfo().BaseType != null && seqType.GetTypeInfo().BaseType != typeof (object))
            {
                return seqType.GetTypeInfo().BaseType.FindIEnumerable();
            }
            return null;
        }

        public static Type GetElementType(this Type seqType)
        {
            var ienum = seqType.FindIEnumerable();
            return ienum == null ? seqType : ienum.GetGenericArguments()[0];
        }

        public static Type[] GetGenericArguments(this Type type)
        {
            return type.GetTypeInfo().GetGenericTypeDefinition().GenericTypeArguments;
        }

        public static IEnumerable<Type> GetInterfaces(this Type type)
        {
            return type.GetTypeInfo().ImplementedInterfaces;
        }

        public static bool IsNullableType(this Type type)
        {
            return type != null && type.GetTypeInfo().IsGenericType &&
                   type.GetGenericTypeDefinition() == typeof (Nullable<>);
        }

        public static bool IsNullAssignable(this Type type)
        {
            return !type.GetTypeInfo().IsValueType || IsNullableType(type);
        }

        public static Type GetNonNullableType(this Type type)
        {
            return IsNullableType(type) ? type.GetGenericArguments()[0] : type;
        }

        public static Type GetNullAssignableType(this Type type)
        {
            if (!IsNullAssignable(type))
            {
                return typeof (Nullable<>).MakeGenericType(type);
            }
            return type;
        }

        public static ConstantExpression GetNullConstant(this Type type)
        {
            return Expression.Constant(null, GetNullAssignableType(type));
        }

        public static Type GetMemberType(this MemberInfo mi)
        {
            var fi = mi as FieldInfo;
            if (fi != null) return fi.FieldType;
            var pi = mi as PropertyInfo;
            if (pi != null) return pi.PropertyType;
            var ei = mi as EventInfo;
            if (ei != null) return ei.EventHandlerType;
            var meth = mi as MethodInfo; // property getters really
            return meth?.ReturnType;
        }

        public static object GetDefault(this Type type)
        {
            var isNullable = !type.GetTypeInfo().IsValueType || type.IsNullableType();
            return !isNullable ? Activator.CreateInstance(type) : null;
        }

        public static bool IsInteger(this Type type)
        {
            return IntegralTypes.Contains(GetNonNullableType(type));
        }

        public static object GetValue(this MemberInfo member, object obj)
        {
            return (member as PropertyInfo)?.GetValue(obj);
        }
    }
}