using System;
using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	public partial interface IStartDatafeedRequest
	{
		/// <summary>
		/// The time that the datafeed should end. This value is exclusive.
		/// </summary>
		[DataMember(Name = "end")]
		[JsonFormatter(typeof(NullableDateTimeOffsetEpochMillisecondsFormatter))]
		DateTimeOffset? End { get; set; }

		/// <summary>
		/// The time that the datafeed should begin. This value is inclusive.
		/// </summary>
		[DataMember(Name = "start")]
		[JsonFormatter(typeof(NullableDateTimeOffsetEpochMillisecondsFormatter))]
		DateTimeOffset? Start { get; set; }

		/// <summary>
		/// Controls the amount of time to wait until a datafeed starts.
		/// </summary>
		[DataMember(Name = "timeout")]
		Time Timeout { get; set; }
	}

	/// <inheritdoc />
	public partial class StartDatafeedRequest
	{
		/// <inheritdoc />
		public DateTimeOffset? End { get; set; }

		/// <inheritdoc />
		public DateTimeOffset? Start { get; set; }

		/// <inheritdoc />
		public Time Timeout { get; set; }
	}

	/// <inheritdoc />
	[DescriptorFor("XpackMlStartDatafeed")]
	public partial class StartDatafeedDescriptor
	{
		DateTimeOffset? IStartDatafeedRequest.End { get; set; }
		DateTimeOffset? IStartDatafeedRequest.Start { get; set; }
		Time IStartDatafeedRequest.Timeout { get; set; }

		/// <inheritdoc />
		public StartDatafeedDescriptor Timeout(Time timeout) => Assign(a => a.Timeout = timeout);

		/// <inheritdoc />
		public StartDatafeedDescriptor Start(DateTimeOffset? start) => Assign(a => a.Start = start);

		/// <inheritdoc />
		public StartDatafeedDescriptor End(DateTimeOffset? end) => Assign(a => a.End = end);
	}
}
