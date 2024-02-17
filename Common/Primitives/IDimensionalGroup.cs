namespace Ignite.Spark.Common.Primitives;

public interface IDimensionalGroup<TResolution>
{
	public IList<IDimension<TResolution>> Dimensions { get; }
	
	public Dictionary<string, IMetadata> Metadata { get; }
}