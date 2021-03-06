using System.Collections.Generic;

namespace AutoMapper.Mappers
{
    public static class MapperRegistry
    {
        private static readonly IObjectMapper[] _initialMappers =
        {
            new NullableSourceMapper(),
            new ExpressionMapper(), 
            new FlagsEnumMapper(),
            new StringToEnumMapper(), 
            new EnumToEnumMapper(), 
            new EnumToUnderlyingTypeMapper(),
            new MultidimensionalArrayMapper(),
            new ArrayMapper(),
            new EnumerableToDictionaryMapper(),
#if NETSTANDARD1_3 || NET45
            new NameValueCollectionMapper(),
#endif
            new DictionaryMapper(),
            new ReadOnlyCollectionMapper(),
            new HashSetMapper(),
            new CollectionMapper(),
            new EnumerableMapper(),
            new AssignableMapper(),
            new ConvertMapper(),
            new StringMapper(),
            new TypeConverterMapper(),
            new ImplicitConversionOperatorMapper(),
            new ExplicitConversionOperatorMapper(),
            new FromStringDictionaryMapper(),
            new ToStringDictionaryMapper(),
            new FromDynamicMapper(),
            new ToDynamicMapper()
        };

        private static readonly List<IObjectMapper> _mappers = new List<IObjectMapper>(_initialMappers);

        /// <summary>
        /// Extension point for modifying list of object mappers
        /// </summary>
        public static IList<IObjectMapper> Mappers => _mappers;

        /// <summary>
        /// Reset mapper registry to built-in values
        /// </summary>
        public static void Reset()
        {
            _mappers.Clear();
            _mappers.AddRange(_initialMappers);
        }
    }
}