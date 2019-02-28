using System;
using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	/// <summary>
	/// Retrieve anomaly records for a machine learning job.
	/// </summary>
	public partial interface IGetAnomalyRecordsRequest
	{
		/// <summary>
		/// If true, the results are sorted in descending order.
		/// </summary>
		[DataMember(Name ="desc")]
		bool? Descending { get; set; }

		/// <summary>
		/// Returns records with timestamps earlier than this time.
		/// </summary>
		[DataMember(Name ="end")]
		[JsonFormatter(typeof(NullableDateTimeOffsetEpochMillisecondsFormatter))]
		DateTimeOffset? End { get; set; }

		/// <summary>
		/// If true, the output excludes interim results. By default, interim results are included.
		/// </summary>
		[DataMember(Name ="exclude_interim")]
		bool? ExcludeInterim { get; set; }

		/// <summary>
		/// Specifies pagination for the records
		/// </summary>
		[DataMember(Name ="page")]
		IPage Page { get; set; }

		/// <summary>
		/// Returns records with anomaly scores higher than this value.
		/// </summary>
		[DataMember(Name ="record_score")]
		double? RecordScore { get; set; }

		/// <summary>
		/// Specifies the sort field for the requested records. By default, records are sorted by the anomaly score value.
		/// </summary>
		[DataMember(Name ="sort")]
		Field Sort { get; set; }

		/// <summary>
		/// Returns records with timestamps after this time.
		/// </summary>
		[DataMember(Name ="start")]
		[JsonFormatter(typeof(NullableDateTimeOffsetEpochMillisecondsFormatter))]
		DateTimeOffset? Start { get; set; }
	}

	/// <inheritdoc />
	public partial class GetAnomalyRecordsRequest
	{
		/// <inheritdoc />
		public bool? Descending { get; set; }

		/// <inheritdoc />
		public DateTimeOffset? End { get; set; }

		/// <inheritdoc />
		public bool? ExcludeInterim { get; set; }

		/// <inheritdoc />
		public IPage Page { get; set; }

		/// <inheritdoc />
		public double? RecordScore { get; set; }

		/// <inheritdoc />
		public Field Sort { get; set; }

		/// <inheritdoc />
		public DateTimeOffset? Start { get; set; }
	}

	/// <inheritdoc />
	[DescriptorFor("XpackMlGetRecords")]
	public partial class GetAnomalyRecordsDescriptor
	{
		public GetAnomalyRecordsDescriptor() : base() { }

		bool? IGetAnomalyRecordsRequest.Descending { get; set; }
		DateTimeOffset? IGetAnomalyRecordsRequest.End { get; set; }
		bool? IGetAnomalyRecordsRequest.ExcludeInterim { get; set; }
		IPage IGetAnomalyRecordsRequest.Page { get; set; }
		double? IGetAnomalyRecordsRequest.RecordScore { get; set; }
		Field IGetAnomalyRecordsRequest.Sort { get; set; }
		DateTimeOffset? IGetAnomalyRecordsRequest.Start { get; set; }

		/// <inheritdoc />
		public GetAnomalyRecordsDescriptor Descending(bool? descending = true) => Assign(a => a.Descending = descending);

		/// <inheritdoc />
		public GetAnomalyRecordsDescriptor End(DateTimeOffset? end) => Assign(a => a.End = end);

		/// <inheritdoc />
		public GetAnomalyRecordsDescriptor Page(Func<PageDescriptor, IPage> selector) =>
			Assign(a => a.Page = selector?.Invoke(new PageDescriptor()));

		/// <inheritdoc />
		public GetAnomalyRecordsDescriptor Sort(Field field) => Assign(a => a.Sort = field);

		/// <inheritdoc />
		public GetAnomalyRecordsDescriptor Start(DateTimeOffset? end) => Assign(a => a.Start = end);

		/// <inheritdoc />
		public GetAnomalyRecordsDescriptor ExcludeInterim(bool? excludeInterim = true) =>
			Assign(a => a.ExcludeInterim = excludeInterim);

		/// <inheritdoc />
		public GetAnomalyRecordsDescriptor RecordScore(double? recordScore) =>
			Assign(a => a.RecordScore = recordScore);
	}
}
