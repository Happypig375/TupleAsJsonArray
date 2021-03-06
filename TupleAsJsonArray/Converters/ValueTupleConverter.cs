﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TupleAsJsonArray
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1">The type of the value tuple's only element.</typeparam>
    public class ValueTupleConverter<T1> : TupleConverterBase<ValueTuple<T1>>
    {
        public override ValueTuple<T1> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            reader.Read();
            T1 value = ReadValue<T1>(ref reader, options);

            reader.Read(); // End of Array
            return new ValueTuple<T1>(value);
        }

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            writer.WriteEndArray();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1">The type of the value tuple's first element.</typeparam>
    /// <typeparam name="T2">The type of the value tuple's second element.</typeparam>
    public class ValueTupleConverter<T1, T2> : TupleConverterBase<ValueTuple<T1, T2>>
    {
        public override ValueTuple<T1, T2> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            T1 t1;
            T2 t2;

            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            reader.Read();
            t1 = ReadValue<T1>(ref reader, options);

            reader.Read();
            t2 = ReadValue<T2>(ref reader, options);

            if (!reader.Read() || reader.TokenType != JsonTokenType.EndArray)
            {
                throw new JsonException();
            }

            return (t1, t2);
        }

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1, T2> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            WriteValue(writer, value.Item2, options);
            writer.WriteEndArray();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1">The type of the value tuple's first element.</typeparam>
    /// <typeparam name="T2">The type of the value tuple's second element.</typeparam>
    /// <typeparam name="T3">The type of the value tuple's third element.</typeparam>
    public class ValueTupleConverter<T1, T2, T3> : TupleConverterBase<ValueTuple<T1, T2, T3>>
    {
        public override ValueTuple<T1, T2, T3> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            T1 t1;
            T2 t2;
            T3 t3;

            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            reader.Read();
            t1 = ReadValue<T1>(ref reader, options);

            reader.Read();
            t2 = ReadValue<T2>(ref reader, options);

            reader.Read();
            t3 = ReadValue<T3>(ref reader, options);

            if (!reader.Read() || reader.TokenType != JsonTokenType.EndArray)
            {
                throw new JsonException();
            }

            return (t1, t2, t3);
        }

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1, T2, T3> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            WriteValue(writer, value.Item2, options);
            WriteValue(writer, value.Item3, options);
            writer.WriteEndArray();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1">The type of the value tuple's first element.</typeparam>
    /// <typeparam name="T2">The type of the value tuple's second element.</typeparam>
    /// <typeparam name="T3">The type of the value tuple's third element.</typeparam>
    /// <typeparam name="T4">The type of the value tuple's fourth element.</typeparam>
    public class ValueTupleConverter<T1, T2, T3, T4> : TupleConverterBase<ValueTuple<T1, T2, T3, T4>>
    {
        public override ValueTuple<T1, T2, T3, T4> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            T1 t1;
            T2 t2;
            T3 t3;
            T4 t4;

            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            reader.Read();
            t1 = ReadValue<T1>(ref reader, options);

            reader.Read();
            t2 = ReadValue<T2>(ref reader, options);

            reader.Read();
            t3 = ReadValue<T3>(ref reader, options);

            reader.Read();
            t4 = ReadValue<T4>(ref reader, options);


            if (!reader.Read() || reader.TokenType != JsonTokenType.EndArray)
            {
                throw new JsonException();
            }

            return (t1, t2, t3, t4);
        }

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1, T2, T3, T4> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            WriteValue(writer, value.Item2, options);
            WriteValue(writer, value.Item3, options);
            WriteValue(writer, value.Item4, options);
            writer.WriteEndArray();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1">The type of the value tuple's first element.</typeparam>
    /// <typeparam name="T2">The type of the value tuple's second element.</typeparam>
    /// <typeparam name="T3">The type of the value tuple's third element.</typeparam>
    /// <typeparam name="T4">The type of the value tuple's fourth element.</typeparam>
    /// <typeparam name="T5">The type of the value tuple's fifth element.</typeparam>
    public class ValueTupleConverter<T1, T2, T3, T4, T5> : TupleConverterBase<ValueTuple<T1, T2, T3, T4, T5>>
    {
        public override ValueTuple<T1, T2, T3, T4, T5> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            T1 t1;
            T2 t2;
            T3 t3;
            T4 t4;
            T5 t5;

            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            reader.Read();
            t1 = ReadValue<T1>(ref reader, options);

            reader.Read();
            t2 = ReadValue<T2>(ref reader, options);

            reader.Read();
            t3 = ReadValue<T3>(ref reader, options);

            reader.Read();
            t4 = ReadValue<T4>(ref reader, options);

            reader.Read();
            t5 = ReadValue<T5>(ref reader, options);

            if (!reader.Read() || reader.TokenType != JsonTokenType.EndArray)
            {
                throw new JsonException();
            }

            return (t1, t2, t3, t4, t5);
        }

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1, T2, T3, T4, T5> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            WriteValue(writer, value.Item2, options);
            WriteValue(writer, value.Item3, options);
            WriteValue(writer, value.Item4, options);
            WriteValue(writer, value.Item5, options);
            writer.WriteEndArray();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1">The type of the value tuple's first element.</typeparam>
    /// <typeparam name="T2">The type of the value tuple's second element.</typeparam>
    /// <typeparam name="T3">The type of the value tuple's third element.</typeparam>
    /// <typeparam name="T4">The type of the value tuple's fourth element.</typeparam>
    /// <typeparam name="T5">The type of the value tuple's fifth element.</typeparam>
    /// <typeparam name="T6">The type of the value tuple's sixth element.</typeparam>
    public class ValueTupleConverter<T1, T2, T3, T4, T5, T6> : TupleConverterBase<ValueTuple<T1, T2, T3, T4, T5, T6>>
    {
        public override ValueTuple<T1, T2, T3, T4, T5, T6> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            T1 t1;
            T2 t2;
            T3 t3;
            T4 t4;
            T5 t5;
            T6 t6;

            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            reader.Read();
            t1 = ReadValue<T1>(ref reader, options);

            reader.Read();
            t2 = ReadValue<T2>(ref reader, options);

            reader.Read();
            t3 = ReadValue<T3>(ref reader, options);

            reader.Read();
            t4 = ReadValue<T4>(ref reader, options);

            reader.Read();
            t5 = ReadValue<T5>(ref reader, options);

            reader.Read();
            t6 = ReadValue<T6>(ref reader, options);

            if (!reader.Read() || reader.TokenType != JsonTokenType.EndArray)
            {
                throw new JsonException();
            }

            return (t1, t2, t3, t4, t5, t6);
        }

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1, T2, T3, T4, T5, T6> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            WriteValue(writer, value.Item2, options);
            WriteValue(writer, value.Item3, options);
            WriteValue(writer, value.Item4, options);
            WriteValue(writer, value.Item5, options);
            WriteValue(writer, value.Item6, options);
            writer.WriteEndArray();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1">The type of the value tuple's first element.</typeparam>
    /// <typeparam name="T2">The type of the value tuple's second element.</typeparam>
    /// <typeparam name="T3">The type of the value tuple's third element.</typeparam>
    /// <typeparam name="T4">The type of the value tuple's fourth element.</typeparam>
    /// <typeparam name="T5">The type of the value tuple's fifth element.</typeparam>
    /// <typeparam name="T6">The type of the value tuple's sixth element.</typeparam>
    /// <typeparam name="T7">The type of the value tuple's seventh element.</typeparam>
    public class ValueTupleConverter<T1, T2, T3, T4, T5, T6, T7> : TupleConverterBase<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>
    {
        public override ValueTuple<T1, T2, T3, T4, T5, T6, T7> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            T1 t1;
            T2 t2;
            T3 t3;
            T4 t4;
            T5 t5;
            T6 t6;
            T7 t7;

            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            reader.Read();
            t1 = ReadValue<T1>(ref reader, options);

            reader.Read();
            t2 = ReadValue<T2>(ref reader, options);

            reader.Read();
            t3 = ReadValue<T3>(ref reader, options);

            reader.Read();
            t4 = ReadValue<T4>(ref reader, options);

            reader.Read();
            t5 = ReadValue<T5>(ref reader, options);

            reader.Read();
            t6 = ReadValue<T6>(ref reader, options);

            reader.Read();
            t7 = ReadValue<T7>(ref reader, options);

            if (!reader.Read() || reader.TokenType != JsonTokenType.EndArray)
            {
                throw new JsonException();
            }

            return (t1, t2, t3, t4, t5, t6, t7);
        }

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1, T2, T3, T4, T5, T6, T7> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            WriteValue(writer, value.Item2, options);
            WriteValue(writer, value.Item3, options);
            WriteValue(writer, value.Item4, options);
            WriteValue(writer, value.Item5, options);
            WriteValue(writer, value.Item6, options);
            WriteValue(writer, value.Item7, options);
            writer.WriteEndArray();
        }
    }
}
