using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.Npgsql
{
    /// <summary>
    /// Data type.
    /// It can only be used within methods of the LambdicSql.Db class.
    /// </summary>
    public static class DataType
    {
        /// <summary>
        /// BIGINT
        /// </summary>
        /// <returns>BIGINT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement BigInt() { throw new InvalitContextException(nameof(BigInt)); }

        /// <summary>
        /// BIGSERIAL
        /// </summary>
        /// <returns>BIGSERIAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement BigSerial() { throw new InvalitContextException(nameof(BigSerial)); }

        /// <summary>
        /// BIT
        /// </summary>
        /// <returns>BIT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Bit() { throw new InvalitContextException(nameof(Bit)); }

        /// <summary>
        /// BIT
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>BIT</returns>
        [FuncStyleConverter]
        public static DataTypeElement Bit(int n) { throw new InvalitContextException(nameof(Bit)); }

        /// <summary>
        /// BIT VARYING
        /// </summary>
        /// <returns>BIT VARYING</returns>
        [ClauseStyleConverter(Name = "BIT VARYING")]
        public static DataTypeElement BitVarying() { throw new InvalitContextException(nameof(BitVarying)); }

        /// <summary>
        /// BIT VARYING
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>BIT VARYING</returns>
        [FuncStyleConverter(Name = "BIT VARYING")]
        public static DataTypeElement BitVarying(int n) { throw new InvalitContextException(nameof(BitVarying)); }

        /// <summary>
        /// BOOLEAN
        /// </summary>
        /// <returns>BOOLEAN</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Boolean() { throw new InvalitContextException(nameof(Boolean)); }

        /// <summary>
        /// BOX
        /// </summary>
        /// <returns>BOX</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Box() { throw new InvalitContextException(nameof(Box)); }

        /// <summary>
        /// BYTEA
        /// </summary>
        /// <returns>BYTEA</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Bytea() { throw new InvalitContextException(nameof(Bytea)); }

        /// <summary>
        /// CHAR
        /// </summary>
        /// <returns>CHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Char() { throw new InvalitContextException(nameof(Char)); }

        /// <summary>
        /// CHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>CHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement Char(int n) { throw new InvalitContextException(nameof(Char)); }

        /// <summary>
        /// CHARACTER
        /// </summary>
        /// <returns>CHARACTER</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Character() { throw new InvalitContextException(nameof(Character)); }

        /// <summary>
        /// CHARACTER
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>CHARACTER</returns>
        [FuncStyleConverter]
        public static DataTypeElement Character(int n) { throw new InvalitContextException(nameof(Character)); }

        /// <summary>
        /// CHARACTER VARYING
        /// </summary>
        /// <returns>CHARACTER VARYING</returns>
        [ClauseStyleConverter(Name = "CHARACTER VARYING")]
        public static DataTypeElement CharacterVarying() { throw new InvalitContextException(nameof(CharacterVarying)); }

        /// <summary>
        /// CHARACTER VARYING
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>CHARACTER VARYING</returns>
        [FuncStyleConverter(Name = "CHARACTER VARYING")]
        public static DataTypeElement CharacterVarying(int n) { throw new InvalitContextException(nameof(CharacterVarying)); }

        /// <summary>
        /// CIDR
        /// </summary>
        /// <returns>CIDR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Cidr() { throw new InvalitContextException(nameof(Cidr)); }

        /// <summary>
        /// CIRCLE
        /// </summary>
        /// <returns>CIRCLE</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Circle() { throw new InvalitContextException(nameof(Circle)); }

        /// <summary>
        /// DATE
        /// </summary>
        /// <returns>DATE</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Date() { throw new InvalitContextException(nameof(Date)); }

        /// <summary>
        /// DECIMAL
        /// </summary>
        /// <returns>DECIMAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Decimal() { throw new InvalitContextException(nameof(Decimal)); }

        /// <summary>
        /// DECIMAL
        /// </summary>
        /// <param name="precision">precision</param>
        /// <returns>DECIMAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Decimal(int precision) { throw new InvalitContextException(nameof(Decimal)); }

        /// <summary>
        /// DECIMAL
        /// </summary>
        /// <param name="precision">precision</param>
        /// <param name="scale">scale</param>
        /// <returns>DECIMAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Decimal(int precision, int scale) { throw new InvalitContextException(nameof(Decimal)); }

        /// <summary>
        /// DOUBLE PRECISION
        /// </summary>
        /// <returns>DOUBLE PRECISION</returns>
        [ClauseStyleConverter(Name = "DOUBLE PRECISION")]
        public static DataTypeElement DoublePrecision() { throw new InvalitContextException(nameof(DoublePrecision)); }

        /// <summary>
        /// INET
        /// </summary>
        /// <returns>INET</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Inet() { throw new InvalitContextException(nameof(Inet)); }

        /// <summary>
        /// INT
        /// </summary>
        /// <returns>INT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Int() { throw new InvalitContextException(nameof(Int)); }

        /// <summary>
        /// INTEGER
        /// </summary>
        /// <returns>INTEGER</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Integer() { throw new InvalitContextException(nameof(Integer)); }

        /// <summary>
        /// INTERVAL
        /// </summary>
        /// <returns>INTERVAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Interval() { throw new InvalitContextException(nameof(Interval)); }

        /// <summary>
        /// INTERVAL.
        /// </summary>
        /// <param name="p">accuracy.</param>
        /// <returns>INTERVAL.</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Interval(int p) { throw new InvalitContextException(nameof(Interval)); }

        /// <summary>
        /// INTERVAL.
        /// </summary>
        /// <param name="type">type.</param>
        /// <returns>INTERVAL.</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Interval(IntervalType type) { throw new InvalitContextException(nameof(Interval)); }

        /// <summary>
        /// INTERVAL.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="p">accuracy.</param>
        /// <returns>INTERVAL.</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Interval(IntervalType type, int p) { throw new InvalitContextException(nameof(Interval)); }

        /// <summary>
        /// JSON
        /// </summary>
        /// <returns>JSON</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Json() { throw new InvalitContextException(nameof(Json)); }

        /// <summary>
        /// JSONB
        /// </summary>
        /// <returns>JSONB</returns>
        [ClauseStyleConverter]
        public static DataTypeElement JsonB() { throw new InvalitContextException(nameof(JsonB)); }

        /// <summary>
        /// LINE
        /// </summary>
        /// <returns>LINE</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Line() { throw new InvalitContextException(nameof(Line)); }

        /// <summary>
        /// LSEG
        /// </summary>
        /// <returns>LSEG</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Lseg() { throw new InvalitContextException(nameof(Lseg)); }

        /// <summary>
        /// MACADDR
        /// </summary>
        /// <returns>MACADDR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement MacAddr() { throw new InvalitContextException(nameof(MacAddr)); }

        /// <summary>
        /// MONEY
        /// </summary>
        /// <returns>MONEY</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Money() { throw new InvalitContextException(nameof(Money)); }

        /// <summary>
        /// NUMERIC
        /// </summary>
        /// <returns>NUMERIC</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Numeric() { throw new InvalitContextException(nameof(Numeric)); }

        /// <summary>
        /// NUMERIC
        /// </summary>
        /// <param name="precision">precision</param>
        /// <returns>NUMERIC</returns>
        [FuncStyleConverter]
        public static DataTypeElement Numeric(int precision) { throw new InvalitContextException(nameof(Numeric)); }

        /// <summary>
        /// NUMERIC
        /// </summary>
        /// <param name="precision">precision</param>
        /// <param name="scale">scale</param>
        /// <returns>NUMERIC</returns>
        [FuncStyleConverter]
        public static DataTypeElement Numeric(int precision, int scale) { throw new InvalitContextException(nameof(Numeric)); }

        /// <summary>
        /// PATH
        /// </summary>
        /// <returns>PATH</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Path() { throw new InvalitContextException(nameof(Path)); }

        /// <summary>
        /// PG_LSN
        /// </summary>
        /// <returns>PG_LSN</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Pg_Lsn() { throw new InvalitContextException(nameof(Pg_Lsn)); }

        /// <summary>
        /// POINT
        /// </summary>
        /// <returns>POINT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Point() { throw new InvalitContextException(nameof(Point)); }

        /// <summary>
        /// POLYGON
        /// </summary>
        /// <returns>POLYGON</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Polygon() { throw new InvalitContextException(nameof(Polygon)); }

        /// <summary>
        /// REAL
        /// </summary>
        /// <returns>REAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Real() { throw new InvalitContextException(nameof(Real)); }

        /// <summary>
        /// SERIAL
        /// </summary>
        /// <returns>SERIAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Serial() { throw new InvalitContextException(nameof(Serial)); }
        
        /// <summary>
        /// SMALLINT
        /// </summary>
        /// <returns>SMALLINT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement SmallInt() { throw new InvalitContextException(nameof(SmallInt)); }

        /// <summary>
        /// SMALLSERIAL
        /// </summary>
        /// <returns>SMALLSERIAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement SmallSerial() { throw new InvalitContextException(nameof(SmallSerial)); }

        /// <summary>
        /// TEXT
        /// </summary>
        /// <returns>TEXT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Text() { throw new InvalitContextException(nameof(Text)); }

        /// <summary>
        /// TIME
        /// </summary>
        /// <returns>TIME</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Time() { throw new InvalitContextException(nameof(Time)); }

        /// <summary>
        /// TIME
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>TIME</returns>
        [FuncStyleConverter]
        public static DataTypeElement Time(int n) { throw new InvalitContextException(nameof(Time)); }
        
        /// <summary>
        /// TIME WITH TIME ZONE
        /// </summary>
        /// <returns>TIME</returns>
        [ClauseStyleConverter(Name = "TIME WITH TIME ZONE")]
        public static DataTypeElement TimeWithTimeZone() { throw new InvalitContextException(nameof(TimeWithTimeZone)); }

        /// <summary>
        /// TIME WITH TIME ZONE
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>TIME</returns>
        [MethodFormatConverter(Format = "TIME([0]) WITH TIME ZONE|")]
        public static DataTypeElement TimeWithTimeZone(int n) { throw new InvalitContextException(nameof(TimeWithTimeZone)); }

        /// <summary>
        /// TIMESTAMP
        /// </summary>
        /// <returns>TIMESTAMP</returns>
        [ClauseStyleConverter]
        public static DataTypeElement TimeStamp() { throw new InvalitContextException(nameof(TimeStamp)); }

        /// <summary>
        /// TIMESTAMP
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>TIMESTAMP</returns>
        [FuncStyleConverter]
        public static DataTypeElement TimeStamp(int n) { throw new InvalitContextException(nameof(TimeStamp)); }

        /// <summary>
        /// TIME STAMP WITH TIME ZONE
        /// </summary>
        /// <returns>TIMESTAMP</returns>
        [ClauseStyleConverter(Name = "TIMESTAMP WITH TIME ZONE")]
        public static DataTypeElement TimeStampWithTimeZone() { throw new InvalitContextException(nameof(TimeStampWithTimeZone)); }

        /// <summary>
        /// TIME STAMP WITH TIME ZONE
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>TIMESTAMP</returns>
        [MethodFormatConverter(Format = "TIMESTAMP([0]) WITH TIME ZONE|")]
        public static DataTypeElement TimeStampWithTimeZone(int n) { throw new InvalitContextException(nameof(TimeStampWithTimeZone)); }
        
        /// <summary>
        /// TSQUERY
        /// </summary>
        /// <returns>TSQUERY</returns>
        [ClauseStyleConverter]
        public static DataTypeElement TsQuery() { throw new InvalitContextException(nameof(TsQuery)); }

        /// <summary>
        /// TSVECTOR
        /// </summary>
        /// <returns>TSVECTOR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement TsVector() { throw new InvalitContextException(nameof(TsVector)); }

        /// <summary>
        /// TXID_SNAPSHOT
        /// </summary>
        /// <returns>TXID_SNAPSHOT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Txid_Snapshot() { throw new InvalitContextException(nameof(Txid_Snapshot)); }

        /// <summary>
        /// UUID
        /// </summary>
        /// <returns>UUID</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Uuid() { throw new InvalitContextException(nameof(Uuid)); }

        /// <summary>
        /// VARCHAR
        /// </summary>
        /// <returns>VARCHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement VarChar() { throw new InvalitContextException(nameof(VarChar)); }

        /// <summary>
        /// VARCHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>VARCHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement VarChar(int n) { throw new InvalitContextException(nameof(VarChar)); }

        /// <summary>
        /// XML
        /// </summary>
        /// <returns>XML</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Xml() { throw new InvalitContextException(nameof(Xml)); }
    }
}
