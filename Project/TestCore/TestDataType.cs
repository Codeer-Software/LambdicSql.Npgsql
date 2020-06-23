using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.Npgsql.Symbol;
using static Test.Helper.DBProviderInfo;
using Test.Helper;
using LambdicSql.Npgsql;

namespace Test
{
    [TestClass]
    public class TestDataType
    {
        public TestContext TestContext { get; set; }
        public IDbConnection _connection;

        [TestInitialize]
        public void TestInitialize()
        {
            _connection = TestEnvironment.CreateConnection(TestContext);
            _connection.Open();
        }

        [TestCleanup]
        public void TestCleanup() => _connection.Dispose();
        
        [TestMethod]
        public void Test_CreateTable_Postgre()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                CreateTable(db.table3,
                    new Column(db.table3.obj1, DataType.BigInt()),
                    new Column(db.table3.obj2, DataType.BigSerial()),
                    new Column(db.table3.obj3, DataType.Bit(1)),
                    new Column(db.table3.obj4, DataType.BitVarying(1)),
                    new Column(db.table3.obj5, DataType.Boolean()),
                    new Column(db.table3.obj6, DataType.Box()),
                    new Column(db.table3.obj7, DataType.Bytea()),
                    new Column(db.table3.obj8, DataType.Character(1)),
                    new Column(db.table3.obj9, DataType.CharacterVarying(1)),
                    new Column(db.table3.obj10, DataType.Cidr()),
                    new Column(db.table3.obj11, DataType.Circle()),
                    new Column(db.table3.obj12, DataType.Date()),
                    new Column(db.table3.obj13, DataType.DoublePrecision()),
                    new Column(db.table3.obj14, DataType.Inet()),
                    new Column(db.table3.obj15, DataType.Integer()),
                    new Column(db.table3.obj16, DataType.Interval(IntervalType.Day)),
                    new Column(db.table3.obj17, DataType.Json()),
                    new Column(db.table3.obj18, DataType.JsonB()),
                    new Column(db.table3.obj19, DataType.Line()),
                    new Column(db.table3.obj20, DataType.Lseg()),
                    new Column(db.table3.obj21, DataType.MacAddr()),
                    new Column(db.table3.obj22, DataType.Money()),
                    new Column(db.table3.obj23, DataType.Numeric()),//(1, 2)
                    new Column(db.table3.obj24, DataType.Path()),
                    new Column(db.table3.obj25, DataType.Pg_Lsn()),
                    new Column(db.table3.obj26, DataType.Point()),
                    new Column(db.table3.obj27, DataType.Polygon()),
                    new Column(db.table3.obj28, DataType.Real()),
                    new Column(db.table3.obj29, DataType.SmallInt()),
                    new Column(db.table3.obj30, DataType.SmallSerial()),
                    new Column(db.table3.obj31, DataType.Serial()),
                    new Column(db.table3.obj32, DataType.Text()),
                    new Column(db.table3.obj33, DataType.Time()),
                    new Column(db.table3.obj34, DataType.Time(1)),
                    new Column(db.table3.obj35, DataType.TimeStamp()),
                    new Column(db.table3.obj36, DataType.TimeStamp(1)),
                    new Column(db.table3.obj37, DataType.TsQuery()),
                    new Column(db.table3.obj38, DataType.TsVector()),
                    new Column(db.table3.obj39, DataType.Txid_Snapshot()),
                    new Column(db.table3.obj40, DataType.Uuid()),
                    new Column(db.table3.obj41, DataType.Xml()),
                    new Column(db.table3.obj42, DataType.TimeWithTimeZone()),
                    new Column(db.table3.obj43, DataType.TimeWithTimeZone(1)),
                    new Column(db.table3.obj44, DataType.TimeStampWithTimeZone()),
                    new Column(db.table3.obj45, DataType.TimeStampWithTimeZone(1))
                ));
            //time zone

            _connection.Execute(sql);
        }
        
        void CleanUpCreateDropTestTable()
        {
            try
            {
                var sql = Db<DBForCreateTest>.Sql(db => DropTable(db.table3));
                _connection.Execute(sql);
            }
            catch { }
        }
    }
}
