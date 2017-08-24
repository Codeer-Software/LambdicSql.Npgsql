using LambdicSql.BuilderServices.CodeParts;
using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using LambdicSql.Npgsql.Inside.CodeParts;
using System.Linq;
using System.Linq.Expressions;
using static LambdicSql.Npgsql.Inside.PartsUtils;

namespace LambdicSql.Npgsql.ConverterAttributes
{
    /// <summary>
    /// Converter for ALL clause conversion.
    /// </summary>
    public class AllConverterAttribute : MethodConverterAttribute
    {
        /// <summary>
        /// Convert expression to code.
        /// </summary>
        /// <param name="expression">Expression.</param>
        /// <param name="converter">Expression converter.</param>
        /// <returns>Parts.</returns>
        public override ICode Convert(MethodCallExpression expression, ExpressionConverter converter)
        {
            var args = expression.Arguments.Select(e => converter.ConvertToCode(e)).ToArray();
            return new AllDisableBinaryExpressionBracketsCode(Func("ALL".ToCode(), args[0]));
        }
    }
}
