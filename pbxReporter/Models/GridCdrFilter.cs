// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using pbxReporter.Models;
//
//    var gridCdrFilter = GridCdrFilter.FromJson(jsonString);

namespace pbxReporter.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GridCdrFilter
    {


        [JsonProperty("filterGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<FilterGroup> FilterGroups { get; set; }

        [JsonProperty("filterscount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Filterscount { get; set; }

        [JsonProperty("groupscount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Groupscount { get; set; }


        [JsonProperty("pagenum", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pagenum { get; set; }

        [JsonProperty("pagesize", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pagesize { get; set; }

        [JsonProperty("recordstartindex", NullValueHandling = NullValueHandling.Ignore)]
        public long? Recordstartindex { get; set; }

        [JsonProperty("recordendindex", NullValueHandling = NullValueHandling.Ignore)]
        public long? Recordendindex { get; set; }
    }

    public partial class FilterGroup
    {
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Filter> Filters { get; set; }
    }

    public partial class Filter
    {
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }

        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public Operator? Operator { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum? Type { get; set; }
    }

    public enum Operator { And, Or };

    public enum TypeEnum { Datefilter, Numericfilter, Stringfilter };

    public partial class GridCdrFilter
    {
        public static GridCdrFilter FromJson(string json) => JsonConvert.DeserializeObject<GridCdrFilter>(json, pbxReporter.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GridCdrFilter self) => JsonConvert.SerializeObject(self, pbxReporter.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                OperatorConverter.Singleton,
                TypeEnumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class OperatorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Operator) || t == typeof(Operator?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "and":
                    return Operator.And;
                case "or":
                    return Operator.Or;
            }
            throw new Exception("Cannot unmarshal type Operator");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Operator)untypedValue;
            switch (value)
            {
                case Operator.And:
                    serializer.Serialize(writer, "and");
                    return;
                case Operator.Or:
                    serializer.Serialize(writer, "or");
                    return;
            }
            throw new Exception("Cannot marshal type Operator");
        }

        public static readonly OperatorConverter Singleton = new OperatorConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "datefilter":
                    return TypeEnum.Datefilter;
                case "numericfilter":
                    return TypeEnum.Numericfilter;
                case "stringfilter":
                    return TypeEnum.Stringfilter;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Datefilter:
                    serializer.Serialize(writer, "datefilter");
                    return;
                case TypeEnum.Numericfilter:
                    serializer.Serialize(writer, "numericfilter");
                    return;
                case TypeEnum.Stringfilter:
                    serializer.Serialize(writer, "stringfilter");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
