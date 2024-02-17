namespace Ignite.Spark.Common.Primitives;

public interface IMetadata
{
	Type DataType { get; }
	object Data { get; }
	
	T GetData<T>();
}