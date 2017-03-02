using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.Npgsql
{
    /// <summary>
    /// Interval Type.
    /// </summary>
    [EnumToStringConverter]
    public enum IntervalType
    {
        /// <summary>
        /// YEAR
        /// </summary>
        Year,

        /// <summary>
        /// MONTH
        /// </summary>
        Month,

        /// <summary>
        /// DAY
        /// </summary>
        Day,

        /// <summary>
        /// HOUR
        /// </summary>
        Hour,

        /// <summary>
        /// MINUTE
        /// </summary>
        Minute,

        /// <summary>
        /// SECOND
        /// </summary>
        Second,

        /// <summary>
        /// YEAR TO MONTH
        /// </summary>
        [FieldSqlName("YEAR TO MONTH")]
        YearToMonth,

        /// <summary>
        /// DAY TO HOUR
        /// </summary>
        [FieldSqlName("DAY TO HOUR")]
        DayToHour,

        /// <summary>
        /// DAY TO MINUTE
        /// </summary>
        [FieldSqlName("DAY TO MINUTE")]
        DayToMinute,

        /// <summary>
        /// DAY TO SECOND
        /// </summary>
        [FieldSqlName("DAY TO SECOND")]
        DayToSecond,

        /// <summary>
        /// HOUR TO MINUTE
        /// </summary>
        [FieldSqlName("HOUR TO MINUTE")]
        HOURToMinute,

        /// <summary>
        /// HOUR TO SECOND
        /// </summary>
        [FieldSqlName("HOUR TO SECOND")]
        HOURToSecond,

        /// <summary>
        /// MINUTE TO SECOND
        /// </summary>
        [FieldSqlName("MINUTE TO SECOND")]
        MinuteToSecond,
    }
}
